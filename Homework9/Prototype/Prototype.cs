using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Prototype
{
    public class Prototype
    {
        public static void F()
        {
            ITransport figure = new Plane(40000);
            ITransport clonedFigure = figure.Clone();

            figure = new Car(30);
            clonedFigure = figure.Clone();

            Console.ReadLine();
        }
    }

    interface ITransport
    {
        ITransport Clone();
    }

    class Plane : ITransport
    {
        int MaxAltitude;
        public Plane(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public ITransport Clone()
        {
            return new Plane(this.MaxAltitude);
        }

    }

    class Car : ITransport
    {
        int HorsePowers;
        public Car(int horsePowers)
        {
            HorsePowers = horsePowers;
        }

        public ITransport Clone()
        {
            return new Car(this.HorsePowers);
        }
    }
}
