﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class LoginForm : Form //form1
    {
        string path = "users.txt";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (File.Exists(path))
            {
                newUser.GetUsername(txbUsername.Text);
                newUser.GetPassword(txbPassword.Text);

                string unsplitUserDetails = File.ReadAllText(path);

                List<string> allLogins = new List<string>();

                bool isUsernameCorrect = false;
                int userID = -1;

                string[] splitTheString = unsplitUserDetails.Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (string loginDetail in splitTheString)
                {
                    allLogins.Add(loginDetail);
                }

                for (int x = 0; x < allLogins.Count; x += 2)
                {
                    if (newUser.ViewUsername() == allLogins[x])
                    {
                        userID = x;
                        isUsernameCorrect = true;
                        break;
                    }
                }

                if (isUsernameCorrect && newUser.ViewPassword() == allLogins[userID + 1] && userID != -1)
                {
                    ReviewForm newReview = new ReviewForm(newUser);
                    newReview.Show();
                    this.Hide();
                }
                else
                {
                    ClearAllTextBoxes();
                    txbUsername.Text = "INVALID LOGIN";
                    Task.Delay(1000).Wait();
                    ClearAllTextBoxes();
                }
            }
        }

        private void ClearAllTextBoxes()
        {
            txbUsername.Clear();
            txbPassword.Clear();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text != null && txbPassword.Text != null)
            {
                string username = txbUsername.Text;
                string password = txbPassword.Text;

                string text = $"{username};{password};";

                File.AppendAllText(path, text) ;
            }
            
        }
    }
}

//source for swapping between forms https://www.homeandlearn.co.uk/csharp/csharp_s13p1.html#:~:text=To%20display%20the%20second%20form,to%20create%20the%20object%20yourself.
