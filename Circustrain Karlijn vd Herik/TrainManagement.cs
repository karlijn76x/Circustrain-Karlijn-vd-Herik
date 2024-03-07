using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
	public class TrainManagement
	{
		private List<Wagon> wagons;

		public TrainManagement() 
		{ 
			wagons = new List<Wagon>();
		}

		public void AddAnimalToWagon(Animal animal)
		{
			bool added = false;

			foreach(Wagon wagon in wagons) {

				if (wagon.TryAddAnimal(animal))
				{
					added = true;
					break;
				}
			}

			if (!added)
			{
				Wagon newWagon = new Wagon();
				newWagon.TryAddAnimal(animal);
				wagons.Add(newWagon);
			}
			DisplayTrain();
		}

		public void DisplayTrain()
		{
			int wagonNumber = 1;
			foreach (var wagon in wagons)
			{
				Console.WriteLine($"Wagon {wagonNumber}:");
				foreach (var animal in wagon.Animals)
				{
					Console.WriteLine($"- {animal.Name} ({animal.Size}), Eats Meat: {animal.EatsMeat}");
				}
				Console.WriteLine();
				wagonNumber++;
			}
		}
	}
}
