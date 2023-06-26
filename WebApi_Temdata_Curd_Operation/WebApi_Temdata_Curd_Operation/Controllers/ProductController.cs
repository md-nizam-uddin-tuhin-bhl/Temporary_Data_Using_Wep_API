using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Temdata_Curd_Operation.Models;

namespace WebApi_Temdata_Curd_Operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> ListProduct = new List<Product>() {
         new Product() { Id = 1,ProductName="Nokia N77",Descripsion="Good Product"} ,
         new Product() { Id = 2,ProductName="HP 840 G2",Descripsion="Good Product"},
         new Product() { Id = 3,ProductName="Sony Ranks",Descripsion="Good Product"}
        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ListProduct;
        }
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            ListProduct.Add(product);
        } 
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Product product)
        {
            ListProduct[id] = product;
        } 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListProduct.RemoveAt(id);
        }

    }
}
