Imports DB

Public Class ClsCmpDetails

    Private objDBOperation As DBOperation

#Region "Constructor"
    Public Sub New()
        Try
            objDBOperation = New DBOperation
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class
