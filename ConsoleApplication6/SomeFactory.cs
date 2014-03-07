using System;

namespace ConsoleApplication6
{
    public abstract class SomeFactory : SomeBaseFactory, ISomeFactory
    {
        public override void Hello()
        {
            Console.WriteLine("SomeFactory:Hello implicit");
        }

        
        void ISomeBaseFactory.Hello()
        {
            Console.WriteLine("SomeFactory:Hello explicit");
        }
    }
}