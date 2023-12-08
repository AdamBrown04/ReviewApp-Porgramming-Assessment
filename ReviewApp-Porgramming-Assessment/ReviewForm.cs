using ReviewApp_Porgramming_Assessment.Properties;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class ReviewForm : Form //form2
    {
        //The classes are used to be able to store an instance of a class to allow multiple instances to exist at once
        Review currentReview;
        User currentUser;
        //these vairables are global for use throughout multiple functions
        int currentIndex = -1;
        int userStarReview = 0;
        int textLength;
        //This vairable stores the file path for the data on reviews made previously
        string path = "reviews.txt";

        public ReviewForm(User user)
        {
            InitializeComponent();
            /*this line transfers the data of the current user from the login form to the review form, this is 
            to check the username against the username of reviews and to store the current users username when making
            a review*/
            currentUser = user;
            txbReviewerUsername.Text = currentUser.ViewUsername();
        }

        //this function checks if the data input is valid then if it is, the data will be written to the file
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string writtenReview = txbWrittenReview.Text;
            if (userStarReview > 0 && writtenReview.Length < 257)
            {
                Review newReview = new Review();

                newReview.GetUsername(currentUser.ViewUsername());
                newReview.GetComapnyName(txbCompanyName.Text);
                newReview.GetStarRating(userStarReview);
                newReview.GetWrittenReview(txbWrittenReview.Text);

                currentReview = newReview;

                string text = $"{newReview.ViewUsername()};{newReview.ViewCompanyName()};{newReview.ViewStarRating()};{newReview.ViewWrittenReview()};";

                LsbViewReview.Items.Add(newReview);
                File.AppendAllText(path, text);

                userStarReview = 0;
                ClearTextBoxes();
                ClearStarBoxes();
            }
            else if (userStarReview == 0)
            {
                MessageBox.Show("Please enter a star rating");
            }
            else if (writtenReview.Length > 256)
            {
                ClearTextBoxes();
                txbWrittenReview.Text = "Maximum review length is 256 characters";
                Task.Delay(1500).Wait();
                txbWrittenReview.Clear();
            }

        }
        //this function updates when text is inputted into the txbWrittenReview text box then updates the label lblCharcterCount
        private void txbWrittenReview_TextChanged(object sender, EventArgs e)
        {
            textLength = txbWrittenReview.Text.Length;
            lblCharacterCount.Text = $"{textLength}/256";
        }
        //this function removes all text from text boxes that the user can input data into
        private void ClearTextBoxes()
        {
            txbCompanyName.Clear();
            txbWrittenReview.Clear();
        }

        //this function resets all the picture boxes back to the starting image
        private void ClearStarBoxes()
        {
            pcbStarOne.Image = Resources.whiteStar;
            pcbStarTwo.Image = Resources.whiteStar;
            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        //these five functions set the vairable userStarReview to a different value then runs the function ShowStarRating
        private void pcbStarFive_Click(object sender, EventArgs e)
        {
            userStarReview = 5;
            ShowStarRating();
        }

        private void pcbStarFour_Click(object sender, EventArgs e)
        {
            userStarReview = 4;
            ShowStarRating();
        }

        private void pcbStarThree_Click(object sender, EventArgs e)
        {
            userStarReview = 3;
            ShowStarRating();
        }

        private void pcbStarTwo_Click(object sender, EventArgs e)
        {
            userStarReview = 2;
            ShowStarRating();
        }

        private void pcbStarOne_Click(object sender, EventArgs e)
        {
            userStarReview = 1;
            ShowStarRating();
        }

        //the functions bellow will change the state of the picture boxes when hovering over
        private void pcbStarFive_MouseHover(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;
            pcbStarFive.Image = Resources.yellowStar;
        }

        private void pcbStarFour_MouseHover(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;

            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarThree_MouseHover(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;

            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarTwo_MouseHover(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;

            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarOne_MouseHover(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;

            pcbStarTwo.Image = Resources.whiteStar;
            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }
        //these fucntions will show the picture boxes based on what the current value of userStarReview using the function ShowStarRating
        private void pcbStarFive_MouseLeave(object sender, EventArgs e)
        {
            ShowStarRating();
        }

        private void pcbStarFour_MouseLeave(object sender, EventArgs e)
        {
            ShowStarRating();
        }

        private void pcbStarThree_MouseLeave(object sender, EventArgs e)
        {
            ShowStarRating();
        }

        private void pcbStarTwo_MouseLeave(object sender, EventArgs e)
        {
            ShowStarRating();
        }

        private void pcbStarOne_MouseLeave(object sender, EventArgs e)
        {
            ShowStarRating();
        }

        //this function will take the global vairable userStarRating and use a switch case to display the correct image in the picture boxes
        private void ShowStarRating()
        {
            switch (userStarReview)
            {
                case 1:
                    pcbStarOne.Image = Resources.yellowStar;

                    pcbStarTwo.Image = Resources.whiteStar;
                    pcbStarThree.Image = Resources.whiteStar;
                    pcbStarFour.Image = Resources.whiteStar;
                    pcbStarFive.Image = Resources.whiteStar;
                    break;
                case 2:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;

                    pcbStarThree.Image = Resources.whiteStar;
                    pcbStarFour.Image = Resources.whiteStar;
                    pcbStarFive.Image = Resources.whiteStar;
                    break;
                case 3:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;

                    pcbStarFour.Image = Resources.whiteStar;
                    pcbStarFive.Image = Resources.whiteStar;
                    break;
                case 4:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;
                    pcbStarFour.Image = Resources.yellowStar;

                    pcbStarFive.Image = Resources.whiteStar;
                    break;
                case 5:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;
                    pcbStarFour.Image = Resources.yellowStar;
                    pcbStarFive.Image = Resources.yellowStar;
                    break;
                default:
                    pcbStarOne.Image = Resources.whiteStar;
                    pcbStarTwo.Image = Resources.whiteStar;
                    pcbStarThree.Image = Resources.whiteStar;
                    pcbStarFour.Image = Resources.whiteStar;
                    pcbStarFive.Image = Resources.whiteStar;
                    break;
            }

        }
        //this function displays preivously created reviews to the user when selected from the listbox called lsbViewReview
        private void LsbViewReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = LsbViewReview.SelectedIndex;
            if (currentIndex != -1)
            {
                Review viewReview = LsbViewReview.SelectedItem as Review;

                txbReviewerUsername.Text = viewReview.ViewUsername();
                txbCompanyName.Text = viewReview.ViewCompanyName();
                txbWrittenReview.Text = viewReview.ViewWrittenReview();
                userStarReview = viewReview.ViewStarRating();

                ShowStarRating();

                currentReview = viewReview;
                //this if statement checks if the current user and the user who set the review are the same, if so it will allow them to make changes to their old reviews
                if (currentUser.ViewUsername() == viewReview.ViewUsername())
                {
                    btnUpdateReview.Visible = true;
                }
            }
        }
        //this function will allow the user to update a preivous review they have set, only changing the data stored if the input data has changed
        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            if (currentReview.ViewCompanyName() != txbCompanyName.Text)
            {
                currentReview.GetComapnyName(txbCompanyName.Text);
            }

            if (currentReview.ViewStarRating() != userStarReview)
            {
                currentReview.GetStarRating(userStarReview);
            }

            if (currentReview.ViewWrittenReview() != txbWrittenReview.Text)
            {
                currentReview.GetWrittenReview(txbWrittenReview.Text);
            }

            ClearStarBoxes();
            ClearTextBoxes();
            LsbViewReview.Items.RemoveAt(currentIndex);
            LsbViewReview.Items.Add(currentReview);

            currentIndex = -1;
        }

        //this function will run when the form is loaded, it will store the data from the file as a class and then store it in the listbox
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string unsplitReview = File.ReadAllText(path);

                string[] splitTheString = unsplitReview.Split(';', StringSplitOptions.RemoveEmptyEntries);

                List<string> splitReview = new List<string>();

                foreach (string item in splitTheString)
                {
                    splitReview.Add(item);
                }

                for (int x = 0; x < splitReview.Count; x += 4)
                {
                    Review loadReview = new Review();

                    loadReview.GetUsername(splitReview[x]);
                    loadReview.GetComapnyName(splitReview[x + 1]);
                    loadReview.GetStarRating(Convert.ToInt32(splitReview[x + 2]));
                    loadReview.GetWrittenReview(splitReview[x + 3]);

                    LsbViewReview.Items.Add(loadReview);
                }
            }
        }

        //this function will close the program when the review form is closed
        private void ReviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}


//Source for the changing stars - https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden
//source for closing the application when the form closes https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/#:~:text=When%20we%20need%20to%20exit,on%20some%20button%20click%20event.&text=When%20we%20are%20running%20a,then%20we%20should%20use%20%22System.