using System;
using System.Drawing;
using System.Windows.Forms;

namespace CanvasApplication
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point startPoint;
        private Bitmap drawingBitmap;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

            // Initializing a Bitmap to draw on
            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            pictureBox1.Image = drawingBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                // Drawing line from startPoint to current mouse position
                graphics.DrawLine(Pens.Black, startPoint, e.Location);
                startPoint = e.Location; 
                pictureBox1.Invalidate(); 
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
