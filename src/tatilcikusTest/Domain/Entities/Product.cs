using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }

    public Product()
    {
        Name = string.Empty;
    }

    public Product(string name, decimal unitPrice, short unitsInStock)
    {
        Name = name;
        UnitPrice = unitPrice;
        UnitsInStock = unitsInStock;
    }

    public Product(int id, string name, decimal unitPrice, short unitsInStock)
        : base(id)
    {
        Name = name;
        UnitPrice = unitPrice;
        UnitsInStock = unitsInStock;
    }
}
