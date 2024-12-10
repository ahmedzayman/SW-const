using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using mhma_kan;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AdventureWorks2022Context _context;

    public ProductsController(AdventureWorks2022Context context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return _context.Products.ToList();
    }
}