using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day3Homework.Controllers
{
    
    public class OrderItemsController : Controller
    {
        private Day3Homework.Data.ApplicationDbContext _context;
        public OrderItemsController(Day3Homework.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var orderItems = _context.OrderItems.ToList();
            return View(orderItems);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Day3Homework.Data.OrderItem newOrderItem)
        {
            if(ModelState.IsValid)
            {
                _context.OrderItems.Add(newOrderItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newOrderItem);
            }
        }
        public IActionResult Update(int id)
        {
            var orderItemToUpdate = _context.OrderItems.SingleOrDefault(x => x.Id == id);

            if (orderItemToUpdate == null)
            {
                return RedirectToAction("Index");
            }

            return View(orderItemToUpdate);
        }

        [HttpPost]
        public IActionResult Update(Day3Homework.Data.OrderItem updatedOrderItem)
        {
            if (ModelState.IsValid)
            {
                _context.OrderItems.Update(updatedOrderItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(updatedOrderItem);
            }
        }
        public IActionResult Delete(int id)
        {
            var orderItemToDelete = _context.OrderItems.SingleOrDefault(x => x.Id == id);

            if (orderItemToDelete != null)
            {
                _context.OrderItems.Remove(orderItemToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}