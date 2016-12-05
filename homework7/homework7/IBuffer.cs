using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public interface IBuffer <T>:IPrintable
    {

        void Buffer();
        void ParceD();
        bool IsFull();
        bool IsEmpty();
        void Peek();



    }
}
