using Microsoft.AspNetCore.Identity;
using Moq;
using RoesteCrmServer.Application.Features.Roles.CreateRole;

namespace RoesteCrmServer.Test.RoleTests;

[TestFixture]
public class CreateRoleCommandHandlerTests
{
    private Mock<RoleManager<IdentityRole<Guid>>> _mockRoleManager;
    private CreateRoleCommandHandler _handler ;
    
    [SetUp]
    public void Setup()
    {
        _mockRoleManager = new Mock<RoleManager<IdentityRole<Guid>>>(
            Mock.Of<IRoleStore<IdentityRole>>(), null, null, null, null);

        _handler = new CreateRoleCommandHandler(_mockRoleManager.Object);
    }

    [Test]
    public async Task Handle_Should_Create_Role_When_Role_Does_Not_Exist()
    {
        _mockRoleManager.Setup(r=>r.RoleExistsAsync(It.IsAny<string>()))
            .ReturnsAsync(false);
        _mockRoleManager.Setup(r => r.CreateAsync(It.IsAny<IdentityRole<Guid>>()))
            .ReturnsAsync(IdentityResult.Success);
        
        var command = new CreateRoleCommand("TestRole");
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsTrue(result.IsSuccessful);
        _mockRoleManager.Verify(r=>r.CreateAsync(It.IsAny<IdentityRole<Guid>>()), Times.Once);
    }

    [Test]
    public async Task Handle_Should_Not_Create_Role_When_Role_Already_Exists()
    {
        _mockRoleManager.Setup(r=>r.RoleExistsAsync(It.IsAny<string>()))
            .ReturnsAsync(true);
        
        var command = new CreateRoleCommand("Admin");
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsFalse(result.IsSuccessful);
        _mockRoleManager.Verify(r => r.CreateAsync(It.IsAny<IdentityRole<Guid>>()), Times.Never);
    }
}