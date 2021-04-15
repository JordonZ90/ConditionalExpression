using System;

namespace ConditionalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalExpression();
        }
        public static void ConditionalExpression()
        {
            Console.WriteLine("Please enter the score");
            int score = Convert.ToInt32(Console.ReadLine());
            string gradeLetter = (score <= 55) ? "F" :
            (score <= 65) ? "D" :
            (score <= 75) ? "C" :
            (score <= 85) ? "B" :
            (score <= 95) ? "A" :
            "A+";
            Console.WriteLine(gradeLetter);
        }
    }
}
