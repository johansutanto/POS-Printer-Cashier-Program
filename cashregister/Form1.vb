Imports System.Data.Odbc

Module MdlKoneksi

    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand
    Sub bukaDB()
        konek = New OdbcConnection("Driver={PostgreSQL ANSI};database=cashregister;server=127.0.0.1;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;User ID=postgres;password=admin;")
        konek.Open()
        If konek.State = ConnectionState.Closed Then
            MsgBox("Not Connected To PostGres, Check Your Database!", MsgBoxStyle.MsgBoxSetForeground)
        End If
    End Sub
End Module

Public Class Form1
    Public print1 As String = ""
    Public print2 As Int32 = 0, print3 As Int32 = 0, print4 As Int32 = 0
    Dim a = 0, b = 0
    Dim TextToPrint As String = ""
    Public Sub PrintHeader()

        TextToPrint = ""

        'send Business Name
        Dim StringToPrint As String = "Murah Jaya"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 3)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "Jl. Rajawali 121"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 3))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "(0272)321403"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 3))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        StringToPrint = "(0272)321325"
        LineLen = StringToPrint.Length
        Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 3))
        TextToPrint &= spcLen4b & StringToPrint & Environment.NewLine

        ' send date time
        StringToPrint = Date.Now
        LineLen = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((31 - LineLen) / 3))
        TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine

    End Sub
    Public Sub ItemsToBePrintedDebit()
        Dim globalLengt As Integer = 0
        Dim StringToPrint As String = "Kepada " & print1  'Change here to subtotal
        Dim LineLen As String = 20
        globalLengt = 20
        Dim spcLen5 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine

        StringToPrint = "Total   " & print2.ToString("c2").PadLeft(16, " "c)
        LineLen = globalLengt
        Dim spcLen6 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine

        StringToPrint = "Bayar   " & print3.ToString("c2").PadLeft(16, " "c)
        LineLen = globalLengt
        Dim spcLen7 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= spcLen7 & StringToPrint & Environment.NewLine

        StringToPrint = "Kembali " & print4.ToString("c2").PadLeft(16, " "c)
        LineLen = globalLengt
        Dim spcLen8 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= spcLen8 & StringToPrint & Environment.NewLine & Environment.NewLine

    End Sub

    Public Sub ItemsToBePrintedKredit()
        Dim globalLengt As Integer = 0
        Dim StringToPrint As String = "Kepada " & print1  'Change here to subtotal
        Dim LineLen As String = StringToPrint.Length
        globalLengt = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine

        StringToPrint = "Total   " & print2.ToString("c2")
        LineLen = globalLengt
        Dim spcLen6 As New String(" "c, Math.Round((22 - LineLen)))
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine & Environment.NewLine
    End Sub

    Public Sub PrintDebit()
        PrintHeader()
        ItemsToBePrintedDebit()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub PrintKredit()
        PrintHeader()
        ItemsToBePrintedKredit()
        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.PrinterSettings.PrinterName = "POS-58"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Timer1.Start()
        Dim dt As Date = Date.Today
        Me.ToolStripStatusLabel1.Text = dt
        debit.Text = Integer.Parse(a).ToString("c2")
        kredit.Text = Integer.Parse(b).ToString("c2")
        Refreshgrid()
    End Sub

    Public Sub Refreshgrid()
        debitgrid()
        kreditgrid()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Sub debitgrid()
        bukaDB()

        Dim str = "SELECT namacus AS customer,cash As total, bayar FROM debit LEFT JOIN customer ON debit.kodecus = customer.kodecus WHERE debit.created::text LIKE '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        DA = New Odbc.OdbcDataAdapter(str, konek)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "debit")
        tabeldebit.DataSource = (DS.Tables("debit"))
        tabeldebit.Enabled = True

        Me.tabeldebit.Columns("total").DefaultCellStyle.Format = "c"
        Me.tabeldebit.Columns("bayar").DefaultCellStyle.Format = "c"

        str = "SELECT SUM(cash) FROM debit LEFT JOIN customer ON debit.kodecus = customer.kodecus WHERE debit.created::text LIKE '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        CMD = New Odbc.OdbcCommand(str, konek)
        a = CMD.ExecuteScalar
        If IsDBNull(a) Then
            a = 0
        End If
        debit.Text = Integer.Parse(a).ToString("c2")
        subtotal.Text = Integer.Parse(a - b).ToString("c2")
    End Sub

    Sub kreditgrid()
        bukaDB()
        Dim str = "SELECT namacus AS customer,cash FROM kredit LEFT JOIN customer ON kredit.kodecus = customer.kodecus WHERE kredit.created::text LIKE '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        DA = New Odbc.OdbcDataAdapter(str, konek)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "kredit")
        tabelkredit.DataSource = (DS.Tables("kredit"))
        tabelkredit.Enabled = True

        Me.tabelkredit.Columns("cash").DefaultCellStyle.Format = "c"

        str = "SELECT SUM(cash) FROM kredit LEFT JOIN customer ON kredit.kodecus = customer.kodecus WHERE kredit.created::text LIKE '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        CMD = New Odbc.OdbcCommand(str, konek)
        b = CMD.ExecuteScalar
        If IsDBNull(b) Then
            b = 0
        End If
        kredit.Text = Integer.Parse(b).ToString("c2")
        subtotal.Text = Integer.Parse(a - b).ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New Form2
        form.dk = "debit"

        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form = New Form2
        form.dk = "kredit"
        form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form = New Form3
        form.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 8, FontStyle.Regular)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 8, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        print1 = tabeldebit.SelectedRows.Item(0).Cells.Item(0).Value
        print2 = tabeldebit.SelectedRows.Item(0).Cells.Item(1).Value
        print3 = tabeldebit.SelectedRows.Item(0).Cells.Item(2).Value
        print4 = print3 - print2
        PrintDebit()

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Q Then
            Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.W Then
            Button2_Click(sender, e)
        End If
        If e.KeyCode = Keys.E Then
            Button3_Click(sender, e)
        End If
    End Sub

End Class
