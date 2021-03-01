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
		[Route("Assignment/{permission?}")]
		public IActionResult Index(int permission = 1)
		{
			ViewBag.PermissionId = permission;

			List<Student> studentData = new List<Student>();
			studentData.Add(new Student("Mike", "Dylan", "B"));
			studentData.Add(new Student("Gabe", "Smith", "A+"));
			studentData.Add(new Student("Jerome", "Rivers", "F"));
			studentData.Add(new Student("Donnie", "Troomp", "Expelled"));

			return View("Index", studentData);
		}
	}
}
