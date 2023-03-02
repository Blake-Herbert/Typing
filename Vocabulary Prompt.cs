using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
	public class Prompt
	{
		List<string> singleWordPrompts = new List<string> { "Tree", "Wood", "Chop" };

		List<string> phrasePrompts = new List<string> { "If a tree falls...", "Chop it down! Chop it with your axe!" };

		public string RandomSingleWord()

		{
			var random = new Random();
			int index = random.Next(singleWordPrompts.Count());
			return (singleWordPrompts[index]);

		}



	}
}
