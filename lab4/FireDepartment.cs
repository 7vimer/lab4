﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
	internal class FireDepartment : IObserver
	{
		public void Signal()
		{
			Console.WriteLine("Пожарные вызваны");
		}
	}
}
