using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Stack
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> test1 = new Stack<int>(5);
            test1.Pop();
            test1.Push(1);
            test1.Push(2);
            test1.Push(3);
            test1.Push(4);
            test1.Push(5);
            test1.Push(6);
            test1.Pop();
            test1.Peak();
            test1.Print();
            test1.Clear();
            test1.Print();
            var test2 = new Stack<string>(3);
            test2.Push("Hey");
            test2.Push("There");
            test2.Push(":D");
            test2.Print();
            
        }
    }
}