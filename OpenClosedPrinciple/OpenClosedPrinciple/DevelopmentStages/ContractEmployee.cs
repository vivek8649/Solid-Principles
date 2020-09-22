using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class ContractEmployee : Employee
	{
		public ContractEmployee(int Id, string Name): base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.2 * salary;
		}
	}
}
