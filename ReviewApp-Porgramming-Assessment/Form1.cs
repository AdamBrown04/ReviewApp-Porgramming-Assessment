using ReviewApp_Porgramming_Assessment.Properties;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class Form1 : Form
    {

        Review newReview = new Review();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            newReview.GetUsername(txbUsername.Text);
            newReview.GetComapnyName(txbCompanyName.Text);
            newReview.GetWrittenReview(txbWrittenReview.Text);

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txbUsername.Clear();
            txbCompanyName.Clear();
            txbWrittenReview.Clear();
        }

        private void pcbStarFive_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;
            pcbStarFive.Image = Resources.yellowStar;
        }

        private void pcbStarFour_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;
            pcbStarFour.Image = Resources.yellowStar;

            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarThree_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;
            pcbStarThree.Image = Resources.yellowStar;

            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarTwo_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;
            pcbStarTwo.Image = Resources.yellowStar;

            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }

        private void pcbStarOne_Click(object sender, EventArgs e)
        {
            pcbStarOne.Image = Resources.yellowStar;

            pcbStarTwo.Image = Resources.whiteStar;
            pcbStarThree.Image = Resources.whiteStar;
            pcbStarFour.Image = Resources.whiteStar;
            pcbStarFive.Image = Resources.whiteStar;
        }
    }
}


//make a repsonsive star thing https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden