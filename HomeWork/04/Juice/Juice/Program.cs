using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice
{
    [Flags]
    enum Containers
    {
        TwentyLiters = 0x1,
        FiveLiters = 0x1 << 1,
        OneLiters = 0x1 << 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much juice (in liters) do I need to pack?");
            double litersJuice = double.Parse(Console.ReadLine());

            var counterContainers = new int[3];

            counterContainers[0] = (int)Math.Floor(litersJuice / 20d);
            litersJuice -= 20 * counterContainers[0];

            counterContainers[1] = (int)Math.Floor(litersJuice / 5d);
            litersJuice -= 5 * counterContainers[1];
            counterContainers[2] = (int)Math.Ceiling((litersJuice / 1d));
            var container =(Containers[])Enum.GetValues(typeof(Containers));
            for (int i = 0; i < counterContainers.Length; i++)
            {
                if (counterContainers[i] != 0)
                Console.WriteLine($"{container[i]} - {counterContainers[i]}");
            }
            Console.ReadKey();




        }
    }
}
