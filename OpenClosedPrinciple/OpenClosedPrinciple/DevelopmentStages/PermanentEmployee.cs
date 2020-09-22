using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class PermanentEmployee : Employee
	{
		public PermanentEmployee(int Id, string Name) : base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.5 * salary;
		}

	}
}
