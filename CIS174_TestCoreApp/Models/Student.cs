using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Grade { get; set; }
		
		// If sufficient access doesn't exist
		public Student(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
		public Student(string firstName, string lastName, string grade)
		{
			FirstName = firstName;
			LastName = lastName;
			Grade = grade;
		}
	}
}
