using System;
using System.Collections.Generic;

namespace WKTest.Vendrame.Domain.Models
{
	public class OrderItem
	{

		public OrderItem(Dish dish, IList<DishOption> options)
		{
			foreach (DishOption option in options)
			{
				if(option.Category != dish.Category)
				{					
					throw new ArgumentException("The option " + option.Name + " is invalid for this dish.");
				}
			}

			this.Dish = dish;
			this.Options = options;
		}

		public Dish Dish { get; set; }

		public IList<DishOption> Options { get; set; }
	}
}