using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication {
    public class Question {
        private string question;
        private int answer;

        public Question(string question, int answer) {
            this.question = question;
            this.answer = answer;
        }

        public bool IsCorrect(int givenAns) {
            return givenAns == answer;
        }

        public string GetQuestion() {
            return question;
        }

        public int GetAnswer() {
            return answer;
        }
    }
}
