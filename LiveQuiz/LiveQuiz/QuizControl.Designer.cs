namespace LiveQuiz
{
    partial class QuizControl
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
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnJoinQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuizName.Location = new System.Drawing.Point(9, 9);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(122, 30);
            this.lblQuizName.TabIndex = 0;
            this.lblQuizName.Text = "Quiz Name";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreator.Location = new System.Drawing.Point(10, 44);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(190, 21);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "Created by: Creator Name";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTopic.Location = new System.Drawing.Point(10, 66);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(152, 21);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Topic: The Quiz Topic";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnJoinQuiz
            // 
            this.btnJoinQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJoinQuiz.Location = new System.Drawing.Point(447, 11);
            this.btnJoinQuiz.Name = "btnJoinQuiz";
            this.btnJoinQuiz.Size = new System.Drawing.Size(98, 78);
            this.btnJoinQuiz.TabIndex = 3;
            this.btnJoinQuiz.Text = "Join";
            this.btnJoinQuiz.UseVisualStyleBackColor = true;
            this.btnJoinQuiz.Click += new System.EventHandler(this.btnJoinQuiz_Click);
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnJoinQuiz);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblQuizName);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(559, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnJoinQuiz;
    }
}
