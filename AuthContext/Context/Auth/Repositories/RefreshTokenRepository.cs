using AuthContext.Context.Auth.Entities;
using AuthContext.Context.Auth.Persistence;

namespace AuthContext.Context.Auth.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly DbContext _context;  

        public RefreshTokenRepository(DbContext context)
        {
            _context = context;
        }

        public void SaveRefreshToken(string email, RefreshToken refreshToken)
        {
            User user = _context.Users.FindByEmail(email); //implementar
            
            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.AddRefreshToken(refreshToken);
            _context.SaveChanges();
        }
    }
}
