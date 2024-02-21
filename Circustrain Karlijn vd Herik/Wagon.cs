using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
	public class Wagon
	{
		private int capacity = 10;
		private List<Animal> animals;

		public Wagon()
		{
			animals = new List<Animal>();
		}

		public bool TryAddAnimal(Animal animal)
		{
			if (animals.Sum(a => (int)a.Size) + (int)animal.Size <= capacity && CanAddAnimal(animal))
			{
				animals.Add(animal);
				return true;
			}
			return false;
		}

		private bool CanAddAnimal(Animal newAnimal)
		{ 
			foreach (var animal in animals)
			{
				if (newAnimal.EatsMeat && !animal.EatsMeat && (int)newAnimal.Size <= (int)animal.Size)
				{
					return false;
				}
				if (!newAnimal.EatsMeat && animal.EatsMeat && (int)newAnimal.Size >= (int)animal.Size)
				{
					return false;
				}
			}
			return true;
		}
	}

}

