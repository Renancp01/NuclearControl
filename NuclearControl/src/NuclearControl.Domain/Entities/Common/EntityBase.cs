namespace NuclearControl.Domain.Entities.Common;

public class EntityBase
{
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }
}