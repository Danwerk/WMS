using App.Domain.Identity;
using Base.Domain;
using Domain.Contracts.Base;

namespace App.Domain;

public class Warehouse : DomainEntityId
{
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}