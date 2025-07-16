Imports DB

Public Class ClsSelectMaster
    Private objDBOperation As DBOperation
    Public ALPARAVAL As New ArrayList

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
            Dim strcommand As String = "SP_MASTER_SELECT_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@FRMSTRING", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@NAME", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CMPID", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", ALPARAVAL(I)))
                I += 1


            End With

            Dim INTERES As Integer = objDBOperation.executeNonQuery(strcommand, alParameter)
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UPDATE() As Integer
        Try
            Dim intResult As Integer
            Dim strcommand As String = "SP_MASTER_SELECT_UPDATE"
            'Update CategoryMaster
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@FRMSTRING", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@NAME", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@CMPID", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@USERID", ALPARAVAL(I)))
                I += 1


                .Add(New SqlClient.SqlParameter("@FRMSTRINGID", ALPARAVAL(I)))
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

            'Delete CategoryMaster
            strcommand = "SP_MASTER_SELECT_DELETE"

            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0

                .Add(New SqlClient.SqlParameter("@FRMSTRING", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@FRMSTRINGID", ALPARAVAL(I)))
                I += 1

            End With

            Dim INTES As Integer = objDBOperation.executeNonQuery(strcommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0

    End Function

    Public Function GETSELECT() As DataTable
        Dim dtTable As DataTable
        Dim strcommand As String = ""
        Try
            strcommand = "SP_MASTER_SELECT"

            Dim alParameter As New ArrayList
            With alParameter
                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@FRMSTRING", ALPARAVAL(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@FRMSTRINGID", ALPARAVAL(I)))
                I += 1
            End With
            dtTable = objDBOperation.execute(strcommand, alParameter).Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
        Return dtTable
    End Function

#End Region

End Class
