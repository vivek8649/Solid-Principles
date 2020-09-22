using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage2ContractEmployee : Stage2Employee
	{
		public Stage2ContractEmployee(int Id, string Name): base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.2 * salary;
		}
	}
}
