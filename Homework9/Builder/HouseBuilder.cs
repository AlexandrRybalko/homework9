using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Builder
{
    public abstract class HouseBuilder
    {
        public House House { get; private set; }
        public void CreateHouse()
        {
            House = new House();
        }
        public abstract void BuildFloor();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
    }
}
