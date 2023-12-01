using ReviewApp_Porgramming_Assessment.Properties;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class ReviewForm : Form //form2
    {
        User currentUser;
        int userStarReview = 0;
        int textLength;
        string path = "reviews.txt";

        public ReviewForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

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
        private void txbWrittenReview_TextChanged(object sender, EventArgs e)
        {
            textLength = txbWrittenReview.Text.Length;
            lblCharacterCount.Text = $"{textLength}/256";
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

        private void LsbViewReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            Review viewReview = LsbViewReview.SelectedItem as Review;

            txbShowUsername.Text = viewReview.ViewUsername();
            txbShowCompanyName.Text = viewReview.ViewCompanyName();
            txbShowWrittenReview.Text = viewReview.ViewWrittenReview();

            switch (viewReview.ViewStarRating())
            {
                case 1:
                    pcbShowStars1.Image = Resources.yellowStar;
                    break;
                case 2:
                    pcbShowStars1.Image = Resources.yellowStar;
                    pcbShowStars2.Image = Resources.yellowStar;
                    break;
                case 3:
                    pcbShowStars1.Image = Resources.yellowStar;
                    pcbShowStars2.Image = Resources.yellowStar;
                    pcbShowStars3.Image = Resources.yellowStar;
                    break;
                case 4:
                    pcbShowStars1.Image = Resources.yellowStar;
                    pcbShowStars2.Image = Resources.yellowStar;
                    pcbShowStars3.Image = Resources.yellowStar;
                    pcbShowStars4.Image = Resources.yellowStar;
                    break;
                case 5:
                    pcbShowStars1.Image = Resources.yellowStar;
                    pcbShowStars2.Image = Resources.yellowStar;
                    pcbShowStars3.Image = Resources.yellowStar;
                    pcbShowStars4.Image = Resources.yellowStar;
                    pcbShowStars5.Image = Resources.yellowStar;
                    break;
            }

            if (currentUser.ViewUsername() == viewReview.ViewUsername())
            {
                btnUpdateReview.Visible = true;
            }
        }

        private void btnUpdateReview_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


//Source for the changing stars - https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden