
namespace LiveQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegisterStart = new System.Windows.Forms.Button();
            this.lblUserError = new System.Windows.Forms.Label();
            this.txtPass1Register = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass2Register = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPassError = new System.Windows.Forms.Label();
            this.btnRegisterComplete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnJoinAnon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserLogin.Location = new System.Drawing.Point(16, 33);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(250, 29);
            this.txtUserLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassLogin.Location = new System.Drawing.Point(295, 33);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '*';
            this.txtPassLogin.Size = new System.Drawing.Size(250, 29);
            this.txtPassLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(295, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t Have an Account Yet? Register Now for Quiz-Face Showcase!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserRegister
            // 
            this.txtUserRegister.Enabled = false;
            this.txtUserRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserRegister.Location = new System.Drawing.Point(163, 342);
            this.txtUserRegister.Name = "txtUserRegister";
            this.txtUserRegister.Size = new System.Drawing.Size(382, 29);
            this.txtUserRegister.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desired Username:";
            // 
            // btnRegisterStart
            // 
            this.btnRegisterStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterStart.Location = new System.Drawing.Point(16, 302);
            this.btnRegisterStart.Name = "btnRegisterStart";
            this.btnRegisterStart.Size = new System.Drawing.Size(529, 29);
            this.btnRegisterStart.TabIndex = 8;
            this.btnRegisterStart.Text = "Register New Account";
            this.btnRegisterStart.UseVisualStyleBackColor = true;
            this.btnRegisterStart.Click += new System.EventHandler(this.btnRegisterStart_Click);
            // 
            // lblUserError
            // 
            this.lblUserError.AutoSize = true;
            this.lblUserError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserError.ForeColor = System.Drawing.Color.Red;
            this.lblUserError.Location = new System.Drawing.Point(163, 374);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(141, 21);
            this.lblUserError.TabIndex = 12;
            this.lblUserError.Text = "Desired Username:";
            // 
            // txtPass1Register
            // 
            this.txtPass1Register.Enabled = false;
            this.txtPass1Register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass1Register.Location = new System.Drawing.Point(163, 408);
            this.txtPass1Register.Name = "txtPass1Register";
            this.txtPass1Register.PasswordChar = '*';
            this.txtPass1Register.Size = new System.Drawing.Size(382, 29);
            this.txtPass1Register.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password:";
            // 
            // txtPass2Register
            // 
            this.txtPass2Register.Enabled = false;
            this.txtPass2Register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass2Register.Location = new System.Drawing.Point(163, 443);
            this.txtPass2Register.Name = "txtPass2Register";
            this.txtPass2Register.PasswordChar = '*';
            this.txtPass2Register.Size = new System.Drawing.Size(382, 29);
            this.txtPass2Register.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Confirm Password:";
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassError.ForeColor = System.Drawing.Color.Red;
            this.lblPassError.Location = new System.Drawing.Point(163, 475);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(141, 21);
            this.lblPassError.TabIndex = 15;
            this.lblPassError.Text = "Desired Username:";
            // 
            // btnRegisterComplete
            // 
            this.btnRegisterComplete.Enabled = false;
            this.btnRegisterComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterComplete.Location = new System.Drawing.Point(16, 510);
            this.btnRegisterComplete.Name = "btnRegisterComplete";
            this.btnRegisterComplete.Size = new System.Drawing.Size(529, 29);
            this.btnRegisterComplete.TabIndex = 16;
            this.btnRegisterComplete.Text = "Register";
            this.btnRegisterComplete.UseVisualStyleBackColor = true;
            this.btnRegisterComplete.Click += new System.EventHandler(this.btnRegisterComplete_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(529, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Join a Quiz Anonymously!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(295, 176);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(250, 29);
            this.txtCode.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(291, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quiz Room Code:";
            // 
            // txtAnon
            // 
            this.txtAnon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnon.Location = new System.Drawing.Point(16, 176);
            this.txtAnon.Name = "txtAnon";
            this.txtAnon.Size = new System.Drawing.Size(250, 29);
            this.txtAnon.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Temporary Username:";
            // 
            // btnJoinAnon
            // 
            this.btnJoinAnon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJoinAnon.Location = new System.Drawing.Point(295, 222);
            this.btnJoinAnon.Name = "btnJoinAnon";
            this.btnJoinAnon.Size = new System.Drawing.Size(250, 29);
            this.btnJoinAnon.TabIndex = 22;
            this.btnJoinAnon.Text = "Join Quiz";
            this.btnJoinAnon.UseVisualStyleBackColor = true;
            this.btnJoinAnon.Click += new System.EventHandler(this.btnJoinAnon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(563, 557);
            this.Controls.Add(this.btnJoinAnon);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegisterComplete);
            this.Controls.Add(this.lblPassError);
            this.Controls.Add(this.txtPass2Register);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserError);
            this.Controls.Add(this.txtPass1Register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegisterStart);
            this.Controls.Add(this.txtUserRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome to Quiz-Face Showcase!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterStart;
        private System.Windows.Forms.Label lblUserError;
        private System.Windows.Forms.TextBox txtPass1Register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass2Register;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Button btnRegisterComplete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnJoinAnon;
    }
}
