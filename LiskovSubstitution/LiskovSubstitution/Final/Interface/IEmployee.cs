using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Final.Interface
{
	interface IEmployee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int GetMinimumSalary();
	}
}
