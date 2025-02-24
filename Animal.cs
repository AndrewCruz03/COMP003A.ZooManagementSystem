using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    


    abstract class Animal      
    {
        private string _name;
        private string _species;

        /// <summary>
        /// get and set used for animal name
        /// </summary>
        public string Name            
        { 
            get { return _name; }
            set 
            { 
            if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name is required");   
            }
        }

        /// <summary>
        /// get and set animal species
        /// </summary>
        public string Species           
        { 
            get { return _species; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Species must be identified."); 
            }
        }

        public abstract void MakeSound();

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }


    }
}
