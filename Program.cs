using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Lumberjack_Typing_Adventure;
using static System.Console;

MainMenu Menu = new MainMenu();
Menu.Start();







public class MainMenu : Menu
{
	public void Start()
	{
		string[] mainMenuOptions = { "F. New Game", "J. Info", "Space . Exit" };
		Menu MainMenu = new Menu();
		MainMenu.Options = mainMenuOptions;
		MainMenu.Prompt = "Lumberjack ";
		MainMenu.DisplayOptions();


		ConsoleKeyInfo selection = ReadKey();

		if (selection.Key == ConsoleKey.F)
		{
			Game game = new Game();
			game.Run();
			

		}
		else if (selection.Key == ConsoleKey.J)
		{
			Clear();
			WriteLine("\nHere's some information");
			ReadKey();
		}
		else if (selection.Key == ConsoleKey.Spacebar)
		{
			Clear();
			WriteLine("Goodbye!");
			Environment.Exit(0);
		}
	}
}


