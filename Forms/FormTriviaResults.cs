using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsraelTrivia.Forms
{
    public partial class FormTriviaResults : Form
    {
        private ArrayList triviaCurrentQuestions;
        private int[] results;
        public eOptions ReturnValue { get; set; }
        
        public FormTriviaResults(ArrayList triviaCurrentQuestions, int[] results)
        {
            InitializeComponent();
            this.triviaCurrentQuestions = triviaCurrentQuestions;
            this.results = results;
        }

        private void FormTriviaResults_Load(object sender, EventArgs e)
        {
            int correctAns = 0;
            double score = 0.0;
            for(int i = 0; i < results.Length; i++)
            {
                int userAnswerResult = results[i];
                if(userAnswerResult == 0)
                {
                    Question question = triviaCurrentQuestions[i] as Question;
                    this.listBoxWrongAns.Items.Add(question.Id);
                }
                else
                {
                    correctAns++;
                }
            }

            this.textBoxScore.Text = ((double)correctAns / this.triviaCurrentQuestions.Count).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReturnValue = eOptions.Quit;
            this.Close();
        }

        public enum eOptions
        {
            Quit,
            TryAgain,
            NewGame,
            MoveToLearning
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ReturnValue = eOptions.TryAgain;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ReturnValue = eOptions.NewGame;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = eOptions.MoveToLearning;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//item was selected in listbox
            int i = 0;
            int currentQuestion = int.Parse(listBoxWrongAns.SelectedItem.ToString());
            Question question = triviaCurrentQuestions[i] as Question;
            while(question.Id != currentQuestion)
            {
                i++;
                question= triviaCurrentQuestions[i] as Question;
            }

            this.textBoxQuestion.Text = question.Content;
            this.textBoxAnswer.Text = question.PossibleAnswers.Keys.First();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
