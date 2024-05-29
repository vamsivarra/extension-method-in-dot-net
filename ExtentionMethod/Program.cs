using System;
namespace ExtentionMethod
{
	public class Program
	{
        public Program()
        {
        }
            static void Main(string[] args)
            {
                int i = 10;

                bool result = i.IsGreaterThan(100);

                Console.WriteLine(result);
            }
    }
}


