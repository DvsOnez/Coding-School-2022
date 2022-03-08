using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05
{
    public class ActionRequest
    {
        public Guid RequestID { get; }

        public string Input { get; }
        
        public ActionEnu Action { get; }

        public ActionRequest(Guid requestId, string input, ActionEnu action)
        {

            RequestID = requestId; 
            Input = input;
            Action = action;
        }
    }
}
