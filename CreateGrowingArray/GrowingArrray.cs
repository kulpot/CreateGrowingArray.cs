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
        private int currentPosition = 0;

        public GrowingArrray()
        {
            intArray = new int[2];
        }

        public void Add(int intToAdd)
        {
            intArray[currentPosition] = intToAdd;
            currentPosition++;


            if(currentPosition >= intArray.Length)  
            {
                //grow array 
                int[] tempArray = new int[intArray.Length * 2];
                //copy the data to the new array  
                for(int i = 0; i < intArray.Length; i++)
                {
                    tempArray[i] = intArray[i];
                }
            }
        }
    }
}
