﻿using System;

namespace DelegateProgram
{
   
    class BasicDelegate
    {
        public delegate void DelegateRef();
        static void Print()
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)
        {
            var delegateObj = new DelegateRef(Print);
            delegateObj();
        }
 
    }
}

