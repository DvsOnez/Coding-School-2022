using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Session_04
{
    public class ArrayMultiplier
    {
        public int[] Left { get; }

        public int[] Right { get; }

        public ArrayMultiplier(int[] left, int[] right)
        {
            Left = left;
            Right = right;
        }


        public int[] Results()
        {
            int length = Math.Min(Left.Length, Right.Length);
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
                result[i] = Left[i] * Right[i];

            return result;
        }
    }
}

    