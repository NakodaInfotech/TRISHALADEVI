
Imports DB

Public Class ClsToken

    Private objDBOperation As DBOperation
    Public alParaval As New ArrayList

#Region "Constructor"
    Public Sub New()
        Try
            objDBOperation = New DBOperation
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Function"

    Public Function SAVE() As DataTable
        Dim DT As New DataTable
        Try
            'Save PatientMaster
            Dim strcommand As String = "SP_MASTER_TOKEN_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@DATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OPDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@IPDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TYPE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(I)))
                I += 1

            End With

            DT = objDBOperation.execute(strcommand, alParameter).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
        Return DT
    End Function

#End Region

End Class
