﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
  public  interface IMyStack<T>: IPrintable 
    {
        void Print();
        void Push();
        void Pop();


    }
}