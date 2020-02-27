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

		public FootballGame(string TeamName1,string TeamName2)
		{
			FootballTeam1 = new FootballTeam(TeamName1);
			FootballTeam2 = new FootballTeam(TeamName2);
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
