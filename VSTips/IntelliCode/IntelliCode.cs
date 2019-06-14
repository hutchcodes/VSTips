using System;
using System.Collections.Generic;
using System.Text;

namespace VSTips.IntelliCode
{
    class IntelliCode
    {
        public string[] SplitString(string value)
        {
            if (value.Length == 0)
            {
                return new string[0];
            }

            var firstPart = value.Substring(0, value.IndexOf(','));

            string[] parts = value.Split(',');

            return parts;
        }
    }
}
