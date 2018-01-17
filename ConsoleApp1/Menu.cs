using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	static class Menu
	{
		public static void ShowMenu()
		{
			Console.WriteLine(@"1. List of books.
2. Technical books.
3. Fiction books.
4. Sort by author.
5. Sort by name.
6. Exit.
");
			var key = Console.ReadKey();

			switch (key.Key)
			{
				case ConsoleKey.D1:
					Library.PrintAllBooks();
					Console.Clear();
					ShowMenu();
					break;

				case ConsoleKey.D2:
					Library.PrintTechBooks();
					Console.Clear();
					ShowMenu();
					break;

				case ConsoleKey.D3:
					Library.PrintFicBooks();
					Console.Clear();
					ShowMenu();
					break;

				case ConsoleKey.D4:
					Library.SortByAuthor();
					Console.Clear();
					ShowMenu();
					break;

				case ConsoleKey.D5:
					Library.SortByName();
					Console.Clear();
					ShowMenu();
					break;

				case ConsoleKey.D6:
					Console.Clear();
					return;

				case ConsoleKey.Escape:
					Console.Clear();
					return;

				default:
					Console.Clear();
					ShowMenu();
					break;
			}
		}
	}
}
