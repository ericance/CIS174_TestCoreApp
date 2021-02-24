using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
	public class AssignmentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
