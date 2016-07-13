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
    public class PlacesController : Controller
    {
        private PlaceContext _context;
        public PlacesController(PlaceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Place> Get()
        {
            return _context.Places.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Place Get(int id)
        {
            var place = _context.Places.SingleOrDefault(x => x.Id == id);
            return place;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Place newPlace)
        {
            _context.Places.Add(newPlace);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Place updatePlace)
        {
            var place = _context.Places.SingleOrDefault(x => x.Id == id);
            place.Cost = updatePlace.Cost;
            place.Railcar = updatePlace.Railcar;
            place.RailcarId = updatePlace.RailcarId;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var place = _context.Places.SingleOrDefault(x => x.Id == id);
            _context.Places.Remove(place);
            _context.SaveChanges();
        }
    }
}
