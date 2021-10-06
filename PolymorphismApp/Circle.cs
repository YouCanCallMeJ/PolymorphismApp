using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Circle
    {
        private int radius;
        

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double getAreaCircle()
        {
            return Math.PI * radius * radius;
        }
    }
}
