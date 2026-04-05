using AuthContext.Context.Auth.Entities;

namespace AuthContext.Context.Auth.Interfaces
{
    public interface IRefreshTokenRepository
    {
        public void SaveRefreshToken(string email, RefreshToken refreshToken); 
    }
}
