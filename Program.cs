using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        bool IsEmpty();
        int SizeOf();
    }
    public class Stack : IStack<int>
    {
        int top = -1;

        public void Push(int data)
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            if (top == -1) return 
        }

        public int SizeOf()
        {
            throw new NotImplementedException();
        }
    }
}
