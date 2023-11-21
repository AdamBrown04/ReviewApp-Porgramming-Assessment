using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class LoginForm : Form //form1
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = "users.txt";

            User newUser = new User();

            if (File.Exists(path))
            {
                newUser.GetUsername(txbUsername.Text);
                newUser.GetPassword(txbPassword.Text);

                string unsplitUserDetails = File.ReadAllText(path);

                List<string> allLogins = new List<string>();
                bool isUsernameCorrect = false;
                string[] splitTheString = unsplitUserDetails.Split(';', StringSplitOptions.RemoveEmptyEntries);
                
                foreach(string loginDetail in splitTheString)
                {
                    allLogins.Add(loginDetail);
                }

                for(int x = 0; x < allLogins.Count; x += 2)
                {
                    if(newUser.ViewPassword() == allLogins[x])
                    {
                        isUsernameCorrect = true;
                        break;
                    }
                }

                if (isUsernameCorrect)
                {
                    //check password is correct
                }
                else
                {
                    //error message saying username is incorrect
                }
                ClearAllTextBoxes();

                ReviewForm newReview = new ReviewForm(newUser);
                newReview.Show();
                this.Hide();
            }
            
            //if(login details are correct)
            //swap to ReviewForm.cs
            //close LoginForm
            //else
            //warning about incorrect login details
           
        }

        private void ClearAllTextBoxes()
        {
            txbUsername.Clear();
            txbPassword.Clear();
        }
    }
}

//source for swapping between forms https://www.homeandlearn.co.uk/csharp/csharp_s13p1.html#:~:text=To%20display%20the%20second%20form,to%20create%20the%20object%20yourself.
