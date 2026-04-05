using AuthContext.Context.Auth.Interfaces;

namespace AuthContext.Context.Auth.Controller;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IRefreshTokenRepository _refreshTokenRepository;

    public AuthController(IRefreshTokenRepository refreshTokenRepository)
    {
        _refreshTokenRepository = refreshTokenRepository;
    }
}