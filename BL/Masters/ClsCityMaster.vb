Imports DB

Public Class ClsCityMaster


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

#Region "Functions"

    Public Function save() As Integer

        Dim intResult As Integer
        'Dim cityid, stateid, countryid As Integer

        'Dim objTrans As SqlClient.SqlTransaction
        'objTrans = objDBOperation.StartNewTransaction
        Try

            Dim strCommand As String = "SP_MASTER_CITYMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@city_name", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_remark", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_cmpid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_locationid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_userid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_yearid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@city_transfer", alParaval(I)))
                I += 1

            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0

    End Function

    Public Function UpdateCITY() As Integer

        Dim intResult As Integer
        Try

            Dim strCommand As String = "SP_MASTER_CITYMASTER_UPDATE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@city_name", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@city_remark", alParaval(1)))
                .Add(New SqlClient.SqlParameter("@city_cmpid", alParaval(2)))
                .Add(New SqlClient.SqlParameter("@city_locationid", alParaval(3)))
                .Add(New SqlClient.SqlParameter("@city_userid", alParaval(4)))
                .Add(New SqlClient.SqlParameter("@city_yearid", alParaval(5)))
                .Add(New SqlClient.SqlParameter("@city_transfer", alParaval(6)))
                .Add(New SqlClient.SqlParameter("@cityid", alParaval(7)))
            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0
    End Function


    Public Function SAVESTATE() As Integer

        Dim intResult As Integer
        'Dim cityid, stateid, countryid As Integer

        'Dim objTrans As SqlClient.SqlTransaction
        'objTrans = objDBOperation.StartNewTransaction
        Try

            Dim strCommand As String = "SP_MASTER_STATEMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@STATE_name", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_remark", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_cmpid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_locationid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_userid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_yearid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@STATE_transfer", alParaval(I)))
                I += 1

            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0

    End Function

    Public Function UpdateSTATE() As Integer

        Dim intResult As Integer
        Try

            Dim strCommand As String = "SP_MASTER_STATEMASTER_UPDATE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@STATE_name", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@STATE_remark", alParaval(1)))
                .Add(New SqlClient.SqlParameter("@STATE_cmpid", alParaval(2)))
                .Add(New SqlClient.SqlParameter("@STATE_locationid", alParaval(3)))
                .Add(New SqlClient.SqlParameter("@STATE_userid", alParaval(4)))
                .Add(New SqlClient.SqlParameter("@STATE_yearid", alParaval(5)))
                .Add(New SqlClient.SqlParameter("@STATE_transfer", alParaval(6)))
                .Add(New SqlClient.SqlParameter("@STATEid", alParaval(7)))
            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0
    End Function

    Public Function SAVECOUNTRY() As Integer

        Dim intResult As Integer
        'Dim cityid, stateid, countryid As Integer

        'Dim objTrans As SqlClient.SqlTransaction
        'objTrans = objDBOperation.StartNewTransaction
        Try

            Dim strCommand As String = "SP_MASTER_COUNTRYMASTER_SAVE"
            Dim alParameter As New ArrayList
            With alParameter

                Dim I As Integer = 0
                .Add(New SqlClient.SqlParameter("@COUNTRY_name", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_remark", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_cmpid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_locationid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_userid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_yearid", alParaval(I)))
                I += 1
                .Add(New SqlClient.SqlParameter("@COUNTRY_transfer", alParaval(I)))
                I += 1

            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0

    End Function

    Public Function UPDATECOUNTRY() As Integer

        Dim intResult As Integer
        Try

            Dim strCommand As String = "SP_MASTER_COUNTRYMASTER_UPDATE"
            Dim alParameter As New ArrayList
            With alParameter
                .Add(New SqlClient.SqlParameter("@COUNTRY_name", alParaval(0)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_remark", alParaval(1)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_cmpid", alParaval(2)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_locationid", alParaval(3)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_userid", alParaval(4)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_yearid", alParaval(5)))
                .Add(New SqlClient.SqlParameter("@COUNTRY_transfer", alParaval(6)))
                .Add(New SqlClient.SqlParameter("@COUNTRYid", alParaval(7)))
            End With

            intResult = objDBOperation.executeNonQuery(strCommand, alParameter)

        Catch ex As Exception
            Throw ex
        End Try
        Return 0
    End Function



#End Region
End Class
