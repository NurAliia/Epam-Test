using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_testTask_battalova.Tasks
{
    class Task3
    {
        public string str = "as as ds eeret";
        
        public List<string> SearchWords()
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (var s in str.Split(' '))
            {
                if (counter.Keys.Contains(s))
                {
                    counter[s]++;
                }
                else
                {
                    counter.Add(s, 1);
                }
            }
            List<string> result = new List<string>();
            foreach (var i in counter)
            {
                if (i.Value==1)                    
                    result.Add(i.Key);
            }
            return result;
        }
        public void Print(List<string> massive)
        {
            foreach (var i in massive)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
