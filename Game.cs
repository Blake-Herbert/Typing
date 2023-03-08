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
			Clear();
			Prompt prompt = new Prompt();
			string currentPrompt = prompt.RandomSingleWord();
			WriteLine(currentPrompt);
			int score = 0;
			if (currentPrompt == ReadLine())
			{
				Clear();
				score++;
				Console.WriteLine("+1");

			}
			else
			{ Console.WriteLine(" Try Again"); }

			WriteLine(score);
			ReadLine();
			MainMenu mainmenu = new MainMenu();
			mainmenu.Start();
		}

	}
}
