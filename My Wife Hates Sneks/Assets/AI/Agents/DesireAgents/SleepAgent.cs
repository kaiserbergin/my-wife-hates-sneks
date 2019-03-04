using Assets.AI.Agents.BaseAgents;

namespace Assets.AI.Agents.DesireAgents
{
    public class SleepAgent : DesireAgent
    {
        public float DesireStartTime;
        public float LinearRate;
        public float RateTimeBracket;
        public bool IsSleeping;

        public override void Act()
        {
            Status = AgentStatuses.RUNNING;

            if (IsSleeping)
            {
                Result = 0f;
            }
            else
            {
                if (Blackboard.Floats.TryGetValue("currentTime", out float currentTime))
                {

                }
            }

            Status = AgentStatuses.COMPLETE;
        }
    }
}
