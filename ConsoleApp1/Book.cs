using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Book
	{
		protected readonly string _author;
		protected readonly string _name;
		protected readonly int _pages;
		//public virtual int _fieldOfScince { get; set; }

		public Book(string author, string name, int pages)
		{
			_author = author;
			_name = name;
			_pages = pages;
		}

		public Book(string author, string name)
		{
			_author = author;
			_name = name;
		}

		public Book()
		{

		}

		public string AuthorProp
		{
			get
			{
				return _author;
			}

		}

		public string NameProp
		{
			get
			{
				return _name;
			}
		}

		public int PagesProp
		{
			get
			{
				return _pages;
			}
		}

		public abstract void Print();

	}
}
