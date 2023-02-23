using ScheduleDatabaseClassLibrary;
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public partial class frmAltMainMenu : Form
    {
        public frmAltMainMenu()
        {
            InitializeComponent();
        }

        
        private frmLabEsc showLabEscForm()
        {
            frmLabEsc EscalationsForm = new frmLabEsc();
            //EscalationsForm.MdiParent= this;
            EscalationsForm.StartPosition = FormStartPosition.CenterScreen;
            //EscalationsForm.Height = 718;
            //EscalationsForm.Width = 1330;
            EscalationsForm.Show();
            return EscalationsForm;
        }

        private void frmAltMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            GV.MODE = Mode.LabEscAdd;
            showLabEscForm();
        }
    }
}
