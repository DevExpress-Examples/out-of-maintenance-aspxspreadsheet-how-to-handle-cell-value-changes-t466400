Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Spreadsheet
Imports DevExpress.Web
Imports DevExpress.Web.Office


Imports Sample

Partial Public Class [Default]
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not Page.IsPostBack Then
            Dim currentUserID As String = GenerateUniqueId()

            Dim user_Renamed = Users.Register(currentUserID)

            Dim templatePath = Server.MapPath("~/App_Data/WorkDirectory/CellValueChangedSample.xlsx")
            Dim documentId = GenerateUniqueId()
            user_Renamed.DocumentIDs.Add(documentId)
            spreadsheet.Open(documentId, DocumentFormat.Xlsx, Function() System.IO.File.ReadAllBytes(templatePath))
        End If
    End Sub

    Private Shared Function GenerateUniqueId() As String
        Return Guid.NewGuid().ToString()
    End Function

End Class