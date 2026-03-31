using AuthContext.Context.Auth.Entities;

namespace AuthContext.Context.Auth.Interfaces
{

    public interface IUserRepository
    {
        public string Login();//Retornar token JWT
        public void Logout(); //vai retornar que foi feito logout?
        public void RefreshToken();//Tem que implementar Refresh Token!
    }
}