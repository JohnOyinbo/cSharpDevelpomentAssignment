using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RandomQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
        }

        static void QuestionDatabase()
        {
            // question 1
            Options option1 = new Options
            {
                OptionA = "Russia",
                OptionB = "America",
                OptionC = "China",
                OptionD = "India",
            };
            Questions question1 = new Questions
            {
                Question = "What is the biggest country in the world?",

                Options = option1
            };


            //question 2
            Options option2 = new Options
            {
                OptionA = "8 billion",
                OptionB = "6 billion",
                OptionC = "7 billion",
                OptionD = "5 billion"
            };
            Questions question2 = new Questions
            {
                Question = "Approximately how many people live on earth",

                Options = option2
            };
            

            //question 3
            Questions question3 = new Questions();
            question3.Question = "What is the biggest river in the world?";
            question3.Options.OptionA = "Nile";
            question3.Options.OptionB = "Amazon";
            question3.Options.OptionC = "Mississippi-Missouri";
            question3.Options.OptionD = "Chang Jiang (Yangtze) ";
            question3.Options.CorrectOption = question3.Options.OptionA;

        }
    }
}
