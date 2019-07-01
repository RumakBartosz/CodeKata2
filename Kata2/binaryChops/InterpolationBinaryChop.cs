using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.binaryChops
{
    public class InterpolationBinaryChop
    {
        public int Chop(int elementToSearch, int[] dataSource, int size)
        {
            if (size == 0)
                return -1;

            int low = 0;
            int mid;
            int high = size - 1;

            while((dataSource[low] != dataSource[high]) && (dataSource[high] >= elementToSearch) && (dataSource[low] <= elementToSearch))
            {
                mid = low + ((elementToSearch - dataSource[low]) * (high - low) / (dataSource[high] - dataSource[low]));

                if (dataSource[mid] < elementToSearch)
                    low = mid + 1;
                else if (dataSource[mid] > elementToSearch)
                    high = mid - 1;
                else
                    return mid;
            }

            if (dataSource[low] == elementToSearch)
                return low;

            return -1;
        }
    }
}
