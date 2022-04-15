using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClasses;

namespace LiveQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPassError.Text = "";
            lblUserError.Text = "";
            lblLoginError.Text = "";
            lblAnonError.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check that both fields are filled
            if (txtUserLogin.Text == "" || txtPassLogin.Text == "")
                lblLoginError.Text = "Please Enter Username and Password";

            // Attempt to log the user in
            else
            {
                // Hash the password
                string hashedPass = hashPassword(txtPassLogin.Text);
                // Attempt the login
                bool success = QuiznessLayer.Login(txtUserLogin.Text, hashedPass);
                // Alert the user if it fails
                if (!success)
                    lblLoginError.Text = "Incorrect Username or Password";
                // Open the home form if it succeeds
                else 
                {
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
            }
        }
        private void btnJoinAnon_Click(object sender, EventArgs e)
        {
            // Check if username is available
            bool available = QuiznessLayer.CheckAvailableUserName(txtAnon.Text);

            if (!available)
                lblAnonError.Text = "Username Taken";            
            else
            {
                // Check if room code is legitimate
                Quiz tmp = QuiznessLayer.GetQuizbyCode(txtCode.Text);

                if (tmp != null)
                {
                    Anon au = new Anon()
                    {
                        Username = txtAnon.Text,
                        Password = null,
                        RegistrationDate = DateTime.Now,
                    };
                    bool success = QuiznessLayer.CreateAnon(au);

                    if (success)
                    {
                        QuizContestantForm qcf = new QuizContestantForm(tmp, au);
                        this.Hide();
                        qcf.ShowDialog();
                        this.Show();
                    }
                    
                }
                else
                {
                    lblAnonError.Text = "Code Not Valid";
                }
            }
        }

        private void btnRegisterStart_Click(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = false;
            txtPassLogin.Enabled = false;

            txtUserRegister.Enabled = true;
            txtPass1Register.Enabled = true;
            txtPass2Register.Enabled = true;
            btnRegisterComplete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnRegisterComplete_Click(object sender, EventArgs e)
        {
            // Clear any previous errors
            lblUserError.Text = "";
            lblPassError.Text = "";

            // Check if username is free of special characters
            if (hasSpecialCharacters(txtUserRegister.Text))
                lblUserError.Text = "No Special Characters";
            // Check if username is available
            else if (!QuiznessLayer.CheckAvailableUserName(txtUserRegister.Text))
            {
                lblUserError.Text = "That Username is Already Taken";
            }
            // Check if passwords match
            else if (txtPass1Register.Text != txtPass2Register.Text)
                lblPassError.Text = "Passwords do not Match";
            // If all above, create account
            else
            {
                // Create a user
                string hashedPass = hashPassword(txtPass2Register.Text);

                User u = new User()
                {
                    Username = txtUserRegister.Text,
                    Password = hashedPass,
                    RegistrationDate = DateTime.Now,
                };

                // Send user to business layer for registration in DB
                bool success = QuiznessLayer.Register(u);

                // Alert user that registration was successful
                if (success)
                    MessageBox.Show("Registration Successful!");
                else
                    MessageBox.Show("Registration Failed. Please try again later.");

                // Reactivate other controls
                txtUserLogin.Enabled = true;
                txtPassLogin.Enabled = true;

                txtUserRegister.Enabled = false;
                txtPass1Register.Enabled = false;
                txtPass2Register.Enabled = false;
                btnRegisterComplete.Enabled = false;
            }            
        }

        public bool hasSpecialCharacters(string input)
        {
            string characters = @"|!#$%&/()=?»«@£§€{}.;~`'<>";

            foreach (char item in characters)
            {
                if (input.Contains(item))
                    return true;
            }

            return false;
        }

        public string hashPassword(string input)
        {
            SHA256CryptoServiceProvider SHA = new SHA256CryptoServiceProvider();
            byte[] bytes = ASCIIEncoding.Default.GetBytes(input + "Qu1-/_");
            byte[] encoded = SHA.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                sb.Append(encoded[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = true;
            txtPassLogin.Enabled = true;

            txtUserRegister.Text = "";
            txtPass1Register.Text = "";
            txtPass2Register.Text = "";
            txtUserRegister.Enabled = false;
            txtPass1Register.Enabled = false;
            txtPass2Register.Enabled = false;
            btnRegisterComplete.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
