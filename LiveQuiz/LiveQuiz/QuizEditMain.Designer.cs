namespace LiveQuiz
{
    partial class QuizEditMain
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
            this.btnBasics = new System.Windows.Forms.Button();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasics
            // 
            this.btnBasics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBasics.Location = new System.Drawing.Point(12, 12);
            this.btnBasics.Name = "btnBasics";
            this.btnBasics.Size = new System.Drawing.Size(447, 40);
            this.btnBasics.TabIndex = 0;
            this.btnBasics.Text = "Edit Quiz Basics";
            this.btnBasics.UseVisualStyleBackColor = true;
            this.btnBasics.Click += new System.EventHandler(this.btnBasics_Click);
            // 
            // btnQuestions
            // 
            this.btnQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuestions.Location = new System.Drawing.Point(12, 58);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(447, 40);
            this.btnQuestions.TabIndex = 1;
            this.btnQuestions.Text = "Edit Questions";
            this.btnQuestions.UseVisualStyleBackColor = true;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(12, 104);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(447, 40);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // QuizEditMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 157);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnQuestions);
            this.Controls.Add(this.btnBasics);
            this.Name = "QuizEditMain";
            this.Text = "QuizEditMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasics;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Button btnDone;
    }
}