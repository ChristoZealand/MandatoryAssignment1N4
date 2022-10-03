using MandatoryAssignment1;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MandatoryAssignment4
{
    [Route("api/FootballPlayers")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly FootballPlayersManager _footballPlayersManager = new FootballPlayersManager();

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet()]
        public ActionResult<IEnumerable<FootballPlayer>> Get()
        {
            IEnumerable<FootballPlayer> player = _footballPlayersManager.GetAll();

            if (player.Count() == 0) return NotFound("No such class, id");
            return Ok(player);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> Get(int id)
        {
            FootballPlayer player = _footballPlayersManager.GetById(id);
            if (player == null) return NotFound("No such class, id: " + id);
            return Ok(player);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            FootballPlayer player = _footballPlayersManager.Add(value);
            if (player == value) return Created("Api/IPAs/" + value.Id, value);
            return Created("", player);
        }

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPut("{id}")]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value)
        {
            FootballPlayer player = _footballPlayersManager.Update(id, value);
            if (player.ShirtNumber > 99) return BadRequest("BAAAD");
            return BadRequest();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            FootballPlayer player = _footballPlayersManager.Delete(id);
            if (player == null) return NoContent();
            return NoContent();

        }
    }
}
