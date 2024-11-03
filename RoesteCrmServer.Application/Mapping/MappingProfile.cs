using AutoMapper;
using RoesteCrmServer.Application.Features.Accounts.CreateAccount;
using RoesteCrmServer.Application.Features.Accounts.UpdateAccount;
using RoesteCrmServer.Application.Features.Addresses.CreateAddress;
using RoesteCrmServer.Application.Features.Leads.CreateLead;
using RoesteCrmServer.Application.Features.Leads.UpdateLead;
using RoesteCrmServer.Application.Features.LeadStatuses.CreateLeadStatuses;
using RoesteCrmServer.Application.Features.Users.CreateUser;
using RoesteCrmServer.Application.Features.Users.UpdateUser;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Mapping;

public sealed class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserCommand, AppUser>();
        CreateMap<UpdateUserCommand, AppUser>();
        CreateMap<UpdateUserCommandResponse, UpdateUserCommand>().ReverseMap();
        CreateMap<CreateUserCommandResponse, AppUser>().ReverseMap();

        CreateMap<CreateLeadCommand, Lead>();
        CreateMap<CreateLeadCommand, Address>();
        CreateMap<UpdateLeadCommand, Lead>();

        CreateMap<CreateAccountCommand, Account>();
        CreateMap<UpdateAccountCommand, Account>();
        
        CreateMap<CreateLeadStatusesCommand, LeadStatus>();
        CreateMap<CreateAddressCommand, Address>();
    }
}
