
namespace CSharp_Stack
{
    interface IStack<T>
    {
        bool IsEmpty();
        bool IsFull();
        
        //Stores an object on top of the stack.
        void Push(T data);
        
        //Removes the object on top of the stack and returns it.
        T Pop();
        
        //Prints out all stack objects.
        void Print();
        
        //Prints the object on top of the stack if exists without removing it.
        void Peak();
        
        //Removes all objects from the stack.
        void Clear();
    }
}