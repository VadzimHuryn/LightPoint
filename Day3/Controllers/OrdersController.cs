using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day3Homework.Controllers
{
    public class OrdersController : Controller
    {
        private Day3Homework.Data.ApplicationDbContext _context;
        
        public OrdersController(Day3Homework.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Day3Homework.Data.Order newOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(newOrder);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newOrder);
            }
        }
        public IActionResult Update(int id)
        {
            var orderToUpdate = _context.Orders.SingleOrDefault(x => x.Id == id);

            if (orderToUpdate == null)
            {
                return RedirectToAction("Index");
            }

            return View(orderToUpdate);
        }

        [HttpPost]
        public IActionResult Update(Day3Homework.Data.Order updatedOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Update(updatedOrder);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(updatedOrder);
            }
        }
        public IActionResult Delete(int id)
        {
            var orderToDelete = _context.Orders.SingleOrDefault(x => x.Id == id);

            if (orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}