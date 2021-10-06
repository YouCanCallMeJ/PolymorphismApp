using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismApp
{
    public partial class Form1 : Form
    {
        private List<Rectangle> rectangles = new List<Rectangle>();
        private List<Circle> circles = new List<Circle>();
        //new list for triangle
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(10, 20);
            rectangles.Add(r);
            r = new Rectangle(10, 20);
            rectangles.Add(r);
            r = new Rectangle(10, 20);
            rectangles.Add(r);
            r = new Rectangle(10, 20);
            rectangles.Add(r);
            r = new Rectangle(10, 20);
            rectangles.Add(r);

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle c = new Circle(5);
            circles.Add(c);
            c = new Circle(5);
            circles.Add(c);
            c = new Circle(5);
            circles.Add(c);
            c = new Circle(5);
            circles.Add(c);
            c = new Circle(5);
            circles.Add(c);
            c = new Circle(5);
            circles.Add(c);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (Rectangle item in rectangles)
            {
                total += item.getAreaRectangle();
            }

            foreach (Circle item in circles)
            {
                total += item.getAreaCircle();
            }

            //another loop for triangle

            MessageBox.Show("total area: " + total.ToString());

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            //create all triangle instances
        }
    }
}
