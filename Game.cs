using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
	public class Game
	{
		public void Run()
		{
			Clear();
			Prompt prompt = new Prompt();
			string currentPrompt = prompt.RandomSingleWord();
			WriteLine(currentPrompt);
			if (currentPrompt == ReadLine())
			{
				Console.WriteLine("Pass");
			}
			else
			{ Console.WriteLine("Wrong"); }

			ReadLine();
		}

	}
}
