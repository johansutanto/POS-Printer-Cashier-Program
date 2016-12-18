Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str = "SELECT password FROM database LIMIT 1"
        CMD = New Odbc.OdbcCommand(Str, konek)
        Dim a = CMD.ExecuteScalar
        If a = TextBox1.Text Then
            Dim form = New Form2
            form.dk = "kredit"
            form.ShowDialog()
            Me.Visible = False
        Else
            MsgBox("Password Salah!")
        End If
    End Sub

End Class