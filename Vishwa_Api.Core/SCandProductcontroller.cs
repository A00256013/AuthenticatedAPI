[Authorize]
[ApiController]
[Route("[controller]")]
public class ShoppingCartController : ControllerBase
{
    private List<ShoppingCart> _carts;

    public ShoppingCartController()
    {
        _carts = new List<ShoppingCart>
        {
            new ShoppingCart
            {
                Id = 1,
                User = "User1",
                Products = new List<Product>
                {
                    new Product { Id = 1, Name = "Product1", Price = 10.0, Description = "Description1", Category = new Category { Id = 1, Description = "Category1" } },
                    new Product { Id = 2, Name = "Product2", Price = 20.0, Description = "Description2", Category = new Category { Id = 2, Description = "Category2" } }
                }
            },
            // ... other shopping carts ...
        };
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        var user = User.Identity.Name;
        var cart = _carts.FirstOrDefault(c => c.User == user);
        if (cart == null)
        {
            return NotFound();
        }
        return Ok(cart.Products);
    }

    // ... other endpoints ...
}

[Authorize]
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private List<Product> _products;

    public ProductController()
    {
        _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10.0, Description = "Description1", Category = new Category { Id = 1, Description = "Category1" } },
            new Product { Id = 2, Name = "Product2", Price = 20.0, Description = "Description2", Category = new Category { Id = 2, Description = "Category2" } },
            // ... other products ...
        };
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return Ok(_products);
    }

    // ... other endpoints ...
}

