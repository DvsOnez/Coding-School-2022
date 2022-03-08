using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05
{
    public class ActionResponse
    {
        public Guid RequestID { get; }

        public Guid ResponseID { get; }

        public string Output { get; }

        public ActionResponse(Guid requestId, Guid responseId, string output)
        {
            RequestID = requestId;
            ResponseID = responseId;
            Output = output;
        }
    }
}