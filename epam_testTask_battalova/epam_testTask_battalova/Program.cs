using epam_testTask_battalova.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_testTask_battalova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Task1_2 task1 = new Task1_2();
            task1.massive = task1.MergeSort(task1.massive); // We can use fucntion Sort()
            task1.Print(task1.massive);

            //Task 2
            int digit = -17;
            if (task1.BinarySearch(digit)) //We can use "task1.massive.Any(i=>i==digit)"
            {
                Console.WriteLine($"Massive contains {digit}");
            }
            else
            {
                Console.WriteLine($"Massive not contains {digit}");
            }

            //Task 3
            Task3 task3 = new Task3();
            task3.Print(task3.SearchWords());

            //Task 4
            digit = 5;
            Task4 factorial = new Task4();
            Console.WriteLine(factorial.Factorial(digit));

            //Task 5
            Task5 bkt = new Task5();
            if (bkt.CheckString()) //We can use Regex
            {
                Console.WriteLine($"String is CBS");
            }
            else
            {
                Console.WriteLine($"String isn't CBS");
            }
        }      
    }
}
