using NuclearControl.Domain.Entities.Common;

namespace NuclearControl.Domain.Entities.Center;

public class Center : EntityBase
{
    public string Name { get; set; }

    public string City { get; set; }
}