using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAWorkFlowEngine
{
    class CallWebServer : IWorkFlowTask
    {

        public void Execute()
        {
            Console.WriteLine("callServerMessage");

        }
    }
}
