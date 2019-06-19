using System.Text.RegularExpressions;

namespace VSTips.Regexer
{
	class Regexer
	{
		public bool CheckString(string value)
		{
            //language=regex,ExplicitCapture
            string containsUnicode = @"\\\\u[0-9A-Fa-f]{4}";

            var regEx = new Regex(@"(A|[B]|C)Test\1");

			var match = new Regex(containsUnicode).Match(value);

			//UNDONE: Needs to be completed
			return true;
		}
	}
}
