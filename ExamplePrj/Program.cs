using System;
using ExamplePrj1;
using System.ComponentModel;
using System.Text;
using System.Xml;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace ExamplePrj
{
    public class Example
    {
        public int exampleNumber;
        public string exampleName;
        public Example(int num)
        {
            exampleNumber = num;
        }

        public Example(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }
    }
    internal class Program
    {
        //infinite parameters
        public static void ExampleInfinite(params string[] words)
        {
            foreach (string word in words) 
            {
            Console.WriteLine(word);
            }
        }
        //properties
        private string id;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        static void Main(string[] args)
        {
            //infinite param method - calling it
            ExampleInfinite();
            ExampleInfinite("hi");
            ExampleInfinite("hi", "hello");
            ExampleInfinite("hi", "hello", "aloha");


            //lambda and func and delegates
            Func<int, int, int> multiply = (x, y) => { return x * y; };
            Console.WriteLine(multiply(3,2));

            //Properties
            Program program = new Program();
            program.Id = "1234";
            Console.WriteLine(program.Id);


            //calling the Example class to test Constructor
            Example ex = new Example(5);
            Console.WriteLine(ex.exampleNumber);
            Example ex2 = new Example(5, "John");
            Console.WriteLine("{0} {1}", ex2.exampleNumber, ex2.exampleName);

            //working with files
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.text";
            if (!File.Exists(path)) 
            {
                File.Create(path);
            }

            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World");
            fs.Write(info, 0, info.Length);
            fs.Close();

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();
            Console.WriteLine(fileText);


            //obtaining numerical input from uer
            Console.WriteLine("\n Please enter a number: ");
            do
            {
                string userInput2 = Console.ReadLine();
                int inputnumber;

                if (!int.TryParse(userInput2, out inputnumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered invalid input!");
                    Console.ResetColor();
                    Console.WriteLine("\n Please enter a number: ");
                }
                else
                {
                    Console.WriteLine("\n Thanks!  Enter another number: ");
                }
            } while (true);


            //background color program with Read()
            Console.WriteLine("g = green, r = red, b = blue, w = white");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);

            while (userInput != 'z')
            {
                switch (userInput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("g = green, r = red, b = blue, w = white");
                x = Console.Read(); 
                userInput = Convert.ToChar(x);
            }

            //Read()
            Console.WriteLine("hit a key: ");
            int n = Console.Read();
            Console.WriteLine(n);
            Console.WriteLine(Convert.ToChar(n));

            //ReadLine()
            Console.WriteLine("Type some text: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine(userInput1);

            //while loop
            int q = 0;
            while (q < 3) 
            {
                Console.WriteLine(q.ToString());
                q++;
            }

            //foreach loop
            foreach (char r in "abc") 
            {
                Console.WriteLine(r);
            }


            //code challenge add all numbers from 0 to 99
            int p= 0;
            for (int i = 0; i< 100; i++)
            {
                p+= i;
            }
            Console.WriteLine(p);

            //for loops
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("Hello World");
            }

            string forstring = "abcd";
            for(int i = 0; i < forstring.Length; i++)
            {
                Console.WriteLine(forstring[i]);
            }

            for(int i = forstring.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(forstring[i]);
            }

            //nested for loops
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("i = " + i.ToString() + "j = " + j.ToString());
                }
            }
            //nested if statement
            if (1 < 2)
            {
                if(false) 
                {
                    Console.WriteLine("nested if hit");
                }
                else
                {
                    Console.WriteLine("nested else hit");
                }

            }


            //if else if and else
            if (5 < 3) 
            {
                Console.WriteLine("5 is less than 3");

            }
            else if (4 < 2)
            {
                Console.WriteLine("4 is less than 2");
            }
            else 
            {
                Console.WriteLine("else statement hit");
            }

            //DateTime class
            Console.WriteLine(DateTime.Now);

            DateTime date = new DateTime();

            //Timespan Class
            TimeSpan timeSpan = new TimeSpan();

            //DateTime Formatting
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyy hh:mm tt"));
            Console.WriteLine(DateTime.Now.ToUniversalTime().ToString("MM/dd/yyy hh:mm tt"));

            //boxing stores a value type to a reference type of object
            int example1 = 1;
            object o = example1;

            //unboxing the box object
            int example2 = (int)o;

            //implicit conversion
            int num = 3;
            float f = num;

            //explicit conversion or 'cast'
            float t = 1.5f;
            int example = (int)t;




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
            //will print 'price' as 100.00
            float percent = 0.5f;
            Console.WriteLine("The task is {0:P} complete", percent);

            //slicing strings
            string example12 = "abc";
            Console.WriteLine(example12.Contains("bc"));
            Console.WriteLine(example12.Substring(1));
            //will print 'bc'
            Console.WriteLine(example12.Substring(0, 2));
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