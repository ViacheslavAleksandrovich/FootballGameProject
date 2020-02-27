using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class FootballTeam
	{
		public string NameTeam;
		public List<Player> Team;
		public Trainer trainer;
		public Maneger maneger;
		public int SkillTeam;
		Random random = new Random();
		public FootballTeam(string NameTeam)
		{
			Team = new List<Player>(11);
			trainer = new Trainer("Shevcenko",40,"Man","Trainer", random.Next(50, 100));
			maneger = new Maneger("Maneger1",20,"Man","Maneger", random.Next(25, 50));
			this.NameTeam = NameTeam;
			for(int i = 1;i <= 11;i++)
			{
				
				Team.Add(person);
				foreach (var SkillPlayer in Team)
				{
					SkillTeam += SkillPlayer.Skill;
				}
			}
		}
	}
}
