using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
  public  interface IMyStack<T>: IBuffer<T>
    {
        void Push(T put);
        T Pop();
        T Peek();
    }
}
