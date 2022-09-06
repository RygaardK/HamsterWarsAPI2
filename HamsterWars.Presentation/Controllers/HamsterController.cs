using HamsterWarsAPI.Presentation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Service.Contracts;
using SharedHelpers.DataTransferObjects;

namespace HamsterWars.Presentation.Controllers
{
    [Route("hamster")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        private readonly IServiceManager _service;
        public HamsterController(IServiceManager service) => _service = service;
        [HttpGet]
        public async Task<IActionResult> GetAllHamstersAsync()
        {
            var hamsters = await _service.HamsterService.GetAllHamstersAsync(trackChanges: false);
            return Ok(hamsters);

        }
        [HttpGet("{id:int}", Name = "HamsterById")]
        public async Task<IActionResult> GetHamsterByIdAsync(int id)
        {
            var hamster = await _service.HamsterService.GetHamsterByIdAsync(id, trackChanges: false);
            return Ok(hamster);
        }
        [HttpPost]
        [ServiceFilter(typeof(AsyncActionFilter))]
        public async Task<IActionResult> CreateHamsterAsync([FromBody] HamsterForCreationDto hamster)
        {
            var createdHamster = await _service.HamsterService.CreateHamsterAsync(hamster);
            return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteHamsterAsync(int id)
        {
            await _service.HamsterService.DeleteHamsterAsync(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("update/{id:int}")]
        //[ServiceFilter(typeof(AsyncActionFilter))] - kolla update först innan expr.
        public async Task<IActionResult> UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamster, bool trackChanges)
        {
            await _service.HamsterService.UpdateHamsterAsync(id, hamster, trackChanges: true);
            return NoContent();
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandomHamster()
        {
            var hamster = await _service.HamsterService.GetRandomHamsterAsync(trackChanges: false);
            return Ok(hamster);
        }
    }

}
