using System;
using System.Collections.Generic;
using System.Text;

namespace VSTips
{
   interface IGreeter
    {
        string SayHello();
        string SayHello(string firstName, string lastName);
        string SayHello(string fullName);
    }
}
