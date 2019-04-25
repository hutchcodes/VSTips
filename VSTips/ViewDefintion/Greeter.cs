using System;
using System.Collections.Generic;
using System.Text;

namespace VSTips.ViewDefintion
{
    class SimpleGreeter : IGreeter
    {
        public virtual string SayHello()
        {
            return "Hello";
        }

        public string SayHello(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }

        public string SayHello(string fullName)
        {
            return $"Hello {fullName}";
        }
    }

    class WorldGreeter : SimpleGreeter
    {
        public override string SayHello()
        {
            return $"Hello World!";
        }
    }
    
}
