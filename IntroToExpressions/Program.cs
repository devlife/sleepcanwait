using System;

namespace IntroToExpressions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string myString = null;
				Validate.IsNotNull(() => myString);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.Read();
		}
	}
}
