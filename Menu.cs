using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
			Clear();

			WriteLine(Prompt);
			for (int i = 0; i < Options.Length; i++)
			{
				string currentOption = Options[i];
				WriteLine(currentOption);
			}

		}
	}


	public class MainMenu
	{
		public void Start()
		{
			Menu MainMenu = new Menu();
			MainMenu.Prompt = "Lumberjack ";
			string[] mainMenuOptions = { "F. New Game", "J. Info", "Space. Exit" };
			MainMenu.Options = mainMenuOptions;
			MainMenu.DisplayOptions();


			ConsoleKeyInfo selection = ReadKey();
			switch (selection.Key) 
			{
				case ConsoleKey.F:
					Game game = new Game();
					game.Start();
					break;

				case ConsoleKey.J:
					informationMenu informationMenu = new informationMenu();
					informationMenu.Start();
					break;

				case ConsoleKey.Spacebar:
					Clear();
					WriteLine("Goodbye!");
					Environment.Exit(0);
					break;
			}
		}
	}

	public class informationMenu
	{
		public void Start()
		{
			Menu informationMenu = new Menu();
			informationMenu.Prompt = "Here's some information ";
			string[] menuOptions = { "press any key to return to main menu" };
			informationMenu.Options = menuOptions;
			informationMenu.DisplayOptions();

			ReadKey();

			MainMenu mainMenu = new MainMenu();
			mainMenu.Start();

		}
	}

	
}
