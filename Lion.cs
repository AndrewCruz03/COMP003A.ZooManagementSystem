using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// Lion inherits Animal
    /// </summary>
    internal class Lion : Animal
    {
        public Lion(string Name, string Species) : base(Name, Species) 
        {
            
        
        }
        /// <summary>
        /// Makes the sound for lion
        /// </summary>
        public override void MakeSound() 
        {
            Console.WriteLine($"The Lion ROARS!!({Name},{Species})");
        
        }






    }
}
