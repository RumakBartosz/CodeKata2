using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.binaryChops
{
    public class ExponentialBinaryChop
    {
        readonly RecursiveBinaryChop RecursiveChopMock = new RecursiveBinaryChop();
        public int Chop(int elementToSearch, int[] dataSource, int size)
        {
            if (size == 0)
                return -1;

            int bound = 1;

            while (bound < size && dataSource[bound] < elementToSearch)
                bound *= 2;

            return RecursiveChopMock.Chop(elementToSearch, dataSource, bound / 2, Math.Min(bound, size - 1));
        }
    }
}
