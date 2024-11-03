

public class c_currentUser
{
    public string Id {get; set;}

    public string Email {get; set;}
    public string UserName {get; set;}

    public string fullName {get; set;}

    public string phoneNumber {get; set;}

    public bool IsLoggedIn {get; set;} = false;

public void SetUser(string id,string email, string fullname, string phonenumber, string username)    
    {
        Id = id;
        Email = email;
        fullName = fullname;
        UserName = username;
        phoneNumber = phonenumber;
        IsLoggedIn = true;
    }

    
}

