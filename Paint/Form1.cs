using System.Drawing.Imaging;

namespace Paint
{
    public partial class Paint : Form
    {

        Graphics graphics;
        Bitmap bitmap;

        Pen pen = new Pen(Color.Black, 3);
        Pen erase = new Pen(Color.White, 20);

        Point startP;
        Point currentP;

        bool isPaint = false;

        int drawingToolIndex = 1;

        int startX, startY, currentX, currentY, widthX, heightY;

        public Paint()
        {
            InitializeComponent();

            bitmap = new Bitmap(canvas.Width, canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            canvas.Image = bitmap;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void color_Click(object sender, EventArgs e)
        {
            PictureBox colorPicker = (PictureBox)sender;
            pen.Color = colorPicker.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            startP = e.Location;

            startX = e.X;
            startY = e.Y;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                if (drawingToolIndex == 1)
                {
                    currentP = e.Location;
                    graphics.DrawLine(pen, startP, currentP);
                    startP = currentP;
                }
                if (drawingToolIndex == 0)
                {
                    currentP = e.Location;
                    graphics.DrawLine(erase, startP, currentP);
                    startP = currentP;
                }

            }

            canvas.Refresh();

            currentX = e.X;
            currentY = e.Y;
            widthX = currentX - startX;
            heightY = currentY - startY;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;

            currentX = e.X;
            currentY = e.Y;
            widthX = currentX - startX;
            heightY = currentY - startY;

            if (drawingToolIndex == 2)
            {
                graphics.DrawLine(pen, startX, startY, currentX, currentY);
            }
            if (drawingToolIndex == 3)
            {
                Rectangle rectangle = new Rectangle(
                    Math.Min(startX, currentX),
                    Math.Min(startY, currentY),
                    Math.Abs(widthX), 
                    Math.Abs(heightY));
                graphics.DrawRectangle(pen, rectangle);
            }
            if(drawingToolIndex == 4)
            {
                Rectangle rectangle = new Rectangle(startX, startY, widthX, heightY);
                graphics.DrawEllipse(pen, rectangle);
            }

            canvas.Refresh();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;

            if (isPaint)
            {
                if (drawingToolIndex == 2)
                {
                    graph.DrawLine(pen, startX, startY, currentX, currentY);
                }
                if (drawingToolIndex == 3)
                {
                    Rectangle rectangle = new Rectangle(
                        Math.Min(startX,currentX), 
                        Math.Min(startY, currentY), 
                        Math.Abs(widthX), 
                        Math.Abs(heightY));
                    graph.DrawRectangle(pen, rectangle);
                }
                if (drawingToolIndex == 4)
                {
                    Rectangle rectangle = new Rectangle(startX, startY, widthX, heightY);
                    graph.DrawEllipse(pen, rectangle);
                }
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            drawingToolIndex = 1;
            pen.Color = Color.Black;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Image(*.jpg) | *.jpg";
            saveFileDialog.ShowDialog();

            bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            drawingToolIndex = 1;
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            drawingToolIndex = 0;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            drawingToolIndex = 2;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            drawingToolIndex = 3;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            drawingToolIndex = 4;
        }
    }
}