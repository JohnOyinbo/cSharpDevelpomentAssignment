using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomIndexGen();
            for (int j = 0; j < 10; j++)
            {
                Questions a = QuestionDatabase()[index[j] - 1];
                Console.WriteLine($"{j+1}. {a}");
                string userOption = Console.ReadLine().ToLower();
                Grading(a, userOption);
            }
            Console.WriteLine($"your score is {score}%");
            Console.ReadLine();
        }
        static Questions[] QuestionDatabase()
        {
            Questions question1 = new Questions
            {
                Question = "What is the biggest country in the world?",
                Answer = "Russia",
                Options = new string[] { "Russia", "U.S.A", "China", "India" }
            };

            Questions question2 = new Questions
            {
                Question = "Approximately how many people live on earth?",
                Answer = "7 billion",
                Options = new string[] { "8 billion", "7 billion", "9 billion", "6 billion" }
            };

            Questions question3 = new Questions
            {
                Question = "What is the biggest river in the world?",
                Answer = "Nile",
                Options = new string[] { "Nile", "Amazon", "Mississippi-Missouri", "Chang Jiang (Yangtze)" }
            };

            Questions question4 = new Questions
            {
                Question = "What is the highest mountain in the world?",
                Answer = "Mount Everest",
                Options = new string[] { "Mount Everest", "K-2", "Kangchenjunga", "Lhotse" }
            };

            Questions question5 = new Questions
            {
                Question = "What is the largest coffee growing country in the world?",
                Answer = "Brazil",
                Options = new string[] { "America", "Brazil", "Italy", "England" }
            };

            Questions question6 = new Questions
            {
                Question = "In what city were the 2000 Olympics held in australia?",
                Answer = "Sydney",
                Options = new string[] { "Melbourne", "Sydney", "Canberra", "Hobart" }
            };

            Questions question7 = new Questions
            {
                Question = "What is the capital city of New zealand?",
                Answer = "Wellington",
                Options = new string[] { "Wellington", "Christchurch", "Auckland", "Hamilton" }
            };

            Questions question8 = new Questions
            {
                Question = "Which indoor sport is the most popular in the US?",
                Answer = "Basketball",
                Options = new string[] { "Indoor soccer", "Basketball", "Swimming", "Football" }
            };

            Questions question9 = new Questions
            {
                Question = "In which country was golf first played?",
                Answer = "Scotland",
                Options = new string[] { "England", "Scotland", "Australia", "America" }
            };

            Questions question10 = new Questions
            {
                Question = "Which state is the biggest in the US?",
                Answer = "California",
                Options = new string[] { "New York", "California", "Alaska", "Texas" }
            };

            Questions[] questions = { question1, question2, question3, question4, question5, question6, question7, question8, question9, question10 };
            return questions;
        }
        public static int[] index = new int[10];
        static void RandomIndexGen()
        {
            Random random = new Random();
            var counter = 0;
            do
            {
                var randomNumber = random.Next(1, 11);
                if (Array.IndexOf(index, randomNumber) == -1)
                {
                    index[counter] = randomNumber;
                    counter++;
                }
            } while (counter < 10);
        }
        public static int score = 0;
        static int Grading(Questions a, string userInput)
        {
            
           string userInput2 = "";
            
            if (userInput == "a")
                userInput2 = a.Options[a.numbers[0] - 1];
            else if (userInput == "b")
                userInput2 = a.Options[a.numbers[1] - 1];
            else if (userInput == "c")
                userInput2 = a.Options[a.numbers[2] - 1];
            else if (userInput == "d")
                userInput2 = a.Options[a.numbers[3] - 1];
            else
                userInput2 = "";


            if (userInput2 == a.Answer)
                score += 10;
            else
                score += 0;
            return score;
        }
    }
}
