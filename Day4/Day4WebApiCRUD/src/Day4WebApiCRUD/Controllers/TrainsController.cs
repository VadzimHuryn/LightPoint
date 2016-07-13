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
    public class TrainsController : Controller
    {

        private PlaceContext _context;
        public TrainsController(PlaceContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Train> Get()
        {
            return _context.Trains.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Train Get(int id)
        {
            var train = _context.Trains.SingleOrDefault(x => x.Id == id);
            return train;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Train newTrain)
        {
            _context.Trains.Add(newTrain);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Train updateTrain)
        {
            var train = _context.Trains.SingleOrDefault(x => x.Id == id);
            train.TrainNum = updateTrain.TrainNum;
            train.Railcars = updateTrain.Railcars;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var train = _context.Trains.SingleOrDefault(x => x.Id == id);
            _context.Trains.Remove(train);
            _context.SaveChanges();
        }
    }
}
