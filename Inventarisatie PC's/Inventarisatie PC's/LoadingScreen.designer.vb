<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingScreen))
        Me.Start_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GDK_START_IMAGE = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GDK_START_IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start_title
        '
        Me.Start_title.AutoSize = True
        Me.Start_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Start_title.Location = New System.Drawing.Point(72, 20)
        Me.Start_title.Name = "Start_title"
        Me.Start_title.Size = New System.Drawing.Size(346, 42)
        Me.Start_title.TabIndex = 1
        Me.Start_title.Text = "Inventarisatie PC's"
        Me.Start_title.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-48, 272)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(566, 271)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'GDK_START_IMAGE
        '
        Me.GDK_START_IMAGE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GDK_START_IMAGE.Image = CType(resources.GetObject("GDK_START_IMAGE.Image"), System.Drawing.Image)
        Me.GDK_START_IMAGE.InitialImage = CType(resources.GetObject("GDK_START_IMAGE.InitialImage"), System.Drawing.Image)
        Me.GDK_START_IMAGE.Location = New System.Drawing.Point(107, 85)
        Me.GDK_START_IMAGE.Name = "GDK_START_IMAGE"
        Me.GDK_START_IMAGE.Size = New System.Drawing.Size(252, 236)
        Me.GDK_START_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GDK_START_IMAGE.TabIndex = 3
        Me.GDK_START_IMAGE.TabStop = False
        Me.GDK_START_IMAGE.UseWaitCursor = True
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(463, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.GDK_START_IMAGE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Start_title)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GDK_START_IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GDK_START_IMAGE As PictureBox
End Class
