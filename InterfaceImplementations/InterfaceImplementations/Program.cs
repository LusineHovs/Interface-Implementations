using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementations
{
    interface IExample
    {
        int Method(int e);
    }
    // IExample interface explicit implementation
    class A : IExample
    {
        int IExample.Method(int a)
        {
            return a * a;
        }
    }

    // IExample interface implicit implementation
    class B : IExample
    {
        public int Method(int e)
        {
            return e*e;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //In case of explicit implementation
            A a = new A();
            ((IExample)a).Method(10);

            //In case of implicit implementation
            B b = new B();
            b.Method(12);

        }
    }
}
