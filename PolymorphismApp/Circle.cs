using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Circle : Figure2D
    {
        private int radius;
        

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * radius * radius;
        }

        
    }
}
