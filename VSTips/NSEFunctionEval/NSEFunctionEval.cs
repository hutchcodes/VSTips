using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VSTips.NSEFunctionEval
{
    class NSEFunctionEval
    {
        public static void Run()
        {
            var foo = new Foo();

            foo.AddOne();
            foo.AddOne();

            Console.WriteLine($"Final Count = {foo.Count}");
        }

        [DebuggerDisplay("Count={Count}")]
        class Foo
        {
            public int Count { get; private set; } = 0;

            public int AddOne()
            {
                Count++;
                return Count;
            }
        }
    }
}
