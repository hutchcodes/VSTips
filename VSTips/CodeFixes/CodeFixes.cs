using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSTips.CodeFixes
{
    class CodeFixes
    {
        public void Foo(bool isTrue)
        {
            if (!isTrue)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            //var request = new RestRequest();
        }
    }
}
