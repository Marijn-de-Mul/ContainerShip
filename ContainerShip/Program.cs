using ContainerShip;

namespace ContainerShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship containerShip = new Ship(Input.Width, Input.Length);

            containerShip.Create(Input.NormalContainers, Input.CooledContainers, Input.ValuableContainers);
        }
    }
}