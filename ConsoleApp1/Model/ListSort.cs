using System;

namespace test
{
    public class ListSort
    {
        List<int> arr = new List<int>() { 1, 6, 9, 7, 8, 1, 3, 5, 94 };

        public void SortByDescending()
        {
            arr.Sort((x, y) => y.CompareTo(x);
            Console.WriteLine(string.Join(" ", arr));
        }

        public void ScreenList()
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

