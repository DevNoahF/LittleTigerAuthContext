using AuthContext.Context.Auth.DTOs;
using AuthContext.Context.Auth.UseCases;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AuthContext.Context.Auth.Controller;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly LoginUseCase _loginUseCase;

    public AuthController(LoginUseCase loginUseCase)
    {
        _loginUseCase = loginUseCase;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var userRequest = new UserResquestDTO(request.Email, request.Password);
        var result = _loginUseCase.Execute(userRequest);
        return Ok(result);
    }
}


