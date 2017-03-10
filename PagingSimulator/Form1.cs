using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagingSimulator
{
    public partial class Form1 : Form
    {
        List<Page> pages;

        public Form1()
        {
            pages = new List<Page>();

            pages.Add(new Page("Page1"));
            pages.Add(new Page("Page2"));
            pages.Add(new Page("Page3"));
            pages.Add(new Page("Page4"));
            pages.Add(new Page("Page5"));
            pages.Add(new Page("Page6"));
            pages.Add(new Page("Page7"));

            InitializeComponent();
        }
        void OnLoad(object sender, EventArgs e)
        {
            drawPages();
        }

        public void DrawBox(int x, int y, int width, int height) {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(x, y, width, height));
            Rectangle rect = new Rectangle(x+1, y+1, width-1, height-1);
            formGraphics.FillRectangle(myBrush, rect);

            myPen.Dispose();
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        public void addWidth(int ammount)
        {
            this.Width += ammount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawBox(0, 0, 200, 200);
            addWidth(100);
        }

        public void drawPages()
        {
            Pen myPen = new Pen(Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(20, 40, 30, pages.Count * 10));
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            Memory fifo = new Memory(5, "FIFO");


           // fifo.pages = somePages;

        }
    }
}
