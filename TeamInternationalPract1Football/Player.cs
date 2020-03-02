using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class Player : Person
	{
		public int Skill { get; set; }
		public int NumberPlayer { get; set; }
		public Player(string Name,int Age,string Gender,string Status, int Skill , int NumberPlayer) : base(Name,Age, Status, Gender)
		{
			this.Skill = Skill;
			this.NumberPlayer = NumberPlayer;
		}
	}
}
