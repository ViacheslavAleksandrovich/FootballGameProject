using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class Maneger:Person
	{
		public int LuckAppTeam;
		public Maneger(string Name, int Age, string Gender, string Status, int LuckAppTeam)
		{
			this.Name = Name;
			this.Age = Age;
			this.Gender = Gender;
			this.Status = Status;
			this.LuckAppTeam = LuckAppTeam;
		}
	}
}
