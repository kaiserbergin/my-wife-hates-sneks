using Assets.AI.Blackboard;
using UnityEngine;

namespace Assets.AI.Agents.BaseAgents
{
    public abstract class Agent : MonoBehaviour
    {
        public AgentStatuses Status { get; set; }
        public float Result { get; set; }
        public BlackBoard Blackboard = BlackBoard.Instance;

        public abstract void Act();
    }
}
