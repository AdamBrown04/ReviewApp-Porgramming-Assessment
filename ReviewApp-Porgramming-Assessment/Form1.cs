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
            newReview.GetStarRating(Convert.ToSingle(txbStarReview.Text));
            newReview.GetWrittenReview(txbWrittenReview.Text);

            ClearAllTextBoxes();
        }

        private void ClearAllTextBoxes()
        {
            txbUsername.Clear();
            txbCompanyName.Clear();
            txbStarReview.Clear();
            txbWrittenReview.Clear();
        }

        
    }
}