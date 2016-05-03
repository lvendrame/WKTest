using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTest.Vendrame.Domain.Models.Options
{
	public class TasteOption : DishOption
	{
		public TasteOption() : base(Category.MainCourse)
		{
		}
	}
}
