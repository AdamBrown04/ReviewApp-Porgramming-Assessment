using ReviewApp_Porgramming_Assessment.Properties;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class Form1 : Form
    {

        Review newReview = new Review();
        int userStarReview;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            newReview.GetUsername(txbUsername.Text);
            newReview.GetComapnyName(txbCompanyName.Text);
            newReview.GetStarRating(userStarReview);
            newReview.GetWrittenReview(txbWrittenReview.Text);

            ClearTextBoxes();
            ClearStarBoxes();
        }

        private void ClearTextBoxes()
        {
            txbUsername.Clear();
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
    }
}


//make a repsonsive star thing https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden