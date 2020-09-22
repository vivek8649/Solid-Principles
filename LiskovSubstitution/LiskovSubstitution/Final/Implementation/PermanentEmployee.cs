using LiskovSubstitution.StageDevelopment.Final.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Final.Implementation
{
	class PermanentEmployee : Employee
	{
		public PermanentEmployee(int id, string name) : base(id, name)
		{

		}
		public override double GetEmployeeBonus(int salary)
		{
			return 0.5 * salary;
		}

		public override int GetMinimumSalary()
		{
			return 15000;
		}
	}
}
