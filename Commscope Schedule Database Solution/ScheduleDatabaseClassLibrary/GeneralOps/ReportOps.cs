using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public static class ReportOps
    {
        public static void FormatMultiResultExport(Excel.Worksheet wks)
        {

            string[] headers = new string[]
            {
                "Request ID", "MSO", "Activity", "Start Date", "End Date","Salesperson", "Product List", "Number of Techs", "Date Completed",
                "Hours on Site", "Comments", "CRM Number", "Requestor", "Customer Name",  "Customer Email",
                "Customer Phone", "Site Name", "Site Address", "City", "State", "Country",
                "Postal Code", "Region"
            };
            placeHeaderTextInExport(wks, headers);
            formatExcelHeaderRow(wks);

            int[] widths = new int[]
            {
            //  A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  AA AB  
                26,15,20,15,15,15,15,15,18,15,25,22,15,15,25,15,18,18,15,18,18,15,18
            };

            string[] currencyCols = { "" };
            //FormatExcelColumnsAsCurrency(wks, currencyCols);
            setExcelExportColumnWidths(wks, widths);
            wks.get_Range("R:R").WrapText = true;
            wks.get_Range("Z:Z").WrapText = true;
            wks.get_Range("AA:AA").WrapText = false;
            wks.get_Range("L:L").WrapText = true;

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
    }    
}
