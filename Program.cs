using Lumberjack_Typing_Adventure;
using static System.Console;

MainMenu();
ConsoleKeyInfo selection = ReadKey();



if (selection.Key == ConsoleKey.F)
{
	Clear();
	WriteLine("Keep practicing!");
	ReadKey();
}
else if (selection.Key == ConsoleKey.J)
{
	Clear();
	WriteLine("\nHere's some information");
	ReadKey();
}
else if (selection.Key == ConsoleKey.Spacebar)
{
	WriteLine("Goodbye!");
	Environment.Exit(0);
}





void MainMenu()
{
	string[] mainMenuOptions = { "F. New Game", "J. Info", "Space . Exit" };
	Menu MainMenu = new Menu();
	MainMenu.options = mainMenuOptions;
	MainMenu.prompt = "Lumberjack ";
	MainMenu.DisplayOptions();
}