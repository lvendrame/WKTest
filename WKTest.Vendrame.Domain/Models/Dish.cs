using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTest.Vendrame.Domain.Models
{
	public class Dish
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public Category Category { get; set; }

		public TimeSpan PreparationTime { get; set; }
	}
}
