using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//need to add proof of testing and add comments when needed
namespace ReviewApp_Porgramming_Assessment
{
    public partial class LoginForm : Form //form1
    {
        //vairables for user login data
        string path = "users.txt";
        List<string> allLogins = new List<string>();
        //vairables used for checking the data from file
        bool isUsernameCorrect = false;
        int userID = -1;
        public LoginForm()
        {
            InitializeComponent();
            RunTests(); //runs a set of tests to ensure that the class runs correctly before the user tries it
        }

        //function used to see if login details entered a valid on the system
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (File.Exists(path))
            {
                newUser.GetUsername(txbUsername.Text);
                newUser.GetPassword(txbPassword.Text);

                FindUsername(newUser.ViewUsername());

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
        //function used to allow users to create a new account with a unique username
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            isUsernameCorrect = false;
            string username = txbUsername.Text.Trim();
            string password = txbPassword.Text.Trim();

            FindUsername(username);

            if (username != "" && password != "" && isUsernameCorrect == false)
            {
                string text = $"{username};{password};";

                File.AppendAllText(path, text);

                ClearAllTextBoxes();

                MessageBox.Show("New user has been created");
            }
            else 
            {
                ClearAllTextBoxes();

                MessageBox.Show("                       INVALID INPUT! " +
                    "\n        Username and password are required");
            }
        }

        //function to remove data from text boxes
        private void ClearAllTextBoxes()
        {
            txbUsername.Clear();
            txbPassword.Clear();
        }

        //function that is used to find the inputed username in the current data set, sets a boolean global vairbale depending on result
        private void FindUsername(string inputUsername)
        {
            string unsplitUserDetails = File.ReadAllText(path);

            string[] splitTheString = unsplitUserDetails.Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (string loginDetail in splitTheString)
            {
                allLogins.Add(loginDetail);
            }

            for (int x = 0; x < allLogins.Count; x += 2)
            {
                if (inputUsername == allLogins[x])
                {
                    userID = x;
                    isUsernameCorrect = true;
                    break;
                }
            }
        }

        private void RunTests() //a set of tests to see if all data is saved correctly to the User class
        {
            User testUser = new User();
            testUser.GetUsername("user1");
            Debug.Assert(testUser.ViewUsername() == "user1");
            testUser.GetPassword("Password");
            Debug.Assert(testUser.ViewPassword() == "Password");
        }
    }
}

//source for swapping between forms https://www.homeandlearn.co.uk/csharp/csharp_s13p1.html#:~:text=To%20display%20the%20second%20form,to%20create%20the%20object%20yourself.
//source for the split function https://eur02.safelinks.protection.outlook.com/?url=https%3A%2F%2Flearn.microsoft.com%2Fen-us%2Fdotnet%2Fapi%2Fsystem.string.split%3Fview%3Dnet-7.0&data=05%7C01%7CAdam.Brown9%40student.shu.ac.uk%7C3d23371240e648625d5c08dbe521193c%7C8968f6a1ac13472fb899f7316e439f43%7C0%7C0%7C638355702530830959%7CUnknown%7CTWFpbGZsb3d8eyJWIjoiMC4wLjAwMDAiLCJQIjoiV2luMzIiLCJBTiI6Ik1haWwiLCJXVCI6Mn0%3D%7C3000%7C%7C%7C&sdata=3Xal2M6SSKfrI0wPQP6lMeTGaKrxy2ifOXLGVWErq94%3D&reserved=0