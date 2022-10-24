using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_FindEven
{//找出[4, 15] 之間的所有偶數
	internal class Program
	{
		static void Main(string[] args)
		{
			int startNumber = 4;
			int endNumber = 15;

			for (int i = startNumber; i <= endNumber; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
