using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
	public class Wagon
	{
		private int TotalCapacity = 10;
		//public readonly List<Animal> Animals;
        public List<Animal> Animals { get; private set; }

        public Wagon()
		{
			Animals = new List<Animal>();
			
		}

		public bool TryAddAnimal(Animal newAnimal)
		{
			if (EnoughRoomForAnimal(newAnimal) && IsFriendlyAnimal(newAnimal))
			{
				Animals.Add(newAnimal);
				return true;
			}
			return false;
		}

		public bool EnoughRoomForAnimal(Animal newAnimal)
		{
			return Animals.Sum(a => (int)a.Size) + (int)newAnimal.Size <= TotalCapacity;
		}

		public bool IsFriendlyAnimal(Animal newAnimal)
		{
			foreach (var animal in Animals)
			{
				if (newAnimal.EatsMeat)
				{
					if ((int)newAnimal.Size >= (int)animal.Size)
					{
						return false;
					}
					else
					{
						if (animal.EatsMeat && (int)newAnimal.Size <= (int)animal.Size)
						{
							return false;
						}	
					}
				}
			}
			return true;
		}
	}
}

