using System;

namespace ConsoleApplication6
{
    public abstract class SomeBaseFactory : ISomeBaseFactory
    {
        public virtual void Hello()
        {
            Console.WriteLine("SomeBaseFactory:Hello");
        }
    }
}