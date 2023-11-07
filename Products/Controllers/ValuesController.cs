using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Product> myProducts = new List<Product>();
        public ValuesController()
        {
        myProducts.Add(new Product() { Id = 111,Name = "111",Price = 111});
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public List<Product> Get()
        {
            return myProducts;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product p = myProducts.Find(item => item.Id == id);
            return p;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(Product value)
        {
            myProducts.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id,string name)
        {
            Product p = myProducts.Find(item => item.Id == id);
            p.Name = name;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product p = myProducts.Find(item => item.Id == id);
            myProducts.Remove(p);
        }
        // SEARCH api/<ValuesController>/5
        [HttpGet("getByName")]
        public Product Get(string name)
        {
            Product p = myProducts.Find(item => item.Name == name);
            return p;
        }
    }
}
