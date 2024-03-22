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
		
        public List<Animal> Animals { get; set; }

        public Wagon(List<Animal> animals = null)
		{
			Animals = animals ?? new List<Animal>();	
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
                // Als het nieuwe dier vlees eet
                if (newAnimal.EatsMeat)
                {
                    // Als het andere dier ook vlees eet en van dezelfde grootte is, is het niet vriendelijk
                    if (animal.EatsMeat && newAnimal.Size == animal.Size)
                    {
                        return false;
                    }
                }
                // Als het nieuwe dier plantaardig eet
                else
                {
                    // Als het andere dier vlees eet en van dezelfde grootte is, is het niet vriendelijk
                    if (animal.EatsMeat && newAnimal.Size == animal.Size)
                    {
                        return false;
                    }

                    // Als het andere dier vlees eet en groter is, is het niet vriendelijk
                    if (animal.EatsMeat && newAnimal.Size < animal.Size)
                    {
                        return false;
                    }
                }
            }
			return true;
		}
	}
}

