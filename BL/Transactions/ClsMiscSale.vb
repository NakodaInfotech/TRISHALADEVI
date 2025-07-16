Imports DB
Public Class ClsMiscSale
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
            Dim strcommand As String = "SP_MASTER_MISCSALE_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DATE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@AMOUNT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RECDAMT", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@DISC", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@INWORDS", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@REMARKS", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@SUBTOTAL", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@GRANDTOTAL", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@BALAMT", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PATIENTNAME", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@MOBILENO", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PLACE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@OCCUPATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOCTOR", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COMMPER", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COMM", alParaval(I)))
                I += 1



                'ITEM ADD IN GRID
                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHARGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AMT", alParaval(I)))
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

            'Update PatientMaster
            strcommand = "SP_MASTER_MISCSALE_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DATE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@AMOUNT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RECDAMT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISC", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@INWORDS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@REMARKS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SUBTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@GRANDTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BALAMT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PATIENTNAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILENO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PLACE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OCCUPATION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SEX", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DOCTOR", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COMMPER", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COMM", alParaval(I)))
                I += 1

                'ITEM ADD IN GRID
                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHARGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AMT", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TEMPSALENO", alParaval(I)))
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
            strcommand = "SP_MASTER_MISCSALE_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@TEMPSALENO", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(1)))
            End With
            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GETMISC() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_MASTER_SELECT_MISCSALE"

            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@TEMPSALENO", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(1)))
            End With
            dtTable = objDBOperation.execute(strcommand, alParameter).Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
        Return dtTable
    End Function


#End Region

End Class






