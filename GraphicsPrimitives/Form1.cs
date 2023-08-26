namespace GraphicsPrimitives
{
    public partial class Form1 : Form
    {
        internal Graphics gr;
        public Form1()
        {
            InitializeComponent();

            #region Graphic Region
            gr = CreateGraphics();
            Paint += MainForm_Paint;
            #endregion

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Circle circle = new(new Point(60, 70), 30)
            {
                BorderColor = Color.Magenta,
                FigureColor = Color.Green
            };

            circle.Draw(gr);

            Rectangle rectangle = new(new Point(100, 100), 30, 20)
            {
                BorderColor = Color.Brown,
                FigureColor = Color.Aqua,
            };
            rectangle.Draw(gr);


        }

    }
}