<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventarisatie_PCs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventarisatie_PCs))
        Me.LoadInFiles = New System.Windows.Forms.Button()
        Me.PCTable = New System.Windows.Forms.DataGridView()
        Me.ClearTable = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.SearchBoxTitle = New System.Windows.Forms.Label()
        Me.Titel = New System.Windows.Forms.Label()
        Me.Ondertitel = New System.Windows.Forms.Label()
        Me.DeleteDuplicates = New System.Windows.Forms.Button()
        Me.ExportToExcel = New System.Windows.Forms.Button()
        Me.KroonImage = New System.Windows.Forms.PictureBox()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Datum = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tijd = New System.Windows.Forms.Label()
        Me.LogoGDK2 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK3 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK4 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK5 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK6 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK7 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK8 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK9 = New System.Windows.Forms.PictureBox()
        Me.LogoGDK10 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LogoGDK1 = New System.Windows.Forms.PictureBox()
        CType(Me.PCTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KroonImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoGDK1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadInFiles
        '
        Me.LoadInFiles.Font = New System.Drawing.Font("Klavika Rg", 13.0!, System.Drawing.FontStyle.Bold)
        Me.LoadInFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LoadInFiles.Location = New System.Drawing.Point(231, 16)
        Me.LoadInFiles.Name = "LoadInFiles"
        Me.LoadInFiles.Size = New System.Drawing.Size(333, 46)
        Me.LoadInFiles.TabIndex = 1
        Me.LoadInFiles.Text = "Ophalen gegevens"
        Me.LoadInFiles.UseVisualStyleBackColor = True
        '
        'PCTable
        '
        Me.PCTable.AllowUserToAddRows = False
        Me.PCTable.AllowUserToDeleteRows = False
        Me.PCTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PCTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PCTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PCTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.PCTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Klavika Bd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PCTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PCTable.ColumnHeadersHeight = 30
        Me.PCTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PCTable.DefaultCellStyle = DataGridViewCellStyle5
        Me.PCTable.Location = New System.Drawing.Point(12, 147)
        Me.PCTable.Name = "PCTable"
        Me.PCTable.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PCTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.PCTable.RowHeadersVisible = False
        Me.PCTable.RowHeadersWidth = 20
        Me.PCTable.Size = New System.Drawing.Size(1510, 469)
        Me.PCTable.TabIndex = 2
        '
        'ClearTable
        '
        Me.ClearTable.Font = New System.Drawing.Font("Klavika Rg", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ClearTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClearTable.Location = New System.Drawing.Point(948, 79)
        Me.ClearTable.Name = "ClearTable"
        Me.ClearTable.Size = New System.Drawing.Size(333, 47)
        Me.ClearTable.TabIndex = 3
        Me.ClearTable.Text = "Leeg de tabel"
        Me.ClearTable.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.SearchBox.Location = New System.Drawing.Point(1309, 107)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(213, 26)
        Me.SearchBox.TabIndex = 4
        '
        'SearchBoxTitle
        '
        Me.SearchBoxTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBoxTitle.AutoSize = True
        Me.SearchBoxTitle.Font = New System.Drawing.Font("Klavika Bd", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBoxTitle.Location = New System.Drawing.Point(1305, 80)
        Me.SearchBoxTitle.Name = "SearchBoxTitle"
        Me.SearchBoxTitle.Size = New System.Drawing.Size(82, 24)
        Me.SearchBoxTitle.TabIndex = 5
        Me.SearchBoxTitle.Text = "Zoeken:"
        '
        'Titel
        '
        Me.Titel.AutoSize = True
        Me.Titel.Font = New System.Drawing.Font("Klavika Rg", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Titel.Location = New System.Drawing.Point(606, 12)
        Me.Titel.Name = "Titel"
        Me.Titel.Size = New System.Drawing.Size(301, 39)
        Me.Titel.TabIndex = 6
        Me.Titel.Text = "Inventarisatie PC's"
        '
        'Ondertitel
        '
        Me.Ondertitel.AutoSize = True
        Me.Ondertitel.Font = New System.Drawing.Font("Klavika Rg", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ondertitel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Ondertitel.Location = New System.Drawing.Point(638, 51)
        Me.Ondertitel.Name = "Ondertitel"
        Me.Ondertitel.Size = New System.Drawing.Size(213, 33)
        Me.Ondertitel.TabIndex = 7
        Me.Ondertitel.Text = "Gebr. de Koning"
        '
        'DeleteDuplicates
        '
        Me.DeleteDuplicates.Font = New System.Drawing.Font("Klavika Rg", 13.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteDuplicates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DeleteDuplicates.Location = New System.Drawing.Point(231, 80)
        Me.DeleteDuplicates.Name = "DeleteDuplicates"
        Me.DeleteDuplicates.Size = New System.Drawing.Size(333, 46)
        Me.DeleteDuplicates.TabIndex = 8
        Me.DeleteDuplicates.Text = "Verwijder dubbele werkstations"
        Me.DeleteDuplicates.UseVisualStyleBackColor = True
        '
        'ExportToExcel
        '
        Me.ExportToExcel.Font = New System.Drawing.Font("Klavika Rg", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ExportToExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ExportToExcel.Location = New System.Drawing.Point(948, 16)
        Me.ExportToExcel.Name = "ExportToExcel"
        Me.ExportToExcel.Size = New System.Drawing.Size(333, 46)
        Me.ExportToExcel.TabIndex = 9
        Me.ExportToExcel.Text = "Exporteren naar Excel"
        Me.ExportToExcel.UseVisualStyleBackColor = True
        '
        'KroonImage
        '
        Me.KroonImage.Image = CType(resources.GetObject("KroonImage.Image"), System.Drawing.Image)
        Me.KroonImage.Location = New System.Drawing.Point(718, 87)
        Me.KroonImage.Name = "KroonImage"
        Me.KroonImage.Size = New System.Drawing.Size(55, 43)
        Me.KroonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.KroonImage.TabIndex = 10
        Me.KroonImage.TabStop = False
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Klavika Rg", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(712, 619)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(61, 14)
        Me.Copyright.TabIndex = 11
        Me.Copyright.Text = "Copyright "
        '
        'Datum
        '
        Me.Datum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datum.AutoSize = True
        Me.Datum.Font = New System.Drawing.Font("Klavika Rg", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datum.Location = New System.Drawing.Point(1303, 23)
        Me.Datum.Name = "Datum"
        Me.Datum.Size = New System.Drawing.Size(64, 24)
        Me.Datum.TabIndex = 12
        Me.Datum.Text = "Date: "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Tijd
        '
        Me.Tijd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tijd.AutoSize = True
        Me.Tijd.Font = New System.Drawing.Font("Klavika Rg", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tijd.Location = New System.Drawing.Point(1302, 51)
        Me.Tijd.Name = "Tijd"
        Me.Tijd.Size = New System.Drawing.Size(63, 24)
        Me.Tijd.TabIndex = 13
        Me.Tijd.Text = "Time:"
        '
        'LogoGDK2
        '
        Me.LogoGDK2.Image = CType(resources.GetObject("LogoGDK2.Image"), System.Drawing.Image)
        Me.LogoGDK2.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK2.Name = "LogoGDK2"
        Me.LogoGDK2.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK2.TabIndex = 14
        Me.LogoGDK2.TabStop = False
        Me.LogoGDK2.Visible = False
        '
        'LogoGDK3
        '
        Me.LogoGDK3.Image = CType(resources.GetObject("LogoGDK3.Image"), System.Drawing.Image)
        Me.LogoGDK3.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK3.Name = "LogoGDK3"
        Me.LogoGDK3.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK3.TabIndex = 15
        Me.LogoGDK3.TabStop = False
        Me.LogoGDK3.Visible = False
        '
        'LogoGDK4
        '
        Me.LogoGDK4.Image = CType(resources.GetObject("LogoGDK4.Image"), System.Drawing.Image)
        Me.LogoGDK4.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK4.Name = "LogoGDK4"
        Me.LogoGDK4.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK4.TabIndex = 16
        Me.LogoGDK4.TabStop = False
        Me.LogoGDK4.Visible = False
        '
        'LogoGDK5
        '
        Me.LogoGDK5.Image = CType(resources.GetObject("LogoGDK5.Image"), System.Drawing.Image)
        Me.LogoGDK5.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK5.Name = "LogoGDK5"
        Me.LogoGDK5.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK5.TabIndex = 17
        Me.LogoGDK5.TabStop = False
        Me.LogoGDK5.Visible = False
        '
        'LogoGDK6
        '
        Me.LogoGDK6.Image = CType(resources.GetObject("LogoGDK6.Image"), System.Drawing.Image)
        Me.LogoGDK6.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK6.Name = "LogoGDK6"
        Me.LogoGDK6.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK6.TabIndex = 18
        Me.LogoGDK6.TabStop = False
        Me.LogoGDK6.Visible = False
        '
        'LogoGDK7
        '
        Me.LogoGDK7.Image = CType(resources.GetObject("LogoGDK7.Image"), System.Drawing.Image)
        Me.LogoGDK7.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK7.Name = "LogoGDK7"
        Me.LogoGDK7.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK7.TabIndex = 19
        Me.LogoGDK7.TabStop = False
        Me.LogoGDK7.Visible = False
        '
        'LogoGDK8
        '
        Me.LogoGDK8.Image = CType(resources.GetObject("LogoGDK8.Image"), System.Drawing.Image)
        Me.LogoGDK8.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK8.Name = "LogoGDK8"
        Me.LogoGDK8.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK8.TabIndex = 20
        Me.LogoGDK8.TabStop = False
        Me.LogoGDK8.Visible = False
        '
        'LogoGDK9
        '
        Me.LogoGDK9.Image = CType(resources.GetObject("LogoGDK9.Image"), System.Drawing.Image)
        Me.LogoGDK9.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK9.Name = "LogoGDK9"
        Me.LogoGDK9.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK9.TabIndex = 21
        Me.LogoGDK9.TabStop = False
        Me.LogoGDK9.Visible = False
        '
        'LogoGDK10
        '
        Me.LogoGDK10.Image = CType(resources.GetObject("LogoGDK10.Image"), System.Drawing.Image)
        Me.LogoGDK10.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK10.Name = "LogoGDK10"
        Me.LogoGDK10.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK10.TabIndex = 22
        Me.LogoGDK10.TabStop = False
        Me.LogoGDK10.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 65
        '
        'LogoGDK1
        '
        Me.LogoGDK1.Image = CType(resources.GetObject("LogoGDK1.Image"), System.Drawing.Image)
        Me.LogoGDK1.Location = New System.Drawing.Point(26, 12)
        Me.LogoGDK1.Name = "LogoGDK1"
        Me.LogoGDK1.Size = New System.Drawing.Size(190, 132)
        Me.LogoGDK1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoGDK1.TabIndex = 25
        Me.LogoGDK1.TabStop = False
        '
        'Inventarisatie_PCs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1534, 641)
        Me.Controls.Add(Me.LogoGDK1)
        Me.Controls.Add(Me.LogoGDK10)
        Me.Controls.Add(Me.LogoGDK9)
        Me.Controls.Add(Me.LogoGDK8)
        Me.Controls.Add(Me.LogoGDK7)
        Me.Controls.Add(Me.LogoGDK6)
        Me.Controls.Add(Me.LogoGDK5)
        Me.Controls.Add(Me.LogoGDK4)
        Me.Controls.Add(Me.LogoGDK3)
        Me.Controls.Add(Me.LogoGDK2)
        Me.Controls.Add(Me.Tijd)
        Me.Controls.Add(Me.Datum)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.KroonImage)
        Me.Controls.Add(Me.ExportToExcel)
        Me.Controls.Add(Me.DeleteDuplicates)
        Me.Controls.Add(Me.Ondertitel)
        Me.Controls.Add(Me.Titel)
        Me.Controls.Add(Me.SearchBoxTitle)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.ClearTable)
        Me.Controls.Add(Me.PCTable)
        Me.Controls.Add(Me.LoadInFiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventarisatie_PCs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventarisatie PC's"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PCTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KroonImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoGDK1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadInFiles As Button
    Friend WithEvents PCTable As DataGridView
    Friend WithEvents ClearTable As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents SearchBoxTitle As Label
    Friend WithEvents Titel As Label
    Friend WithEvents Ondertitel As Label
    Friend WithEvents DeleteDuplicates As Button
    Friend WithEvents ExportToExcel As Button
    Friend WithEvents KroonImage As PictureBox
    Friend WithEvents Copyright As Label
    Friend WithEvents Datum As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Tijd As Label
    Friend WithEvents LogoGDK2 As PictureBox
    Friend WithEvents LogoGDK3 As PictureBox
    Friend WithEvents LogoGDK4 As PictureBox
    Friend WithEvents LogoGDK5 As PictureBox
    Friend WithEvents LogoGDK6 As PictureBox
    Friend WithEvents LogoGDK7 As PictureBox
    Friend WithEvents LogoGDK8 As PictureBox
    Friend WithEvents LogoGDK9 As PictureBox
    Friend WithEvents LogoGDK10 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LogoGDK1 As PictureBox
End Class
