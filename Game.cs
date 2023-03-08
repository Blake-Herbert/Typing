using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
	public class Game
	{
		public void Start()
		{
			int score = 0;
			int rounds = 5;
			for (int i = 0; i < rounds; i++)
			{
				Clear();
				Prompt prompt = new Prompt();
				string currentPrompt = prompt.RandomSingleWord();
				WriteLine(currentPrompt);
				
				if (currentPrompt == ReadLine()) {score++; }
			}
			

			WriteLine($"You scored ({score} / {rounds})");
			WriteLine("Press any key to return to the main menu");
			ReadKey();
			MainMenu mainmenu = new MainMenu();
			mainmenu.Start();
		}

	}
}
