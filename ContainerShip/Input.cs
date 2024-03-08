using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public static class Input
    {
        // Weights (kg) 
        private static int maxWeightOnContainer = 120000;
        private static int fullContainerWeight = 30000; 
        private static int emptyContainerWeight = 4000; 

        // Dimensions (In containers) 
        public static int Width { get; set; } = 2; 
        public static int Length { get; set; } = 3; 

        // Containers 
        public static int NormalContainers { get; set; } = 12; 
        public static int CooledContainers { get; set; } = 6;
        public static int ValuableContainers { get; set; } = 6;
        public static int MaxStackedContainers { get; set; } = 4;
    }
}
