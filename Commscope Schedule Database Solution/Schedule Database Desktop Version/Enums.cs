using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Database_Desktop_Version
{ 
    public enum Mode
    {
        New,
        AddEscalation,
        SearchEscalation,
        EditEscalation,
        DeleteEscalation,
        DateRangeReport,
        Edit,
        Undo,
        CustomerSearch,
        CustomerSearchMDI,
        AddCustomer,
        EditCustomer,
        DeleteCustomer,
        AddCustomerLocation,
        EditCustomerLocation,
        DeleteCustomerLocation,
        LocationSearch,
        LocationSearchMDI,
        Add_Attachment,
        Delete_Attachment,
        SalesPerson_Add,
        SalesPerson_Update,
        SalesPerson_Delete,
        LabRequestAdd,
        LabRequestEdit,
        LabRequestDelete,
        DateRangeReportAT,

        None
    }
}
