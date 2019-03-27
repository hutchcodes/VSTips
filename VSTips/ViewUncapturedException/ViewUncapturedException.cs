using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSTips.ViewUncapturedException
{
    class ViewUncapturedException
    {
        public static void Run()
        {
            var foo = new List<string>();

            string bar;
            try
            {
                bar = foo.First();
            }
            catch (InvalidOperationException)
            {
                //Do something like logging or retry
                bar = null;
            }
        }
    }
}
