using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class Trainer:Person
	{
		int Competition;
		public Trainer(string Name, int Age, string Gender, string Status,int Competition)
		{
			this.Name = Name;
			this.Age = Age;
			this.Gender = Gender;
			this.Status = Status;
			this.Competition = Competition;
		}
	}
}
