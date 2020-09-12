using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args) // Example of Nested-if-else Statement
	{
		string name,length;
		Console.WriteLine("Enter your username: ");
		name = Console.ReadLine();
		Console.WriteLine("enter length");
		length = Console.ReadLine();

		if (name == "Mahbub" && length =="6")
		{
			Console.WriteLine("Hi Mahbub!");
		}
		else if  (name.Length == 0)
		{
			Console.WriteLine("No username was entered.");
		}
		else
		{
			Console.WriteLine("The user {0},{1} has not been registered.",name,length);
		}
		Console.Read();
	}
}