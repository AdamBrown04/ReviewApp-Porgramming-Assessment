namespace ReviewApp_Porgramming_Assessment
{
    class Review
    {
        private string usernameOfReviewer;
        private string companyName;
        private int starRating;
        private string writtenReview;

        public void GetUsername(string username)
        {
            usernameOfReviewer = username;
        }

        public void GetComapnyName(string nameOfCompany)
        {
            companyName = nameOfCompany;
        }

        public void GetStarRating(int ratingFromUser)
        {
            starRating = ratingFromUser;
        }

        public void GetWrittenReview(string newWrittenReview)
        {
            writtenReview = newWrittenReview;
        }

        public string ViewUsername()
        {
            return usernameOfReviewer;
        }

        public string ViewCompanyName()
        {
            return companyName;
        }

        public int ViewStarRating()
        {
            return starRating;
        }

        public string ViewWrittenReview()
        {
            return writtenReview;
        }
    }
}



