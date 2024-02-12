using FinancialTamkeen_BlogAPI.Model;
using FinancialTamkeen_BlogAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancialTamkeen_BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly IGenericRepository<Product> _productRepository;
        public ProductController(IGenericRepository<Product> productRepository)
        {
            _productRepository=productRepository;
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new {code="E001",message="Invalid inputs"});
            }
             _productRepository.Create(product);
            return Ok(new { code = "E001", message = "The product inserted" });
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,Product product)
        {
            var existingproduct= _productRepository.GetById(id);
            if(existingproduct != null)
            {
                return BadRequest(new { code = "E002", message = "Doesn't the product exist" });
            }
            existingproduct.Quantity = product.Quantity;
            existingproduct.Price = product.Price;
            existingproduct.Name = product.Name;
            _productRepository.Update(existingproduct);
            return Ok(new { code = "U002", message = "the product is updated" });

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingproduct = _productRepository.GetById(id);
            if (existingproduct != null)
            {
                return BadRequest(new { code = "E002", message = "Doesn't the product exist" });
            }
            _productRepository.Delete(existingproduct);
            return Ok(new { code = "U002", message = "the product is updated" });
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var existingproduct = _productRepository.GetById(id);
            if (existingproduct != null)
            {
                return NotFound(new { code = "E002", message = "Doesn't the product exist" });
            }
          return  Ok (_productRepository.GetById(id));
        }
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            if(_productRepository.GetAll().Count() == 0)
            {
                return NotFound(new { code = "E002", message = "There is no product" });
            }
            return Ok(_productRepository.GetAll());
        }
    }
}
