using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using List;

namespace TeamInternationalPract1Football
{
	class FootballGame
	{
		public delegate void GameEvent(int NumberPlayer);
		public event GameEvent getRedKard;
		public event GameEvent TeamGoal;
		Random random = new Random();

		public List<FootballTeam> FootballTeam = new List<FootballTeam>(2);

		public FootballGame(FootballTeam FootballTeam1, FootballTeam FootballTeam2)
		{
			this.FootballTeam.Add(FootballTeam1);
			this.FootballTeam.Add(FootballTeam2);
		}

		public void Start()
		{
			int NumberPlayer = 0;
			int randomTeam = 0;

			for(int Minutes = 0; Minutes < 90; Minutes++)
			{ 
				if (random.Next(0, 90) == Minutes)
				{
					NumberPlayer = random.Next(1, 10);
					randomTeam = random.Next(0,1);

					if (random.Next() % 2 == 0)
					{
						Console.WriteLine("\n" + Minutes + " minutes " + FootballTeam[randomTeam].NameTeam + " player number "
							+ NumberPlayer + " GetRedKard ");
						getRedKard += FootballTeam[randomTeam].PlayerGetRedKard;
						getRedKard(NumberPlayer);
					}
					else
					{
						Console.WriteLine("\n" + Minutes + " minutes " + FootballTeam[randomTeam].NameTeam + " player number " + NumberPlayer + " Goal ");

						TeamGoal += FootballTeam[randomTeam].TeamGetGoal;
						TeamGoal(NumberPlayer);
					}
				}
				
			}

			if (FootballTeam[0].TeamGountGoals > FootballTeam[1].TeamGountGoals)
			{
				Console.WriteLine(FootballTeam[0].NameTeam + "won(" + FootballTeam[0].SkillTeam + ") " + FootballTeam[0].TeamGountGoals + " goals");
				Console.Read();
			}
			else if (FootballTeam[0].TeamGountGoals < FootballTeam[0].TeamGountGoals)
			{
				Console.WriteLine(FootballTeam[1].NameTeam + "won(" + FootballTeam[0].SkillTeam + ")" + FootballTeam[1].TeamGountGoals + " goals");
				Console.Read();
			}
			else
			{
				Console.WriteLine("Draw");
			}
		}			
	}
}
