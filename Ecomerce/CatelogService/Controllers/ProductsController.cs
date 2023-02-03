using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CatelogService.BOL;

namespace CatelogService.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController:ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        List<Product> allProducts=new List<Product>(); 
           
        allProducts.Add(new Product{ ProductId=1, Title="Gerbera",  Description="Wedding flower", UnitPrice=5, StockAvailable=4000 });
        allProducts.Add(new Product{ ProductId=2, Title="Rose",  Description="Valentine flower", UnitPrice=12, StockAvailable=16000 });
        return Ok(allProducts);
    }

    [Route("{id}")]
    [HttpGet]
    public IActionResult GetById(int id)
    {
        Product prod=new Product{ ProductId=1, Title="Gerbera",  Description="Wedding flower", UnitPrice=5, StockAvailable=4000 };
        return Ok(prod);
    }
}