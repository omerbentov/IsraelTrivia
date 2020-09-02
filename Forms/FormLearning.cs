using System;
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
    public partial class FormLearning : Form
    {
        private Queue<DataItem> informationDataItems;
        public FormLearning(Queue<DataItem> informationQueue)
        {
            InitializeComponent();
            this.informationDataItems = informationQueue;
        }

        private void FormLearning_Load(object sender, EventArgs e)
        {//initialize form
            DataItem firstDataItem = informationDataItems.Peek();
            this.lblInfoTitle.Text = firstDataItem.Topic;
            this.textBoxContent.Text = firstDataItem.Content;
            if(informationDataItems.Count <= 1)
            {//no info left to next
                btnNext.Text = "Go to trivia game!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//next button
            if(informationDataItems.Count <= 1)
            {
                this.Close();
            }
            else
            {
                this.informationDataItems.Dequeue();
                FormLearning_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//skip to last info
            while(informationDataItems.Count > 1)
            {
                this.informationDataItems.Dequeue();
            }
            FormLearning_Load(sender, e);
        }
    }
}
