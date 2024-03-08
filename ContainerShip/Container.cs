using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class Container
    {
        // Variables 

        public Enums.ContainerType Type { get; set; }
        public int Weight { get; set; } = 0; 

        // Constructor 

        public Container(Enums.ContainerType type, int weight) 
        {
            Type = type; 
            Weight = weight; 
        }

        // Methods 
        
    
    }
}
