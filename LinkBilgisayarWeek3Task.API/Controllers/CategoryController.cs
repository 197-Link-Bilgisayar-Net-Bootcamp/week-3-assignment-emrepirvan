using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkBilgisayarWeek3Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpPost]
        public async Task<IActionResult> Index()
        {
           
            return Ok(_category.GetAll());
        }
    }
}
