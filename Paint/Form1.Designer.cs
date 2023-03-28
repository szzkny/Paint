namespace Paint
{
    partial class Paint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.black = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.purple = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.cyan = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_erase);
            this.panel1.Controls.Add(this.btn_pen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 116);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(712, 42);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 34);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(615, 42);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 34);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Image = global::Paint.Properties.Resources.ellipse;
            this.btn_ellipse.Location = new System.Drawing.Point(540, 32);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(60, 55);
            this.btn_ellipse.TabIndex = 7;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_rectangle.Location = new System.Drawing.Point(462, 32);
            this.btn_rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(60, 55);
            this.btn_rectangle.TabIndex = 6;
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_line
            // 
            this.btn_line.Image = global::Paint.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(386, 32);
            this.btn_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(60, 55);
            this.btn_line.TabIndex = 5;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.Image = global::Paint.Properties.Resources.eraser;
            this.btn_erase.Location = new System.Drawing.Point(311, 32);
            this.btn_erase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(60, 55);
            this.btn_erase.TabIndex = 4;
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.Image = global::Paint.Properties.Resources.pen;
            this.btn_pen.Location = new System.Drawing.Point(236, 32);
            this.btn_pen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(60, 55);
            this.btn_pen.TabIndex = 3;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.black);
            this.panel2.Controls.Add(this.green);
            this.panel2.Controls.Add(this.purple);
            this.panel2.Controls.Add(this.yellow);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.orange);
            this.panel2.Controls.Add(this.cyan);
            this.panel2.Controls.Add(this.red);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 95);
            this.panel2.TabIndex = 2;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(155, 52);
            this.black.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(33, 32);
            this.black.TabIndex = 10;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.color_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(155, 13);
            this.green.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(33, 32);
            this.green.TabIndex = 9;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.color_Click);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(109, 52);
            this.purple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(33, 32);
            this.purple.TabIndex = 8;
            this.purple.TabStop = false;
            this.purple.Click += new System.EventHandler(this.color_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(109, 13);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(33, 32);
            this.yellow.TabIndex = 7;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.color_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(62, 52);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(33, 32);
            this.blue.TabIndex = 6;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.color_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(62, 13);
            this.orange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(33, 32);
            this.orange.TabIndex = 5;
            this.orange.TabStop = false;
            this.orange.Click += new System.EventHandler(this.color_Click);
            // 
            // cyan
            // 
            this.cyan.BackColor = System.Drawing.Color.Cyan;
            this.cyan.Location = new System.Drawing.Point(14, 52);
            this.cyan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(33, 32);
            this.cyan.TabIndex = 4;
            this.cyan.TabStop = false;
            this.cyan.Click += new System.EventHandler(this.color_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(14, 13);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(33, 32);
            this.red.TabIndex = 3;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.color_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 116);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(805, 451);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Paint";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox canvas;
        private Panel panel2;
        private PictureBox black;
        private PictureBox green;
        private PictureBox purple;
        private PictureBox yellow;
        private PictureBox blue;
        private PictureBox orange;
        private PictureBox cyan;
        private PictureBox red;
        private Button btn_ellipse;
        private Button btn_rectangle;
        private Button btn_line;
        private Button btn_erase;
        private Button btn_pen;
        private Button btn_save;
        private Button btn_clear;
    }
}