using OpenClosedPrinciple.DevelopmentStages;
using System;

namespace OpenClosedPrinciple
{
	class Program
	{
		// OpenClosed Principle states that software entities such as class/funtion/modules should be 
		// open for extension but closed for modification

		// Which means any new funtionality should be implemented by adding new classes, attributes and methods instead of changing
		// current existing ones

		// Implementation guidelines
		// 1. Implement new funtionality on derived classes that inherit original implementation.
		// 2. Allow client to access the original class with an abstract interface. 
		static void Main(string[] args)
		{
			// 1. Initial stage
			//Stage1Employee emp1 = new Stage1Employee(1, "Anuj");
			//Console.WriteLine("Employee : " + emp1.Name + " Bonus is : " + emp1.CalculateBonus(20000));

			// 2. Calculate bonus for Permananent employee and contract employee differs
			//  Not following open closed principle 
			// We have changed the method for modification and for new req we'll continue doing so
			//Stage2Employee emp1 = new Stage2Employee(1, "Anuj", "Permanent");
			//Stage2Employee emp2 = new Stage2Employee(1, "Vivek", "Contract");

			//Console.WriteLine("Employee : " + emp1.Name + " Bonus is : " + emp1.CalculateBonus(20000));
			//Console.WriteLine("Employee : " + emp2.Name + " Bonus is : " + emp2.CalculateBonus(20000));

			// 3. 
			Employee emp1 = new ContractEmployee(1, "Ajay");
			Employee emp2 = new PermanentEmployee(2, "Anuj");

			Console.WriteLine(emp1.ToString() + emp1.CalculateBonus(20000));
			Console.WriteLine(emp2.ToString() + emp2.CalculateBonus(20000));
		}
	}
}
