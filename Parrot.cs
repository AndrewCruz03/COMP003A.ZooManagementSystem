using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// Parrot inherits animal class
    /// </summary>
    internal class Parrot: Animal
    {
       

        public Parrot( string Name, string Species) : base(Name, Species) 
        {
           

        }
        /// <summary>
        /// Makes the sound for parrot
        /// </summary>

        public override void MakeSound() 
        {
            Console.WriteLine($"The parrot Squawksss!({Name},{Species})");

        }




    }
}
