using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.DevelopmentStages
{
	class Stage2PermanentEmployee : Stage2Employee
	{
		public Stage2PermanentEmployee(int Id, string Name) : base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			return 0.5 * salary;
		}

	}
}
