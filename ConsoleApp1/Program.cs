using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Library";
			Console.CursorVisible = false;

			Book t = new TechnicalBook("Richter", "Via C#", 1000, "technical");
			Book f = new FictionBook("Jiliasny", "Travel to Mordor", 320, "fiction");
			Book f1 = new FictionBook("Garison", "Steel Rat", 400, "fiction");
			Book f2 = new FictionBook("Doil", "Poison Belt", 240, "fiction");
			Book t1 = new TechnicalBook("Troelsen", "Programing on C#", 900, "technical");
			Book t2 = new FictionBook("Pushkin", "Sbornik Skazok", 340, "fiction");
			Book t3 = new FictionBook("Gogol", "Mertvie dushi", 120, "fiction");
			Book t4 = new TechnicalBook("Stroustrup", "C++", 2014, "technical");


			Library.AddBook(t, t1, t2, t3, t4, f, f1, f2);
			Library.AddBook(new TechnicalBook("Bears", "Game gesign", 750, "technical"));


			Menu.ShowMenu();
		}
	}
}
