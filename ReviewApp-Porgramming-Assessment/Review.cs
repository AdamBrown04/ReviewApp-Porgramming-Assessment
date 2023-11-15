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

    public void GetStarRating (int ratingFromUser)
    {
        starRating = ratingFromUser;
    }

    public void GetWrittenReview(string newWrittenReview)
    {
        writtenReview = newWrittenReview;
    }
}
