using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class zooUtility
    {
        /// <summary>
        /// Animal name
        /// </summary>
        /// <param name="Name"></param>



        public static void DescribeAnimal(string Name)
        {
            Console.WriteLine($"Name: {Name}");
        }

        /// <summary>
        /// Animal name, species
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="species"></param>
        public static void DescribeAnimal(string Name, string species)
        {
            DescribeAnimal(Name);
            Console.WriteLine($"Species: {species}");
        }

        /// <summary>
        /// Animal name,sepcies, age
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="species"></param>
        /// <param name="age"></param>
        public static void DescribeAnimal(string Name, string species, int age)
        {
            DescribeAnimal(Name,species);
            Console.WriteLine($"Age: {age}");
        }


    }
}
