using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Task task;

        public int N { get; set; } = 10;
        public double Leng { get; set; } = 100;
        public double Per1 { get; set; } = 0.5;
        public double Per2 { get; set; } = 0.5;
        public double Th1 { get; set; } = 30;
        public double Th2 { get; set; } = 30;
        public Pen ThePen { get; set; } = Pens.Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxN.DataBindings.Add("Text", this, "N");
            textBoxLeng.DataBindings.Add("Text", this, "Leng");
            textBoxPer1.DataBindings.Add("Text", this, "Per1");
            textBoxPer2.DataBindings.Add("Text", this, "Per2");
            textBoxTh1.DataBindings.Add("Text", this, "Th1");
            textBoxTh2.DataBindings.Add("Text", this, "Th2");
            comboBoxPen.DataSource = new Pen[] { Pens.Red, Pens.Green, Pens.Blue };
            comboBoxPen.DisplayMember = "Color";
            comboBoxPen.DataBindings.Add("SelectedItem", this, "ThePen");
        }

        void DrawCayleyTree(int n, double leng, double x0, double y0, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(
                ThePen,
                (int)x0, (int)y0, (int)x1, (int)y1);

            DrawCayleyTree(n - 1, Per1 * leng, x1, y1, th + Th1 * Math.PI / 180);
            DrawCayleyTree(n - 1, Per2 * leng, x1, y1, th - Th2 * Math.PI / 180);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.task != null && !this.task.IsCompleted)
            {
                MessageBox.Show("正在绘图，请稍后再试！");
                return;
            }
            graphics = this.panel1.CreateGraphics();
            graphics.Clear(panel1.BackColor);
            task = Task.Run(() => DrawCayleyTree(this.N, this.Leng, panel1.Width / 2,
                         panel1.Height - 20, -Math.PI / 2));
        }
    }
}
