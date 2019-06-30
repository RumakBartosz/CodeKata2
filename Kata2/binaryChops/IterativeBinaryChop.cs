using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.binaryChops
{
    public class IterativeBinaryChop
    {
        public int Chop(int elementToSearch, int[] dataSource)
        {
            int left = 0;
            int right = dataSource.Length - 1; // Often out of bounds
            double middleTemp = (left + right) / 2;
            int middle = (int)Math.Floor(middleTemp);


            while(true)
            {
                if (left > right) // position problem
                    return -1;

                if (dataSource[middle] < elementToSearch)
                {
                    left = middle + 1;
                    middleTemp = (left + right) / 2;
                    middle = (int)Math.Floor(middleTemp);
                }
                else if (dataSource[middle] > elementToSearch)
                {
                    right = middle - 1;
                    middleTemp = (left + right) / 2;
                    middle = (int)Math.Floor(middleTemp);
                }
                else if (dataSource[middle] == elementToSearch)
                    return middle;

            }


        }

    }

}
