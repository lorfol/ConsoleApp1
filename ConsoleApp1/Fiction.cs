using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class FictionBook : Book
	{
		protected readonly string _fieldOfScince;

		public FictionBook(string author, string name, int pages, string fieldOfScince) : base(author, name, pages)
		{
			_fieldOfScince = fieldOfScince;
		}

		public override void Print()
		{
			Console.WriteLine($"{_author}, {_name}, {_pages}, {_fieldOfScince}");
		}
	}
}
