using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    //Generic Constraints
    //1)Primary Constraints it cannot be combined or duplicated
    /// class,struct,enum
    //2)Special Primary constraints where T is a parent class and it is own children
    //3)Secondary Constraints which is interfaces

    
    internal class MyStackV02<T> where T : class 
    {
        T[] arr;
        int tos;
        int size;
        public MyStackV02()
        {
            size = 5;
            tos = 0;
            arr = new T[size];
        }
        public MyStackV02(int size)
        {
            this.size = size;
            tos = 0;
            arr = new T[size];

        }
        public void Push(T value)
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
        public T? Pop()
        {
            T? retVal=default;
            if (!IsEmpty())
            {

                retVal = arr[--tos];
            }
            return retVal;
        }
        public bool IsFull() { return tos == size; }
        public bool IsEmpty() { return tos == 0; }
    }
}

