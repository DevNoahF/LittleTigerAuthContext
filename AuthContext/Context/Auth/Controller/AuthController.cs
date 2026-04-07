using AuthContext.Context.Auth.DTOs;
using AuthContext.Context.Auth.UseCases;
using AuthContext.Context.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace AuthContext.Context.Auth.Controller;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly LoginUseCase _loginUseCase;

    public AuthController(LoginUseCase loginUseCase
        )
    {
        _loginUseCase = loginUseCase;

    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UserResquestDTO request)
    {
        if(request.email == null)
            return BadRequest("Email is required.");
        if(request.password == null)
            return BadRequest("Password is required.");
        var result = _loginUseCase.Execute(request);
        return Ok();




    }
}


