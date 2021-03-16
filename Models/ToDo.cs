using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "You need to enter a sprint name.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "You need to enter a sprint description.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "You need to select the sprint number.")]
		public string SprintId { get; set; }
		public Sprint Sprint { get; set; }

		[Required(ErrorMessage = "You haven't selected a point value.")]
		public string PointId { get; set; }
		public Point Point { get; set; }

		[Required(ErrorMessage = "Pick a status.")]
		public string StatusId { get; set; }
		public Status Status { get; set; }
	}
}