using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClasses;

namespace LiveQuiz
{
    public partial class ContestantControl : UserControl
    {
        public User theuser;

        public ContestantControl(User u)
        {
            InitializeComponent();
            this.theuser = u;
            lblUsername.Text = u.Username;
        }
    }
}
