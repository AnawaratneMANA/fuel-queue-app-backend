using Microsoft.AspNetCore.Mvc;
using MongoDBTestProject.Model;
using MongoDBTestProject.Service;

namespace MongoDBTestProject.Controllers
{
    public class FuelStationController : Controller
    {
        private readonly IFuelStationService fuelStationService;
        public FuelStationController(IFuelStationService fuelStationService)
        {
            this.fuelStationService = fuelStationService;
        }

        // POST api/<FuelSationController>/addFuelStation
        [HttpPost("addFuelStation")]
        public ActionResult<User> Registration([FromBody] FuelStation request)
        {
            if (request.Location == null || request.NoOfPumps == 0 || request.Availability == null || request.FuelType == null)
            {
                return BadRequest("Missing Fuel Station Details!");
            }
            FuelStation station = new FuelStation();
            station.Location = request.Location;
            station.NoOfPumps = request.NoOfPumps;
            station.Availability = request.Availability;
            station.FuelType = request.FuelType;
            station.StartingTime = DateTime.Now;
            station.EndingTime = DateTime.Now;
            fuelStationService.CreateFuelStation(station);
            return CreatedAtAction(nameof(GetFuelStation), new { id = station.Id }, station);
        }

        // GET api/<FuelStationController>/<id>
        [HttpGet("{id}")]
        public ActionResult<FuelStation> GetFuelStation(String id)
        {
            var station = fuelStationService.GetFuelStation(id);
            if (station == null)
            {
                return NotFound($"Fuel Station with Id = {id} not found");
            }

            return station;
        }

        //GET api/<FuelStationController>/getFuelStations
        [HttpGet("getFuelStations")]
        public ActionResult<List<FuelStation>> GetAllFuelStations()
        {
            return fuelStationService.GetFuelStations();
        }

        //PUT api/<FuelStationController>/updateStartEndTime
        [HttpPut("updateStartEndTime")]
        public ActionResult updateStartEndTime(String id, [FromBody] FuelStation station)
        {
            fuelStationService.UpdateStartTimeAndEndTime(id, station);
            return NoContent();
        }


    }
}
