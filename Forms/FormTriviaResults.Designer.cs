namespace IsraelTrivia.Forms
{
    partial class FormTriviaResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.listBoxWrongAns = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWrongAns = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLearning = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(14, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(271, 126);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxScore.Location = new System.Drawing.Point(323, 31);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(265, 71);
            this.textBoxScore.TabIndex = 1;
            this.textBoxScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxWrongAns
            // 
            this.listBoxWrongAns.FormattingEnabled = true;
            this.listBoxWrongAns.ItemHeight = 20;
            this.listBoxWrongAns.Location = new System.Drawing.Point(14, 59);
            this.listBoxWrongAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxWrongAns.Name = "listBoxWrongAns";
            this.listBoxWrongAns.Size = new System.Drawing.Size(294, 344);
            this.listBoxWrongAns.TabIndex = 2;
            this.listBoxWrongAns.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAnswer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelWrongAns);
            this.panel1.Controls.Add(this.textBoxQuestion);
            this.panel1.Controls.Add(this.listBoxWrongAns);
            this.panel1.Location = new System.Drawing.Point(21, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 425);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Right Answer";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(327, 300);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(252, 103);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Question";
            // 
            // labelWrongAns
            // 
            this.labelWrongAns.AutoSize = true;
            this.labelWrongAns.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongAns.Location = new System.Drawing.Point(8, 20);
            this.labelWrongAns.Name = "labelWrongAns";
            this.labelWrongAns.Size = new System.Drawing.Size(177, 35);
            this.labelWrongAns.TabIndex = 4;
            this.labelWrongAns.Text = "Wrong Answers!";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(327, 59);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(252, 198);
            this.textBoxQuestion.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnTryAgain);
            this.panel2.Controls.Add(this.btnNewGame);
            this.panel2.Controls.Add(this.btnLearning);
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Controls.Add(this.lblOptions);
            this.panel2.Location = new System.Drawing.Point(611, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 536);
            this.panel2.TabIndex = 4;
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(17, 94);
            this.btnTryAgain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(241, 88);
            this.btnTryAgain.TabIndex = 9;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(17, 209);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(241, 88);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLearning
            // 
            this.btnLearning.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearning.Location = new System.Drawing.Point(17, 320);
            this.btnLearning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLearning.Name = "btnLearning";
            this.btnLearning.Size = new System.Drawing.Size(241, 88);
            this.btnLearning.TabIndex = 7;
            this.btnLearning.Text = "Move to learning";
            this.btnLearning.UseVisualStyleBackColor = true;
            this.btnLearning.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(17, 428);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(241, 88);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(23, 15);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(221, 84);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "Options";
            // 
            // FormTriviaResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IsraelTrivia.Properties.Resources.b7909061_c43b_4fa7_85b3_68c7f1bb0bab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.lblScore);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTriviaResults";
            this.Text = "FormTriviaResults";
            this.Load += new System.EventHandler(this.FormTriviaResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.ListBox listBoxWrongAns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWrongAns;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLearning;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblOptions;
    }
}