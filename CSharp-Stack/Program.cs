using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Stack
{
    class Stack<T> 
    {
        private T[] stack;
        private T top;
        private int size;
        private int max_size;

        public Stack(int max_size)
        {
            stack = new T [max_size];
            this.max_size = max_size;
            this.size = 0;
        }

        bool IsEmpty()
        {
            return size == 0;
        }
        bool IsFull()
        {
            return size == max_size;
        }
        
        //Stores an object on top of the stack.
        public void Push(T data)
        {
            if (IsFull())
            {
                Console.WriteLine("error: stack is full");
                return;
            }
            stack[size] = data;
            size++;
            
        }
        
        //Removes the object on top of the stack and returns it.
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("error: stack is empty");
                return default(T);
            }
            else
            {
                size--;
                return stack[size];
            }
        }
        
        //Prints out all stack objects.
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.Write("[");
            foreach (var tem in stack)
            {
                Console.Write(" "+tem+" ");
            }
            Console.Write("]\n");
        }
        
        //Prints the object on top of the stack if exists without removing it.
        public void Peak()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(stack[size-1]);
            }
            else
            {
                Console.WriteLine("error: stack is empty");
            }
        }
        
        //Removes all objects from the stack.
        public void Clear()
        {
            size = 0;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> test1 = new Stack<int>(5);
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
            
        }
    }
}