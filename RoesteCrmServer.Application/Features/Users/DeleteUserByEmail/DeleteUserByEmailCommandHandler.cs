using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.DeleteUserByEmail;

internal sealed class DeleteUserByEmailCommandHandler(
    UserManager<AppUser> userManager) : IRequestHandler<DeleteUserByEmailCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteUserByEmailCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.Users.FirstOrDefaultAsync(x=>x.Email == request.Email, cancellationToken: cancellationToken);
        if(user == null)
            return Result<string>.Failure("User not found");
        
        var result = await userManager.DeleteAsync(user);
        return result.Succeeded? 
            "Kullanıcı başarıyla silindi.":
            Result<string>.Failure("Kullanıcı silinirken hata oluştu!");
    }
}