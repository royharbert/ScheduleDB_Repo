
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    public class FC
    {
        public static void SetFormPosition(Form frm, int altLocationX = -1, int altLocationY = -1,
           bool useDefaultLocation = true)
        {
            Point adjustedPoint = new Point(altLocationX, altLocationY);
            frm.StartPosition = FormStartPosition.Manual;
            if (useDefaultLocation)
            {
                GV.ScreenList = Screens.GetScreenInfo();
                int Monitor = GV.ActiveScreen;
                int numScreens = GV.ScreenList.Count;
                if (Monitor > numScreens)
                {
                    Monitor = 1;
                    GV.ActiveScreen = 1;
                }
                ScreenModel model = GV.ScreenList[Monitor - 1];
                frm.Location = new Point(model.Xpos, model.Ypos);
            }
            else
            {
                frm.Location = new Point(altLocationX, altLocationY);
            }
        }
        public static bool isFormOpen(string formName)
        {
            FormCollection fc = Application.OpenForms;
            bool isOpen = false;

            foreach (Form frm in fc)
            {                 
                if (frm.Name == formName)
                {
                    isOpen = true;
                    break;
                }
                else
                {
                    isOpen = false;
                }
            }
            return isOpen;
        }

        public static void clearTextinControl(System.Windows.Forms.Control.ControlCollection controls, Type type)
        {
            foreach (Control control in controls)
            {
                if (control.GetType() == type)
                {
                    control.Text = string.Empty;
                }
            }
        }




    }
}

