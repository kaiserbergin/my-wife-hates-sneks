public enum Statuses { COMPLETE, FAILED, RUNNING }

namespace Assets.AI.Agents
{
    public class StatusMessage<T>
    {
        Statuses Status { get; set; }
        T Result { get; set; }
    }
}
