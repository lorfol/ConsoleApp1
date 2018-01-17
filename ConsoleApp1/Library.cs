using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	static class Library
	{
		static List<Book> listOfBooks;

		static Library()
		{
			listOfBooks = new List<Book>();
		}

		public static void AddBook(params Book[] book)
		{
			for (int i = 0; i < book.Length; i++)
			{
				listOfBooks.Add(book[i]);
			}
		}

		public static void PrintAllBooks()
		{
			Console.Clear();
			foreach (var item in listOfBooks)
			{
				Console.WriteLine($"{item.AuthorProp}, {item.NameProp}, {item.PagesProp}"); // добавить возможность вывода жанра
			}
			Console.ReadKey();
		}

		public static void Print(Book book)
		{
			Console.Clear();
			if (book is TechnicalBook)
				Console.WriteLine("Tech");
			else if(book is FictionBook)
				Console.WriteLine("FictionBook");

			Console.ReadKey();
		}

		public static void PrintTechBooks()
		{
			Console.Clear();
			foreach (var item in listOfBooks)
			{
				if (item is TechnicalBook)
					Console.WriteLine($"{item.AuthorProp}, {item.NameProp}, {item.PagesProp}"); // добавить возможность вывода жанра
			}
			Console.ReadKey();
		}

		public static void PrintFicBooks()
		{
			Console.Clear();

			foreach (var item in listOfBooks)
			{
				if (item is FictionBook)
					Console.WriteLine($"{item.AuthorProp}, {item.NameProp}, {item.PagesProp}"); // добавить возможность вывода жанра
			}

			Console.ReadKey();
		}

		public static void SortByAuthor()
		{
			//var sortedBooks = from Book in listOfBooks
			//				  orderby Book.AuthorProp
			//				  select Book;
				

			listOfBooks.Sort((a, b) => a.AuthorProp.CompareTo(b.AuthorProp));

			Console.WriteLine("Library sorted by \'Author\'.");



			PrintAllBooks();
		}

		public static void SortByName()
		{
			listOfBooks.Sort((a, b) => a.NameProp.CompareTo(b.NameProp));

			Console.WriteLine("Library sorted by \'Name\'.");

			PrintAllBooks();
		}
	}
}
