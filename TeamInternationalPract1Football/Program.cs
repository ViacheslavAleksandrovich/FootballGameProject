using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalPract1Football
{
	class Program
	{
		static void Main(string[] args)
		{
			FootballTeam footballTeam1 = new FootballTeam("Readmadrid");
			FootballTeam footballTeam2 = new FootballTeam("Chelsy");

			footballTeam1.AddTrainer("TrainerReadMadrid", 40,"Trainer", "Men", 100);
			footballTeam1.AddManager("Max", 23, "Manager", "Men", 55);
			footballTeam1.AddManager("Nika", 21, "Manager", "Women", 60);
			footballTeam2.AddTrainer("TrainerChelsy", 35, "Trainer", "Man", 80);
			footballTeam2.AddManager("Alina", 20, "Manager", "Women", 70);
			footballTeam2.AddManager("Nastya", 22, "Manager", "Woman", 100);

			footballTeam1.DisplayInformationTeam();
			footballTeam2.DisplayInformationTeam();

			FootballGame game = new FootballGame(footballTeam1, footballTeam2);
			game.Start();

			Console.Read();
		}
	}
}
