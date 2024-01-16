using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFlyweightPattern.Trees
{
    public class TreeType
    {
        private string name;
        private Color color;
        private string otherTreeData;

        public TreeType(string name, Color color, string otherTreeData)
        {
            this.name = name;
            this.color = color;
            this.otherTreeData = otherTreeData;
        }

        public void Draw(Graphics g, int x, int y) 
        {
            g.FillRectangle(Brushes.Black, x - 1, y, 3, 5);
            g.FillEllipse(new SolidBrush(color), x - 5, y - 10, 10, 10);
        }
    }
}
