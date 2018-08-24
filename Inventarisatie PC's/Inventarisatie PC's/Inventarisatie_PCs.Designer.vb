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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventarisatie_PCs))
        Me.PCTable = New System.Windows.Forms.DataGridView()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.SearchBoxTitle = New System.Windows.Forms.Label()
        Me.Titel = New System.Windows.Forms.Label()
        Me.Ondertitel = New System.Windows.Forms.Label()
        Me.ExportToExcel = New System.Windows.Forms.Button()
        Me.KroonImage = New System.Windows.Forms.PictureBox()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Datum = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
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
        Me.ImageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogoGDK1 = New System.Windows.Forms.PictureBox()
        Me.ImageTimer2 = New System.Windows.Forms.Timer(Me.components)
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
        'PCTable
        '
        Me.PCTable.AllowUserToAddRows = False
        Me.PCTable.AllowUserToDeleteRows = False
        Me.PCTable.AllowUserToOrderColumns = True
        Me.PCTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PCTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PCTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PCTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.PCTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PCTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PCTable.ColumnHeadersHeight = 25
        Me.PCTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PCTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.PCTable.Location = New System.Drawing.Point(12, 147)
        Me.PCTable.Name = "PCTable"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PCTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.PCTable.RowHeadersVisible = False
        Me.PCTable.RowHeadersWidth = 20
        Me.PCTable.Size = New System.Drawing.Size(1510, 469)
        Me.PCTable.TabIndex = 2
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
        Me.SearchBoxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBoxTitle.Location = New System.Drawing.Point(1305, 80)
        Me.SearchBoxTitle.Name = "SearchBoxTitle"
        Me.SearchBoxTitle.Size = New System.Drawing.Size(97, 25)
        Me.SearchBoxTitle.TabIndex = 5
        Me.SearchBoxTitle.Text = "Zoeken:"
        '
        'Titel
        '
        Me.Titel.AutoSize = True
        Me.Titel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Titel.Location = New System.Drawing.Point(606, 12)
        Me.Titel.Name = "Titel"
        Me.Titel.Size = New System.Drawing.Size(325, 39)
        Me.Titel.TabIndex = 6
        Me.Titel.Text = "Inventarisatie PC's"
        '
        'Ondertitel
        '
        Me.Ondertitel.AutoSize = True
        Me.Ondertitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ondertitel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Ondertitel.Location = New System.Drawing.Point(638, 51)
        Me.Ondertitel.Name = "Ondertitel"
        Me.Ondertitel.Size = New System.Drawing.Size(241, 33)
        Me.Ondertitel.TabIndex = 7
        Me.Ondertitel.Text = "Gebr. de Koning"
        '
        'ExportToExcel
        '
        Me.ExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ExportToExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ExportToExcel.Location = New System.Drawing.Point(251, 15)
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
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(712, 619)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(71, 15)
        Me.Copyright.TabIndex = 11
        Me.Copyright.Text = "Copyright "
        '
        'Datum
        '
        Me.Datum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datum.AutoSize = True
        Me.Datum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datum.Location = New System.Drawing.Point(1303, 23)
        Me.Datum.Name = "Datum"
        Me.Datum.Size = New System.Drawing.Size(75, 25)
        Me.Datum.TabIndex = 12
        Me.Datum.Text = "Date: "
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        Me.DateTime.Interval = 1000
        '
        'Tijd
        '
        Me.Tijd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tijd.AutoSize = True
        Me.Tijd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tijd.Location = New System.Drawing.Point(1302, 51)
        Me.Tijd.Name = "Tijd"
        Me.Tijd.Size = New System.Drawing.Size(70, 25)
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
        'ImageTimer
        '
        Me.ImageTimer.Interval = 65
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
        'ImageTimer2
        '
        Me.ImageTimer2.Interval = 1
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
        Me.Controls.Add(Me.Ondertitel)
        Me.Controls.Add(Me.Titel)
        Me.Controls.Add(Me.SearchBoxTitle)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.PCTable)
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
    Friend WithEvents PCTable As DataGridView
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents SearchBoxTitle As Label
    Friend WithEvents Titel As Label
    Friend WithEvents Ondertitel As Label
    Friend WithEvents ExportToExcel As Button
    Friend WithEvents KroonImage As PictureBox
    Friend WithEvents Copyright As Label
    Friend WithEvents Datum As Label
    Friend WithEvents DateTime As Timer
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
    Friend WithEvents ImageTimer As Timer
    Friend WithEvents LogoGDK1 As PictureBox
    Friend WithEvents ImageTimer2 As Timer
End Class
