Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Inventarisatie_PCs
    Private Structure Computer
        Public Datum As Date
        Public User As String
        Public Workstation As String
        Public Manufacturer As String
        Public Model As String
        Public OS As String
        Public Architecture As String
        Public RAM As Integer
        Public CPU As CPU
        Public GPU As GPU
        Public FreeSpace As Integer
        Public Disks() As Disk
    End Structure

    Private Structure CPU
        Public Name As String
        Public Benchmark As Integer
    End Structure

    Private Structure GPU
        Public Name As String
        Public Benchmark As Integer
    End Structure

    Private Structure Disk
        Public DiskName As String
        Public DiskMediaType As String
        Public DiskTotalSpace As Integer
    End Structure

    Private CPUs() As CPU
    Private GPUs() As GPU
    Private dt As New DataTable
    Private bs As New BindingSource
    Private dataGeladen As Boolean = False
    Private duplicatesCleared As Boolean = False
    Private imageNumber = 1

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtensionMethods.DoubleBuffered(PCTable, True)
        Copyright.Text = "Copyright " + Chr(169) + " 2018 - All rights reserved - Gebr. de Koning Papendrecht - Yanoah Wiersma"
        PositionControls()

        With dt.Columns
            .Add("Datum en tijd", GetType(Date))
            .Add("Username", GetType(String))
            .Add("Werkstation", GetType(String))
            .Add("Manufacturer", GetType(String))
            .Add("Model", GetType(String))
            .Add("Operating System", GetType(String))
            .Add("Architecture", GetType(String))
            .Add("Werkgeheugen (GB)", GetType(Integer))
            .Add("Processor", GetType(String))
            .Add("Processor Benchmark", GetType(Integer))
            .Add("Video Card", GetType(String))
            .Add("Video Card Benchmark", GetType(Integer))
            .Add("Vrije ruimte C-schijf (GB)", GetType(Integer))
            .Add("Disk 1: Naam", GetType(String))
            .Add("Disk 1: Media Type", GetType(String))
            .Add("Disk 1: Total Space (GB)", GetType(Integer))
            .Add("Disk 2: Naam", GetType(String))
            .Add("Disk 2: Media Type", GetType(String))
            .Add("Disk 2: Total Space (GB)", GetType(Integer))
        End With

        bs.DataSource = dt
        PCTable.DataSource = dt
    End Sub

    Private Sub PositionControls()
        Dim pT As New Point
        pT.X = (Me.Width / 2) - (Titel.Width / 2)
        pT.Y = Titel.Top
        Titel.Location = pT

        Dim pOT As New Point
        pOT.X = (Me.Width / 2) - (Ondertitel.Width / 2)
        pOT.Y = Ondertitel.Top
        Ondertitel.Location = pOT

        Dim pC As New Point
        pC.X = (Me.Width / 2) - (Copyright.Width / 2)
        pC.Y = Me.Height - 60
        Copyright.Location = pC

        Dim pI As New Point
        pI.X = (Me.Width / 2) - (KroonImage.Width / 2)
        pI.Y = KroonImage.Top
        KroonImage.Location = pI

        Dim pB1 As New Point
        pB1.X = (Me.Width / 4) - (LoadInFiles.Width / 2)
        pB1.Y = LoadInFiles.Top
        LoadInFiles.Location = pB1
        LoadInFiles.Width = (Me.Width / 6)

        Dim pB2 As New Point
        pB2.X = (Me.Width / 4) - (DeleteDuplicates.Width / 2)
        pB2.Y = DeleteDuplicates.Top
        DeleteDuplicates.Location = pB2
        DeleteDuplicates.Width = (Me.Width / 6)

        Dim pB3 As New Point
        pB3.X = (Me.Width / 4 * 3) - (ExportToExcel.Width / 2)
        pB3.Y = ExportToExcel.Top
        ExportToExcel.Location = pB3
        ExportToExcel.Width = (Me.Width / 6)

        Dim pB4 As New Point
        pB4.X = (Me.Width / 4 * 3) - (ClearTable.Width / 2)
        pB4.Y = ClearTable.Top
        ClearTable.Location = pB4
        ClearTable.Width = (Me.Width / 6)
    End Sub

    Private Sub ExportToExcelAction()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = Reflection.Missing.Value
        xlApp = CreateObject("Excel.Application")

        Dim i As Integer, j As Integer
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = xlWorkBook.ActiveSheet

        xlApp.Visible = True
        xlApp.ActiveWindow.WindowState = Excel.XlWindowState.xlMaximized
        xlApp.ScreenUpdating = False
        xlApp.Calculation = Excel.XlCalculation.xlCalculationManual

        'Headers
        For Each column As DataGridViewColumn In PCTable.Columns
            xlWorkSheet.Cells(1, column.Index + 1) = column.HeaderText
            xlWorkSheet.Cells(1, column.Index + 1).Font.Bold = True
            xlWorkSheet.Cells(1, column.Index + 1).Interior.Color = 65535
        Next

        'Inhoud
        For i = 0 To PCTable.RowCount - 2
            For j = 0 To PCTable.ColumnCount - 1
                If PCTable(j, i).FormattedValue.ToString = "System.Drawing.Bitmap" Then
                    xlWorkSheet.Cells(i + 2, j + 1) = Nothing
                Else
                    xlWorkSheet.Cells(i + 2, j + 1) = PCTable(j, i).FormattedValue
                End If
            Next
        Next
        xlApp.ScreenUpdating = True
        xlApp.Calculation = Excel.XlCalculation.xlCalculationAutomatic

        With xlApp
            .Sheets(1).Select
        End With

        xlApp.Cells.EntireColumn.AutoFit()
        xlApp.ActiveSheet.rows("1:1").autofilter
        xlApp.Visible = True

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub LoadInFilesAction()
        Dim path As String = "I:\temp\Computer_specs\"
        Dim files As String()
        Dim File As String
        files = Directory.GetFiles(path, "*.txt")
        Dim teller As Integer = 0

        For Each File In files
            ReadFile(File)
            teller = teller + 1
        Next

        path = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles"
        files = Directory.GetFiles(path, "*.txt")
        For Each File In files
            If File = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\CPU benchmarks.txt" Then
                ReadCPUBenchmarks(File)
            ElseIf File = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\GPU benchmarks.txt" Then
                ReadGPUBenchmarks(File)
            End If
        Next
    End Sub

    Private Sub DeleteDuplicatesInTable()
        Dim myWS As String = ""
        For Each row As DataRow In dt.Select("", "[Werkstation] DESC,[Datum en tijd] DESC ")
            If myWS = row("Werkstation") Then
                row.Delete()
            Else
                myWS = row("Werkstation")
            End If
        Next
    End Sub

    Private Sub ReadFile(FileName As String)
        Dim myComputer As New Computer
        Dim Subject As String = ""
        Dim iHardDisks As Integer = 0
        Dim textline As String
        ReDim Preserve myComputer.Disks(iHardDisks)

        Dim objReader As New StreamReader(FileName)
        Do
            textline = objReader.ReadLine()
            If Not textline Is Nothing Then
                WriteToArray(textline, myComputer, Subject, iHardDisks)
            End If
        Loop Until textline Is Nothing
        objReader.Close()

        Dim AantalDisks As Integer = myComputer.Disks.Length
        If Not myComputer.Model = "VMware Virtual Platform" Then
            WriteComputerToData(myComputer, AantalDisks)
        End If
    End Sub

    Private Sub ReadCPUBenchmarks(fileName As String)
        Dim textline As String
        Dim iCPUs As Integer = 0
        ReDim Preserve CPUs(iCPUs)

        Dim objReader As New StreamReader(fileName)
        Do
            textline = objReader.ReadLine()
            If Not textline Is Nothing Then
                WriteToCPUArray(textline, iCPUs)
                iCPUs += 1
                ReDim Preserve CPUs(iCPUs)
            End If
        Loop Until textline Is Nothing
        objReader.Close()

        For Each row As DataRow In dt.Select
            For Each CPU In CPUs
                If CPU.Name = row("Processor") Then
                    row("Processor Benchmark") = CPU.Benchmark
                End If
            Next
        Next
    End Sub

    Private Sub WriteToCPUArray(ByRef myLine As String, ByRef index As Integer)
        Dim myCPU As CPU
        Dim info() As String
        info = Split(myLine, ": ")
        myCPU.Name = info(0)
        myCPU.Benchmark = info(1)
        CPUs(index) = myCPU
    End Sub

    Private Sub ReadGPUBenchmarks(fileName As String)
        Dim textline As String
        Dim iGPUs As Integer = 0
        ReDim Preserve GPUs(iGPUs)

        Dim objReader As New StreamReader(fileName)
        Do
            textline = objReader.ReadLine()
            If Not textline Is Nothing Then
                WriteToGPUArray(textline, iGPUs)
                iGPUs += 1
                ReDim Preserve GPUs(iGPUs)
            End If
        Loop Until textline Is Nothing
        objReader.Close()

        For Each row As DataRow In dt.Select
            For Each GPU In GPUs
                If GPU.Name = row("Video Card") Then
                    row("Video Card Benchmark") = GPU.Benchmark
                End If
            Next
        Next
    End Sub

    Private Sub WriteToGPUArray(ByRef myLine As String, ByRef index As Integer)
        Dim myGPU As GPU
        Dim info() As String
        info = Split(myLine, ": ")
        myGPU.Name = info(0)
        myGPU.Benchmark = info(1)
        GPUs(index) = myGPU
    End Sub

    Private Sub WriteToArray(textline As String, ByRef myComputer As Computer, ByRef Subject As String, ByRef iHardDisks As Integer)
        Dim info() As String
        info = Split(textline, ": ")

        If Subject <> info(0) Then iHardDisks = 0

        If Not IsNothing(info(1)) Then
            Select Case info(0)
                Case "Date"
                    myComputer.Datum = Replace(info(1), "/", "-")
                Case "User"
                    myComputer.User = info(1)
                Case "Workstation"
                    myComputer.Workstation = info(1)
                Case "Manufacturer"
                    myComputer.Manufacturer = info(1)
                Case "Model"
                    myComputer.Model = info(1)
                Case "Operating System"
                    myComputer.OS = info(1)
                Case "Architecture"
                    myComputer.Architecture = info(1)
                Case "CPU"
                    myComputer.CPU.Name = info(1)
                Case "RAM (GB)"
                    myComputer.RAM = CInt(info(1))
                Case "GPU"
                    myComputer.GPU.Name = info(1)
                Case "Disk Name"
                    ReDim Preserve myComputer.Disks(iHardDisks)
                    myComputer.Disks(iHardDisks).DiskName = info(1)
                    Subject = info(0)
                Case "Disk Media Type"
                    myComputer.Disks(iHardDisks).DiskMediaType = info(1)
                    Subject = info(0)
                Case "Disk Total Size (GB)"
                    myComputer.Disks(iHardDisks).DiskTotalSpace = CInt(info(1))
                    Subject = info(0)
                Case "Disk Total Free Space (GB)"
                    myComputer.FreeSpace = CInt(info(1))
            End Select
        End If

        iHardDisks += 1

    End Sub

    Private Sub WriteComputerToData(ByRef myComputer As Computer, ByRef AantalDisks As Integer)
        If AantalDisks = 0 Then
            With dt.Rows
                .Add(myComputer.Datum,
                     myComputer.User,
                     myComputer.Workstation,
                     myComputer.Manufacturer,
                     myComputer.Model,
                     myComputer.OS,
                     myComputer.Architecture,
                     myComputer.RAM,
                     myComputer.CPU.Name,
                     myComputer.CPU.Benchmark,
                     myComputer.GPU.Name,
                     myComputer.GPU.Benchmark,
                     myComputer.FreeSpace
                     )
            End With

        ElseIf AantalDisks = 1 Then
            With dt.Rows
                .Add(myComputer.Datum,
                     myComputer.User,
                     myComputer.Workstation,
                     myComputer.Manufacturer,
                     myComputer.Model,
                     myComputer.OS,
                     myComputer.Architecture,
                     myComputer.RAM,
                     myComputer.CPU.Name,
                     myComputer.CPU.Benchmark,
                     myComputer.GPU.Name,
                     myComputer.GPU.Benchmark,
                     myComputer.FreeSpace,
                     myComputer.Disks(0).DiskName,
                     myComputer.Disks(0).DiskMediaType,
                     myComputer.Disks(0).DiskTotalSpace
                     )
            End With

        ElseIf AantalDisks = 2 Then
            If myComputer.Disks(0).DiskMediaType = "SSD" Then
                With dt.Rows
                    .Add(myComputer.Datum,
                     myComputer.User,
                     myComputer.Workstation,
                     myComputer.Manufacturer,
                     myComputer.Model,
                     myComputer.OS,
                     myComputer.Architecture,
                     myComputer.RAM,
                     myComputer.CPU.Name,
                     myComputer.CPU.Benchmark,
                     myComputer.GPU.Name,
                     myComputer.GPU.Benchmark,
                     myComputer.FreeSpace,
                     myComputer.Disks(0).DiskName,
                     myComputer.Disks(0).DiskMediaType,
                     myComputer.Disks(0).DiskTotalSpace,
                     myComputer.Disks(1).DiskName,
                     myComputer.Disks(1).DiskMediaType,
                     myComputer.Disks(1).DiskTotalSpace
                     )
                End With
            Else
                With dt.Rows
                    .Add(myComputer.Datum,
                     myComputer.User,
                     myComputer.Workstation,
                     myComputer.Manufacturer,
                     myComputer.Model,
                     myComputer.OS,
                     myComputer.Architecture,
                     myComputer.RAM,
                     myComputer.CPU.Name,
                     myComputer.CPU.Benchmark,
                     myComputer.GPU.Name,
                     myComputer.GPU.Benchmark,
                     myComputer.FreeSpace,
                     myComputer.Disks(1).DiskName,
                     myComputer.Disks(1).DiskMediaType,
                     myComputer.Disks(1).DiskTotalSpace,
                     myComputer.Disks(0).DiskName,
                     myComputer.Disks(0).DiskMediaType,
                     myComputer.Disks(0).DiskTotalSpace
                     )
                End With
            End If
        End If
    End Sub

    Private Sub LoadInFiles_Click(sender As Object, e As EventArgs) Handles LoadInFiles.Click
        If dataGeladen = False Then
            LoadInFilesAction()
            dataGeladen = True
        Else
            MessageBox.Show("Er zijn al gegevens ingeladen.", "Probleem gevonden", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ClearTable_Click(sender As Object, e As EventArgs) Handles ClearTable.Click
        If dataGeladen = True Then
            dt.Clear()
            dataGeladen = False
            duplicatesCleared = False
        Else
            MessageBox.Show("De tabel is al leeg.", "Probleem gevonden", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        bs.Filter = VulFilter(PCTable, sender.Text)
    End Sub

    Private Sub DeleteDuplicates_Click(sender As Object, e As EventArgs) Handles DeleteDuplicates.Click
        If dataGeladen = True And duplicatesCleared = False Then
            DeleteDuplicatesInTable()
            duplicatesCleared = True
        ElseIf dataGeladen = True And duplicatesCleared = True Then
            MessageBox.Show("De dubbele werkstations zijn al verwijderd.", "Probleem gevonden", MessageBoxButtons.OK)
        Else
            MessageBox.Show("De tabel is leeg, er kan dus niets verwijderd worden.", "Probleem gevonden", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ExportToExcel_Click(sender As Object, e As EventArgs) Handles ExportToExcel.Click
        If dataGeladen = True Then
            ExportToExcelAction()
        Else
            MessageBox.Show("De tabel is leeg, er kan dus niets geëxporteerd worden.", "Probleem gevonden", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Form_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        PositionControls()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Datum.Text = "Datum: " + Format(Now, "dd-MM-yyyy")
        Tijd.Text = "Tijd: " + Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        imageNumber += 1
        If imageNumber = 1 Then
            LogoGDK10.Visible = False
            LogoGDK1.Visible = True
        End If
        If imageNumber = 2 Then
            LogoGDK1.Visible = False
            LogoGDK2.Visible = True
        End If
        If imageNumber = 3 Then
            LogoGDK2.Visible = False
            LogoGDK3.Visible = True
        End If
        If imageNumber = 4 Then
            LogoGDK3.Visible = False
            LogoGDK4.Visible = True
        End If
        If imageNumber = 5 Then
            LogoGDK4.Visible = False
            LogoGDK5.Visible = True
        End If
        If imageNumber = 6 Then
            LogoGDK5.Visible = False
            LogoGDK6.Visible = True
        End If
        If imageNumber = 7 Then
            LogoGDK6.Visible = False
            LogoGDK7.Visible = True
        End If
        If imageNumber = 8 Then
            LogoGDK7.Visible = False
            LogoGDK8.Visible = True
        End If
        If imageNumber = 9 Then
            LogoGDK8.Visible = False
            LogoGDK9.Visible = True
        End If
        If imageNumber = 10 Then
            LogoGDK9.Visible = False
            LogoGDK10.Visible = True
        End If
        If imageNumber = 11 Then
            LogoGDK10.Visible = False
            LogoGDK9.Visible = True
        End If
        If imageNumber = 12 Then
            LogoGDK9.Visible = False
            LogoGDK8.Visible = True
        End If
        If imageNumber = 13 Then
            LogoGDK8.Visible = False
            LogoGDK7.Visible = True
        End If
        If imageNumber = 14 Then
            LogoGDK7.Visible = False
            LogoGDK6.Visible = True
        End If
        If imageNumber = 15 Then
            LogoGDK6.Visible = False
            LogoGDK5.Visible = True
        End If
        If imageNumber = 16 Then
            LogoGDK5.Visible = False
            LogoGDK4.Visible = True
        End If
        If imageNumber = 17 Then
            LogoGDK4.Visible = False
            LogoGDK3.Visible = True
        End If
        If imageNumber = 18 Then
            LogoGDK3.Visible = False
            LogoGDK2.Visible = True
        End If
        If imageNumber = 19 Then
            LogoGDK2.Visible = False
            LogoGDK1.Visible = True
            imageNumber = 1
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub LogoGDK1_Click(sender As Object, e As EventArgs) Handles LogoGDK1.Click
        Timer2.Enabled = True
    End Sub
End Class
