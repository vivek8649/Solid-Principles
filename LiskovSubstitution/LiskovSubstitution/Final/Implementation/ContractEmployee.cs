using LiskovSubstitution.Final.Interface;
using LiskovSubstitution.StageDevelopment.Final.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Final.Implementation
{
	class ContractEmployee : Employee
	{
		public ContractEmployee(int id, string name) : base(id, name)
		{

		}
		public override double GetEmployeeBonus(int salary)
		{
			return 0.2 * salary;
		}

		public override int GetMinimumSalary()
		{
			return 12000;
		}
	}
}
