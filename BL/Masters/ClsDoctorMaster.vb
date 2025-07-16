Imports DB

Public Class ClsDoctorMaster

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
        Try
            'Save PatientMaster
            Dim strcommand As String = "SP_MASTER_DOCTORMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SPECIALIZATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CITY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADDRESS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(I)))
                I += 1

            End With

            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UPDATE() As Integer

        Dim intResult As Integer
        Dim strcommand As String = ""

        Try
            'UPDATE PatientMaster
            strcommand = "SP_MASTER_DOCTORMASTER_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SPECIALIZATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CITY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADDRESS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@DOCTORID", alParaval(I)))
                I += 1

            End With

            intResult = objDBOperation.executeNonQuery(strcommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0
    End Function

    Public Function DELETE() As DataTable
        Dim strcommand As String = ""
        Try
            'Delete SurgeryMaster
            strcommand = "SP_MASTER_DOCTORMASTER_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@DOCTORID", alParaval(0)))
            End With
            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GETDOCTOR() As DataTable
        Dim DT As DataTable
        Try
            Dim strcommand As String = "SP_MASTER_SELECT_DOCTOR"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@DOCTORID", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(1)))
            End With
            DT = objDBOperation.execute(strcommand, alParameter).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
        Return DT
    End Function

#End Region

End Class
