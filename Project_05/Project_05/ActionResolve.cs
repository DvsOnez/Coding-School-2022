using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_05
{
    public class ActionResolve
    {       
       
        

        private AbstractResolver? GetResolver(ActionEnu action)
        {
            switch (action)
            {
                case ActionEnu.Convert:                    
                    return new ConvertResolver();
                    break;
                case ActionEnu.Uppercase:                   
                    return new UppercaseResolver();
                    break;
                case ActionEnu.Reverse:                    
                    return new ReverseResolver();
                    break;
                default:                  
                    return null;
                    break;
            }
        }

        
    }
}