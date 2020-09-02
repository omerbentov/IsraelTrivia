using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsraelTrivia
{
    class Utils
    {   
        public static string username = "";
        private static readonly string gameDataPath = Path.GetFullPath(Environment.CurrentDirectory + @"..\..\..\DATA\gameData.txt");
        private static readonly string infoDataPath = Path.GetFullPath(Environment.CurrentDirectory + @"..\..\..\DATA\infoData.txt");

        public static ArrayList readGameData()
        {
            string[] lines = System.IO.File.ReadAllLines(gameDataPath);
            ArrayList questionsArray = new ArrayList(lines.Length);
            foreach (string line in lines)
            {
                questionsArray.Add(parseQuestion(line));
            }

            return questionsArray;
        }

        public static Queue<DataItem> readInfoData()
        {
            string[] lines = System.IO.File.ReadAllLines(infoDataPath);
            Queue<DataItem> infoArray = new Queue<DataItem>(lines.Length);
            foreach (string line in lines)
            {
                infoArray.Enqueue(parseInfo(line));
            }

            return infoArray;
        }

        private static DataItem parseInfo(string line)
        {
            DataItem parsedDataItem;
            string[] properties = line.Split(';');
            parsedDataItem = new DataItem(int.Parse(properties[0]), properties[1], properties[2]);
            return parsedDataItem;
        }

        public static Question parseQuestion(string line)
        {
            Question parsedQuestion;
            Dictionary<string, int> possibleAnswers = new Dictionary<string, int>();
            string[] properties = line.Split(';');
            int id = int.Parse(properties[0]);
            int type = int.Parse(properties[1]);
            int numOfOptions = 0;
            switch(type)
            {
                case (int)Question.eQuestionType.American:
                    numOfOptions = 4;
                    break;
                case (int)Question.eQuestionType.TrueOrFalse:
                    numOfOptions = 2;
                    break;
            }

            for(int i = 3; i < numOfOptions + 3; i++)
            {
                if(possibleAnswers.Count == 0)
                {
                    possibleAnswers.Add(properties[i], (int)Question.eCorrectness.Correct);
                }
                else
                {
                    possibleAnswers.Add(properties[i], (int)Question.eCorrectness.Incorrect);
                }
            }
            parsedQuestion = new Question(id, type, properties[2], possibleAnswers);
            return parsedQuestion;
        }
    }
}
