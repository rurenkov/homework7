using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public interface ISorter<T> : IPrintable
    {
         void Sort();
        
    }
/*
        interface ISorter<T> : IPrintable
        {
            public void Sort();
        }

        public abstract class Sorter<T> : ISorter<T>, IComparable
        {
            public virtual Sorter(T[] InputArray);
            public virtual void Swap(int a, int b);
            public virtual void Sort();
        }

        protected class Sorter<T> : Sorter<T>
        {
            //----Variables
            protected T[] MyArray;
            //----Constructors
            public Sorter(int ArraySize)
            {
                MyArray = new T[ArraySize];
                FillArrayRandomly();
            }
            public Sorter(T[] InputArray)
            {
                MyArray = InputArray;
            }
            //-----internal Methods
            protected void FillArrayRandomly()
            {
                Random rand = new Random();
                int a = MyArray.Length;
                for (int i = 0; i < a; i++)
                {
                    object temp = rand.Next();
                    MyArray[i] = (T)temp;
                }
            }
            protected void Swap(int a, int b)
            {
                T c = MyArray[a];
                MyArray[a] = MyArray[b];
                MyArray[b] = c;
            }
            //------API methods
            public void Print()
            {
                int len = MyArray.Length;
                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine(MyArray[i]);
                }
            }
        }

        public class BubbleSort<T> : Sorter<T>
        {
            public BubbleSort(int ArraySize)
                : base(ArraySize)
            { }
            public BubbleSort(T[] InputArray)
                : base(InputArray)//--------------------------
            { }
            public override void Sort()
            {
                bool NotYetSorted = true;

                while (NotYetSorted)
                {
                    NotYetSorted = false;
                    int len = MyArray.Length;
                    for (int i = 1; i < len; i++)
                    {
                        object a = MyArray[i];
                        object b = MyArray[i - 1];
                        if (a.CompareTo(b) < 0)//------------------------------------------
                        {
                            NotYetSorted = true;
                            Swap(i, i - 1);//-------------------------------------------------
                        }
                    }
                }
            }
        }
*/




  
}
