using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
	public class Animal
	{
		public enum PointSize
		{
			small = 1,
			medium = 3,
			large = 5,

		}

		public string Name { get; private set; }
		public PointSize Size { get; private set; }

		public bool EatsMeat { get; private set; }



		public Animal(string name, PointSize size, bool eatsMeat)
		{
			Name = name;
			Size = size;
			EatsMeat = eatsMeat;
		}

	}
}
