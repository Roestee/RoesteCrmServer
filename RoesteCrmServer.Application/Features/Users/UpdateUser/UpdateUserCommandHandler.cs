using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.UpdateUser;

internal sealed class UpdateUserCommandHandler(
    UserManager<AppUser> userManager,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateUserCommand, Result<UpdateUserCommandResponse>>
{
    public async Task<Result<UpdateUserCommandResponse>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.Id.ToString());
        if(user == null)
            return Result<UpdateUserCommandResponse>.Failure("Kullanıcı bulunamadı!");
            
        mapper.Map(request, user);
        var oldRole = (await userManager.GetRolesAsync(user)).FirstOrDefault();
        if (oldRole == null || oldRole != request.Role)
        {
            if(oldRole != null)
                await userManager.RemoveFromRoleAsync(user, oldRole);
            
            await userManager.AddToRoleAsync(user, request.Role);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);
        var userResponse = mapper.Map<UpdateUserCommandResponse>(request);
        return Result<UpdateUserCommandResponse>.Succeed(userResponse, "Kullanıcı başarıyla güncellendi.");
    }
}