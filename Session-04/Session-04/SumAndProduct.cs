using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class SumAndProduct
    {

        public int GetProduct(int n)
        {
            int product = n;
            for (int i = 1; i < n; i++)
                product = product * i;  
            return product;
        }
        public int GetSum(int n)
        {
            int sum = n;
            for (int i = 1; i <= n; i++)
                sum = sum + i;
            return sum;
            
        }

        public SumAndProduct()
        {

        }
    }
}



