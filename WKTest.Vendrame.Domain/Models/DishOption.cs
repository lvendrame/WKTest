using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTest.Vendrame.Domain.Models
{
	public abstract class DishOption
	{

		public DishOption(Category category)
		{
			this.Category = category;
		}

		public Category Category { get; private set; }
		public string Name { get; internal set; }
	}
}
