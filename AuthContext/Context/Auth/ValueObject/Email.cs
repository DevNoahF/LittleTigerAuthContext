namespace AuthContext.Context.Auth.ValueObject;

public class Email
{
    public String Value { get; private set; }
    
    public  Email(String value)
    {
        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(value))
            throw new Exception("Email is required");
        if (value.Contains("@") &&  value.Contains("."))
            this.Value = value;
    }
    
   
    
}