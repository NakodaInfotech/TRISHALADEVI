Imports DB
Public Class ClsIPD
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
            Dim strcommand As String = "SP_MASTER_IPD_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTADMISSION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTDISCHARGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTAPPOINMENT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HOSPITAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HTALUKA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HREGNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGEON", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SMOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGERY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HISTORY", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@RBS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HIV", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HBsAg", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ASCAN", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BSCAN", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PERSONALHISTORY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ALLERGY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PULSE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TEMPRATURE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BP", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@APPRIHENSIVE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@UNCOOPERATIVE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CALM", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ISSUE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ORALMEDICINE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANAESTHESIOLOGIST", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AMOUNT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RECDAMT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISC", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@INWORDS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SUBTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@GRANDTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BALAMT", alParaval(I)))
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
            strcommand = "SP_MASTER_IPD_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@MRDNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTADMISSION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTDISCHARGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DTAPPOINMENT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HOSPITAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HTALUKA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HREGNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGEON", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SMOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGERY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HISTORY", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@RBS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HIV", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@HBsAg", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ASCAN", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BSCAN", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PERSONALHISTORY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ALLERGY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PULSE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@TEMPRATURE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BP", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@APPRIHENSIVE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@UNCOOPERATIVE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CALM", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ISSUE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ORALMEDICINE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANAESTHESIOLOGIST", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AMOUNT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RECDAMT", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISC", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@INWORDS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SUBTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@GRANDTOTAL", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@BALAMT", alParaval(I)))
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
                .Add(New SqlClient.SqlParameter("@TEMPIPDNO", alParaval(I)))
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
            strcommand = "SP_MASTER_IPD_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@TEMPIPDNO", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(1)))
            End With
            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GETIPD() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_MASTER_SELECT_IPD"

            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@TEMPIPDNO", alParaval(0)))
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


