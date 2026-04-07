using AuthContext.Context.Auth.ValueObject;

namespace AuthContext.Context.Auth.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public String Token { get; set; }
    public String Role { get; set; }

    public User(Email email, Password password)
    {
        Email = email;
        Password = password;
        Role = "User";
        Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InRlc3RlQHRlc3RlLmNvbSIsInBhc3N3b3JkIjoic2VuaGF0ZXN0ZTFAIiwicm9sZSI6IlVzZXIifQ.Ne1YaEBnPMPDotgMzyVW6YO7IYd9O4OP1g0bdaTZ2Xo";
        Id = new Guid();
    }
}