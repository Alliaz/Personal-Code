﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSU___Lab_2___Application
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, EventArgs e)
        {
            if (txtUsername.Text != "1" || txtPassword.Text != "1")
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord");
            }
            else
            {
                ActiveForm.Hide();
                new FormMenu().Show();
                
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
