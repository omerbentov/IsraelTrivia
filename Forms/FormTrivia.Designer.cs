namespace IsraelTrivia.Forms
{
    partial class FormTrivia
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxAnswer = new System.Windows.Forms.CheckedListBox();
            this.textBoxQuestionContent = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 98);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trivia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkedListBoxAnswer);
            this.panel1.Controls.Add(this.textBoxQuestionContent);
            this.panel1.Location = new System.Drawing.Point(2, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 361);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose answer";
            // 
            // checkedListBoxAnswer
            // 
            this.checkedListBoxAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxAnswer.FormattingEnabled = true;
            this.checkedListBoxAnswer.Location = new System.Drawing.Point(25, 176);
            this.checkedListBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxAnswer.Name = "checkedListBoxAnswer";
            this.checkedListBoxAnswer.Size = new System.Drawing.Size(613, 142);
            this.checkedListBoxAnswer.TabIndex = 1;
            this.checkedListBoxAnswer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // textBoxQuestionContent
            // 
            this.textBoxQuestionContent.Location = new System.Drawing.Point(25, 11);
            this.textBoxQuestionContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuestionContent.Multiline = true;
            this.textBoxQuestionContent.Name = "textBoxQuestionContent";
            this.textBoxQuestionContent.Size = new System.Drawing.Size(613, 114);
            this.textBoxQuestionContent.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(209, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(246, 42);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Question Number: ";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(27, 462);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(331, 82);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(364, 475);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(124, 58);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Skip >";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(440, 49);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(30, 29);
            this.lblQuestionNumber.TabIndex = 6;
            this.lblQuestionNumber.Text = "X";
            // 
            // FormTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IsraelTrivia.Properties.Resources.Raising_the_Ink_Flag_at_Umm_Rashrash__cropped_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 562);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTrivia";
            this.Text = "FormTrivia";
            this.Load += new System.EventHandler(this.FormTrivia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuestionContent;
        private System.Windows.Forms.Label lblQuestionNumber;
    }
}