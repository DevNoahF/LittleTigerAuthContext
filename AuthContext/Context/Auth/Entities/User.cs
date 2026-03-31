using AuthContext.Context.Auth.ValueObject;

namespace AuthContext.Context.Auth.Entities;

public class User
{
    public Email Email { get; private set; }

    public Password Password { get; private set; }

    public String Jwt { get; set; }

    public User(Email email, Password password, String jwt)
    {
        Email = email;
        Password = password;
        Jwt = jwt;
    }
    
    
}