using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Manager
    {
		public bool IsValid(short number)
		{
			if (number < 100)
				return true;
			else
				return false;
		}
    }
}
