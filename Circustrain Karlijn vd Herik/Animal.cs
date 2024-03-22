using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
	public enum AnimalSize
	{
		Small = 1,
		Medium = 3,
		Large = 5,
	}

	public class Animal
	{
		public string Name { get; private set; }
		public AnimalSize Size { get; private set; }
		public bool EatsMeat { get; private set; }

		public Animal(AnimalSize size, bool eatsMeat) : this("", size, eatsMeat)
		{	
		}

		public Animal(string name, AnimalSize size, bool eatsMeat)
		{
			if (string.IsNullOrEmpty(name)) Name = GenerateName();
			else Name = name;
			Size = size;
			EatsMeat = eatsMeat;
		}

		public override string? ToString()
		{
			return GenerateName();
		}

		private string GenerateName()
		{
			return EatsMeat ? $"VleesEter{Size}" : $"PlantEter{Size}";
		}
	}
}
