using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Adv_c__revision
{
    internal class MyStack
    {
        int[] arr;
        int tos;
        int size;
        public MyStack()
        {
            size = 5;
            tos=0;
            arr = new int[size];
        }
        public MyStack(int size)
        {
            this.size = size;  
            tos = 0;
            arr=new int[size];
            
        }
        public void Push(int value)
        {
            if (!IsFull())
            {
                arr[tos++] = value;
            }
            else
            {
                Console.WriteLine("IsFull");
            }
        }
        public int Pop() {
            int retVal = -123;
            if(!IsEmpty())
            {

                retVal = arr[--tos];
            }
            return retVal;
        }
        public bool IsFull() { return tos == size; }
        public bool IsEmpty() { return tos == 0; }
        }
    }

