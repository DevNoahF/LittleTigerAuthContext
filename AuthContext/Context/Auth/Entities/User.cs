using AuthContext.Context.Auth.ValueObject;

namespace AuthContext.Context.Auth.Entities;

public class User
{
    public Email Email { get; private set; }

    public Password Password { get; private set; }

    public User(Email email, Password password)
    {
        Email = email;
        Password = password;
    }
    
    
}