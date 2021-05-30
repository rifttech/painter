using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painter
{
    public partial class MainForm : Form
    {
        private int widthSize = 10;
        private int heightSize= 10;
        private core.FigureType figureType;
        private Color currentColor = Color.Black;


        public MainForm()
        {
            InitializeComponent();
            InitializeUIControls();
            Repaint();

        }

        private void InitializeUIControls() {
            comboBox1.Items.Add(core.FigureType.Circle);
            comboBox1.Items.Add(core.FigureType.Rectangle);
            comboBox1.SelectedItem = figureType = core.FigureType.Circle;
            tb_height_size.Value = heightSize;
            tb_width_size.Value = widthSize;
        }

        private void Repaint(bool force = false) {
            if (!force)
            {
                if (pictureBox1.Image != null)
                {
                    return;
                }
            }
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = bmp;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Repaint();
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                drawing.DrawingManager.draw(new drawing.DrawingContext
                {
                    Graphics = g,
                    FigureType = figureType,
                    Width = widthSize,
                    Height = heightSize,
                    Origin = ((MouseEventArgs)e).Location,
                    FigureColor = currentColor,
                    Printer = print
                }) ;
                
            }
            pictureBox1.Invalidate();
           
        }

        private void print(core.Figure figure) {
            figure_info.Text = new core.FigurePrinter(figure).ToString();     
        }

        private void btn_change_figure_color(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                currentColor = colorDialog1.Color;
            } 
        }

        private void btn_canvas_clear_Click(object sender, EventArgs e)
        {
            Repaint(true);
        }

        private void tb_height_size_ValueChanged(object sender, EventArgs e)
        {
            this.heightSize = tb_height_size.Value;
            if (figureType == core.FigureType.Circle) {
                this.widthSize = tb_width_size.Value = tb_height_size.Value;
            }
        }

        private void tb_width_size_ValueChanged(object sender, EventArgs e)
        {
            this.widthSize = tb_width_size.Value;
            if (figureType == core.FigureType.Circle)
            {
                this.heightSize = tb_height_size.Value = tb_width_size.Value;
            }
        }

        private void cmb_figures_DropDownClosed(object sender, EventArgs e)
        {
            figureType = (core.FigureType)comboBox1.SelectedItem;
        }
    }
}
