using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Parrot: Animal
    {
        public string ParrotName
        {
            get; set;
        }

        public Parrot(string ParrotName, string Name, string Species)
        {
            ParrotName = ParrotName;

        }


        public override void MakeSound() 
        {
            Console.WriteLine("The parrot Squawksss!");

        }




    }
}
