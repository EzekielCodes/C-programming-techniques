using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using opleiding.api.Repositories;
using opleiding.models.Opos;
using System.Threading.Tasks;

namespace opleiding.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OposController : ControllerBase
    {
        private readonly IOpoRepository _opoRepository;

        public OposController(IOpoRepository x)
        {
            _opoRepository = x;
        }

        [HttpGet]
        public async Task <ActionResult<GetOpoModel>> GetOpos()
        {
            return await _opoRepository.GetOpos();
        }
    }
}
