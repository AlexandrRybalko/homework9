using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Builder
{
    public class Director
    {
        public House Build(HouseBuilder houseBuilder)
        {
            houseBuilder.CreateHouse();
            houseBuilder.BuildFloor();
            houseBuilder.BuildWalls();
            houseBuilder.BuildRoof();
            return houseBuilder.House;
        }
    }
}
