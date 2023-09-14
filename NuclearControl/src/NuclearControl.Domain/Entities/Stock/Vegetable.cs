using System.Security.AccessControl;
using NuclearControl.Domain.Entities.Common;

namespace NuclearControl.Domain.Entities.Stock;

public class Vegetable : EntityBase
{
    public Vegetable(int code, double quantity, string origin, IEnumerable<TypeVegetable> types)
    {
        Code = code;
        Quantity = quantity;
        Types = types;
        Origin = origin;
    }

    public int Code { get; private set; }

    public string Origin { get; private set; }

    public double Quantity { get; private set; }

    public IEnumerable<TypeVegetable> Types { get; private set; }

    public ICollection<Person> Person { get; } = new List<Person>();

    public void FixQuantity(double quantity) => Quantity = quantity;

    public void AddPerson(string name, string lastname) => Person.Add(new Person(name, lastname));
}