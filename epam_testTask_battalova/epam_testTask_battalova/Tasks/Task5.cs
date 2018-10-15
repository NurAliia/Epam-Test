using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_testTask_battalova.Tasks
{
    class Task5
    {
        public StringBuilder str = new StringBuilder("((()");
        public bool CheckString()
        {
            for (int i = 0; i < str.Length;)
            {
                if (str[i] == '(')
                {
                    if (SearchSecondBkt(i, ')'))
                    {
                        str.Remove(i, 1);
                    }
                    else
                        return false;
                }
                else if (str[i] == '{')
                {
                    if (SearchSecondBkt(i, '}'))
                    {
                        str.Remove(i, 1);
                    }
                    else
                        return false;
                }
                else if (str[i] == '[')
                {
                    if (SearchSecondBkt(i, ']'))
                    {
                        str.Remove(i, 1);
                    }
                    else
                        return false;
                }
                else
                    i++;
            }
            if (str.Length > 0)
                return false;
            return true;
        }
        public bool SearchSecondBkt(int index,char c)
        {
            for (int i = str.Length-1; i > 0; i--)
            {
                if (str[i] == c && i > index)
                {
                    str.Remove(i,1);
                    return true;
                }
            }
            return false;
        }
    }
}
