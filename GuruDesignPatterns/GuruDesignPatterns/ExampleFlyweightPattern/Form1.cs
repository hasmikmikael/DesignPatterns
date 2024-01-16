using ExampleFlyweightPattern.Forests;
using ExampleFlyweightPattern.Trees;

namespace ExampleFlyweightPattern
{
    public partial class Form1 : Form
    {

        static int CANVAS_SIZE = 500;
        static int TREES_TO_DRAW = 1000000; //1000;
        static int TREE_TYPES = 2;

        public Form1()
        {
            InitializeComponent();

            TextBox textBoxExt = new TextBox();
            textBoxExt.Width = CANVAS_SIZE;

            textBoxExt.Text = $"{TREES_TO_DRAW} trees drawn " +
                              $"---------------------" +
                              $"Memory usage:" +
                              $"Tree size (8 bytes) * {TREES_TO_DRAW}" +
                              $"+ TreeTypes size (~30 bytes) * {TREE_TYPES}" +
                              $"---------------------" +
                              $"Total: {((TREES_TO_DRAW * 8 + TREE_TYPES * 30) / 1024 / 1024)} MB (instead of {((TREES_TO_DRAW * 38) / 1024 / 1024)} MB)";
            
            this.Controls.Add(textBoxExt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Forest forest = new Forest();
            Random random = new Random();

            for (int i = 0; i < Math.Floor((double)TREES_TO_DRAW / TREE_TYPES); i++)
            {
                forest.PlantTree(random.Next(0, CANVAS_SIZE + 1), random.Next(0, CANVAS_SIZE + 1),
                    "Summer Oak", Color.Green, "Oak texture stub");
                forest.PlantTree(random.Next(0, CANVAS_SIZE + 1), random.Next(0, CANVAS_SIZE + 1),
                    "Autumn Oak", Color.Orange, "Autumn Oak texture stub");
            }

            forest.Size = new System.Drawing.Size(CANVAS_SIZE, CANVAS_SIZE);
            forest.Visible = true;
        }
    }
}