using System;

namespace Test2
{
    class Program
    {
		//Covert Roman Figures to numbers
        static void Main(string[] args)
        {
			string[] romanNumbers = new[] { "M", "MCMXC", "MMVIII", "MDCLXVI" };
			foreach (string number in romanNumbers)
			{
				int decimalNumber = Decode(number);
				Console.WriteLine("{0}: {1}", number, decimalNumber);
			}
		}


		// returns the value for a roman literal
		private static int romanValue(int index)
		{
			int basefactor = ((index % 2) * 4 + 1); // either 1 or 5...
													
			return index > 1 ? (int)(basefactor * System.Math.Pow(10.0, index / 2)) : basefactor; // ...multiplied with the exponentation of 10, if the literal is `x` or higher
		}



		//convert roman to numeric 
		public static int Decode(string roman)
		{
			roman = roman.ToLower();
			string literals = "mdclxvi";
			int value = 0, index = 0;
			foreach (char literal in literals)
			{
				value = romanValue(literals.Length - literals.IndexOf(literal) - 1);
				index = roman.IndexOf(literal);
				if (index > -1)
					return Decode(roman.Substring(index + 1)) + (index > 0 ? value - Decode(roman.Substring(0, index)) : value);
			}

			return 0;
		}
	}
}
