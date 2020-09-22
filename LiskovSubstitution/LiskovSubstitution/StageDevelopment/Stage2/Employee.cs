using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	abstract class Stage2Employee
	{

		public int Id { get; set; }
		public string Name { get; set; }

		public Stage2Employee(int Id, string Name)
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
