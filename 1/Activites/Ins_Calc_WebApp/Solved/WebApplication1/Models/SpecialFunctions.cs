using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    class SpecialFunctions
    {
        public static int Factorial(int n)
        {
            int _retval = 1;
            while (n != 1)
            {
                _retval = _retval * n;
                n = n - 1;
            }
            return _retval;

        }
    }
}
