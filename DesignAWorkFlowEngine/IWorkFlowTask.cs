using System.Collections.Generic;

namespace DesignAWorkFlowEngine
{
    public interface IWorkFlowTask // each task can be executed
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        void AddTask(IWorkFlowTask task);
        void RemoveTask(IWorkFlowTask task);
        IEnumerable<IWorkFlowTask> GetTask();
    }


}
