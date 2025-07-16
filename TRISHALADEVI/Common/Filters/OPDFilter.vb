
Imports BL

Public Class OPDFilter
    Dim fromD
    Dim toD
    Dim a1, a2, a3, a4 As String

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Dim a11, a12, a13, a14 As String

    Sub getFromToDate()
        a1 = DatePart(DateInterval.Day, dtfrom.Value)
        a2 = DatePart(DateInterval.Month, dtfrom.Value)
        a3 = DatePart(DateInterval.Year, dtfrom.Value)
        fromD = "(" & a3 & "," & a2 & "," & a1 & ")"

        a11 = DatePart(DateInterval.Day, dtto.Value)
        a12 = DatePart(DateInterval.Month, dtto.Value)
        a13 = DatePart(DateInterval.Year, dtto.Value)
        toD = "(" & a13 & "," & a12 & "," & a11 & ")"
    End Sub

    Private Sub cmdshow_Click(sender As Object, e As EventArgs) Handles cmdshow.Click
        Try

            Dim OBJOPD As New IPDDesign
            If RDBDTLS.Checked = True Then
                OBJOPD.FRMSTRING = "OPDDAYWISE"
            ElseIf RDBALLBILLS.Checked = True Then
                OBJOPD.FRMSTRING = "OPDALLBILLS"
            End If
            OBJOPD.STRSEARCH = OBJOPD.STRSEARCH & "{OPDMASTER.OPD_YEARID} = " & YearId
            If chkdate.Checked = True Then
                getFromToDate()
                OBJOPD.PERIOD = Format(dtfrom.Value, "dd/MM/yyyy") & " - " & Format(dtto.Value, "dd/MM/yyyy")
                OBJOPD.STRSEARCH = OBJOPD.STRSEARCH & " and {@DATE} in date " & fromD & " to date " & toD & ""
            Else
                OBJOPD.PERIOD = Format(AccFrom, "dd/MM/yyyy") & " - " & Format(AccTo, "dd/MM/yyyy")
            End If

            OBJOPD.MdiParent = MDIMain
            OBJOPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class