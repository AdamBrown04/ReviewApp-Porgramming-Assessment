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
            //newReview.GetStarRating(Convert.ToSingle(txbStarReview.Text));
            newReview.GetWrittenReview(txbWrittenReview.Text);

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txbUsername.Clear();
            txbCompanyName.Clear();
            txbStarReview.Clear();
            txbWrittenReview.Clear();
        }
    }
}


//make a repsonsive star thing https://www.youtube.com/watch?v=V0gccjef5_E&ab_channel=AaricAaiden