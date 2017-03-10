using Microsoft.AspNetCore.Mvc;
using MyCodeCamp.Data;

namespace MyCodeCamp.Controllers
{
    [Route("api/Camps")]
    public class CampsController : Controller
    {
        private readonly ICampRepository repo;

        public CampsController(ICampRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var camps = repo.GetAllCamps();
            return Ok(camps);
        }
    }
}