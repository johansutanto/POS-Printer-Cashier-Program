Public Class Form3
    Dim a = 0, b = 0
    Dim d = DateTime.Now.ToString("yyyy-MM-dd")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.Value = Date.Now
        Refreshgrid()
    End Sub
    Public Sub Refreshgrid()
        debitgridlap()
        kreditgridlap()
    End Sub

    Sub debitgridlap()
        bukaDB()
        Dim str = "SELECT namacus AS customer,cash AS total, bayar  FROM debit LEFT JOIN customer ON debit.kodecus = customer.kodecus WHERE debit.created::text LIKE '" & d & "'"
        DA = New Odbc.OdbcDataAdapter(str, konek)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "debit")

        tabeldebitlap.DataSource = (DS.Tables("debit"))
        tabeldebitlap.Enabled = True

        'Me.tabeldebitlap.Columns("total").DefaultCellStyle.Format = "c"

        str = "SELECT SUM(cash) FROM debit LEFT JOIN customer ON debit.kodecus = customer.kodecus WHERE debit.created::text LIKE '" & d & "'"
        CMD = New Odbc.OdbcCommand(str, konek)
        a = CMD.ExecuteScalar
        If IsDBNull(a) Then
            a = 0
        End If
        debit.Text = Integer.Parse(a).ToString("c2")
        subtotal.Text = Integer.Parse(a - b).ToString("c2")
    End Sub

    Sub kreditgridlap()
        bukaDB()
        Dim str = "SELECT namacus AS customer,cash AS total FROM kredit LEFT JOIN customer ON kredit.kodecus = customer.kodecus WHERE kredit.created::text LIKE '" & d & "'"
        DA = New Odbc.OdbcDataAdapter(str, konek)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "kredit")
        Me.tabelkreditlap.DataSource = (DS.Tables("kredit"))
        Me.tabelkreditlap.Enabled = True

        'Me.tabelkreditlap.Columns("total").DefaultCellStyle.Format = "c"

        str = "SELECT SUM(cash) FROM kredit LEFT JOIN customer ON kredit.kodecus = customer.kodecus WHERE kredit.created::text LIKE '" & d & "'"
        CMD = New Odbc.OdbcCommand(str, konek)
        b = CMD.ExecuteScalar
        If IsDBNull(b) Then
            b = 0
        End If
        kredit.Text = Integer.Parse(b).ToString("c2")
        subtotal.Text = Integer.Parse(a - b).ToString("c2")
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        d = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Refreshgrid()
    End Sub
End Class