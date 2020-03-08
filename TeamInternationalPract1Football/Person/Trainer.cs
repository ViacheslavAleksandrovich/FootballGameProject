using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class Trainer:Person
	{
		public int Competition;
		public Trainer(string Name, int Age, string Gender, string Status,int Competition):base(Name,Age,Status,Gender)
		{
			this.Competition = Competition;
		}

		protected override void DisplayInform()
		{
			Console.WriteLine($"Name Trainer " + this.Name + " Gender " + this.Gender + " Age " + this.Age + " Status " + this.Status
				+ " Competition " + this.Competition);
		}
	}
}
