using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class FootballTeam
	{
		public string NameTeam = "Default";
		public List<Player> ListPlayer = new List<Player>();
		public Trainer trainer;
		public List<Maneger> ListNManeger = new List<Maneger>();
		public int SkillTeam = 0;
		Random random = new Random();
		public FootballTeam(string NameTeam)
		{
			ListPlayer = new List<Player>(11);
			this.NameTeam = NameTeam;
			for(int i = 0;i < 11;i++)
			{
				Player newPlayer = new Player(String.Format("Player ", NameTeam), random.Next(18, 25), "Men","Player", random.Next(10, 100),i);
				ListPlayer.Add(newPlayer);
			}
			foreach(var SkillPlayer in ListPlayer)
			{
				SkillTeam += SkillPlayer.Skill;
			}
		}
		public void AddTrainer(string Name,int Age,string Status,string Gender,int Competition)
		{
			trainer = new Trainer(Name, Age, Gender, Status, Competition);
			SkillTeam += trainer.Competition;
		}
		public void AddManager(string Name, int Age, string Status, string Gender, int LuckAppTeam)
		{
			Maneger maneger = new Maneger(Name, Age, Gender, Status, LuckAppTeam);
			this.ListNManeger.Add(maneger);
			foreach(var ManegersSkill in ListNManeger)
			{
				SkillTeam += ManegersSkill.LuckAppTeam;
			}
		}

		public void DisplayInformationTeam()
		{
			Console.WriteLine(this.NameTeam);
			foreach(var PlayerTeam in ListPlayer)
			{
				Console.WriteLine("{0} Age {1} {2} {3} {4} Skill {5}", PlayerTeam.Name,PlayerTeam.Age,PlayerTeam.Gender,PlayerTeam.Status,PlayerTeam.NumberPlayer,PlayerTeam.Skill);
			}

			Console.WriteLine("{0} Age {1} {2} {3} Competition {4}", trainer.Name, trainer.Age, trainer.Status, trainer.Gender, trainer.Competition);
			foreach(var Maneger in ListNManeger)
			{
				Console.WriteLine("{0} Age {1} {2} {3} LuckAppTeam {4}", Maneger.Name, Maneger.Age, Maneger.Status, Maneger.Gender, Maneger.LuckAppTeam);
			}
		}
	}
}
