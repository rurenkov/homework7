using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public abstract class Sorter<T> : ISorter <T>
    {
        public T[] Array;


        public Sorter(T[] array)
        {
            Array = array;
        }



        public void Swap(ref T a, ref T b)   // need to fix it in order to work with indexes.

        {
            T tmp;
            tmp = a;
            a = b;
            b = tmp;
        }


        public void Sort()
        {

        }

        public void Print()
        {

        }

    }
}
