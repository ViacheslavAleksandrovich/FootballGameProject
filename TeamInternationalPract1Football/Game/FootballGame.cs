using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class FootballGame
	{
		public delegate void GameEvent(int NumberPlayer);
		public event GameEvent getRedKard;
		public event GameEvent TeamGoal;
		Random random = new Random();

		public FootballTeam FootballTeam1;
		public FootballTeam FootballTeam2;

		public FootballGame(FootballTeam FootballTeam1, FootballTeam FootballTeam2)
		{
			this.FootballTeam1 = FootballTeam1;
			this.FootballTeam2 = FootballTeam2;

			this.getRedKard += FootballTeam1.PlayerGetRedKard;
			this.getRedKard += FootballTeam2.PlayerGetRedKard;
		}

		public void Start()
		{
			int NumberPlayerGetRedKard;
			for(int i = 0; i <= 90; i++)
			{
				if (i == random.Next(1, 90))
				{
					if (random.Next(0,1000) % 2 == 0)
					{
						NumberPlayerGetRedKard = random.Next(1, 11);
						getRedKard(NumberPlayerGetRedKard);
						Console.WriteLine("\n" + i + " minutes " + FootballTeam1.NameTeam + " player number " + NumberPlayerGetRedKard + " GetRedKard ");
					}
					else
					{
						NumberPlayerGetRedKard = random.Next(1, 11);
						getRedKard(NumberPlayerGetRedKard);
						Console.WriteLine("\n" + i + " minutes " + FootballTeam2.NameTeam + " player number " + NumberPlayerGetRedKard + " GetRedKard ");
					}
				}
			}

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
