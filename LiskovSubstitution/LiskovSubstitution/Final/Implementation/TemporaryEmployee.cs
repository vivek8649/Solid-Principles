﻿using LiskovSubstitution.Final.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Final.Implementation
{
	class TemporaryEmployee : IEmployee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public TemporaryEmployee(int id, string Name)
		{
			this.Id = id;
			this.Name = Name;
		}

		public override string ToString()
		{
			return string.Format("Id : {0} Name : {1} ", this.Id, this.Name);
		}
		public int GetMinimumSalary()
		{
			return 10000;
		}
	}
}
