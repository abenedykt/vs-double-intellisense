using System;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("f1 : ");
            Factory f1 = new Factory();
            f1.Hello();

            Console.Write("f2 : ");
            SomeFactory f2 = new Factory();
            f2.Hello();

            Console.Write("f3 : ");
            ISomeFactory f3 = new Factory();
            f3.Hello();

            Console.Write("f4 : ");
            SomeBaseFactory f4 = new Factory();
            f4.Hello();

            Console.Write("f5 : ");
            ISomeBaseFactory f5 = new Factory();
            f5.Hello();

            Console.ReadLine();
        }
    }
}
