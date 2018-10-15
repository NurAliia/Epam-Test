using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_testTask_battalova.Tasks
{
    class Task4
    {
        public long Factorial(int digit)
        {
            if (digit == 0)
                return 1;
            else
                return digit*Factorial(digit - 1);
        }
    }
}
