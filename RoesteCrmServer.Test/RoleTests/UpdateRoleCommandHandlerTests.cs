using Microsoft.AspNetCore.Identity;
using Moq;
using RoesteCrmServer.Application.Features.Roles.UpdateRole;

namespace RoesteCrmServer.Test.RoleTests;

[TestFixture]
public class UpdateRoleCommandHandlerTests
{
    private Mock<RoleManager<IdentityRole<Guid>>> _mockRoleManager;
    private UpdateRoleCommandHandler _handler;
    
    [SetUp]
    public void SetUp()
    {
        _mockRoleManager = new Mock<RoleManager<IdentityRole<Guid>>>(Mock.Of<IRoleStore<IdentityRole<Guid>>>(), null, null, null, null);
        _handler = new UpdateRoleCommandHandler(_mockRoleManager.Object);
    }

    [Test]
    public async Task Handle_Should_Not_Update_Role_If_Role_Not_Found()
    {
        _mockRoleManager.Setup(r=>r.RoleExistsAsync(It.IsAny<string>())).ReturnsAsync(false);
        
        var command = new UpdateRoleCommand(Guid.NewGuid(), "TestRole");
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsFalse(result.IsSuccessful);
        _mockRoleManager.Verify(r=>r.UpdateAsync(It.IsAny<IdentityRole<Guid>>()), Times.Never);
    }

    [Test]
    public async Task Handle_Should_Not_Update_Role_If_New_Role_Name_Already_Exists()
    {
        _mockRoleManager.Setup(r=>r.RoleExistsAsync(It.IsAny<string>())).ReturnsAsync(true);
        
        var command = new UpdateRoleCommand(Guid.NewGuid(), "TestRole");
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsFalse(result.IsSuccessful);
        _mockRoleManager.Verify(r=>r.UpdateAsync(It.IsAny<IdentityRole<Guid>>()), Times.Never);
    }
}