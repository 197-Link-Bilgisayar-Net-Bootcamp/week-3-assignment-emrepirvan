using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkBilgisayarWeek3Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService) //ProductService' ctor da kullandığımıza göre
                                                                 //Program.cs tarafında DIConteinear'a eklemeliyiz
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _productService.GetAll();

            return new ObjectResult(response) { StatusCode = response.Status }; //Bu şekilde başarılıysa 200 dön başarısızsa 404 dön yazmama gerek kalmadı
        }
    }
}
