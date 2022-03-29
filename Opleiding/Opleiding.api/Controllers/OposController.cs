using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using opleiding.api.Repositories;
using opleiding.models.Opos;
using System.Threading.Tasks;

namespace opleiding.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class OposController : ControllerBase
    {
        private readonly IOpoRepository _opoRepository;

        public OposController(IOpoRepository opoRepository)
        {
            _opoRepository = opoRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "student, docent")]
        public async Task<ActionResult<GetOposModel>> GetOpos()
        {
            return await _opoRepository.GetOpos();
        }

        [HttpGet("(id)")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "student, docent")]
        public async Task<ActionResult<GetOpoModel>> GetOpo(Guid id)
        {
            return await _opoRepository.GetOpo(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Authorize(Roles = "docent")]
        public async Task<ActionResult<GetOpoModel>> PostOpo(PostOpoModel postOpoModel)
        {
            GetOpoModel getopomodel = await _opoRepository.PostOpo(postOpoModel);
            return CreatedAtAction("GetOpo", new { id = getopomodel.OpoId }, getopomodel);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Authorize(Roles = "docent")]
        public async Task<IActionResult> PutOpo(Guid id,PutOpoModel putOpoModel)
        {
            bool result = await _opoRepository.PutOpo(id, putOpoModel);
            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Authorize(Roles = "docent")]
        public async Task<IActionResult> DeleteOpo(Guid id)
        {
            bool result = await _opoRepository.DeleteOpo(id);

            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
