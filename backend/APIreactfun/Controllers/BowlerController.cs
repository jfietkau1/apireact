using APIreactfun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIreactfun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        //the three lines of code below connect us to the repository so we can connect to our database.
        private IBowlerRepository _bowlerRepository;
        private readonly ILogger<BowlerController> _logger;

        public BowlerController(IBowlerRepository temp, ILogger<BowlerController> logger)
        {
            _bowlerRepository = temp;
            _logger = logger;
        }
        //[HttpGet]
        //public IEnumerable<Bowlers> Get()
        //{

        //    var BowlerData = _bowlerRepository.Bowlers.ToArray();

        //    return BowlerData;

        //}
        [HttpGet]
        public ActionResult<IEnumerable<BowlerTeamInfo>> Get()
        {
            try
            {
                // Call the GetBowlerTeams method to get the joined data
                var bowlerTeamInfo = _bowlerRepository.GetBowlerTeams();
                return Ok(bowlerTeamInfo);
            }
               
            
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving data from the database");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

    }
}
