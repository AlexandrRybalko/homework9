using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Builder
{
    public class BrickHouseBuilder : HouseBuilder
    {
        public override void BuildFloor()
        {
            this.House.Floor = new Floor();
        }
        public override void BuildWalls()
        {
            this.House.Walls = new Walls() { Sort = "Brick" };
        }
        public override void BuildRoof()
        {
            this.House.Roof = new Roof() { Material = "Wood" };
        }
    }
}
