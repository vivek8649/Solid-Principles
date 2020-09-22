using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage1PermanentEmployee : Stage1Employee
	{
		public Stage1PermanentEmployee(int Id, string Name) : base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.5 * salary;
		}

	}
}
