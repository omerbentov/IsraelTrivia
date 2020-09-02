using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelTrivia
{
    public class Question
    {
        private int id, type;
        private string content;
        private Dictionary<String, int> possibleAnswers;

        public Question(int id, int type, string content, Dictionary<String, int> possibleAnswers)
        {
            this.id = id;
            this.type = type;
            this.content = content;
            this.possibleAnswers = possibleAnswers;
        }
        public enum eCorrectness
        {
            Incorrect = 0,
            Correct = 1
        }
        public enum eQuestionType
        {
            TrueOrFalse = 0,
            American = 1
        }

        public int Id
        {
            get => id;
        }
        public int Type1
        {
            get => type;
        }
        public string Content
        {
            get => content;
        }
        public Dictionary<string, int> PossibleAnswers
        {
            get => possibleAnswers;
        }
    }
}
