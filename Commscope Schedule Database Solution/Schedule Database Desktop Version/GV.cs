using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Database_Desktop_Version
{
    class GV
    {
        //public static frmLabEsc ESCALATIONFORM { get; set; }
        //public static frmLabEsc LABESCFORM { get; set; }
        public List<ProductModel> ProductsList { get; set; }
        public static UserModel USERMODEL { get; set; }
        public static frmAMDI_Parent MAINMENU { get; set; }
        public static frmAltMainMenu ALTMENU { get; set; }  
        public static frmLogin LOGIN { get; set; }
        public static int Priviledge { get; set; }
        public static List<ScreenModel> ScreenList { get; set; }
        public static int ActiveScreen { get; set; }
        public static DateTime nullDate { get; set; } = new DateTime(1900, 1, 1);
        public static frmInput inputForm {get; set; }

        public static Mode MODE
        {
            get
            {
                return mode;
            }
            set
            {
                PreviousMode = mode;
                mode = value;
            }
        }
        public static Mode PreviousMode { get; set; }

        private static Mode mode = Mode.None;
    }
}
