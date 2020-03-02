using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	abstract class Person
	{
		public string Status { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }

		public Person(string Name,int Age, string Status, string Gender)
		{
			this.Name = Name;
			this.Status = Status;
			this.Age = Age;
			this.Gender = Gender;
		}

		protected virtual void DisplayInform()
		{
			Console.WriteLine($"Name person -> " + this.Name + "Gender ->" + this.Gender + "Age -> " + this.Age + "Status -> " + this.Status);
		}
	}
}
