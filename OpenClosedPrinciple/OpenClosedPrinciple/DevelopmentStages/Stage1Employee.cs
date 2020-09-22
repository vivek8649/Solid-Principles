using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage1Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Stage1Employee(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
		}

		public double CalculateBonus(int salary)
		{
			return 0.5 * salary;
		}

	}
}
