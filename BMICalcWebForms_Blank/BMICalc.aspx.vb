Public Class BMICalc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ''' <summary>
    ''' BMI計算をします
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnCalc_Click(sender As Object, e As EventArgs)
    End Sub


    ''' <summary>
    ''' 簡易エラーメッセージ（alert）
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub ShowMessage(message As String)
        Dim script As String = $"alert('{message}');"
        ClientScript.RegisterStartupScript(Me.GetType(), "ALERT_MESSAGE", script, True)
    End Sub

End Class