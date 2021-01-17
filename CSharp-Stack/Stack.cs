using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Stack 
{
    
    class Stack<T> : IStack<T>
    {
        private readonly T[] _stack;
        private int _size;
        private readonly int _maxSize;

        public Stack(int maxSize)
        {
            _stack = new T [maxSize];
            this._maxSize = maxSize;
            this._size = 0;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public bool IsFull()
        {
            return _size == _maxSize;
        }

        public void Push(T data)
        {
            if (IsFull())
            {
                Console.WriteLine("error: stack is full");
                return;
            }
            _stack[_size] = data;
            _size++;
            
        }
        
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("error: stack is empty");
                return default(T);
            }
            _size--;
            return _stack[_size];
        }
        
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.Write("[");
            foreach (var tem in _stack)
            {
                Console.Write(" "+tem+" ");
            }
            Console.Write("]\n");
        }
        
        public void Peak()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(_stack[_size-1]);
            }
            else
            {
                Console.WriteLine("error: stack is empty");
            }
        }
        
        public void Clear()
        {
            _size = 0;
        }
        
    }
}