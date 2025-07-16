
Imports BL

Public Class CmpExciseInf

    Public alParaval As New ArrayList
    Public EDIT As Boolean
    Public TEMPCMPNAME As String

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        Try

            alParaval.Add(txtvatno.Text)
            alParaval.Add(txtcstno.Text)
            alParaval.Add(txtstno.Text)
            alParaval.Add(txtpanno.Text)
            alParaval.Add(txteccno.Text)
            alParaval.Add(txtexno.Text)
            alParaval.Add(txtplano.Text)
            alParaval.Add(txtrange.Text)
            alParaval.Add(txtdivision.Text)
            alParaval.Add(txtcentralexoff.Text)
            alParaval.Add(txtdivisionoff.Text)
            alParaval.Add(txtcommissionerate.Text)
            alParaval.Add(txtheadingno.Text)
            alParaval.Add(txtnotoficationno.Text)

            Me.Hide()
            Cmppassword.alParaval = alParaval
            Cmppassword.EDIT = EDIT
            Cmppassword.TEMPCMPNAME = TEMPCMPNAME
            Cmppassword.ShowDialog()

        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Try
            Dim obj As New Cmpmaster
            Me.Hide()
            obj.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub txtrange_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrange.Validated
        'pcase(txtrange)
    End Sub

    Private Sub txtdivision_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdivision.Validated
        pcase(txtdivision)
    End Sub

    Private Sub txtcentralexoff_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcentralexoff.Validated
        pcase(txtcentralexoff)
    End Sub

    Private Sub txtdivisionoff_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdivisionoff.Validated
        pcase(txtdivisionoff)
    End Sub

    Private Sub CmpExciseInf_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If EDIT = True Then
                Dim OBJCMN As New ClsCommon
                Dim DT As New DataTable
                DT = OBJCMN.search("CMP_VATNO, CMP_CSTNO, CMP_STNO, CMP_PANNO, CMP_ECCNO, CMP_EXCISENO, CMP_PLANO, CMP_RANGE, CMP_DIVISION, CMP_EXCISEOFF, CMP_DIVISIONOFF,CMP_COMMISSIONERATE, CMP_HEADINGNO, CMP_NOTIFICATIONNO ", "", " CMPMASTER", " AND CMP_NAME = '" & TEMPCMPNAME & "'")
                Dim DTROW As DataRow = DT.Rows(0)

                txtvatno.Text = DTROW(0).ToString
                txtcstno.Text = DTROW(1).ToString
                txtstno.Text = DTROW(2).ToString
                txtpanno.Text = DTROW(3).ToString
                txteccno.Text = DTROW(4).ToString
                txtexno.Text = DTROW(5).ToString
                txtplano.Text = DTROW(6).ToString
                txtrange.Text = DTROW(7).ToString
                txtdivision.Text = DTROW(8).ToString
                txtcentralexoff.Text = DTROW(9).ToString
                txtdivisionoff.Text = DTROW(10).ToString
                txtcommissionerate.Text = DTROW(11).ToString
                txtheadingno.Text = DTROW(12).ToString
                txtnotoficationno.Text = DTROW(13).ToString
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub
End Class