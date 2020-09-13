using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Builder
{
    public class House
    {
        // мука
        public Walls Walls { get; set; }
        // соль
        public Floor Floor { get; set; }
        // пищевые добавки
        public Roof Roof { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Walls != null)
                sb.Append(Walls.Sort + "\n");
            if (Floor != null)
                sb.Append("Floor \n");
            if (Roof != null)
                sb.Append("Roof: " + Roof.Material + " \n");
            return sb.ToString();
        }
    }
}
