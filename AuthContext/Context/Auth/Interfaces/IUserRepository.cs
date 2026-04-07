using AuthContext.Context.Auth.DTOs;

namespace AuthContext.Context.Auth.Interfaces
{

    public interface IUserRepository
    {
        public string Login(UserResquestDTO request);//Retornar token JWT
    }
}