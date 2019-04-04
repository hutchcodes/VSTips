using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VSTips.DebuggerDisplay
{
    class DebuggerDisplay
    {
        static List<Person> persons;
        public static void Run()
        {
            //Todo: Show a task
            persons = new List<Person>
            {
                new Person {FirstName = "Fred", LastName = "Flintstone" },
                new Person {FirstName = "Wilma", LastName = "Flintstone" },
                new Person {FirstName = "Pebbles", LastName = "Flintstone" },
                new Person {FirstName = "Barney", LastName = "Rubble" },
                new Person {FirstName = "Betty", LastName = "Rubble" },
                new Person {FirstName = "Bamm-Bamm", LastName = "Rubble" },
            };

            var p = new Person { FirstName = "Dino", LastName = "Flintstone" };
        }
    }
}
