using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Models
{
    public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

		public DbSet<ToDo> Tickets { get; set; }
		public DbSet<Sprint> Sprints { get; set; }
		public DbSet<Point> Points { get; set; }
		public DbSet<Status> Statuses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Sprint>().HasData(
				new Sprint { SprintId = "a", Name = "0" },
				new Sprint { SprintId = "b", Name = "1" },
				new Sprint { SprintId = "c", Name = "2" },
				new Sprint { SprintId = "d", Name = "3" },
				new Sprint { SprintId = "e", Name = "4" },
				new Sprint { SprintId = "f", Name = "5" },
				new Sprint { SprintId = "g", Name = "6" },
				new Sprint { SprintId = "h", Name = "7" },
				new Sprint { SprintId = "i", Name = "8" },
				new Sprint { SprintId = "j", Name = "9" },
				new Sprint { SprintId = "k", Name = "10" },
				new Sprint { SprintId = "l", Name = "11" },
				new Sprint { SprintId = "m", Name = "12" },
				new Sprint { SprintId = "n", Name = "13" },
				new Sprint { SprintId = "o", Name = "14" },
				new Sprint { SprintId = "p", Name = "15" },
				new Sprint { SprintId = "q", Name = "16" },
				new Sprint { SprintId = "r", Name = "17" },
				new Sprint { SprintId = "s", Name = "18" },
				new Sprint { SprintId = "t", Name = "19" },
				new Sprint { SprintId = "u", Name = "20" }
			);
			modelBuilder.Entity<Point>().HasData(
				new Point { PointId = "a", Name = "1" },
				new Point { PointId = "b", Name = "2" },
				new Point { PointId = "c", Name = "3" },
				new Point { PointId = "d", Name = "4" },
				new Point { PointId = "e", Name = "5" },
				new Point { PointId = "f", Name = "6" },
				new Point { PointId = "g", Name = "7" },
				new Point { PointId = "h", Name = "8" },
				new Point { PointId = "i", Name = "9" },
				new Point { PointId = "j", Name = "10" },
				new Point { PointId = "k", Name = "11" },
				new Point { PointId = "l", Name = "12" },
				new Point { PointId = "m", Name = "13" },
				new Point { PointId = "n", Name = "14" },
				new Point { PointId = "o", Name = "15" },
				new Point { PointId = "p", Name = "16" },
				new Point { PointId = "q", Name = "17" },
				new Point { PointId = "r", Name = "18" },
				new Point { PointId = "s", Name = "19" },
				new Point { PointId = "t", Name = "20" }
			);
			modelBuilder.Entity<Status>().HasData(
				new Status { StatusId = "todo", Name = "To Do" },
				new Status { StatusId = "wip", Name = "In Progress" },
				new Status { StatusId = "qa", Name = "Quality Assurance" },
				new Status { StatusId = "closed", Name = "Done" }
			);
		}
	}
}