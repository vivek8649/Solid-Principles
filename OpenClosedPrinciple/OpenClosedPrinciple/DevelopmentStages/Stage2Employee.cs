using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage2Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Emptype { get; set; }


		public Stage2Employee(int Id, string Name, string empType)
		{
			this.Id = Id;
			this.Name = Name;
			this.Emptype = empType;
		}

		public double CalculateBonus(int salary)
		{
			if (this.Emptype == "Permanent")
			{
				return 0.5 * salary;
			}
			else if (this.Emptype == "Contract")
			{
				return 0.2 * salary;
			}
			else
			{
				return 0;
			}
		}
	}
}
