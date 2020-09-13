using Homework9.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();  
            HouseBuilder builder = new WoodenHouseBuilder();        
            House woodenHouse = director.Build(builder);
            Console.WriteLine(woodenHouse.ToString());

            builder = new BrickHouseBuilder();
            House brickHouse = director.Build(builder);
            Console.WriteLine(brickHouse.ToString());

            Prototype.Prototype.F();



            Console.ReadKey();
        }
    }
}
