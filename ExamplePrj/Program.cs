using ExamplePrj1;
using System.ComponentModel;

namespace ExamplePrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = "abc" is string;
            Console.WriteLine(b);

            Console.WriteLine("Hello, World!");
            MyMethod();
            Testing.newClassMethod();
            int number = Add(2, 3);
            Console.WriteLine(number);
            
            Double.DoubleNumber(5);

            //for loops
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i =0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

            //while loops
            int y = 3;
            while (y > 0)
            {
                Console.WriteLine(y);
                y--;
            }

        }

        static void  MyMethod()
        {
            var testText = "Hello Method";
            Console.WriteLine(testText);
        }

        public static int Add(int a, int b)
        {
            return a + b;

        }

        
       
    }
}