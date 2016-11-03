using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var mngr = new Manager();
			Console.WriteLine(mngr.IsValid(10));
		}
	}
}
