using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public string Index()
		{
			return "return String";
		}
		public ViewResult AutoProperty()
		{
			Product myProduct = new Product();

			myProduct.Name = "kayak";

			string productName = myProduct.Name;

			return View("Result", (object)String.Format("Product name; {0}", productName));
		}
	}
}