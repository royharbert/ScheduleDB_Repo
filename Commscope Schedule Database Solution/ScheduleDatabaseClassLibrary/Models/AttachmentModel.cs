﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class AttachmentModel
    {
        /// <summary>
        /// Unique ID for record
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Project ID
        /// </summary>
        public string PID { get; set; }
        /// <summary>
        /// Text to be displayed in listview
        /// </summary>
        public string DisplayText { get; set; }
        /// <summary>
        /// Type of attachment (BOM, Drawing ...)
        /// </summary>
        public string ItemType { get; set; }  
        /// <summary>
        /// Filename of file to save
        /// </summary>
        public string FileToSave { get; set; }


        public AttachmentModel()
        {

        }

        public AttachmentModel(string pID, string displayText, string itemType, string serverPath, string fileToSave)
        {
            PID = pID;
            DisplayText = displayText;
            ItemType = itemType;            
        }
    }
}
