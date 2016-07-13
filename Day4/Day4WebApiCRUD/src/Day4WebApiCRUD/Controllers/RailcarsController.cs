using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day4WebApiCRUD.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Day4WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    public class RailcarsController : Controller
    {
        private PlaceContext _context;
        public RailcarsController(PlaceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Railcar> Get()
        {
            return _context.Railcars.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Railcar Get(int id)
        {
            var railcar = _context.Railcars.SingleOrDefault(x => x.Id == id);
            return railcar;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Railcar newRailcar)
        {
            _context.Railcars.Add(newRailcar);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Railcar updateRailcar)
        {
            var railcar = _context.Railcars.SingleOrDefault(x => x.Id == id);
            railcar.RailcarNum = updateRailcar.RailcarNum;
            railcar.Train = updateRailcar.Train;
            railcar.TrainId = updateRailcar.TrainId;
            railcar.Places = updateRailcar.Places;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var railcar = _context.Railcars.SingleOrDefault(x => x.Id == id);
            _context.Railcars.Remove(railcar);
            _context.SaveChanges();
        }
    }
}
