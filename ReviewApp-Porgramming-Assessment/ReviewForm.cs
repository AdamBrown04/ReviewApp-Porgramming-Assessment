using ReviewApp_Porgramming_Assessment.Properties;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class ReviewForm : Form //form2
    {
        User currentUser;
        Review currentReview;
        Review viewReview = new Review();
        int userStarReview = 0;
        int textLength;
       
        public ReviewForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string writtenReview = txbWrittenReview.Text; 
            if(userStarReview > 0 && writtenReview.Length < 257)
            {
                Review newReview = new Review();

                newReview.GetUsername(currentUser.ViewUsername());
                newReview.GetComapnyName(txbCompanyName.Text);
                newReview.GetStarRating(userStarReview);
                newReview.GetWrittenReview(txbWrittenReview.Text);
                
                currentReview = newReview;

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

        private void ClearTextBoxes()
        {
            txbCompanyName.Clear();
            txbWrittenReview.Clear();
        }

        private void ClearStarBoxes()
        {
            pcbStarOne.Image = Resources.whiteStar;
            pcbStarTwo.Image = Resources.whiteStar;
            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarFive_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;
            pcbStarFive.Image = Resources.yellowStar;

            userStarReview = 5;
        }

        private void pcbStarFour_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;

            pcbStarFive.Image = Resources.whiteStar;

            userStarReview = 4;
        }

        private void pcbStarThree_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;

            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;

            userStarReview = 3;
        }

        private void pcbStarTwo_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;

            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;

            userStarReview = 2;
        }

        private void pcbStarOne_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;

            pcbStarTwo.Image = Resources.whiteStar;
            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;

            userStarReview = 1;
        }

        private void btnViewReview_Click(object sender, EventArgs e)
        {
            txbCompanyName.Text = currentReview.ViewCompanyName();
            txbWrittenReview.Text = currentReview.ViewWrittenReview();
            lblUsernameText.Text = currentReview.ViewUsername();
            switch (currentReview.ViewStarRating())  
            {
                case 1:
                    pcbStarOne.Image = Resources.yellowStar;
                    break;
                case 2:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    break;
                case 3:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;
                    break;
                case 4:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;
                    pcbStarFour.Image = Resources.yellowStar;
                    break;
                case 5:
                    pcbStarOne.Image = Resources.yellowStar;
                    pcbStarTwo.Image = Resources.yellowStar;
                    pcbStarThree.Image = Resources.yellowStar;
                    pcbStarFour.Image = Resources.yellowStar;
                    pcbStarFive.Image = Resources.yellowStar;
                    break;
            }

        }

        private void txbWrittenReview_TextChanged(object sender, EventArgs e)
        {
            textLength = txbWrittenReview.Text.Length;
            lblCharacterCount.Text = $"{textLength}/256";
        }
    }
}


//Source for the changing stars - https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden