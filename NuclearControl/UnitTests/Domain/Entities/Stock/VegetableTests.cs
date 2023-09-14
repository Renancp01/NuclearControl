using FluentAssertions;
using NuclearControl.Domain.Entities.Stock;

namespace UnitTests.Domain.Entities.Stock;

public class VegetableTests
{
    [Fact]
    public void FixQuantity_Should_Fix_Quantity_Correct()
    {
        //Arrange
        var vegetable = new Vegetable(1, 10.1, "Teste", new List<TypeVegetable> { TypeVegetable.Caupuri });

        //Action
        vegetable.FixQuantity(10.2);

        //Assert
        vegetable.Quantity.Should().Be(10.2);
    }

    [Fact]
    public void AddPerson_Should_New_Person_With_Success()
    {
        //Arrange
        var vegetable = new Vegetable(1, 10.1, "Teste", new List<TypeVegetable> { TypeVegetable.Caupuri });

        //Action
        vegetable.AddPerson("Name", "Lastname");

        //Assert
        vegetable.Origin.Should().Be("Teste");
        vegetable.Code.Should().Be(1);
        vegetable.Types.Should().HaveCount(1);
        vegetable.Person.Should().NotBeNull();
        vegetable.Person.Count.Should().Be(1);
        vegetable.Person.First().Name.Should().Be("Name");
        vegetable.Person.First().LastName.Should().Be("Lastname");
    }
}