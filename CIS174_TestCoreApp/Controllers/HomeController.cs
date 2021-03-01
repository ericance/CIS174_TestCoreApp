﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.Controllers;

namespace CIS174_TestCoreApp.Controllers
{
	public class HomeController : Controller
	{

		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
