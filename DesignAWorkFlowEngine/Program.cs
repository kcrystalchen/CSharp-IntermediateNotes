using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAWorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine workFlow = new WorkFlowEngine();

            workFlow.AddTask(new UploadVideo());
            workFlow.AddTask(new CallWebServer());
            workFlow.Run(workFlow);




        }
    }
}
