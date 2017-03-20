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
        List<Page> requests; //pages requesting entry
        Font myFont = new Font("Microsoft sans serif", 9);
        Memory memory;

        public Form1()
        {
            pages = new List<Page>();
            requests = new List<Page>();

            Page A = new Page("A");
            Page B = new Page("B");
            Page C = new Page("C");
            Page D = new Page("D");
            Page E = new Page("E");
            Page F = new Page("F");
            Page G = new Page("G");

            pages.Add(A);
            pages.Add(B);
            pages.Add(C);
            pages.Add(D);
            pages.Add(E);
            pages.Add(F);
            pages.Add(G);
   
            requests.Add(A);
            requests.Add(B);
            requests.Add(C);
            requests.Add(A);
            requests.Add(D);
            requests.Add(E);
            requests.Add(G);
            requests.Add(A);
            requests.Add(F);
            requests.Add(B);
            requests.Add(A);
            requests.Add(E);
            requests.Add(C);

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

        public void addWidth(int ammount) //Not sure if i need this yet
        {
            this.Width += ammount;
        }

        private void button2_Click(object sender, EventArgs e) //TESTER Event
        {
            DrawBox(0, 0, 200, 200);
            addWidth(100);
        }

        public void drawPages() //should be called onLoad
        {
            Pen myPen = new Pen(Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            //draw rectangle
            formGraphics.DrawRectangle(myPen, new Rectangle(20, 40, 45, pages.Count * 30));
            //write every Page inside the rectangle
            SolidBrush myBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < pages.Count; i++)
            {
                PointF point = new PointF(22, (45 + 30 * i));
                formGraphics.DrawString((pages[i].name), myFont, myBrush, point);
            }
            myBrush.Dispose();
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void drawFrames(Frame[] someFrames)
        {
            //initialize drawing tools
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Black);

            drawPageRequestIds();

            //for each frame
            for (int i = 0; i < someFrames.Length; i++)
            {
                //Draw Rect
                formGraphics.DrawRectangle(myPen, new Rectangle(100, 40 + (i * 45), 45 * requests.Count, 40));                      
                //formGraphics.DrawLine(myPen, new Point(100, ))
            }
            myBrush.Dispose();
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void drawFramePages(Frame[] someFrames)
        {
            //initialize drawing tools
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Black);

            for (int j = 0; j < requests.Count; j++)
            {
                //for each frame
                for (int i = 0; i < someFrames.Length; i++)
                {
                    //Draw every Letter
                    PointF point = new PointF(102 + (45 * requestNumber), (45 + 45 * i));
                    if (!someFrames[i].isFree)
                    {
                        formGraphics.DrawString((someFrames[i].getPage().id), myFont, myBrush, point);
                    }
                    //formGraphics.DrawLine(myPen, new Point(100, ))
                }
            }
            myBrush.Dispose();
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void drawPageRequestIds()
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < requests.Count; i++)
            {                                                                  //104 + each distance apart
                formGraphics.DrawString(requests[i].id, myFont, myBrush, new PointF(104 + (45 * i), 24));
            }

            formGraphics.Dispose();
            myBrush.Dispose();
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {

            memory = new Memory(int.Parse(cmbFrames.Text), "FIFO");
            drawFrames(memory.frames);

            // fifo.pages = somePages;
        }

        int requestNumber = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requestNumber < requests.Count)
            {
                memory.offer(requests[requestNumber]);
                drawFramePages(memory.frames);

                foreach(Page page in pages)
                {
                    if (requests[requestNumber].id == page.id)
                    {
                        page.frequency++;
                    }
                }
                requestNumber++;
            }
        }

        private void btnLFU_Click(object sender, EventArgs e)
        {
            memory = new Memory(int.Parse(cmbFrames.Text), "LFU");
            drawFrames(memory.frames);
        }
    }
}
