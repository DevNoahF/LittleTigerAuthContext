using AuthContext.Context.Auth.DTOs;
using AuthContext.Context.Auth.Interfaces;
using AuthContext.Context.Auth.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AuthContext.Context.Auth.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AuthDbContext _context;

    public UserRepository(AuthDbContext context)
    {
        _context = context;
    }

    public string Login(UserResquestDTO request)
    {
        
        if (string.IsNullOrWhiteSpace(request.email))
            throw new Exception("Email is required");

        if (string.IsNullOrWhiteSpace(request.password))
            throw new Exception("Password is required");

        var user = _context.Users
            .AsNoTracking()
            .FirstOrDefault(u => u.Email.Value == request.email);

        
        if (user == null)
            throw new Exception("Email not found in database");

        
        if (user.Password.Value != request.password)
            throw new Exception("Invalid password");

       
        return user.Token;
    }

   
}