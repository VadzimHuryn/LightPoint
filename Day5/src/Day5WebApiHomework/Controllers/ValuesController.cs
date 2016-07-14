using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Day5WebApiHomework.Models;
using Microsoft.AspNetCore.Authorization;

namespace Day5WebApiHomework.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ValuesController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private ApplicationContext _context;

        public ValuesController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Place> Get()
        {
            var userId = _userManager.GetUserId(Request.HttpContext.User);
            var places = _context.Places.ToList().Where(x => x.UserId == userId);
            return places;
        }

        // POST api/values
        [HttpPost("{id}")]
        public void Post(int id)
        {
            var place = _context.Places.SingleOrDefault(x => x.Id == id && x.UserId == null);
            if (place != null)
            {
                place.UserId = _userManager.GetUserId(Request.HttpContext.User);
                _context.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            var place = _context.Places.SingleOrDefault(x => x.Id == id && x.UserId == _userManager.GetUserId(Request.HttpContext.User));
            place.UserId = null;
            _context.SaveChanges();
        }

    }
}
