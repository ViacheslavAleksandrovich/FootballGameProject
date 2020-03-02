using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class FootballGame
	{
		public FootballTeam FootballTeam1;
		public FootballTeam FootballTeam2;

		public FootballGame(FootballTeam FootballTeam1, FootballTeam FootballTeam2)
		{
			this.FootballTeam1 = FootballTeam1;
			this.FootballTeam2 = FootballTeam2;
		}

		public void Start()
		{

			if (FootballTeam1.SkillTeam > FootballTeam2.SkillTeam)
			{
				Console.WriteLine(FootballTeam1.NameTeam + "won(" + FootballTeam1.SkillTeam + ")");
			}
			else if (FootballTeam1.SkillTeam < FootballTeam2.SkillTeam)
			{
				Console.WriteLine(FootballTeam2.NameTeam + "won(" + FootballTeam2.SkillTeam + ")");
			}
			else { Console.WriteLine("Skill " + FootballTeam1.NameTeam + " == skill " + FootballTeam2.NameTeam); }
		}
	}
}
