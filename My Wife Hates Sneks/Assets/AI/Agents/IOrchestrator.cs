namespace Assets.AI.Agents
{
    interface IOrchestrator<T>
    {        
        void Register(IAgent agent);
        void Orchestrate();
        StatusMessage<T> ReadChildStatus(StatusMessage<T> status);
        void InterpretResults();
        void ReportStatus();        
    }
}
