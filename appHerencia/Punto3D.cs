using System;
using System.Collections.Generic;
using System.Text;

namespace appHerencia
{
    class Punto3D : Punto2D
    {
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        private double distance;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public Punto3D() : base()
        {
            z = 0;
        }
        public Punto3D(double x, double y, double z) : base(x,y)
        {
            this.z = z;
        }
        public double DistanciaXY(double x, double y)
        {
            double d = x - y;
            distance = d;
            return d;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z + "\n distancia X-Y= " + distance;
        }
    }
}
