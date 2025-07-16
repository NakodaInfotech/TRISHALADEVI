Imports DB

Public Class ClsPatientMaster
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
            Dim strcommand As String = "SP_MASTER_PATIENTMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HOF", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@FIRSTNAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@LASTNAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CATEGORY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TALUKA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISTRICT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADDRESS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OCCUPATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHECKCONSULTATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@UHLDNO", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@IMGPATH", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOC1PATH", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOC2PATH", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
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

            'Update PatientMaster
            strcommand = "SP_MASTER_PATIENTMASTER_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HOF", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@FIRSTNAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@LASTNAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CATEGORY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TALUKA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISTRICT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADDRESS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OCCUPATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHECKCONSULTATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@UHLDNO", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@IMGPATH", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOC1PATH", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOC2PATH", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1


                .Add(New SqlClient.SqlParameter("@PATIENTID", alParaval(I)))
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
            strcommand = "SP_MASTER_PATIENTMASTER_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@PATIENTID", alParaval(0)))
            End With
            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GETPATIENT() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_MASTER_SELECT_PATIENT"

            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@PATIENTID", alParaval(0)))

            End With
            dtTable = objDBOperation.execute(strcommand, alParameter).Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
        Return dtTable
    End Function

   
#End Region

End Class
