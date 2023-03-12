using Microsoft.AspNetCore.Identity;

namespace Domain.Identity;

public class AapUser : IdentityUser<Guid>, IDomainEntityId
{
    
}