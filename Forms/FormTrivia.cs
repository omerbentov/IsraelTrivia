using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsraelTrivia.Forms
{
    public partial class FormTrivia : Form
    {
        private int lastChecked;
        private ArrayList allQuestionsArray, randomQuestions;
        private int currentQuestionInd;
        private int[] results;
        private string[] chosenAnswers;

        public FormTriviaResults.eOptions ReturnValue { get; set; }
        public FormTrivia(ArrayList questionsArray)
        {
            InitializeComponent();
            this.allQuestionsArray = questionsArray;
            this.results = null;
            this.chosenAnswers = null;
        }

        private void FormTrivia_Load(object sender, EventArgs e)
        {
            this.currentQuestionInd = 0;
            this.randomQuestions = generateRandomQuestions();
            this.results = new int[randomQuestions.Count];
            chosenAnswers = new string[randomQuestions.Count];
            updateQuestionPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentQuestionInd++; 
            updateQuestionPanel();
        }


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {//item was selected in listbox
            int activeCheckBox = e.Index;
            if(activeCheckBox != lastChecked && lastChecked != -1)
                this.checkedListBoxAnswer.SetItemCheckState(lastChecked, CheckState.Unchecked);
            this.lastChecked = e.NewValue == CheckState.Checked ? activeCheckBox : -1;
        }

        private ArrayList generateRandomQuestions()
        {//generate random questions for the trivia
            Random rand = new Random();
            ArrayList questions = (ArrayList)allQuestionsArray.Clone();
            ArrayList randomQuestions = new ArrayList(10);
            for(int i = 0; i < 10; i++)
            {
                int randomInd = rand.Next(0, questions.Count - 1);
                randomQuestions.Add(questions[randomInd]);
                questions.RemoveAt(randomInd);
            }

            return randomQuestions;
        }

        private void button1_Click(object sender, EventArgs e)
        {//answer button
            Question currentQuestion = randomQuestions[currentQuestionInd] as Question;
            if(lastChecked != -1)
            {//check if some answer was picked before click
                string ans = this.checkedListBoxAnswer.CheckedItems[0].ToString();
                results[currentQuestionInd] = currentQuestion.PossibleAnswers[ans];
                chosenAnswers[currentQuestionInd] = ans;
                currentQuestionInd++;
                updateQuestionPanel();
            }
            else
            {
                //error
            }
        }

        private void updateQuestionPanel()
        {//update panel after change
            if(currentQuestionInd < this.randomQuestions.Count)
            {//trivia isnt done yet
                this.lastChecked = -1;
                this.btnSkip.Enabled = this.currentQuestionInd < this.randomQuestions.Count - 1;
                Question currentQuestion = (Question)randomQuestions[this.currentQuestionInd];
                this.lblQuestionNumber.Text = this.currentQuestionInd.ToString();
                this.textBoxQuestionContent.Text = currentQuestion.Content;
                while (this.checkedListBoxAnswer.Items.Count > 0) this.checkedListBoxAnswer.Items.RemoveAt(0);
                foreach (KeyValuePair<string, int> option in currentQuestion.PossibleAnswers)
                {
                    this.checkedListBoxAnswer.Items.Add(option.Key, false);
                }
            }

            else
            {//player done the game
                saveStatistics();
                this.Hide();
                FormTriviaResults formTriviaResults = new FormTriviaResults(this.randomQuestions, this.results);
                formTriviaResults.ShowDialog();
                FormTriviaResults.eOptions result = formTriviaResults.ReturnValue;
                
                switch(result)
                {//list of callbacks from the result trivia form
                    case FormTriviaResults.eOptions.TryAgain:
                        this.currentQuestionInd = 0;
                        updateQuestionPanel();
                        this.Show();
                        break;
                    case FormTriviaResults.eOptions.NewGame:
                        this.currentQuestionInd = 0;
                        this.randomQuestions = generateRandomQuestions();
                        this.results = new int[randomQuestions.Count];
                        updateQuestionPanel();
                        this.Show();
                        break;
                    case FormTriviaResults.eOptions.Quit:
                        this.ReturnValue = formTriviaResults.ReturnValue;
                        this.Close();
                        break;
                    case FormTriviaResults.eOptions.MoveToLearning:
                        this.ReturnValue = formTriviaResults.ReturnValue;
                        this.Close();
                        break;
                }
                
            }

           
        }

        private void saveStatistics()
        {//save each answer and question with username
            string path = Path.GetFullPath(Environment.CurrentDirectory + @"..\..\..\Statistics\outdata_" + DateTime.Now.ToString("yyyy-MM-ddTHH_mm_ss") + ".txt");
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(Utils.username);
                sw.Write(";");
                for(int i = 0; i < randomQuestions.Count; i++)
                {
                    Question question = randomQuestions[i] as Question;
                    sw.Write(question.Content);
                    sw.Write(";");
                    sw.Write(chosenAnswers[i]);
                    sw.WriteLine(";");
                }
            }
        }
    }
}
