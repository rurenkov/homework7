using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
   public abstract class Buffer <T> : IBuffer<T>
    {

        public T[]Array;


        public int head;
        public int free;
        public T put;

        public Buffer(T[] array)
        {
            Array = array;
            
            free = Array.Length - head;
        }

        void IBuffer<T>.ParceD()
        {
            
        }

        void IPrintable.Print()
        { }

        bool IBuffer<T>.IsEmpty()
        {
        return true;
        }

        bool IBuffer<T>.IsFull()
        {
            return true;
        }
        void IBuffer<T>.Peek()
        {
            
        }

        void IBuffer<T>.Buffer()
        {
            throw new NotImplementedException();
        }
    }
}
