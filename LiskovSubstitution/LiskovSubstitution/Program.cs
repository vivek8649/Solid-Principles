using LiskovSubstitution.Final.Implementation;
using LiskovSubstitution.Final.Interface;
using LiskovSubstitution.StageDevelopment.Final.Abstract;
using LiskovSubstitution.StageDevelopment.Stage2;
using OpenClosedPrinciple.DevelopmentStages;
using System;
using System.Collections.Generic;

namespace LiskovSubstitution
{
	class Program
	{
		// Liskov substitution principle 

		//	Substitutability is a principle in object-oriented programming and it states that, in a computer program,
		//	if S is a Subtype of T, then objects of type T may be replaced with objects of type S

		// Which means, Derived types must be completely substitutable for their base types

		// 1. No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.

		// 2. We should also ensure that Clients should not know which specific subtype they are calling, 
		//	  nor should they need to know that.The client should behave the same regardless of the subtype instance that it is given.

		// 3. And last but not the least, New derived classes just extend without replacing the functionality of old classes

		static void Main(string[] args)
		{
			// 1. Partially adhering to liskov substitution as we are using subtype in place of base
			//Stage1Employee emp1 = new Stage1ContractEmployee(1, "Ajay");
			//Stage1Employee emp2 = new Stage1PermanentEmployee(2, "Anuj");

			//Console.WriteLine(emp1.ToString() + emp1.CalculateBonus(20000));
			//Console.WriteLine(emp2.ToString() + emp2.CalculateBonus(20000));

			//Console.WriteLine("Hello World!");

			// 2. Adding another temp employee
			// No new exception should be thrown but throwing 
			//Stage2Employee emp1 = new Stage2ContractEmployee(1, "Ajay");
			//Stage2Employee emp2 = new Stage2PermanentEmployee(2, "Anuj");
			//Stage2Employee emp3 = new Stage2TemporaryEmployee(2, "Vivek");

			//Console.WriteLine(emp1.ToString() + emp1.CalculateBonus(20000));
			//Console.WriteLine(emp2.ToString() + emp2.CalculateBonus(20000));
			//Console.WriteLine(emp3.ToString() + emp3.CalculateBonus(20000)); // No new exception can be thrown by subtype

			// 3. Final 

			//Employee emp1 = new ContractEmployee(1, "Ajay");
			//Employee emp2 = new PermanentEmployee(2, "Anuj");
			//Employee emp3 = new TemporaryEmployee(2, "Vivek"); // unable to cast

			IEmployee emp1 = new ContractEmployee(1, "Ajay");
			IEmployee emp2 = new PermanentEmployee(2, "Anuj");
			IEmployee emp3 = new TemporaryEmployee(2, "Vivek"); 

			List<IEmployee> employeeList = new List<IEmployee>();
			employeeList.Add(emp1);
			employeeList.Add(emp2);
			employeeList.Add(emp3);

			foreach (var emp in employeeList)
			{
				Console.WriteLine(emp.ToString() + emp.GetMinimumSalary());
			}
		}
	}
}
