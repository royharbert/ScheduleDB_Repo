
using ScheduleDatabaseClassLibrary.GeneralOps;
using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{ }
    public static class ListLooper
    {
        //private static Excel.Worksheet wks = null;

        //public static void excelRequestExport(List<AssignmentDisplayModel> list)
        //{
        //    Excel.Application xlApp = makeRequestSheet();
        //    loadData(list);
        //    ExcelOps.releaseObject(xlApp);
        ////}

        //private static void loadData(List<AssignmentDisplayModel> list)
        //{
        //    int row = 2;

        //    foreach (AssignmentDisplayModel item in list)
        //    {
        //        wks.Cells[row, 1].Value = item.RequestID;
        //        wks.Cells[row, 2].Value = item.MSO;
        //        wks.Cells[row, 3].Value = item.Activity;
        //        wks.Cells[row, 4].Value = item.StartDate;
        //        wks.Cells[row, 5].Value = item.EndDate;
        //        wks.Cells[row, 6].Value = item.CustReqDate;
        //        wks.Cells[row, 7].Value = item.SalesPerson;
        //        wks.Cells[row, 8].Value = item.ProductList;
        //        wks.Cells[row, 9].Value = item.NumTechs;
        //        wks.Cells[row, 10].Value = item.DateCompleted;
        //        wks.Cells[row, 11].Value = item.HrsOnSite;
        //        wks.Cells[row, 12].Value = item.Comments;
        //        wks.Cells[row, 13].Value = item.CRMNumber;
        //        //wks.Cells[row, 14].Value = item.FE1ID;
        //        //wks.Cells[row, 15].Value = item.FE2ID;
        //        //wks.Cells[row, 16].Value = item.FE3ID;
        //        //wks.Cells[row, 17].Value = item.ContactID;
        //        wks.Cells[row, 18].Value = item.DocCovid;
        //        wks.Cells[row, 19].Value = item.DocCrm;
        //        wks.Cells[row, 20].Value = item.DocTripRpt;
        //        wks.Cells[row, 21].Value = item.DocWRE;
        //        wks.Cells[row, 22].Value = item.DocRoster;
        //        //wks.Cells[row, 23].Value = item.MSO_ID;
        //        //wks.Cells[row, 24].Value = item.LocationID;
        //        //wks.Cells[row, 25].Value = item.ProductListXML;
        //        //wks.Cells[row, 26].Value = item.Requestor;
        //        //wks.Cells[row, 27].Value = item.ID;

        //        //ks.Cells[row, 17].Value = item.CustFirstName;
        //        //wks.Cells[row, 18].Value = item.CustLastName;
        //        //wks.Cells[row, 19].Value = item.ContactMSO;
        //        wks.Cells[row, 20].Value = item.CustEMail;
        //        wks.Cells[row, 21].Value = item.CustPhone;
        //        //wks.Cells[row, 22].Value = item.ID_CustomerTable;
        //        wks.Cells[row, 23].Value = item.SiteName;
        //        //wks.Cells[row, 24].Value = item.LocMSO;
        //        wks.Cells[row, 25].Value = item.LocAddress;
        //        wks.Cells[row, 26].Value = item.LocPostalCode;
        //        wks.Cells[row, 27].Value = item.LocRegion;
        //        //wks.Cells[row, 27].Value = item.Activity_ID;
        //        row++;
        //    }
        //}

        //private static Excel.Application makeRequestSheet()
        //{
        //    //get application, set worksheet
        //    Excel.Application xlApp = ExcelOps.makeExcelApp();
        //    xlApp.Workbooks.Add();
        //    wks = xlApp.ActiveSheet;
        //    xlApp.Visible = true;


        //    //make header row            
        //    int col = 1;

        //    string[] headers = new string[]
        //    {
        //        "Project ID", "MSO", "End Customer", "City", "State","Country", "Region", "Design Requestor", "Quote Type",
        //        "Priority", "Designer", "Project Name", "Original Quote", "Assisted By", "Category", "Architecture Type",
        //        "Date Assigned", "Date All Info Received", "Date Due", "Award Status", "Date Last Update", "Reviewed By",
        //        "Date Completed", "Total Hours", "BOM Value", "% Project Covered", "Architecture Details", "Comments"
        //    };

        //    int[] widths = new int[]
        //    {
        //        26, 26, 26, 26, 20,26, 26,20,15, 10,15,26,26,15,10,20,15,15,15,15,15,15,15,15,15,15,50,26
        //    };

        //    foreach (string header in headers)
        //    {
        //        wks.Cells[1, col].Value = headers[col - 1];
        //        wks.Columns[col].ColumnWidth = widths[col - 1];
        //        wks.Columns[col].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
        //        col++;
        //    }

        //    return xlApp;
        //}

        //public static void useReflection(object obj, Type T)
        //{

        //    FieldInfo[] fields = T.GetFields();
        //    foreach (FieldInfo field in fields)
        //    {
        //        string fName = field.Name;
        //        string fType = field.FieldType.Name;
        //    }
        //}

        /// <summary>
        /// Instantiate class and set List property to a generic list
        /// Wksheet property will hold unformatted worksheet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ExcelExporter<T>
        {
            List<T> _list = null;
            public List<T> List
            {
                get
                {
                    return _list;
                }
                set
                {
                    List<T> _list = value;
                    if (_list.Count > 0)
                    {
                        Type type = _list[0].GetType();
                        Excel.Worksheet wks = excelExport(type, _list);
                        Wksheet = wks;
                    }
                }
            }

            public Excel.Worksheet Wksheet { get; set; }

            /// <summary>
            /// Reflects into list and makes header row and data rows
            /// </summary>
            /// <param name="type"></param>
            /// <param name="list"></param>
            private Excel.Worksheet excelExport(Type type, List<T> list)
            {
                //make xlApp
                Excel.Application xlApp = ExcelOps.makeExcelApp();
                xlApp.Workbooks.Add();
                xlApp.Visible = true;

                //set wks
                Excel.Worksheet wks = xlApp.ActiveSheet;
                wks.get_Range("1:1").WrapText = true;
                wks.get_Range("1:1").Font.Bold = true;
                wks.get_Range("A:AC").WrapText = true;

                //get property names, place in row 1

                PropertyInfo[] properties = type.GetProperties();
                Collection<PropertyInfo> props = new Collection<PropertyInfo>();
                for (int i = 0; i < properties.Length; i++)
                {

                    Object[] att = properties[i].GetCustomAttributes(true);
                    for (int j = 0; j < att.Length; j++)
                    {
                        Type aType = att[j].GetType();
                        if (aType.Name == "ExcelExportProperty")
                        {
                            props.Add((PropertyInfo)properties[i]);
                        }

                    }
                }


                int col = 1;
                foreach (var prop in props)
                {
                    wks.Cells[1, col].Value = prop.Name;
                    col++;
                }

                int row = 2;
                col = 1;
                foreach (var request in list)
                {
                    foreach (var prop in props)
                    {
                    if (prop.PropertyType == typeof(DateTime))
                    {
                        DateTime date = (DateTime)prop.GetValue(request);
                        if (date.Year == 1900)
                        {
                            wks.Cells[row, col].Value = "";
                        }

                        else
                        {
                            wks.Cells[row, col].Value = prop.GetValue(request);
                        }
                    }
                    else
                    {
                        wks.Cells[row, col].Value = prop.GetValue(request);
                    }
                        col++;
                    }
                    row++;
                    col = 1;
                }
                ExcelOps.releaseObject(xlApp);
                return wks;
            }

        }
    }


