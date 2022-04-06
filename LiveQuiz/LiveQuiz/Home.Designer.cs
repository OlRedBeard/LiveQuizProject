namespace LiveQuiz
{
    partial class Home
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
            this.btnMyQuizzes = new System.Windows.Forms.Button();
            this.lblContext = new System.Windows.Forms.Label();
            this.flpContext = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyScores = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnJoinCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNewQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyQuizzes
            // 
            this.btnMyQuizzes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyQuizzes.Location = new System.Drawing.Point(12, 62);
            this.btnMyQuizzes.Name = "btnMyQuizzes";
            this.btnMyQuizzes.Size = new System.Drawing.Size(190, 44);
            this.btnMyQuizzes.TabIndex = 0;
            this.btnMyQuizzes.Text = "My Quizzes";
            this.btnMyQuizzes.UseVisualStyleBackColor = true;
            this.btnMyQuizzes.Click += new System.EventHandler(this.btnMyQuizzes_Click);
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContext.Location = new System.Drawing.Point(224, 18);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(137, 21);
            this.lblContext.TabIndex = 1;
            this.lblContext.Text = "Join a Public Quiz!";
            // 
            // flpContext
            // 
            this.flpContext.AutoScroll = true;
            this.flpContext.Location = new System.Drawing.Point(224, 51);
            this.flpContext.Name = "flpContext";
            this.flpContext.Size = new System.Drawing.Size(569, 348);
            this.flpContext.TabIndex = 2;
            this.flpContext.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContext_Paint);
            // 
            // btnMyScores
            // 
            this.btnMyScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyScores.Location = new System.Drawing.Point(12, 112);
            this.btnMyScores.Name = "btnMyScores";
            this.btnMyScores.Size = new System.Drawing.Size(190, 44);
            this.btnMyScores.TabIndex = 3;
            this.btnMyScores.Text = "My Scores";
            this.btnMyScores.UseVisualStyleBackColor = true;
            this.btnMyScores.Click += new System.EventHandler(this.btnMyScores_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 39);
            this.textBox1.TabIndex = 4;
            // 
            // btnJoinCode
            // 
            this.btnJoinCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJoinCode.Location = new System.Drawing.Point(12, 355);
            this.btnJoinCode.Name = "btnJoinCode";
            this.btnJoinCode.Size = new System.Drawing.Size(190, 44);
            this.btnJoinCode.TabIndex = 5;
            this.btnJoinCode.Text = "Join Quiz";
            this.btnJoinCode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Join Quiz with Room Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(190, 44);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnNewQuiz
            // 
            this.btnNewQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewQuiz.Location = new System.Drawing.Point(603, 12);
            this.btnNewQuiz.Name = "btnNewQuiz";
            this.btnNewQuiz.Size = new System.Drawing.Size(190, 33);
            this.btnNewQuiz.TabIndex = 8;
            this.btnNewQuiz.Text = "Create New Quiz";
            this.btnNewQuiz.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 422);
            this.Controls.Add(this.btnNewQuiz);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJoinCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMyScores);
            this.Controls.Add(this.flpContext);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.btnMyQuizzes);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMyQuizzes;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.FlowLayoutPanel flpContext;
        private System.Windows.Forms.Button btnMyScores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnJoinCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNewQuiz;
    }
}