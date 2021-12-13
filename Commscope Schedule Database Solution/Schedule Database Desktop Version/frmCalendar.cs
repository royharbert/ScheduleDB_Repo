using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.Models;
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
        Dictionary<string, int> months = new Dictionary<string, int>()
        {
                    { "january", 1},
                    { "february", 2},
                    { "march", 3},
                    { "april", 4},
                    { "may", 5},
                    { "june", 6},
                    { "july", 7},
                    { "august", 8},
                    { "september", 9},
                    { "october", 10},
                    { "november", 11},
                    { "december", 12},
        };

        string currentRegion = "";
        List<FE_Model> currentFEs = null;
        Dictionary<int, FE_Model> feDictionary = null;
        Graphics g;
        Rectangle[,] dayArray = new Rectangle[5, 7];
        public frmCalendar()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            fillRegionComboList();
            cboRegions.SelectedItem = -1;
        }

        private void makeFE_Dictionary()
        {
            List<FE_Model> allFEs = GlobalConfig.Connection.GenericGetAll<FE_Model>("tblFE", "LastName");
            foreach (var fe in allFEs)
            {
                feDictionary.Add(fe.ID, fe);
            }
        }

        private void fillRegionComboList()
        {
            List<RegionsModel> regions = GlobalConfig.Connection.GenericGetAll<RegionsModel>("tblRegions", "Region");
            cboRegions.DataSource = regions;
            cboRegions.DisplayMember = "Region";
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

        private List<AssignmentTableModel> getAssignments(string month, string year)
        {
            DateTime startDate = DateTime.Parse(month + " 1, " + year);
            string lcMonth = month.ToLower();
            int monthInt = months[lcMonth];
            int lastDOM = DateTime.DaysInMonth(int.Parse(year), monthInt);
            DateTime endDate = DateTime.Parse(month + " " + lastDOM.ToString() + ", " + year);

            List<AssignmentTableModel> assignments = GlobalConfig.Connection.DateRangeSearch_SortBy(startDate, endDate);

            return assignments;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegionsModel region = (RegionsModel)cboRegions.SelectedItem;
            currentRegion = region.ToString();
            currentFEs = GlobalConfig.Connection.GetItemByColumn<FE_Model>("tblFE", "Region",
                currentRegion);
            List<AssignmentTableModel> assignments = getAssignments(cboMonth.SelectedItem.ToString(),
                cboYear.SelectedItem.ToString());
        }
    }
}
