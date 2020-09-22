using OpenClosedPrinciple.DevelopmentStages;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.StageDevelopment.Stage2
{
	class Stage2TemporaryEmployee: Stage2Employee
	{
		public Stage2TemporaryEmployee(int Id, string Name) : base(Id, Name)
		{
		}

		public override double CalculateBonus(int salary)
		{
			throw new NotImplementedException();
		}
	}
}
