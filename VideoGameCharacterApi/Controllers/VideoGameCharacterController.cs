using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Xml.Linq;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //inject service provider into controller
    public class VideoGameCharacterController(IVideoGameCharacterService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters() => Ok(await service.GetAllCharactersAsync());

        // {} indecates that the id is a parameter that will be passed in the URL
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("Character with the given ID was not found.") : Ok(character);

            //if (character is null)
            //    return NotFound("Character with the given ID was not found.");
            //return Ok(character);
        }
    }
}
