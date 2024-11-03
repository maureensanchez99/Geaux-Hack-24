public class c_currentUser
{
    public string Id {get; set;}

    public string Email { get; set; }

    public string fullName {get; set;}

    public string phoneNumber {get; set;}

    public bool IsLoggedIn { get; set; } = false;

    public void SetUser(string id,string email, string fullname, string phonenumber)
    {
        Id = id;
        Email = email;
        fullName = fullname;
        phoneNumber = phonenumber;
        IsLoggedIn = true;
    }

    public void ClearUser()
    {
        Id = string.Empty;
        Email = string.Empty;
        phoneNumber = string.Empty;
        fullName = string.Empty;
        IsLoggedIn = false;
    }
}