using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ponto
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Ponto(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
