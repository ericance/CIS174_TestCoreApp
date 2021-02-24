using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174_TestCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CIS174_TestCoreApp.Models
{
	public class StudentContext : DbContext
	{
		public StudentContext(DbContextOptions<StudentContext> options) : base(options)
		{ }
		public DbSet<Student> Students { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Student>().HasData(
				new Student
				{
					StudentId = 1,
					FirstName = "Eric",
					LastName = "Stalcup",
					Grade = "12"
				});
		}
	}
}
