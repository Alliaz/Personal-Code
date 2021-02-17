using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSU2___Lab_1___Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "1" && txtPassword.Text == "1")
            {
                ActiveForm.Hide();
                new SystemApp().Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials entered, please try again");
            }
        }
    }
}
