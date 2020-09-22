using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	abstract class Employee
	{

		public int Id { get; set; }
		public string Name { get; set; }

		public Employee(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
		}
		public abstract double CalculateBonus(int salary);

		public override string ToString()
		{
			return string.Format("Id : {0} Name : {1} ", this.Id, this.Name);
		}
	}
}
