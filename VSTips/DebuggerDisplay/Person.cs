using System.Diagnostics;

namespace VSTips.DebuggerDisplay
{
    [DebuggerDisplay("{LastName,nq}, {FirstName.Length >= 5 ? FirstName.Substring(0, 5) : FirstName,nq}")]
    class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
