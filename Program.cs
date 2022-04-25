using System;

namespace WeekThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //int firstNumber = 2;
            //int secondNumber = 4;
            //int thirdNumber = 2 + 4;

            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);
            //Console.WriteLine(thirdNumber);

            int myAgeToday = 29;

            //Console.WriteLine(myAgeToday);

            //myAgeToday = myAgeToday + 1;

            //Console.WriteLine(myAgeToday);

            //synthatical suger
            //myAgeToday += 1;
            myAgeToday ++;

            //Console.WriteLine(myAgeToday);


            //<<<<<<<<<<<simple Calculator App>>>>>>>>>>>>
            Console.WriteLine("This is a calculator app");
            Console.Write("Type in your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type in your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;
            //Concatenation
            Console.WriteLine("The addition of " + firstNumber + "and" + secondNumber +"is" + result);
        }
    }
}
