using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.binaryChops
{
    public class RecursiveBinaryChop
    {
        public int Chop(int elementToSearch, int[] dataSource, int left, int right)
        {

            if (left <= right) // position problem
            {

                double middleTemp = (left + right) / 2;
                int middle = (int)Math.Floor(middleTemp);

                if (dataSource[middle] == elementToSearch)
                    return middle;

                else if (dataSource[middle] < elementToSearch)
                {
                    left = middle + 1;
                    return Chop(elementToSearch, dataSource, left, right);
                }
                else
                {
                    right = middle - 1;
                    return Chop(elementToSearch, dataSource, left, right);
                }

            }
            return -1;

        }
    }
}
