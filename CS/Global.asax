<%@ Application Language="C#" %>
<%@ Import Namespace="DevExpress.Web.ASPxSpreadsheet" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="DevExpress.Spreadsheet" %>
<%@ Import Namespace="Sample" %>


<script RunAt="server">
    void Application_Start(object sender, EventArgs e) {
        ASPxSpreadsheet.CellValueChanged += Spreadsheet_CellValueChanged;
    }

    static void Spreadsheet_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e) {
        Logger.SaveChangesToLog(sender, e.Cell.GetReferenceA1(), e.OldValue, e.Value);

        if (e.Cell.ColumnIndex == 0 && e.Cell.RowIndex > 0) 
            e.Worksheet.Cells[e.Cell.RowIndex, 1].Value = SampleData.Lookup(e.Value.ToString());
    }

</script>
