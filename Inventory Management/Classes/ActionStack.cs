using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    enum actions
    {
        Main,
        Add,
        Search,
        Edit,
        Suppliers,
        ViewEdits
    }
    class ActionStack
    {
        int front, length;
        actions[] list;
        public ActionStack(int Length)
        {
            length = Length;
            front = -1;
            list = new actions[length];
        }
        public actions Pop()
        {
            actions value;
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                value = list[front];
                front--;
            }
            return value;
        }
        public void Push(actions value)
        {
            if (IsFull())
            {
                throw new StackOverflowException("Full stack");
            }
            else
            {
                list.SetValue(value, front+1);
                front++;
            }
        }
        public actions Peek()
        {
            actions value;
            if (IsEmpty())
            {
                throw new Exception("Empty stack");
            }
            else
            {
                value = list[front];
            }
            return value;
        }
        public bool IsEmpty()
        {
            bool status;
            if (front == -1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public bool IsFull()
        {
            bool status;
            if (front == length-1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        public int GetCount()
        {
            int count = front;
            return count;
        }
    }
}
