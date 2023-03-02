using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
	public class Menu
	{
		public string Prompt { get; set; }
		public string[] Options { get; set; }

		public void DisplayOptions()
		{
			WriteLine(Prompt);
			for (int i = 0; i < Options.Length; i++)
			{
				string currentOption = Options[i];
				WriteLine(currentOption);
			}

		}


	}
}
