﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
   public class Program
    {
        static void Main(string[] args)
        {
            //*******************************************************//
            // BuBBLE SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******buble************");

            
            int[] array1 = new int[] { 5, 4, 1, 9, 1 };
            var bubbleSorter = new BubbleSorter <int>(array1);
            bubbleSorter.Print();
            bubbleSorter.Sort();
            bubbleSorter.Print();

            //*******************************************************//
            // INSERTING SORT
            //*******************************************************//
            Console.WriteLine("************************");
            Console.WriteLine("******insert************");
            int[] array2 = new int[] { 9, 6, 3, 1, 4 };
            var InsertionSorter = new InsertionSorter<int>(array2);

            InsertionSorter.Print();
            InsertionSorter.Sort();
            InsertionSorter.Print();













            Console.ReadLine();
        }
       
    }
}
