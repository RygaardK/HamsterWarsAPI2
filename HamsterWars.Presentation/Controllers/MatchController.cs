using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace HamsterWars.Presentation.Controllers
{
    [Route("matches")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IServiceManager _service;
        public MatchController(IServiceManager service) => _service = service;
        [HttpGet]
        public async Task<IActionResult> GetMatchesAsync()
        {
            var matches = await _service.MatchesService.GetAllMatchesAsync(trackChanges: false);
            return Ok(matches);

        }
        [HttpGet("{id:int}", Name = "GetMatch")]
        public async Task<IActionResult> GetMatchById(int id)
        {
            var match = await _service.MatchesService.GetMatchByIdAsync(id, trackChanges: false);
            return Ok(match);
        }

        [HttpPost]
        [ServiceFilter(typeof(ActionFilterAttribute))]
        public async Task<IActionResult> CreateMatchAsync([FromBody] MatchForCreationDto match)
        {
            var matchToReturn = await _service.MatchesService.CreateMatchAsync(match, trackChanges: false);
            return CreatedAtRoute("MatchForCreationDto", new { id = matchToReturn.Id }, matchToReturn);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteMatchAsync(int id)
        {
            await _service.MatchesService.DeleteMatchAsync(id, trackChanges: false);
            return NoContent();
        }

    }


}
