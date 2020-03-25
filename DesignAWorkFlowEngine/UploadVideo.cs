using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAWorkFlowEngine
{
    class UploadVideo : IWorkFlowTask
    {
        public void Execute()
        {
            Console.WriteLine("UploadVideo");
        }
    }
}
