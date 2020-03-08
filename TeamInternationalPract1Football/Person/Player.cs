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
		public bool RedKard;
		public int CountGoals { get; set; }
		public Player(string Name,int Age,string Gender,string Status, int Skill , int NumberPlayer,bool RedKard) : base(Name,Age, Status, Gender)
		{
			this.Skill = Skill;
			this.NumberPlayer = NumberPlayer;
			this.RedKard = RedKard;
		}
		protected override void DisplayInform()
		{
			Console.WriteLine($"Name Player " + this.Name + " Gender " + this.Gender + " Age " + this.Age + " Status " + this.Status
				+ " NumberPlayer " + this.NumberPlayer + " CountCoals " + this.CountGoals);
		}

	}
}
