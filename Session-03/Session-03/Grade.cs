using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Grade
    {
        public Guid StudentID { get; set; } 
        public Guid CourseID { get; set; } 
        public Guid ID { get; set; } 
        public int Value { get; set; }


        public Grade()
        {

    
            ID = Guid.NewGuid();
        }

        public Grade(Guid studentID) => StudentID = studentID;
    }


}

