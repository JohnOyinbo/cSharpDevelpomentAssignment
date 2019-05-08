using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomQuiz
{
    public class Questions

    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string[] Options = new string[4];
        public readonly int[] numbers = new int[4];
        public Questions()
        {

            Random random = new Random();
            var counter = 0;
            do
            {
                var randomNumber = random.Next(1, 5);
                if (Array.IndexOf(numbers, randomNumber) == -1)
                {
                    numbers[counter] = randomNumber;
                    counter++;
                }
            } while (counter < 4);
        }
        public override string ToString()
        {
            return $@"{Question}
a. {Options[numbers[0] - 1]}
b. {Options[numbers[1] - 1]}
c. {Options[numbers[2] - 1]}
d. {Options[numbers[3] - 1]}";
        }

    }
}
