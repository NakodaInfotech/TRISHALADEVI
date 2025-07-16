Imports DB

Public Class ClsClaim
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
            'Save Claim
            Dim strcommand As String = "SP_TRANSACTION_CLAIM_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SOCIETY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGEFINALBILL", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CLAIMNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SANCTIONDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGERY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ILLNESS", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@SURGERYDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADMISSIONDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISCHARGEDATE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CODEAPP", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CODEDONE", alParaval(I)))
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

                .Add(New SqlClient.SqlParameter("@PBEFORE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PAFTER", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PASCAN", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PCLAIM", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PAUTHORITY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PUHLD", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PDOC1", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PDOC2", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PDOC3", alParaval(I)))
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
            strcommand = "SP_TRANSACTION_CLAIM_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0

                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MOBILE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@AGE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SOCIETY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@VILLAGEFINALBILL", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CLAIMNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SANCTIONDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@SURGERY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ILLNESS", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@SURGERYDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ADMISSIONDATE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@DISCHARGEDATE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CODEAPP", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CODEDONE", alParaval(I)))
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

                .Add(New SqlClient.SqlParameter("@PBEFORE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PAFTER", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PASCAN", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PCLAIM", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PAUTHORITY", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PUHLD", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@PDOC1", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PDOC2", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PDOC3", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(I)))
                I += 1


            End With

            intResult = objDBOperation.executeNonQuery(strcommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0
    End Function

    Public Function DELETE() As Integer
        Dim strcommand As String = ""
        Try
            'Delete PatientMaster
            strcommand = "SP_TRANSACTION_CLAIM_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@YEARID", alParaval(1)))
            End With
            Dim INTRES As Integer = objDBOperation.executeNonQuery(strcommand, alParameter)
        Catch ex As Exception
            Throw ex
        End Try
        Return 0

    End Function

    Public Function GETCLAIM() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_TRANSACTION_SELECT_CLAIM"

            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@SRNO", alParaval(0)))
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
