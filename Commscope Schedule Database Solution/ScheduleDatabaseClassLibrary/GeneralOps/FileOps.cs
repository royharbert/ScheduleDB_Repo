﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ScheduleDatabaseClassLibrary.Models
{ 
    public static class FileOps
    {
        public static void SaveAttFile(AttachmentModel model)
        {
            string fullSavePath = GlobalConfig.AttachmentPath + "\\" + model.PID;
            if (!Directory.Exists(fullSavePath))
            {
                Directory.CreateDirectory(fullSavePath);
            }
            string fullFileName = fullSavePath + "\\" + model.DisplayText;
            File.Copy(model.FileToSave, fullFileName, true);
            //MessageBox.Show("1 file copied");
            
        }
    }
}
