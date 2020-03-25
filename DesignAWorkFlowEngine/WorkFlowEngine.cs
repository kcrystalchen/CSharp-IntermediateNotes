using System;
using System.Collections.Generic;

namespace DesignAWorkFlowEngine
{
    public class WorkFlowEngine : IWorkFlow
    {
      
        private readonly List<IWorkFlowTask> _workFlowTask; // an empty list of workflow 

        public WorkFlowEngine() // assign the new IWorkFlow to variable _workFlow, it is empty first
        {
            _workFlowTask = new List<IWorkFlowTask>();
        }



        public void AddTask(IWorkFlowTask task)
        {
            _workFlowTask.Add(task);
        }



        public void RemoveTask(IWorkFlowTask task)
        {
            _workFlowTask.Remove(task);
          
            
        }


        public IEnumerable<IWorkFlowTask> GetTask()  // return a read-only WorkFlowTask list 
        {
            return _workFlowTask;
        }


        public void Run(IWorkFlow workFlow)
        {
            foreach (var eachObject in workFlow.GetTask())
            {
                eachObject.Execute();
            }
        }
    }
}
