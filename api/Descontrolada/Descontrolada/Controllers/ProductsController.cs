using Descontrolada.Data;
using Descontrolada.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Descontrolada.Properties
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductsAPIDbContext dbContext;

        public ProductsController(ProductsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(int? page)
        {
            const int itemsPerPage = 5;
            int nPage = (page ?? 1);
            return Ok(await dbContext.Products.ToPagedListAsync(nPage, itemsPerPage));
        }

        [HttpPost]
        public async Task<IActionResult> addProduct(AddProductRequest addProductRequest)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = addProductRequest.Name,
                Price = addProductRequest.Price,
                Qtd = addProductRequest.Qtd,
                Type = addProductRequest.Type,
                Description = addProductRequest.Description
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            return Ok(product);
        }
    }
}
