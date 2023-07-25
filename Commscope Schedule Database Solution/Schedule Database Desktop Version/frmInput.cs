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
    public partial class frmInput : Form
    {
        public event EventHandler<InputDataReadyEventArgs> InputDataReady;       

        public frmInput()
        {
            LabEscModel model = new LabEscModel();
            InitializeComponent();
            this.AcceptButton = btnGo;
            this.CancelButton = btnCancel;
            switch (GV.MODE)
            {
                case Mode.LabEscEdit:

                    break;
                case Mode.LabEscDelete:

                    break;
                case Mode.LabEscSearch:

                    break;
                case Mode.LabEscRestore:

                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)        
        {
            InputDataReadyEventArgs args = new InputDataReadyEventArgs();
            args.SearchString = "%" + txtInput.Text.Trim().ToUpper() + "%";
            InputDataReady?.Invoke(this, args);
            this.Hide();
        }

        //private void frmInput_Activated(object sender, EventArgs e)
        //{
        //    txtInput.Clear();
        //    this.BringToFront();
        //}
    }

    public class InputDataReadyEventArgs : EventArgs
    {
        public string SearchString { get; set; }
    }
}
