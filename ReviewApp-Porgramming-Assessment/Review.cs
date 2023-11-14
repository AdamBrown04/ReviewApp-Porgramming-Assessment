class Review 
{
    private string usernameOfReviewer;
    private string companyName;
    private float starRating;
    private string writtenReview;

    public void GetUsername(string username)
    {
        usernameOfReviewer = username;
    }

    public void GetComapnyName(string nameOfCompany)
    {
        companyName = nameOfCompany;
    }

    public void GetStarRating(float newStarRating)
    {
        starRating = newStarRating;
    }

    public void GetWrittenReview(string newWrittenReview)
    {
        writtenReview = newWrittenReview;
    }
}
