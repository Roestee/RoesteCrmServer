using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHandler(
    UserManager<AppUser> userManager,
    IMapper mapper) : IRequestHandler<CreateUserCommand, Result<CreateUserCommandResponse>>
{
    public async Task<Result<CreateUserCommandResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var isEmailExists = userManager.Users.Any(u => u.Email == request.Email);
        if(isEmailExists)
            return Result<CreateUserCommandResponse>.Failure("Bu email daha önce kullanılmış!");
        
        var user = mapper.Map<AppUser>(request);
        user.EmailConfirmed = true;
        var result = await userManager.CreateAsync(user, request.Password);
        await userManager.AddToRoleAsync(user, request.Role);
        var userResponse = mapper.Map<CreateUserCommandResponse>(user);
        userResponse.Role = request.Role;
        return result.Succeeded ? 
            Result<CreateUserCommandResponse>.Succeed(userResponse, "Kullanıcı kaydı başarıyla yapıldı.") : 
            Result<CreateUserCommandResponse>.Failure("Kullanıcı eklenirken sorun oluştu.");
    }
}