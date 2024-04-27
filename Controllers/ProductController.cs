using BookSelling_E_Comerse.Data;
using BookSelling_E_Comerse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace BookSelling_E_Comerse.Controllers;
public class ProductController(ApplicatioDbContext dbContext) : Controller
{
    public ApplicatioDbContext DbContext { get; } = dbContext;

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult GetProduct(int id)
    {
        var product = DbContext.Products.FirstOrDefault(x => x.Id == id);
        return Ok(product);
    }
    [HttpGet]
    public ActionResult<List<Product>> GetAllProduct()
    {
        var products = DbContext.Products.ToList();
        return Ok(products);
    }

    //public ActionResult CreateProduct(string name, string category, decimal price)
    [HttpPost]
    //public ActionResult CreateProduct(Product? product)
    //{
    //    if (product == null) 
    //    { 
    //        throw new NotImplementedException();
    //    }
    //    if(product.Name is null)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    return Ok();
    //}
    [HttpPost]
    public ActionResult CreateProduct(string name, decimal price, string categoryName, int categoryId)
    {
        var product = new Product
        {
            Name = name,
            Price = price,
            CategoryName = categoryName,
            CategoryId = categoryId

        };
        DbContext.Add(product);
        DbContext.SaveChanges();

        return Ok(product.Id);
    }
    [HttpPost]
    public ActionResult UpdateProduct(int id, string name, decimal price, string categoryName, int categoryId)
    {
        var product = DbContext.Products.FirstOrDefault(x => x.Id == id);
        if (product is not null)
        {
            product.Name = name;
            product.CategoryName = categoryName;
            product.CategoryId = categoryId;
            product.Price = price;
            DbContext.Update(product);
            DbContext.SaveChanges();
        }
        return Ok();
    }
    [HttpDelete]
    public ActionResult DeleteProduct(int id)
    {
        var product = DbContext.Products.FirstOrDefault(x => x.Id == id);
        DbContext.Remove(product!);
        DbContext.SaveChanges();
        return Ok();
    }
}