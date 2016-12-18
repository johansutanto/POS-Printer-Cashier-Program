Public Class Form2
    Dim f As Long
    Dim f2 As Long

    Private _dk As String = ""
    Friend Property dk As String
        Get
            Return _dk
        End Get
        Set(ByVal value As String)
            _dk = value
        End Set
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str
        If (Nama.Text = "" Or Nota.Text = "" Or Uang.Text = "") And dk = "debit" Then
            MsgBox("Masukan Kostumer dan Cash!")
        ElseIf (f2 - f < 0) And dk = "debit" Then
            MsgBox("Cash tidak boleh kurang!")
        ElseIf (Nama.Text = "" Or Nota.Text = "") And dk = "kredit" Then
            MsgBox("Masukan Kostumer dan Cash!")
        Else
            bukaDB()
            Str = "SELECT kodecus FROM customer WHERE namacus LIKE '" & Nama.Text & "'"
            CMD = New Odbc.OdbcCommand(Str, konek)

            If CMD.ExecuteNonQuery = 0 Then
                Str = "SELECT kodecus FROM customer ORDER BY kodecus DESC LIMIT 1"
                CMD = New Odbc.OdbcCommand(Str, konek)
                Dim maxid As Integer = CMD.ExecuteScalar()
                Id.Text = maxid + 1
                Str = "INSERT INTO customer(kodecus,namacus) VALUES (" & Id.Text & ",'" & Nama.Text & "')"
                CMD = New Odbc.OdbcCommand(Str, konek)
                CMD.ExecuteNonQuery()
            End If
            Dim myform As Form1
            If dk = "debit" Then
                Str = "INSERT INTO " & _dk & "(cash,kodecus,bayar) VALUES (" & f & ",'" & Id.Text & "'," & f2 & ")"
                myform = New Form1
                myform.print1 = Nama.Text
                myform.print2 = f
                myform.print3 = f2
                myform.print4 = f2 - f
                myform.PrintDebit()
            Else
                Str = "INSERT INTO " & _dk & "(cash,kodecus) VALUES (" & f & ",'" & Id.Text & "')"
                myform = New Form1
                myform.print1 = Nama.Text
                myform.print2 = f
                myform.PrintKredit()
            End If
            CMD = New Odbc.OdbcCommand(Str, konek)
            CMD.ExecuteNonQuery()
            Form1.Refreshgrid()
            Me.Close()
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text += " " & dk
        If dk = "kredit" Then
            Label2.Hide()
            Uang.Hide()
        End If
        bukaDB()
        Dim str = "SELECT namacus,kodecus FROM customer"
        DA = New Odbc.OdbcDataAdapter(str, konek)
        Dim DT = New DataTable
        DA.Fill(DT)
        Dim col As New AutoCompleteStringCollection
        'Melakukan perulangan untuk mengisi col sebanyak data dari datatable 17     
        For i As Integer = 0 To DT.Rows.Count - 1
            col.Add(DT.Rows(i)("namacus"))
        Next
        Nama.AutoCompleteSource = AutoCompleteSource.CustomSource
        Nama.AutoCompleteCustomSource = col
        Nama.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nota.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Nota.TextChanged
        If Nota.Text = "" Then
            Nota.Text = "0"
        End If
        f = Nota.Text
        Nota.Text = Format(f, "##,##0")
        Nota.SelectionStart = Len(Nota.Text)
        subtotal.Text = (f2 - f).ToString("c2")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Nama.TextChanged
        Dim str = "SELECT kodecus FROM customer WHERE namacus LIKE '" & Nama.Text & "'"
        CMD = New Odbc.OdbcCommand(str, konek)
        str = CMD.ExecuteScalar
        Id.Text = str
        If Nama.Text.Count > 16 Then
            Nama.Text = Nama.Text.Remove(16, 1)
            Nama.SelectionStart = 16
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Uang_Keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Uang.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Uang_TextChanged(sender As Object, e As EventArgs) Handles Uang.TextChanged
        If Uang.Text = "" Then
            Uang.Text = "0"
        End If
        f2 = Uang.Text
        Uang.Text = Format(f2, "##,##0")
        Uang.SelectionStart = Len(Nota.Text)
        subtotal.Text = (f2 - f).ToString("c2")
    End Sub
End Class