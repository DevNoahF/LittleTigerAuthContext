namespace AuthContext.Context.Auth.Entities
{
    public class RefreshToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public bool Revoked { get; set; }

        //Revoked - inativo
        public RefreshToken(string token, DateTime expiration)
        {
            this.Token = token;
            this.Expiration = expiration;
            this.Revoked = false;
        }

        public bool IsExpired()
        {
            return DateTime.Now >= this.Expiration;
        }

        public void Revoke()
        {
            this.Revoked = true;
        }
    }
}
