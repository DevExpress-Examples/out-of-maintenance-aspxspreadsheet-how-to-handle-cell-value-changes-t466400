Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace Sample
    Public Class User
        Private privateId As String
        Public Property Id() As String
            Get
                Return privateId
            End Get
            Private Set(ByVal value As String)
                privateId = value
            End Set
        End Property

        Private documentIDs_Renamed As List(Of String)
        Private userID As String

        Public Sub New(ByVal id As String)
            Me.Id = id
        End Sub

        Public ReadOnly Property DocumentIDs() As List(Of String)
            Get
                If documentIDs_Renamed Is Nothing Then
                    documentIDs_Renamed = New List(Of String)()
                End If
                Return documentIDs_Renamed
            End Get
        End Property
    End Class

    Public NotInheritable Class Users

        Private Sub New()
        End Sub
        Private Shared syncRoot As New Object()

'INSTANT VB TODO TASK: There is no VB equivalent to 'volatile':
'ORIGINAL LINE: private static volatile List(Of User) all;

        Private Shared all_Renamed As List(Of User)
        Public Shared ReadOnly Property All() As List(Of User)
            Get
                If all_Renamed Is Nothing Then
                    SyncLock syncRoot
                        If all_Renamed Is Nothing Then
                            all_Renamed = New List(Of User)()
                        End If
                    End SyncLock
                End If
                Return all_Renamed
            End Get
        End Property

        Public Shared Function GetUserByDocument(ByVal documentID As String) As String
            SyncLock syncRoot
                For Each user In All
                    If user.DocumentIDs.Contains(documentID) Then
                        Return user.Id
                    End If
                Next user
                Return Nothing
            End SyncLock
        End Function

        Public Shared Function Register(ByVal userID As String) As User
            SyncLock syncRoot
                Dim user = New User(userID)
                All.Add(user)
                Return user
            End SyncLock
        End Function
    End Class
End Namespace