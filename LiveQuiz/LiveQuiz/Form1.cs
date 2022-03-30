using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPassError.Text = "";
            lblUserError.Text = "";
        }

        private void btnRegisterStart_Click(object sender, EventArgs e)
        {
            txtUserLogin.Enabled = false;
            txtPassLogin.Enabled = false;

            txtUserRegister.Enabled = true;
            txtPass1Register.Enabled = true;
            txtPass2Register.Enabled = true;
            btnRegisterComplete.Enabled = true;
        }

        private void btnRegisterComplete_Click(object sender, EventArgs e)
        {
            // Check if username is available

            // Check if passwords match

            // If all above, create account

            // Reactivate other controls
            txtUserLogin.Enabled = true;
            txtPassLogin.Enabled = true;

            txtUserRegister.Enabled = false;
            txtPass1Register.Enabled = false;
            txtPass2Register.Enabled = false;
            btnRegisterComplete.Enabled = false;
        }
    }
}
