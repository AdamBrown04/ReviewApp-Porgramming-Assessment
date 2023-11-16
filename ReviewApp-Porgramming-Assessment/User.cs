class User
{
    private string username;
    private string password;

    public void GetUsername(string newUsername)
    {
        username = newUsername.Trim();
    }

    public void GetPassword(string newPassword)
    {
        password = newPassword.Trim();
    }

    public string ViewUsername()
    {
        return username;
    }
}