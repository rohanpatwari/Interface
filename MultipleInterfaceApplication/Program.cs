using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceApplication
{
    interface IA
    {
        void printA();
    }
    class A : IA
    {
    public void printA()
    {
        Console.WriteLine("A");
    }
    }
    interface IB
    {
        void printB();
    }
    class B : IB
    {
    public void printB()
    {
       Console.WriteLine("B");
    }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void printA()
        {
            a.printA();
        }
        public void printB()
        {
            b.printB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.printA();
            ab.printB();
            Console.ReadLine();
        }
    }
}
