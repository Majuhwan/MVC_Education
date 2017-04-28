using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		
		// GET: Home
		//private int value1;
		public ViewResult Index()
		{
			//this.value1 = 10;
			//return View();

			//0426 실습 1
			int hour = DateTime.Now.Hour;
			this.ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
			return this.View();
		}

		[HttpGet]
		public ViewResult RsvpForm()
		{
			return View();
		}
		[HttpPost]
		public ViewResult RsvpForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid)
				return View("Thanks", guestResponse);
			else
				return View();
		}
	}
}