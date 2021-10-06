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
        private List<Figure2D> figures = new List<Figure2D>();



        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Figure2D r = new Rectangle(10, 20);
                       
            figures.Add(r);
            r = new Rectangle(10, 20);
            figures.Add(r);
            r = new Rectangle(10, 20);
            figures.Add(r);
            r = new Rectangle(10, 20);
            figures.Add(r);
            r = new Rectangle(10, 20);
            figures.Add(r);

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle c = new Circle(5);
            figures.Add(c);
            c = new Circle(5);
            figures.Add(c);
            c = new Circle(5);
            figures.Add(c);
            c = new Circle(5);
            figures.Add(c);
            c = new Circle(5);
            figures.Add(c);
            c = new Circle(5);
            figures.Add(c);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (Figure2D item in figures)
            {
                if (item is Rectangle)
                {
                    Rectangle rect = (Rectangle)item;
                    total += rect.getAreaRectangle();
                }
                else if (item is Circle)
                {
                    Circle circ = (Circle)item;
                    total += circ.getAreaCircle();
                }


            }

            MessageBox.Show("total area: " + total.ToString());

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            //create all triangle instances
        }
    }
}
