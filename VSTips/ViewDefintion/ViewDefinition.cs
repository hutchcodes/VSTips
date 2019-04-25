using System;
using System.Collections.Generic;
using System.Text;

namespace VSTips.ViewDefintion
{
    class ViewDefinition
    {
        public static void Run()
        {
            IGreeter greeter1 = new SimpleGreeter();
            Console.WriteLine(greeter1.SayHello());

            SimpleGreeter greeter2 = new SimpleGreeter();
            Console.WriteLine(greeter2.SayHello());

            SimpleGreeter greeter3 = new WorldGreeter();
            Console.WriteLine(greeter3.SayHello());

            WorldGreeter greeter4 = new WorldGreeter();
            Console.WriteLine(greeter4.SayHello());

            SimpleGreeter greeter5 = new WorldGreeter();
            Console.WriteLine(greeter5.SayHello("Jeremy"));

        }
    }
}
