using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Maths Quiz");
            Console.WriteLine("Input your name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Input your email address");
            string studentAddress = Console.ReadLine();
            Console.WriteLine("Input your age");
            string studentAge = Console.ReadLine();
            Console.WriteLine($"{studentName},Welcome to Maths Quiz \nThere are 10 questions in this quiz under which 4 options are listed \nkindly type in the correct option(a,b,c or d) and press enter.\n GODDLUCK!!!! \nPress any key to begin.");
            Console.ReadKey();
            int score = 0;
            string studentOption;
            string[] questions = { "\nQuestion 1: 5+9 =", "Question 2: 5*6 =", "Question 3: 98+55 =", "Question 4: 65+88 =", "Question 5: 38/2 =", "Question 6: 4*4 =", "Question 7: 10+5-3 = ", "Question 8: 24/8 = ", "Question 9: 3*4 =", "Question 10: 5*2*3 =" };
            string[] options = { "a.14 \nb.13\nc.24\nd.12", "a.40\nb.45\nc.30\nd.35 ", "a.154\nb.153\nc.155\nd.152", "a.153\nb.155\nc.154\nd.160", "a.20\nb.19\nc.21\nd.18", "a.15\nb.14\nc.13\nd.16", "a.13\nb.12\nc.14\nd.11", "a.6\nb.4\nc.3\nd.9", "a.16\nb.13\nc.12\nd.18", "a.20\nb.30\nc.40\nd.50" };
            string[] correctAnswers = { "a", "c", "b", "a", "b", "d", "b", "c", "c", "b" };
            for (int i = 0; i < 10; i++)
            {
                string question = questions[i];
                string answer = options[i];
                Console.WriteLine(question);
                Console.WriteLine(answer);
                Console.WriteLine("select an option");
                studentOption = Console.ReadLine();
                if (studentOption.ToLower() == correctAnswers[i])
                {
                    score += 1;
                }
                else
                {
                    score += 0;
                }

            }
            Console.WriteLine($"Dear {studentName},\nYour score is {score * 10}%");
            Console.ReadLine();
        }
    }
}
