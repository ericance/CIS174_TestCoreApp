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
		public IActionResult Index(int permissionId = 1)
		{
			ViewBag.PermissionId = permissionId;

			List<Student> studentData = new List<Student>();
			studentData.Add(new Student("Mike", "Dylan", "15/20"));
			studentData.Add(new Student("Gabe", "Smith", "21/20"));
			studentData.Add(new Student("Jerome", "Rivers", "4/20"));
			studentData.Add(new Student("Donnie", "Troomp", "0/20"));

			return View("Index", studentData);
		}
	}
}
