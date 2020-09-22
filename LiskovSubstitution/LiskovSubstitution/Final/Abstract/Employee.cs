using LiskovSubstitution.Final.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.StageDevelopment.Final.Abstract
{
	abstract class Employee: IEmployee, IEmployeeBonus
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Employee(int id, string Name)
		{
			this.Id = id;
			this.Name = Name;
		}

		public override string ToString()
		{
			return string.Format("Id : {0} Name : {1} ", this.Id, this.Name);
		}

		public abstract int GetMinimumSalary();

		public abstract double GetEmployeeBonus(int salary);
	}
}
