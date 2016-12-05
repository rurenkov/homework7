using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public class BubbleSorter <T>: Sorter<T> where  T: IComparable<T>
    {

        public BubbleSorter(T[] array) : base(array)
        {
        }
        
        public new void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", Array));
        }


        public new void Sort()   // sorting logic
        {
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 1; j < Array.Length; j++)
                {
                    if (Array[j].CompareTo (Array[j - 1])<0)    //!! USE COMPARER
                    {
                        Swap(ref Array[j - 1], ref Array[j]);
                    }
                }
            }
        }


    }
}
