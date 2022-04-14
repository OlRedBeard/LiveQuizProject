namespace LiveQuiz
{
    partial class QuizContestantForm
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
            this.pnlContestants = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlContestants
            // 
            this.pnlContestants.Location = new System.Drawing.Point(12, 33);
            this.pnlContestants.Name = "pnlContestants";
            this.pnlContestants.Size = new System.Drawing.Size(266, 575);
            this.pnlContestants.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contestants:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(323, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(907, 193);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "label2";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAns1
            // 
            this.btnAns1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAns1.Location = new System.Drawing.Point(323, 536);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(75, 72);
            this.btnAns1.TabIndex = 8;
            this.btnAns1.Text = "FALSE";
            this.btnAns1.UseVisualStyleBackColor = true;
            // 
            // btnAns2
            // 
            this.btnAns2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAns2.Location = new System.Drawing.Point(506, 536);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(75, 72);
            this.btnAns2.TabIndex = 9;
            this.btnAns2.Text = "button1";
            this.btnAns2.UseVisualStyleBackColor = true;
            // 
            // btnAns3
            // 
            this.btnAns3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAns3.Location = new System.Drawing.Point(861, 536);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(75, 72);
            this.btnAns3.TabIndex = 10;
            this.btnAns3.Text = "button1";
            this.btnAns3.UseVisualStyleBackColor = true;
            // 
            // btnAns4
            // 
            this.btnAns4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAns4.Location = new System.Drawing.Point(1048, 536);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(75, 72);
            this.btnAns4.TabIndex = 11;
            this.btnAns4.Text = "button1";
            this.btnAns4.UseVisualStyleBackColor = true;
            // 
            // QuizContestantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 625);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pnlContestants);
            this.Controls.Add(this.label1);
            this.Name = "QuizContestantForm";
            this.Text = "QuizContestantForm";
            this.Load += new System.EventHandler(this.QuizContestantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContestants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
    }
}