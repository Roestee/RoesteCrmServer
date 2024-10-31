using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.DeleteUserById;

internal sealed class DeleteUserByIdCommandHandler(
    UserManager<AppUser> userManager): IRequestHandler<DeleteUserByIdCommand, Result<AppUser>>
{
    public async Task<Result<AppUser>> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.Id.ToString());
        if(user == null)
            return Result<AppUser>.Failure("Kullanıcı bulunamadı!");

        var result = await userManager.DeleteAsync(user);
        return result.Succeeded ?
            Result<AppUser>.Succeed(user,   "Kullanıcı başarıyla silindi."): 
            Result<AppUser>.Failure("Kullanıcı silinirken hata oluştu!");
    }
}