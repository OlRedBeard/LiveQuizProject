namespace LiveQuiz
{
    partial class QuestionsManual
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
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.rdoTF = new System.Windows.Forms.RadioButton();
            this.rdoMC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.lblAns4 = new System.Windows.Forms.Label();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnContext = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstQuestions
            // 
            this.lstQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 21;
            this.lstQuestions.Location = new System.Drawing.Point(12, 32);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(285, 382);
            this.lstQuestions.TabIndex = 0;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuestion.Location = new System.Drawing.Point(303, 32);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(485, 156);
            this.txtQuestion.TabIndex = 1;
            // 
            // txtAns1
            // 
            this.txtAns1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAns1.Location = new System.Drawing.Point(429, 229);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(359, 29);
            this.txtAns1.TabIndex = 2;
            // 
            // rdoTF
            // 
            this.rdoTF.AutoSize = true;
            this.rdoTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoTF.Location = new System.Drawing.Point(413, 194);
            this.rdoTF.Name = "rdoTF";
            this.rdoTF.Size = new System.Drawing.Size(115, 25);
            this.rdoTF.TabIndex = 3;
            this.rdoTF.Text = "True or False";
            this.rdoTF.UseVisualStyleBackColor = true;
            this.rdoTF.CheckedChanged += new System.EventHandler(this.rdoTF_CheckedChanged);
            // 
            // rdoMC
            // 
            this.rdoMC.AutoSize = true;
            this.rdoMC.Checked = true;
            this.rdoMC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoMC.Location = new System.Drawing.Point(538, 194);
            this.rdoMC.Name = "rdoMC";
            this.rdoMC.Size = new System.Drawing.Size(136, 25);
            this.rdoMC.TabIndex = 4;
            this.rdoMC.TabStop = true;
            this.rdoMC.Text = "Multiple Choice";
            this.rdoMC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correct Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(303, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wrong Answer:";
            // 
            // txtAns2
            // 
            this.txtAns2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAns2.Location = new System.Drawing.Point(429, 264);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(359, 29);
            this.txtAns2.TabIndex = 6;
            // 
            // lblAns3
            // 
            this.lblAns3.AutoSize = true;
            this.lblAns3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns3.Location = new System.Drawing.Point(303, 302);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(117, 21);
            this.lblAns3.TabIndex = 9;
            this.lblAns3.Text = "Wrong Answer:";
            // 
            // txtAns3
            // 
            this.txtAns3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAns3.Location = new System.Drawing.Point(429, 299);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(359, 29);
            this.txtAns3.TabIndex = 8;
            // 
            // lblAns4
            // 
            this.lblAns4.AutoSize = true;
            this.lblAns4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAns4.Location = new System.Drawing.Point(303, 337);
            this.lblAns4.Name = "lblAns4";
            this.lblAns4.Size = new System.Drawing.Size(117, 21);
            this.lblAns4.TabIndex = 11;
            this.lblAns4.Text = "Wrong Answer:";
            // 
            // txtAns4
            // 
            this.txtAns4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAns4.Location = new System.Drawing.Point(429, 334);
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.Size = new System.Drawing.Size(359, 29);
            this.txtAns4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correct Answer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(303, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Correct Answer:";
            // 
            // btnContext
            // 
            this.btnContext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContext.Location = new System.Drawing.Point(657, 379);
            this.btnContext.Name = "btnContext";
            this.btnContext.Size = new System.Drawing.Size(131, 35);
            this.btnContext.TabIndex = 14;
            this.btnContext.Text = "Add Question";
            this.btnContext.UseVisualStyleBackColor = true;
            this.btnContext.Click += new System.EventHandler(this.btnContext_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(548, 379);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(103, 35);
            this.btnDone.TabIndex = 15;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditAdd.Location = new System.Drawing.Point(303, 379);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(131, 35);
            this.btnEditAdd.TabIndex = 16;
            this.btnEditAdd.Text = "Add Question";
            this.btnEditAdd.UseVisualStyleBackColor = true;
            this.btnEditAdd.Visible = false;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(440, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // QuestionsManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditAdd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnContext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAns4);
            this.Controls.Add(this.txtAns4);
            this.Controls.Add(this.lblAns3);
            this.Controls.Add(this.txtAns3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAns2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoMC);
            this.Controls.Add(this.rdoTF);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lstQuestions);
            this.Name = "QuestionsManual";
            this.Text = "QuestionsManual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.RadioButton rdoTF;
        private System.Windows.Forms.RadioButton rdoMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnContext;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}