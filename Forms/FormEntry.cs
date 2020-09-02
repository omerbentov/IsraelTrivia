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
using IsraelTrivia.Forms;

namespace IsraelTrivia
{
    public partial class FrmTriviaEntry : Form
    {
        private ArrayList questionsArray = null;
        private Queue<DataItem> informationQueue = null;

        public FrmTriviaEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//move to learning

            if(hasName())
            {//check if name is valid
                Utils.username = getUsername();
                this.Hide();
                FormLearning formLearning = new FormLearning(informationQueue);
                formLearning.ShowDialog();
                FormTrivia formTrivia = new FormTrivia(questionsArray);
                formTrivia.ShowDialog();
                endOfGameCallBack(formTrivia.ReturnValue);
                if(formTrivia.ReturnValue != FormTriviaResults.eOptions.Quit)
                    this.Show();
            }
        }

        private void endOfGameCallBack(FormTriviaResults.eOptions callBack)
        {//check result from the last form
            if (callBack == FormTriviaResults.eOptions.Quit)
            {
                this.Close();
            }
            else if (callBack == FormTriviaResults.eOptions.MoveToLearning)
            {
                this.Hide();
                FormLearning formLearning = new FormLearning(informationQueue);
                formLearning.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//Trivia
            if(hasName())
            {//check if name is valid
                Utils.username = getUsername();
                this.Hide();
                //move to trivia screen
                FormTrivia formTrivia = new FormTrivia(questionsArray);
                formTrivia.ShowDialog();
                endOfGameCallBack(formTrivia.ReturnValue);
                if (formTrivia.ReturnValue != FormTriviaResults.eOptions.Quit)
                    this.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.questionsArray = Utils.readGameData();
            this.informationQueue = Utils.readInfoData();
        }

        private bool hasName()
        {
            return this.textBoxFirstName.Text.Length > 0 && this.textBoxLastName.Text.Length > 0;
        }

        private string getUsername()
        {
            return this.textBoxFirstName.Text + " " + this.textBoxLastName.Text;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
