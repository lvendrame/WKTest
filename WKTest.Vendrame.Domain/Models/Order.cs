using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKTest.Vendrame.Domain.Models
{
	public class Order
	{
		public Order(Table table)
			:this(table, new List<OrderItem>())
		{
		}

		public Order(Table table, IList<OrderItem> items)
		{
			this.Table = table;
			this.Items = items;
		}

		public IList<OrderItem> Items { get; set; }
		public Table Table { get; private set; }

		public void AddItem(Dish dish, DishOption option)
		{
			List<DishOption> options = new List<DishOption>();
			options.Add(option);

			this.AddItem(new OrderItem(dish, options));
		}

		public void AddItem(Dish dish, IList<DishOption> options)
		{
			this.AddItem(new OrderItem(dish, options));
		}

		public void AddItem(OrderItem item)
		{
			this.Items.Add(item);
		}

		public TimeSpan GetEstimatedTime()
		{
			TimeSpan maxMainCourseTime = new TimeSpan(0);

			foreach (OrderItem item in this.Items)
			{
				if(item.Dish.Category == Category.MainCourse)
				{
					if(item.Dish.PreparationTime > maxMainCourseTime)
					{
						maxMainCourseTime = item.Dish.PreparationTime;
					}
				}
			}

			return maxMainCourseTime;
		}

		public decimal TotalBill()
		{
			decimal total = 0;
			foreach (OrderItem item in this.Items)
			{
				total += item.Dish.Price;
			}

			return total;
		}
	}
}
