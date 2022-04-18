namespace LiveQuiz
{
    partial class QuizHostForm
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
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.lblAns4 = new System.Windows.Forms.Label();
            this.btnContext = new System.Windows.Forms.Button();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContestants = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbIP
            // 
            this.cmbIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Location = new System.Drawing.Point(941, 584);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(194, 29);
            this.cmbIP.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIP.Location = new System.Drawing.Point(849, 587);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(86, 21);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP Address:";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBegin.Location = new System.Drawing.Point(1141, 584);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(119, 29);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Start Quiz";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contestants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(294, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Code:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(402, 587);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(102, 21);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Room Code:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuestion.Location = new System.Drawing.Point(296, 57);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(964, 268);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "label3";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns1.Location = new System.Drawing.Point(296, 349);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(63, 25);
            this.lblAns1.TabIndex = 8;
            this.lblAns1.Text = "label3";
            this.lblAns1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns2.Location = new System.Drawing.Point(296, 384);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(63, 25);
            this.lblAns2.TabIndex = 9;
            this.lblAns2.Text = "label3";
            this.lblAns2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAns3
            // 
            this.lblAns3.AutoSize = true;
            this.lblAns3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns3.Location = new System.Drawing.Point(296, 420);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(63, 25);
            this.lblAns3.TabIndex = 10;
            this.lblAns3.Text = "label3";
            this.lblAns3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAns4
            // 
            this.lblAns4.AutoSize = true;
            this.lblAns4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns4.Location = new System.Drawing.Point(296, 456);
            this.lblAns4.Name = "lblAns4";
            this.lblAns4.Size = new System.Drawing.Size(63, 25);
            this.lblAns4.TabIndex = 11;
            this.lblAns4.Text = "label3";
            this.lblAns4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContext
            // 
            this.btnContext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContext.Location = new System.Drawing.Point(296, 549);
            this.btnContext.Name = "btnContext";
            this.btnContext.Size = new System.Drawing.Size(964, 29);
            this.btnContext.TabIndex = 12;
            this.btnContext.Text = "Next Question";
            this.btnContext.UseVisualStyleBackColor = true;
            this.btnContext.Click += new System.EventHandler(this.btnContext_Click);
            // 
            // lblAnswers
            // 
            this.lblAnswers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswers.Location = new System.Drawing.Point(296, 494);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(964, 52);
            this.lblAnswers.TabIndex = 13;
            this.lblAnswers.Text = "label3";
            this.lblAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(294, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Question:";
            // 
            // pnlContestants
            // 
            this.pnlContestants.AutoScroll = true;
            this.pnlContestants.Location = new System.Drawing.Point(12, 33);
            this.pnlContestants.Name = "pnlContestants";
            this.pnlContestants.Size = new System.Drawing.Size(266, 575);
            this.pnlContestants.TabIndex = 15;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(433, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(687, 52);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "30";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuizHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 625);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pnlContestants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.btnContext);
            this.Controls.Add(this.lblAns4);
            this.Controls.Add(this.lblAns3);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.cmbIP);
            this.Name = "QuizHostForm";
            this.Text = "QuizHostForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizHostForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizHostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.Button btnContext;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pnlContestants;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}