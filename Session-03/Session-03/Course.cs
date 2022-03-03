using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Course
    {
        public Guid ID { get; }
        public string code { get; set; }
        public string subject { get; set; }

        public Course()
        {

            Guid ID = Guid.NewGuid();

        }
    }
}
