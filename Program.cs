// Write a C# Sharp program to calculate the average word length in a given string. Round the average length up to two decimal places.

using System.Text.RegularExpressions;
namespace Program
{
    class AverageLengthTask
    {
        public static double AverageLength(string s)
        {
            string new_text = Regex.Replace(s, "[^A-Za-z ]", "");
           
           double result = new_text.Split(" ").Select(x => x.Length).Average();

           return Math.Round(result,2);


        }
        public static void Main(string[] args)
        {
            Console.WriteLine (AverageLength("CPP Exercises."));
            Console.WriteLine (AverageLength("C# syntax is highly expressive, yet it is also simple and easy to learn."));
            Console.WriteLine (AverageLength("C# is an elegant and type-safe object-oriented language"));
        }
    }
}
/*
("CPP Exercises") -> 6
("C# syntax is highly expressive, yet it is also simple and easy to learn.") -> 4
(“C# is an elegant and type safe object oriented language") -> 5.62
*/