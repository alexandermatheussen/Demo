using System;
using System.Collections.Generic;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        private IUserManager mgr;
        // GET

        public UserController()
        {
            mgr = new UserManager();
        }
        
        public IActionResult Index()
        {
            IEnumerable<User> users = mgr.getUsers();
            
            return View(users);
        }

        public IActionResult Edit(int id)
        {
            User user = mgr.getUser(id);
            //ViewBag.Address = user.address;
            return View(user);
        }
        
        [HttpPost]
        public IActionResult Edit(User user)
        {
            Place newPlace = mgr.getPlace(user.address.place.postalCode, user.address.place.name);
            Address newAddress = new Address()
            {
                number = user.address.number,
                place = newPlace,
                street = user.address.street
            };
            user.address = newAddress;
            
            if (!ModelState.IsValid)
            {
                return View(user);
            }
      
            mgr.changeUser(user);
            return RedirectToAction("Index");
        }
    }
}