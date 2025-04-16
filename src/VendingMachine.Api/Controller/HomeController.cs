using VendingMachine.Core.Entities;
using VendingMachine.Data;

public class HomeController : Controller
{
    private readonly ApplicationContext _context;
    public HomeController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var productsFromDb = _context.Set<ProductEntity>().ToList();
        List<Product> productList = new List<Product>();

        if(productsFromDb != null)
        {
            foreach (var product in productsFromDb)
            {
                var productModel = new Product()
                {
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    Quantity = product.Quantity
                };
                productList.Add(productModel);
            }
            return View(productList);
        }

        return View();
    }
}