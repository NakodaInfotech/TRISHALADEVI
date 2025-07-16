
Imports DB

Public Class ClsSurgeryMaster
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

    Public Function SAVE() As Integer
        Try
            'Save SurgeryMaster
            Dim intResult As Integer
            Dim strcommand As String = "SP_MASTER_SURGERYMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0

                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@EYE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHARGES", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OPPROCEDURE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHIEF", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PREORDERS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@POSTORDERS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@INSTRUCTION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANATHESIA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PROCEDURE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@MEDSRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MEDICINE", alParaval(I)))
                I += 1


                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RATE", alParaval(I)))
                I += 1



            End With

            intResult = objDBOperation.executeNonQuery(strcommand, alParameter)
            Return intResult
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UPDATE() As Integer

        Dim intResult As Integer
        Dim strcommand As String = ""

        Try

            'Update SurgeryMaster
            strcommand = "SP_MASTER_SURGERYMASTER_UPDATE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0

                .Add(New SqlClient.SqlParameter("@NAME", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@EYE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHARGES", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@OPPROCEDURE", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CHIEF", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PREORDERS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@POSTORDERS", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@INSTRUCTION", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@ANATHESIA", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@PROCEDURE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@MEDSRNO", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@MEDICINE", alParaval(I)))
                I += 1



                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@RATE", alParaval(I)))
                I += 1

                .Add(New SqlClient.SqlParameter("@SURGERYID", alParaval(I)))
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
            strcommand = "SP_MASTER_SURGERYMASTER_DELETE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@SURGERYID", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@CMPID", alParaval(1)))
            End With
            Dim DT As DataTable = objDBOperation.execute(strcommand, alParameter).Tables(0)
            Return DT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GETSURGERY() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_MASTER_SELECT_SURGERY"

            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@NAME", alParaval(0)))
            End With
            dtTable = objDBOperation.execute(strcommand, alParameter).Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
        Return dtTable
    End Function

#End Region

End Class
