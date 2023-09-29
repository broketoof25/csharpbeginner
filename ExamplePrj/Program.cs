using ExamplePrj1;
using System.ComponentModel;
using System.Text;

namespace ExamplePrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boolean flag technique
            bool flag = false;
            List<int> intList = new List<int>() { 1, 2, 3};
            foreach (int i in intList)
            {
                if (i == 3)
                {
                    flag = true;
                }
            }

            if (flag) 
            {
                Console.WriteLine("3 was found");
            }



            //stringbuilder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World");
            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append("nice to see you");
            }
            string s = stringBuilder.ToString();
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello World");
            sb.AppendLine("Hello World");            
            StringBuilder sb2 = new StringBuilder("Hello World");
            //6, 5 first arg is index to start at, second is length from start
            sb2.Remove(6, 5);
            StringBuilder sb3 = new StringBuilder("This is a string with some spaces");
            //the replace will remove spaces and replace with underscore
            sb3.Replace(" ", "_");
            Console.WriteLine(sb3.ToString());
            stringBuilder.Clear();


            //string format
            int price = 100;
            Console.WriteLine(string.Format("This item costs {0:c}", price));
            //will print 'price' as $100.00
            float percent = 0.5f;
            Console.WriteLine("The task is {0:P} complete", percent);

            //slicing strings
            string example = "abc";
            Console.WriteLine(example.Contains("bc"));
            Console.WriteLine(example.Substring(1));
            //will print 'bc'
            Console.WriteLine(example.Substring(0, 2));
            //will print 'ab'


            //string equality
            string s4 = "abc";
            string s5 = "abc";
            Console.WriteLine(s4 == s5);
            Console.WriteLine(string.Equals(s4, s5));



            //string concatenation
            string s1 = "Hey";
            string s2 = "There";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

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