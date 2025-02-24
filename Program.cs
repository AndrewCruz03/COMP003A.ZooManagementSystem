// Author: Andrew Cruz
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo Managemnet System!");


            List<Animal> animals = new List<Animal>(); 


            while (true) 
            {
                int menuSelection = 0;

                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4.Describe an Animal");
                Console.WriteLine("5.Exit\n");
                Console.Write("Your choice:");


                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception) 
                {
                    throw;
                }



                if (menuSelection == 1) 
                {
                    Console.Write("Enter the name of the lion:");
                    string name = Console.ReadLine();
                    Console.Write("Enter the species of the lion:");
                    string species = Console.ReadLine();    
                    //
                    animals.Add(new Lion(name, species));    
                    Console.WriteLine("\nLion added successfully!\n");
                }





                if (menuSelection == 2) 
                {
                    Console.Write("Enter the name of the parrot:");
                    string name = Console.ReadLine();
                    Console.Write("Enter the species of the parrot:");
                    string species = Console.ReadLine();
                    //
                    animals.Add(new Parrot(name, species));      
                    Console.WriteLine("\nParrot added successfully!\n");
                }

                if (menuSelection == 3) 
                {
                    Console.WriteLine("Displaying all animals:");
                    foreach (var animal in animals)
                    {
                        Console.WriteLine($"{animal.Name},{animal.Species}");
                        animal.MakeSound();
                    }
                
                }

                if (menuSelection == 4) 
                {
                    Console.Write("Describe Animal (name only):");
                    Console.ReadLine();
                }

                if (menuSelection == 5) 
                {
                    Console.WriteLine("\n GoodBye!");
                    break;
                }





            }





            



        }
    }
}
