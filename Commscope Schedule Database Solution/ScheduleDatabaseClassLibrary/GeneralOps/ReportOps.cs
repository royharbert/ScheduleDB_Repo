using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using ScheduleDatabaseClassLibrary.Models;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class ReportOps
    {
        public static List<LabEscModel> GetOpenEscByDateDue()
        {
            return GlobalConfig.Connection.GetOpenEscSortedByDateDue();
        }
        public static void FormatMultiResultExport(Excel.Worksheet wks)
        {
            string[] headers = new string[]
            {
                "Request ID", "MSO", "Activity", "Engineer(s)", "Start Date","End Date", "Salesperson", "Product(s)", "Number of Techs",
                "Date Completed", "Hours on Site", "Comments", "CRM Number", "Customer First Name", "Customer Last Name", "Customer EMail", "Customer Phone",
                "Site Name", "Site Address", "Site City", "Site State", "Site Country", "Site Postal Code", "Site Region"
            };
            placeHeaderTextInExport(wks, headers);
            formatExcelHeaderRow(wks);

            int[] widths = new int[]
            {
            //  A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  AA AB  
                24,25,20,25,15,15,19,25,15,15,10,30,15,10,10,32,16,10,15,18,12,15,14
            };

            string[] currencyCols = { "" };
            //FormatExcelColumnsAsCurrency(wks, currencyCols);
            setExcelExportColumnWidths(wks, widths);

            int[] cols = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            CenterSpecificExcelColumns(wks, cols);
        }

        private static void CenterSpecificExcelColumns(Excel.Worksheet wks, int[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {
                wks.Columns[cols[i]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
        }

        private static void setExcelExportColumnWidths(Excel.Worksheet wks, int[] widths)
        {
            for (int i = 0; i < widths.Length; i++)
            {
                wks.Columns[i + 1].ColumnWidth = widths[i];
            }
        }

        private static void FormatExcelColumnsAsCurrency(Excel.Worksheet wks, string[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {
                string rangeString = cols[i] + ":" + cols[i];
                Excel.Range formatRange;
                formatRange = wks.get_Range(rangeString);
                formatRange.NumberFormat = "$###,###,###.00";
            }
        }

        private static void placeHeaderTextInExport(Excel.Worksheet wks, string[] headers)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                wks.Cells[1, i + 1].Value = headers[i];
            }
        }

        private static void formatExcelHeaderRow(Excel.Worksheet wks)
        {
            //Center text in header/Turn word wrap on/Bold Font
            wks.Range["1:1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            wks.Range["1:1"].WrapText = true;
            wks.Range["1:1"].Font.Bold = true;
        }

        public static void FormatEscalationResultExport(Worksheet wks)
        {
          
            formatExcelHeaderRow(wks);

            int[] widths = new int[]
            {
            //  A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  AA AB  
                25,15,20,10,20,30,10,16,16,30,30,15,15,10
            };

            string[] currencyCols = { "" };
            //FormatExcelColumnsAsCurrency(wks, currencyCols);
            setExcelExportColumnWidths(wks, widths);

            int[] cols = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            CenterSpecificExcelColumns(wks, cols);
        }
    }    
}
