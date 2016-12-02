using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    interface IPrintable
    {
        int property { get; set; }
        void Print();
      
    }

}

class Prinatable : IPrintable
{
    public int property { get; set; }

    public  void Print(int[] MyArray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MyArray));

        }
}
 


