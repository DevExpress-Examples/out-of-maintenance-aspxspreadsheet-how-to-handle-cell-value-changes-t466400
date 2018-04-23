<%@ Application Language="vb" %>
<%@ Import Namespace="DevExpress.Web.ASPxSpreadsheet" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="DevExpress.Spreadsheet" %>
<%@ Import Namespace="Sample" %>


<script RunAt="server">
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler ASPxSpreadsheet.CellValueChanged, AddressOf Spreadsheet_CellValueChanged
    End Sub

    Shared Sub Spreadsheet_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs)
        Logger.SaveChangesToLog(sender, e.Cell.GetReferenceA1(), e.OldValue, e.Value)

        If e.Cell.ColumnIndex = 0 AndAlso e.Cell.RowIndex > 0 Then
            e.Worksheet.Cells(e.Cell.RowIndex, 1).Value = SampleData.Lookup(e.Value.ToString())
        End If
    End Sub

</script>