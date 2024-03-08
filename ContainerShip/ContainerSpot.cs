using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class ContainerSpot
    {
        // Variables 

        public bool Occupied { get; set; } = false; 
        public int X { get; set; } = 0; 
        public int Y { get; set; } = 0; 
        public int Z { get; set; } = 0;
        public Container container; 

        // Constructor 

        public ContainerSpot(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Methods  

        public void AddContainer(Container container)
        {
            if (!Occupied)
            {
                this.container = container;
                Occupied = true;
            }
        }
    }
}
