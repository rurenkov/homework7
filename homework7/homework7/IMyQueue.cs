using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
   public interface IMyQueue<T>:IBuffer<T>

    {
       void Enqueue();
        void Dequeue();
    }
}
