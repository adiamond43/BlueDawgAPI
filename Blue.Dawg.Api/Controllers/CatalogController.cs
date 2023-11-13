using Microsoft.AspNetCore.Mvc;
using Blue.Dawg.Domain.Catalog;
using Microsoft.AspNetCore.Http.HttpResults;
using Blue.Dawg.Catalog;

namespace Blue.Dawg.Api.Controllers
{
    [ApiController]
    [Route ("[[controller]]")]
    public class CatalogController : ControllerBase
    {

    
    
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = new List<Item>()
        {
            new Item("Shirt", "Ohio State shirt", "Nike", 29.99m),
            new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
        };

        return Ok(items);
    }
    }
}