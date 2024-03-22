// See https://aka.ms/new-console-template for more information
namespace Circustrain_Karlijn_vd_Herik
{
	internal class Program
	{
        static void Main(string[] args)
        {
            TrainManagement trainManagement = new TrainManagement();


            Console.WriteLine("Hello! Would you like to add an animal to the list? (Y/N)");
            string answer = Console.ReadLine();

            List<Animal> animalsToAdd = new List<Animal>(); 

            while (answer.ToUpper() == "Y")
            {
                Console.WriteLine("Please enter the name of the animal (press enter to for default name):");
                string name = Console.ReadLine();

                Console.WriteLine("Is the animal's diet meat based or plant based? (M/P)");
                string dietInput = Console.ReadLine();
                bool eatsMeat = (dietInput.ToUpper() == "M");

                Console.WriteLine("What is the size of the animal? (Small/Medium/Large - S/M/L)");
                string sizeInput = Console.ReadLine();
                AnimalSize size = AnimalSize.Small;
                if (sizeInput.ToUpper() == "M")
                    size = AnimalSize.Medium;
                else if (sizeInput.ToUpper() == "L")
                    size = AnimalSize.Large;

                Animal newAnimal = new Animal(name, size, eatsMeat);
                
                animalsToAdd.Add(newAnimal);

                Console.WriteLine("Animal added to the list!");

                Console.WriteLine("Do you want to add another animal to the list? If you press N all animals will be added to the train. (Y/N)");
                answer = Console.ReadLine();
            }

            Console.WriteLine("These are all the animals in the train sorted by size and their diet: ");

            trainManagement.AddAnimalsToTrain(animalsToAdd);
        }    
	}
}
