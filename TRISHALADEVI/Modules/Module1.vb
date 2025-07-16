
Imports Microsoft.Win32 ' for registry access
Imports System.IO


Module Module1

    '******** COMMON VARIABLES **************
    Public Mydate As DateTime                           'Used for SQL Date throughout the Software at the time of login
    Public ClientName As String = ""


    '' -------NOTEPAD CODE --------
    'Public oFile As System.IO.File
    'Public oRead As System.IO.StreamReader = File.OpenText("C:\SERVERNAME.txt")
    'Public SERVERNAME As String = oRead.ReadToEnd
    ''' ----------------- NOTEPAD CODE---------

    ''Public Servername As String = "server\SQLEXPRESS"          'Used for Servername for reports'
    'Public DatabaseName As String = "TRISHALADEVI"          'Used for Servername for reports'
    'Public DBUSERNAME As String = ""
    'Public Dbpassword As String = ""
    'Public Dbsecurity As Boolean = True

    Public SERVERNAME As String
    Public DatabaseName As String
    Public DBUSERNAME As String             'Used for Servername username for reports
    Public Dbpassword As String         ''Used for Servername password for reports
    Public Dbsecurity As Boolean

    '******** FORM WISE VARIABLES ************
    '---CMPDETAILS---
    Public CmpName As String            'Used for CmpName throughout the software 
    Public CMPCITYNAME As String        'Used for TALUKA IN CLAIM
    Public HOSPREGNO As String          'Used for HOSP REG NO IN CLAIM
    Public DBName As String             'Used for DBName throughout the software 
    Public CmpId As Integer             'Used for CmpId throughout the software
    Public YearId As Integer            'Used for YearId throughout the software
    Public AccFrom, AccTo As DateTime   'Used for A/C year start and end throughout the software
    Public Locationid As Integer        'Used for Locationid while login


    '---LOGIN---
    Public Userid As Integer                'Used for Userid while login
    Public UserName As String               'User for UserName while Login
    Public USERTYPE As String               'User for USERTYPE while Login (SUPER, ADMIN, USER)
    Public USEREMPNAME As String            'User for EMNPLOYEENAME TAGGED WITH USER LOGGED IN
    Public USERGODOWN As String             'User for GODOWNNAME
    Public USERSMTP As String               'User for SMTP NAME
    Public USERFROMEMAIL As String          'User for FROM EMAIL
    Public USERSMTPPORT As Integer          'User for SMTP PORT
    Public USERSSL As Boolean               'User for SSL
    Public USEREMAIL As String              'User EMAIL 
    Public USEREMAILPASS As String          'User for USER;S EMAIL;S PASSWORD
    Public USERMOBILE As String             'User for USER'S MOBILENO

    '----FOR WHATSAPP
    Public ALLOWWHATSAPP As Boolean
    Public WHATSAPPAUTOCC As Boolean
    Public WHATSAPPEXPDATE As Date          'Used for COMPANY'S WHATSAPP EXPIRY DATE



    'USED FOR SPECIAL RIGHTS
    Public PRAPPROVAL, PROTP As Boolean     'PURCHASE REQUEST
    Public POAPPROVAL, POOTP As Boolean     'PURCHASE QUOTATION
    Public QUOTEAPPROVAL, QUOTEOTP As Boolean     'SALE QUOTATION
    Public ORDERAPPROVAL, ORDEROTP As Boolean     'SALE ORDER

    Public APPROVED As Boolean          ''OTP GLOBAL APPROVED FOR CHECKBOX


    '---VARIABLE---
    Public USERRIGHTS As DataTable          'USED FOR USER RIGHTS THROUGHOUT THE APPLICATION 

    '---VOUCHERS---
    Public REPORTTYPE As Boolean        'USED TO CHECK IF THE CLIENT WILL USINMG OUR DEFAULT FORMAT OR NOT



    'CODE TO PROGRAMMATICALLY CREATE D. S. N.
    'Module CreateDSN

    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Const vbAPINull As Integer = 0 ' NULL Pointer
    Private Const ODBC_ADD_SYS_DSN As Short = 1 ' Add data source

    Public Sub GETCONN()
        Try
            '-------NOTEPAD CODE --------

            Dim STARTPOS, ENDPOS As Integer
            Dim CONNSTR As String
            Dim oRead As System.IO.StreamReader = File.OpenText("C:\CONNECTIONSTRING.txt")
            CONNSTR = oRead.ReadToEnd

            STARTPOS = CONNSTR.IndexOf("=", 0)
            ENDPOS = CONNSTR.IndexOf(";", STARTPOS)
            SERVERNAME = CONNSTR.Substring(STARTPOS + 1, ENDPOS - STARTPOS - 1).Trim

            STARTPOS = CONNSTR.IndexOf("=", ENDPOS)
            ENDPOS = CONNSTR.IndexOf(";", STARTPOS)
            DatabaseName = CONNSTR.Substring(STARTPOS + 1, ENDPOS - STARTPOS - 1).Trim

            If CONNSTR.IndexOf("User ID", ENDPOS) > 0 Then
                STARTPOS = CONNSTR.IndexOf("=", ENDPOS)
                ENDPOS = CONNSTR.IndexOf(";", STARTPOS)
                DBUSERNAME = CONNSTR.Substring(STARTPOS + 1, ENDPOS - STARTPOS - 1).Trim

                STARTPOS = CONNSTR.IndexOf("=", ENDPOS)
                ENDPOS = CONNSTR.IndexOf(";", STARTPOS)
                Dbpassword = CONNSTR.Substring(STARTPOS + 1, ENDPOS - STARTPOS - 1).Trim

                Dbsecurity = False

            Else
                DBUSERNAME = ""
                Dbpassword = ""
                Dbsecurity = True
            End If

            '----------------- NOTEPAD CODE---------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Module
