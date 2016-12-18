<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelkredit = New System.Windows.Forms.Label()
        Me.kredit = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labeldebit = New System.Windows.Forms.Label()
        Me.debit = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabeldebitlap = New System.Windows.Forms.DataGridView()
        Me.tabelkreditlap = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.tabeldebitlap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelkreditlap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 541)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(760, 101)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.subtotal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(509, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(248, 95)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subtotal"
        '
        'subtotal
        '
        Me.subtotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.subtotal.Font = New System.Drawing.Font("Minion Pro", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.Location = New System.Drawing.Point(5, 48)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.subtotal.Size = New System.Drawing.Size(238, 42)
        Me.subtotal.TabIndex = 0
        Me.subtotal.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.labelkredit)
        Me.Panel2.Controls.Add(Me.kredit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(256, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(247, 94)
        Me.Panel2.TabIndex = 3
        '
        'labelkredit
        '
        Me.labelkredit.AutoSize = True
        Me.labelkredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelkredit.Location = New System.Drawing.Point(8, 5)
        Me.labelkredit.Name = "labelkredit"
        Me.labelkredit.Size = New System.Drawing.Size(50, 20)
        Me.labelkredit.TabIndex = 1
        Me.labelkredit.Text = "Kredit"
        '
        'kredit
        '
        Me.kredit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kredit.Font = New System.Drawing.Font("Minion Pro", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kredit.Location = New System.Drawing.Point(5, 47)
        Me.kredit.Name = "kredit"
        Me.kredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.kredit.Size = New System.Drawing.Size(237, 42)
        Me.kredit.TabIndex = 0
        Me.kredit.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.labeldebit)
        Me.Panel1.Controls.Add(Me.debit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(247, 94)
        Me.Panel1.TabIndex = 2
        '
        'labeldebit
        '
        Me.labeldebit.AutoSize = True
        Me.labeldebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeldebit.Location = New System.Drawing.Point(8, 5)
        Me.labeldebit.Name = "labeldebit"
        Me.labeldebit.Size = New System.Drawing.Size(47, 20)
        Me.labeldebit.TabIndex = 1
        Me.labeldebit.Text = "Debit"
        '
        'debit
        '
        Me.debit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.debit.Font = New System.Drawing.Font("Minion Pro", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debit.Location = New System.Drawing.Point(5, 47)
        Me.debit.Name = "debit"
        Me.debit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.debit.Size = New System.Drawing.Size(237, 42)
        Me.debit.TabIndex = 0
        Me.debit.Text = "0"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tabeldebitlap, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tabelkreditlap, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 541)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 521)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Debit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Kredit"
        '
        'tabeldebitlap
        '
        Me.tabeldebitlap.AllowUserToAddRows = False
        Me.tabeldebitlap.AllowUserToDeleteRows = False
        Me.tabeldebitlap.AllowUserToResizeColumns = False
        Me.tabeldebitlap.AllowUserToResizeRows = False
        Me.tabeldebitlap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabeldebitlap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tabeldebitlap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabeldebitlap.Location = New System.Drawing.Point(3, 3)
        Me.tabeldebitlap.MultiSelect = False
        Me.tabeldebitlap.Name = "tabeldebitlap"
        Me.tabeldebitlap.ReadOnly = True
        Me.tabeldebitlap.RowHeadersVisible = False
        Me.tabeldebitlap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.tabeldebitlap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabeldebitlap.Size = New System.Drawing.Size(374, 515)
        Me.tabeldebitlap.TabIndex = 3
        '
        'tabelkreditlap
        '
        Me.tabelkreditlap.AllowUserToAddRows = False
        Me.tabelkreditlap.AllowUserToDeleteRows = False
        Me.tabelkreditlap.AllowUserToResizeColumns = False
        Me.tabelkreditlap.AllowUserToResizeRows = False
        Me.tabelkreditlap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabelkreditlap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelkreditlap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelkreditlap.Location = New System.Drawing.Point(383, 3)
        Me.tabelkreditlap.MultiSelect = False
        Me.tabelkreditlap.Name = "tabelkreditlap"
        Me.tabelkreditlap.ReadOnly = True
        Me.tabelkreditlap.RowHeadersVisible = False
        Me.tabelkreditlap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelkreditlap.Size = New System.Drawing.Size(374, 515)
        Me.tabelkreditlap.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 648)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 12
        Me.DateTimePicker1.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 697)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Laporan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.tabeldebitlap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelkreditlap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelkredit As Label
    Friend WithEvents kredit As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labeldebit As Label
    Friend WithEvents debit As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabeldebitlap As DataGridView
    Friend WithEvents tabelkreditlap As DataGridView
End Class
