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

        public string Name            
        { 
            get { return _name; }
            set 
            { 
            if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name is required");   
            }
        }


        public string Species           
        { 
            get { return _species; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Species must be indentifed.");// fix spelling error 
            }
        }

        public abstract void MakeSound();



    }
}
