using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        public string LionName
        {
            get; set;

        }

        public Lion(string LionName, string Name, string Species)
        {
            LionName = LionName;
        
        }

        public override void MakeSound() 
        {
            Console.WriteLine("The Lion ROARS!!");
        
        }






    }
}
