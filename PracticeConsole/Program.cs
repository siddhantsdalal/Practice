// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class PracticeProgramBasics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is a Test Program.");
            Console.WriteLine("This is to learn the basics of C#.");
            Console.WriteLine("And also for the future reference.");

            string githubID = "GitHub ID: siddhantsdalal";
            string githubPassword = "Password: Siddhant@1996";
            Console.WriteLine(githubID);
            Console.WriteLine(githubPassword);

            int myNum = 15;
            myNum = 20; // Here we are overwriting the myNum wqhich was 15 by 20.
            Console.WriteLine(myNum);

            const int myNum2 = 30; // Cannot be changed and readonly because of keyword const (Constant)..
            Console.WriteLine(myNum2);

            double floatingNum = 10.5;
            Console.WriteLine(floatingNum);

            bool myBool = false;
            bool myBool2 = true;
            Console.WriteLine(myBool);
            Console.WriteLine(myBool2);

            char myChar;
            myChar = 'a';
            Console.WriteLine(myChar);

            // Display Variables
            string firstName;
            string lastName;
            int a = 1;
            int b = 2;
            firstName = "Siddhant";
            lastName = "Dalal";
            Console.WriteLine("Name = " + firstName + " " + lastName);
            Console.WriteLine(a + b);
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            // Data Types
            float f1 = 35e3F; // A floating point number can also be a scientific number with an "e" to indicate the power of 10.
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            bool booleanTrue = true;
            bool booleanFalse = false;
            Console.WriteLine(booleanTrue);
            Console.WriteLine(booleanFalse);
            char myInitial = 's';
            Console.WriteLine(myInitial);
            string myName = "Siddhant Satish Dalal";
            Console.WriteLine(myName);

            // Type Casting
            int myIntCasting = 9;
            double myDoubleCasting = myIntCasting;       // Automatic casting: int to double (Implicit casting)
            Console.WriteLine(myIntCasting);      // Outputs 9
            Console.WriteLine(myDoubleCasting);   // Outputs 9
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int (Explicit casting)
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(Convert.ToString(myIntCasting));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntCasting));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // Arithematic
            int sum1 = 50 + 50;
            int sum2 = sum1 + 10;
            int sum3 = sum1 + sum2;
            Console.WriteLine(sum3);

            // Assignment Operations
            int d = 10;
            d += 5;
            Console.WriteLine(d);

            // Comparison
            int e = 5;
            int f = 3;
            Console.WriteLine(e > f);
            Console.WriteLine(e < f);
            Console.WriteLine(e != f);
            Console.WriteLine(e >= f);
            Console.WriteLine(e <= f);
            Console.WriteLine(e == f);

            // Logical Operators
            Console.WriteLine(e < 5 && e < 10);
            Console.WriteLine(e < 5 || e < 4);
            Console.WriteLine(!(e < 5 && e < 10));

            // Math
            Math.Sqrt(64);

            // Switch
            int day = 6;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }

            // Loops
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Volvo", "BMW", "Honda", "Ford", "Toyoya" };
            foreach (string j in cars)
            {
                Console.WriteLine(j);
            }
        }
    }
}