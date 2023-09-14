using NuclearControl.Domain.Entities.Common;

namespace NuclearControl.Domain.Entities.Stock;

public class Person : EntityBase
{
    public Person(string name, string lastname)
    {
        Name= name;
        LastName = lastname;
    }

    public string Name { get; set; }

    public string LastName { get; set; }
}