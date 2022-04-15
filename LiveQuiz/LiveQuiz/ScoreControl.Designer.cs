namespace LiveQuiz
{
    partial class ScoreControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuizName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumCorr = new System.Windows.Forms.Label();
            this.lblTTA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuizName.Location = new System.Drawing.Point(9, 9);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(72, 30);
            this.lblQuizName.TabIndex = 0;
            this.lblQuizName.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(338, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(210, 30);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 999";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumCorr
            // 
            this.lblNumCorr.AutoSize = true;
            this.lblNumCorr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCorr.Location = new System.Drawing.Point(11, 45);
            this.lblNumCorr.Name = "lblNumCorr";
            this.lblNumCorr.Size = new System.Drawing.Size(158, 21);
            this.lblNumCorr.TabIndex = 2;
            this.lblNumCorr.Text = "Correct Answers: 999";
            // 
            // lblTTA
            // 
            this.lblTTA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTTA.Location = new System.Drawing.Point(342, 45);
            this.lblTTA.Name = "lblTTA";
            this.lblTTA.Size = new System.Drawing.Size(204, 21);
            this.lblTTA.TabIndex = 3;
            this.lblTTA.Text = "Time to Answer:";
            this.lblTTA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.lblTTA);
            this.Controls.Add(this.lblNumCorr);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblQuizName);
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(560, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumCorr;
        private System.Windows.Forms.Label lblTTA;
    }
}
