using System;          
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace CreateGrowingArray
{
    class GrowingArrray
    {
        private int[] intArray;
        private int currentPosition;

        public GrowingArrray()
        {
            intArray = new int[2];
        }

        public void Add(int intToAdd)
        {
            intArray[0] = intToAdd;
        }
    }
}
