using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomQuiz
{
    public class Options
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }

        public override string ToString()
        {
            return
                $@"a. {OptionA}
b. {OptionB}
c. {OptionC}
d. {OptionD}";
        }

    }
}
