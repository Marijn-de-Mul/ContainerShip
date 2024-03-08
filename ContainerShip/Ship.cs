using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class Ship
    {
        // Variables 

        public List<Container> containers = new List<Container>(); 
        public List<ContainerSpot> containerSpots = new List<ContainerSpot>();

        public int Width { get; set; } = 0;
        public int Length { get; set; } = 0;

        // Constructor 

        public Ship(int width, int length)
        {
            Width = width;
            Length = length;
        }

        // Methods 

        public void Create(int normalContainers, int cooledContainers, int valueableContainers)
        {
            containers = CreateContainerList(normalContainers, cooledContainers, valueableContainers);
            containerSpots = CreateContainerSpotList();

            LoadShip();

            ShowContainerLayoutAndContainerTotal(); 
        }
        
        public void LoadShip()
        {
            foreach (Container container in containers)
            {
                foreach (ContainerSpot containerSpot in containerSpots)
                {
                    if (!containerSpot.Occupied)
                    {
                        if (container.Type == Enums.ContainerType.Normal)
                        {
                            containerSpot.AddContainer(container);
                            break;
                        } 
                    }
                }
            }
        }

        public List<ContainerSpot> CreateContainerSpotList()
        {
            List<ContainerSpot> containerSpots = new List<ContainerSpot>();

            int x = 0;
            int y = 0;
            int z = 0;

            for (int i = 0; i < (Width * Length * Input.MaxStackedContainers); i++)
            {
                if (x == Width)
                {
                    x = 0;
                    y++;
                }

                if (y == Length)
                {
                    y = 0;
                    z++;
                }

                containerSpots.Add(new ContainerSpot(x, y, z));

                x++;
            }

            return containerSpots; 
        }

        private List<Container> CreateContainerList(int normalContainers, int cooledContainers, int valueableContainers)
        {
            List<Container> containers = new List<Container>();

            AddContainer(containers, normalContainers, Enums.ContainerType.Normal, 4000);
            AddContainer(containers, cooledContainers, Enums.ContainerType.Cooled, 4000);
            AddContainer(containers, valueableContainers, Enums.ContainerType.Valuable, 4000);

            return containers;
        }

        private void AddContainer(List<Container> containers, int amount, Enums.ContainerType type, int weight)
        {
            for (int i = 0; i < amount; i++)
            {
                containers.Add(new Container(type, weight));
            }
        }

        public void ShowContainerLayoutAndContainerTotal()
        {
            foreach (ContainerSpot containerSpot in containerSpots)
            {
                if (containerSpot.Occupied)
                {
                    Console.WriteLine($"[X] Container | Type: {containerSpot.container.Type} | Spot: X: {containerSpot.X} Y: {containerSpot.Y} Z: {containerSpot.Z}.");
                } 
                else
                {
                    Console.WriteLine($"[0] Container | Type: None. | Spot: X: {containerSpot.X} Y: {containerSpot.Y} Z: {containerSpot.Z}."); 
                }
            } 

            if (containers.Count > containerSpots.Count)
            {
                Console.WriteLine($"There are {containers.Count - containerSpots.Count} containers that could not be placed on the ship.");
            }
            else
            {
                Console.WriteLine($"All containers have been placed on the ship.");
            }
        }   
    }
}
