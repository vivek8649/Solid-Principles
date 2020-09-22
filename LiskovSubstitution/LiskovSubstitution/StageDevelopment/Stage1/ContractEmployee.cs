using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage1ContractEmployee : Stage1Employee
	{
		public Stage1ContractEmployee(int Id, string Name): base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.2 * salary;
		}
	}
}
