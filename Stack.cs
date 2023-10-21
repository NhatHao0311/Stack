using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private int[] stackArray;
        private int stackMax;
        private int stackTop;

        public int this[int i]
        {
            get { return stackArray[i]; }
            set { stackArray[i] = value; }
        }

        public int[] StackArray
        {
            get { return stackArray; }
            set {  stackArray = value; }
        }

        public int StackMax
        {
            get { return stackMax; }
            set { stackMax = value; }
        }

        public int StackTop
        {
            get { return stackTop; }
            set { stackTop = value; }
        }

        public Stack()
        {
            stackArray = new int[10];
        }

        public Stack(int value = 0)
        {
            stackMax = value;
            stackArray = new int[value];
            stackTop = -1;
        }

        public bool IsEmpty()
        {
            return stackTop == -1;
        }

        public bool IsFull()
        {
            return stackTop == stackMax - 1;
        }

        public bool Push(int value)
        {
            if(IsFull())
            {
                return false;
            }
            stackTop++;
            stackArray[stackTop] = value;
            return true;
        }

        public bool Pop(out int value)
        {
            value = 0;
            if (IsEmpty())
            {
                return false;
            }
            value = stackArray[stackTop];
            stackTop--;
            return true;
        }

        public bool Peek(out int value)
        {
            value = 0;
            if (IsEmpty())
            {
                return false;
            }
            value = stackArray[stackTop];
            return true;
        }


        public void ShowStack()
        {
            for(int i = 0; i < stackArray.Length; i++)
            {
                Console.Write(stackArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int Count()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int count = 0;
                foreach (var value in stackArray)
                {
                    count++;
                }
                return count;
            }
        }

    }
}
