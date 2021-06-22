using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmCalendar : Form
    {
        Graphics g;
        Rectangle[,] dayArray = new Rectangle[5, 7];
        //Panel[,] dayPanels = new Panel[5, 7];
        public frmCalendar()
        {
            InitializeComponent();
            g = this.CreateGraphics();  
        }

        private void pnlMonth_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            int boxWidth = pnlMonth.Width / 7;
            int boxHeight = pnlMonth.Height / 5;
            Pen blackPen = new Pen(Color.Black, 4);
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    int ulx = col * boxWidth;
                    int uly = row * boxHeight;
                    
                    dayArray[row, col] = new Rectangle(ulx, uly, boxWidth, boxHeight);
                    g.DrawRectangle(blackPen,dayArray[row, col]);
                }

            }
        }
    }
}
