namespace VishwaApi.Tests;

public class ProductTests
{
    [Fact]
    public void CanChangeProductName()
    {
        var p = new Product { Name = "Test", Price = 100M };
        p.Name = "New Name";
        Assert.Equal("New Name", p.Name);
    }

    // Add more tests...
}

public class CategoryTests
{
    [Fact]
    public void CanChangeCategoryDescription()
    {
        var c = new Category { Description = "Test" };
        c.Description = "New Description";
        Assert.Equal("New Description", c.Description);
    }

    // Add more tests...
}

public class ShoppingCartTests
{
    [Fact]
    public void CanChangeUser()
    {
        var s = new ShoppingCart { User = "Test" };
        s.User = "New User";
        Assert.Equal("New User", s.User);
    }

    // Add more tests...
}

public class PriceTests
{
    [Fact]
    public void CanChangeProductPrice()
     {

        var a = new Product { Name = "Test", Price = 100M };
        a.Price = 200M;
        Assert.Equal(200M, a.Price);
    }
}


