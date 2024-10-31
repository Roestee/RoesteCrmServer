namespace RoesteCrmServer.Application.Features.Users.CreateUser;

public sealed class CreateUserCommandResponse
{
    public Guid Id { get; set;}
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string UserName { get; set;}
    public string Email { get; set;}
    public string PhoneNumber { get; set;}
    public string? Role { get; set;}

    public CreateUserCommandResponse(
        Guid id, 
        string firstName, 
        string lastName, 
        string userName, 
        string email, 
        string phoneNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}