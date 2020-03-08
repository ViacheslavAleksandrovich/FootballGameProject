using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using List;

namespace TeamInternationalPract1Football
{
	class FootballTeam
	{
		public string NameTeam = "Default";
		public List<Player> ListPlayer = new List<Player>();
		public Trainer trainer;
		public List<Maneger> ListNManeger = new List<Maneger>();
		Random random = new Random();

		public int SkillTeam = 0;
		public int TeamGountGoals { get; set; }

		public FootballTeam(string NameTeam)
		{
			ListPlayer = new List<Player>(11);
			this.NameTeam = NameTeam;
			for(int i = 0;i < 11;i++)
			{
				Player newPlayer = new Player(String.Format("Player ", NameTeam), random.Next(18, 25), "Men","Player", random.Next(10, 100),i + 1,false);
				ListPlayer.Add(newPlayer);
			}
			for(int i = 0; i < ListPlayer.Count;i++)
			{
				SkillTeam += ListPlayer[i].Skill;
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
			for (int i = 0; i < ListNManeger.Count; i++)
			{
				SkillTeam += ListNManeger[i].LuckAppTeam;
			}
		}

		public void DisplayInformationTeam()
		{
			Console.WriteLine(this.NameTeam);
			for(int i = 0; i < ListPlayer.Count; i++)
			{
				Console.WriteLine("{0} Age {1} {2} {3} {4} Skill {5}", ListPlayer[i].Name, ListPlayer[i].Age, ListPlayer[i].Gender,
					ListPlayer[i].Status, ListPlayer[i].NumberPlayer, ListPlayer[i].Skill);
			}

			
			Console.WriteLine("{0} Age {1} {2} {3} Competition {4}", trainer.Name, trainer.Age, trainer.Status, trainer.Gender, trainer.Competition);
			for (int i = 0; i < ListNManeger.Count; i++)
			{
				Console.WriteLine("{0} Age {1} {2} {3} LuckAppTeam {4}", ListNManeger[i].Name, ListNManeger[i].Age,
					ListNManeger[i].Status, ListNManeger[i].Gender, ListNManeger[i].LuckAppTeam);
			}
		}

		public void PlayerGetRedKard(int NumberPlayer)
		{
			ListPlayer[NumberPlayer].RedKard = true;
			//ListPlayer.RemoveAt(NumberPlayer);
			SkillTeam -= ListPlayer[NumberPlayer].Skill;
		}

		public void TeamGetGoal(int NumberPlayer)
		{
			++ListPlayer[NumberPlayer].CountGoals;
			++TeamGountGoals;
		}
	}
}
