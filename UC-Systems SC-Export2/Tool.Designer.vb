<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tool
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tool))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkeerAlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillableGeenStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonBillableGeenStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkkoordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeFacturerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfgehandeldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GefactureerdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NietGeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UrenOmzettenNaarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvondUrenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekendUrenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalenUrenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporteerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkeerAlsToolStripMenuItem, Me.UrenOmzettenNaarToolStripMenuItem, Me.ExporteerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.ShowImageMargin = False
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'MarkeerAlsToolStripMenuItem
        '
        Me.MarkeerAlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillableGeenStatusToolStripMenuItem, Me.NonBillableGeenStatusToolStripMenuItem, Me.BilledToolStripMenuItem, Me.AkkoordToolStripMenuItem, Me.AfgehandeldToolStripMenuItem})
        Me.MarkeerAlsToolStripMenuItem.Name = "MarkeerAlsToolStripMenuItem"
        resources.ApplyResources(Me.MarkeerAlsToolStripMenuItem, "MarkeerAlsToolStripMenuItem")
        '
        'BillableGeenStatusToolStripMenuItem
        '
        Me.BillableGeenStatusToolStripMenuItem.Name = "BillableGeenStatusToolStripMenuItem"
        resources.ApplyResources(Me.BillableGeenStatusToolStripMenuItem, "BillableGeenStatusToolStripMenuItem")
        '
        'NonBillableGeenStatusToolStripMenuItem
        '
        Me.NonBillableGeenStatusToolStripMenuItem.Name = "NonBillableGeenStatusToolStripMenuItem"
        resources.ApplyResources(Me.NonBillableGeenStatusToolStripMenuItem, "NonBillableGeenStatusToolStripMenuItem")
        '
        'BilledToolStripMenuItem
        '
        Me.BilledToolStripMenuItem.Name = "BilledToolStripMenuItem"
        resources.ApplyResources(Me.BilledToolStripMenuItem, "BilledToolStripMenuItem")
        '
        'AkkoordToolStripMenuItem
        '
        Me.AkkoordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceToolStripMenuItem, Me.TeFacturerenToolStripMenuItem})
        Me.AkkoordToolStripMenuItem.Name = "AkkoordToolStripMenuItem"
        resources.ApplyResources(Me.AkkoordToolStripMenuItem, "AkkoordToolStripMenuItem")
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        resources.ApplyResources(Me.ServiceToolStripMenuItem, "ServiceToolStripMenuItem")
        '
        'TeFacturerenToolStripMenuItem
        '
        Me.TeFacturerenToolStripMenuItem.Name = "TeFacturerenToolStripMenuItem"
        resources.ApplyResources(Me.TeFacturerenToolStripMenuItem, "TeFacturerenToolStripMenuItem")
        '
        'AfgehandeldToolStripMenuItem
        '
        Me.AfgehandeldToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceToolStripMenuItem1, Me.GefactureerdToolStripMenuItem, Me.NietGeToolStripMenuItem})
        Me.AfgehandeldToolStripMenuItem.Name = "AfgehandeldToolStripMenuItem"
        resources.ApplyResources(Me.AfgehandeldToolStripMenuItem, "AfgehandeldToolStripMenuItem")
        '
        'ServiceToolStripMenuItem1
        '
        Me.ServiceToolStripMenuItem1.Name = "ServiceToolStripMenuItem1"
        resources.ApplyResources(Me.ServiceToolStripMenuItem1, "ServiceToolStripMenuItem1")
        '
        'GefactureerdToolStripMenuItem
        '
        Me.GefactureerdToolStripMenuItem.Name = "GefactureerdToolStripMenuItem"
        resources.ApplyResources(Me.GefactureerdToolStripMenuItem, "GefactureerdToolStripMenuItem")
        '
        'NietGeToolStripMenuItem
        '
        Me.NietGeToolStripMenuItem.Name = "NietGeToolStripMenuItem"
        resources.ApplyResources(Me.NietGeToolStripMenuItem, "NietGeToolStripMenuItem")
        '
        'UrenOmzettenNaarToolStripMenuItem
        '
        Me.UrenOmzettenNaarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvondUrenToolStripMenuItem, Me.WeekendUrenToolStripMenuItem, Me.NormalenUrenToolStripMenuItem})
        Me.UrenOmzettenNaarToolStripMenuItem.Name = "UrenOmzettenNaarToolStripMenuItem"
        resources.ApplyResources(Me.UrenOmzettenNaarToolStripMenuItem, "UrenOmzettenNaarToolStripMenuItem")
        '
        'AvondUrenToolStripMenuItem
        '
        Me.AvondUrenToolStripMenuItem.Name = "AvondUrenToolStripMenuItem"
        resources.ApplyResources(Me.AvondUrenToolStripMenuItem, "AvondUrenToolStripMenuItem")
        '
        'WeekendUrenToolStripMenuItem
        '
        Me.WeekendUrenToolStripMenuItem.Name = "WeekendUrenToolStripMenuItem"
        resources.ApplyResources(Me.WeekendUrenToolStripMenuItem, "WeekendUrenToolStripMenuItem")
        '
        'NormalenUrenToolStripMenuItem
        '
        Me.NormalenUrenToolStripMenuItem.Name = "NormalenUrenToolStripMenuItem"
        resources.ApplyResources(Me.NormalenUrenToolStripMenuItem, "NormalenUrenToolStripMenuItem")
        '
        'ExporteerToolStripMenuItem
        '
        Me.ExporteerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectieToolStripMenuItem, Me.AllesToolStripMenuItem})
        Me.ExporteerToolStripMenuItem.Name = "ExporteerToolStripMenuItem"
        resources.ApplyResources(Me.ExporteerToolStripMenuItem, "ExporteerToolStripMenuItem")
        '
        'SelectieToolStripMenuItem
        '
        Me.SelectieToolStripMenuItem.Name = "SelectieToolStripMenuItem"
        resources.ApplyResources(Me.SelectieToolStripMenuItem, "SelectieToolStripMenuItem")
        '
        'AllesToolStripMenuItem
        '
        Me.AllesToolStripMenuItem.Name = "AllesToolStripMenuItem"
        resources.ApplyResources(Me.AllesToolStripMenuItem, "AllesToolStripMenuItem")
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.DataGridView2, "DataGridView2")
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.TabStop = False
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Spring = True
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        Me.ToolStripProgressBar1.Step = 25
        '
        'StatusStrip2
        '
        resources.ApplyResources(Me.StatusStrip2, "StatusStrip2")
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.SizingGrip = False
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePicker2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePicker3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4"), resources.GetString("ComboBox1.Items5"), resources.GetString("ComboBox1.Items6"), resources.GetString("ComboBox1.Items7"), resources.GetString("ComboBox1.Items8")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'DateTimePicker2
        '
        resources.ApplyResources(Me.DateTimePicker2, "DateTimePicker2")
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Name = "DateTimePicker2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'DateTimePicker3
        '
        resources.ApplyResources(Me.DateTimePicker3, "DateTimePicker3")
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Name = "DateTimePicker3"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Tool
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.HelpButton = True
        Me.Name = "Tool"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents UrenOmzettenNaarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvondUrenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeekendUrenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalenUrenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkeerAlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillableGeenStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonBillableGeenStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AkkoordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeFacturerenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfgehandeldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GefactureerdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NietGeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExporteerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
