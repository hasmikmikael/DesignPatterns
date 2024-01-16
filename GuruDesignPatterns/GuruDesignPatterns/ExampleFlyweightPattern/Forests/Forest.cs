using ExampleFlyweightPattern.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFlyweightPattern.Forests
{
    public class Forest : Form
    {
        private List<Tree> trees = new List<Tree>();

        public void PlantTree(int x, int y, string name, Color color, string otherTreeData)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, otherTreeData);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Tree tree in trees)
            {
                tree.Draw(e.Graphics);
            }
        }
    }
}
