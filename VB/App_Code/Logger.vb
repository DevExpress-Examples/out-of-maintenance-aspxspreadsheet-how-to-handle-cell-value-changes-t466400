Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Office

Namespace Sample
    Public NotInheritable Class Logger

        Private Sub New()
        End Sub

        Private Shared Log As New List(Of String)()
        Public Shared Sub SaveChangesToLog(ByVal sender As Object, ByVal cellReference As String, ByVal oldValue As CellValue, ByVal newValue As CellValue)
            Dim documentInfo As SpreadsheetDocumentInfo = TryCast(sender, SpreadsheetDocumentInfo)

            Dim userId = Users.GetUserByDocument(documentInfo.DocumentId)

            Log.Add(String.Format("User {0} changed document {1} cell {2} from {3} to {4}", userId, documentInfo.DocumentId, cellReference, oldValue, newValue))
        End Sub
    End Class
End Namespace