using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericClass<T>
    {
        public void Print(T param)
        {
            Console.WriteLine("Parameter "+param);
        }
    }
}
