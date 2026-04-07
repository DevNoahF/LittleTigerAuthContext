using AuthContext.Context.Auth.DTOs;
using AuthContext.Context.Auth.Entities;
using AuthContext.Context.Auth.Interfaces;
using AuthContext.Context.Mappers;

namespace AuthContext.Context.Auth.UseCases;

public class LoginUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly JwtGeneratorUseCase _jwtGeneratorUseCase;

    public LoginUseCase(IUserRepository userRepository, JwtGeneratorUseCase jwtGeneratorUseCase)
    {
        _userRepository = userRepository;
        _jwtGeneratorUseCase = jwtGeneratorUseCase;
    }

    public UserResponseDTO Execute(UserResquestDTO userRequest)
    {
        
        var userEntity = UserMapper.ToEntity(userRequest);

        var token = _jwtGeneratorUseCase.Execute(userEntity);

        return UserMapper.ToDto(userEntity);
    }
}


