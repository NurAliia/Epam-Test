using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_testTask_battalova.Tasks
{
    class Task1_2
    {
        public List<int> massive = new List<int> { 12, 123, 12, -17 };

        public List<int> MergeSort(List<int> massive)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();
            if (massive.Count < 2)
            {
                return massive;
            }
            else
            {
                int middle = massive.Count / 2;
                left.AddRange(massive.GetRange(0, middle));
                right.AddRange(massive.GetRange(middle, massive.Count - middle));

                left = MergeSort(left);
                right = MergeSort(right);
                result = Merge(left, right);
                return result;
            }
        }
        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }

            }
            if (left.Count > 0)
            {
                result.AddRange(left);
            }
            else
            {
                result.AddRange(right);
            }
            return result;
        }
        public bool BinarySearch(int digit)
        {
            int left = 0;
            int right = massive.Count;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + (right - left) / 2;

                if (massive[mid] == digit)
                    return true;

                if (massive[mid] > digit)
                    right = mid;
                else
                    left = mid + 1;
            }
            return false;
        }

        public void Print(List<int> massive)
        {
            foreach (var i in massive)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
