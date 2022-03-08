using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05
{
    public abstract class AbstractResolver
    {
        public AbstractResolver()
        {
        }

        public abstract string? Execute(string content);
    }
}