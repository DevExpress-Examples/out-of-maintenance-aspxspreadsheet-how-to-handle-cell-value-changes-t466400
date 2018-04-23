Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web

Namespace Sample
    Public NotInheritable Class SampleData

        Private Sub New()
        End Sub


        Private Shared data_Renamed As DataTable
        Public Shared ReadOnly Property Data() As DataTable
            Get
                If data_Renamed Is Nothing Then
                    data_Renamed = GenerateSampleData()
                End If
                Return data_Renamed
            End Get
        End Property

        Private Shared Function GenerateSampleData() As DataTable
            data_Renamed = New DataTable()
            Dim keyColumn = data_Renamed.Columns.Add("Id")
            data_Renamed.Columns.Add("Name")
            data_Renamed.PrimaryKey = New DataColumn() { keyColumn }

            data_Renamed.Rows.Add(New Object() { "10115", "Augusta Delono" })
            data_Renamed.Rows.Add(New Object() { "10501", "Berry Dafoe" })
            data_Renamed.Rows.Add(New Object() { "10709", "Chris Cadwell" })
            data_Renamed.Rows.Add(New Object() { "10356", "Esta Mangold" })
            data_Renamed.Rows.Add(New Object() { "10401", "Frank Diamond" })
            data_Renamed.Rows.Add(New Object() { "10202", "Liam Bell" })
            data_Renamed.Rows.Add(New Object() { "10205", "Simon Newman" })
            data_Renamed.Rows.Add(New Object() { "10403", "Wendy Underwood" })

            Return data_Renamed
        End Function

        Public Shared Function Lookup(ByVal key As String) As String
            Dim row = Data.Rows.Find(key)
            Return If(row IsNot Nothing, row("Name").ToString(), "")
        End Function
    End Class
End Namespace