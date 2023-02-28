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
		public string prompt;
		public string[] options;

		public void DisplayOptions()
		{
			WriteLine(prompt);
			for (int i = 0; i < options.Length; i++)
			{
				string currentOption = options[i];
				WriteLine(currentOption);
			}

		}
	}
}
