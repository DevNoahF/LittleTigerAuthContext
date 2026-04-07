namespace AuthContext.Context.Auth.ValueObject;

public class Password
{
    public string Value { get; private set; }

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(value))
            throw new Exception("Password is required");

        if (value.Length > 16)
            throw new Exception("Password is too long");

        if (value.Length < 8)
            throw new Exception("Password is too short");
        
        this.Value = value;
        
    }
}