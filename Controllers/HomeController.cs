﻿
using Microsoft.AspNetCore.Mvc;
using PartyInvitesPractise.Models;
using System.Linq;

namespace PartyInvitesPractise.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        { return View(); }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)

        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse); 
            return View("Thanks", guestResponse);
            }
            else
            {   
                // there is a validation error               
                return View();   
            }
            }
        public ViewResult ListResponses()
        { return View(Repository.Responses.Where(r => r.WillAttend == true)); 
        }
    }
}
