using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Filters
	{
		public Filters(string filterstring)
		{
			FilterString = filterstring ?? "all-all-all";
			string[] filters = FilterString.Split('-');
			SprintId = filters[0];
			PointId = filters[1];
			StatusId = filters[2];
		}



		public string FilterString { get; }
		public string SprintId { get; }
		public string PointId { get; }
		public string StatusId { get; }

		public bool HasSprint => SprintId.ToLower() != "all";
		public bool HasPoint => PointId.ToLower() != "all";
		public bool HasStatus => StatusId.ToLower() != "all";

	}
}