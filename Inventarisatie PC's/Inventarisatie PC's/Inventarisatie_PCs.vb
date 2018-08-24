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
        Public Licenties() As Licentie
    End Structure

    Private Structure Licentie
        Public Programma As String
        Public Code As String
        Public VolledigeCode As String
        Public Type As String
        Public Account As String
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
    Private Licenties As List(Of Licentie) = New List(Of Licentie)
    Private dt As New DataTable
    Private bs As New BindingSource
    Private dataGeladen As Boolean = False
    Private duplicatesCleared As Boolean = False
    Private imageNumber = 1
    Private kroonTeller = 0

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtensionMethods.DoubleBuffered(PCTable, True)
        Copyright.Text = "Copyright " + Chr(169) + " 2018 - All rights reserved - Gebr. de Koning Papendrecht"
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
            .Add("Licentie 1: Programma", GetType(String))
            .Add("Licentie 1: Code", GetType(String))
            .Add("Licentie 1: Doosje/Online", GetType(String))
            .Add("Licentie 1: MS Account", GetType(String))
            .Add("Licentie 2: Programma", GetType(String))
            .Add("Licentie 2: Code", GetType(String))
            .Add("Licentie 2: Doosje/Online", GetType(String))
            .Add("Licentie 2: MS Account", GetType(String))
            .Add("Licentie 3: Programma", GetType(String))
            .Add("Licentie 3: Code", GetType(String))
            .Add("Licentie 3: Doosje/Online", GetType(String))
            .Add("Licentie 3: MS Account", GetType(String))
            .Add("Licentie 4: Programma", GetType(String))
            .Add("Licentie 4: Code", GetType(String))
            .Add("Licentie 4: Doosje/Online", GetType(String))
            .Add("Licentie 4: MS Account", GetType(String))
            .Add("Licentie 5: Programma", GetType(String))
            .Add("Licentie 5: Code", GetType(String))
            .Add("Licentie 5: Doosje/Online", GetType(String))
            .Add("Licentie 5: MS Account", GetType(String))
            .Add("Licentie 6: Programma", GetType(String))
            .Add("Licentie 6: Code", GetType(String))
            .Add("Licentie 6: Doosje/Online", GetType(String))
            .Add("Licentie 6: MS Account", GetType(String))
            .Add("Licentie 7: Programma", GetType(String))
            .Add("Licentie 7: Code", GetType(String))
            .Add("Licentie 7: Doosje/Online", GetType(String))
            .Add("Licentie 7: MS Account", GetType(String))
            .Add("Licentie 8: Programma", GetType(String))
            .Add("Licentie 8: Code", GetType(String))
            .Add("Licentie 8: Doosje/Online", GetType(String))
            .Add("Licentie 8: MS Account", GetType(String))
            .Add("Licentie 9: Programma", GetType(String))
            .Add("Licentie 9: Code", GetType(String))
            .Add("Licentie 9: Doosje/Online", GetType(String))
            .Add("Licentie 9: MS Account", GetType(String))
            .Add("Licentie 10: Programma", GetType(String))
            .Add("Licentie 10: Code", GetType(String))
            .Add("Licentie 10: Doosje/Online", GetType(String))
            .Add("Licentie 10: MS Account", GetType(String))
        End With

        bs.DataSource = dt
        PCTable.DataSource = dt

        SearchBox.Visible = False
        PCTable.ScrollBars = ScrollBars.None
        LoadInFilesAction()
        dataGeladen = True
        PCTable.ScrollBars = ScrollBars.Both
        SearchBox.Visible = True

        PCTable.Columns("Username").Frozen = True
        PCTable.Columns("Werkstation").Frozen = True
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

        Dim pB3 As New Point
        pB3.X = (Me.Width / 4) - (ExportToExcel.Width / 2)
        pB3.Y = ExportToExcel.Top
        ExportToExcel.Location = pB3
        ExportToExcel.Width = (Me.Width / 6)

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
            xlWorkSheet.Cells(1, column.Index + 1).Font.Color = RGB(255, 255, 255)
            xlWorkSheet.Cells(1, column.Index + 1).Interior.Color = RGB(27, 37, 70)
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

        dt.DefaultView.Sort = "Werkstation ASC, Datum en tijd DESC"
        DeleteDuplicatesInTable()

        path = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles"
        files = Directory.GetFiles(path, "*.txt")
        For Each File In files
            If File = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\CPU benchmarks.txt" Then
                ReadCPUBenchmarks(File)
            ElseIf File = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\GPU benchmarks.txt" Then
                ReadGPUBenchmarks(File)
            ElseIf File = "G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\Licentie codes.txt" Then
                ReadLicenties(File)
            End If
        Next
    End Sub

    Private Sub ReadLicenties(file As String)
        Dim textline As String

        Dim objReader As New StreamReader(file)
        Do
            textline = objReader.ReadLine()
            If Not textline Is Nothing Then
                WriteLicentieToArray(textline)
            End If
        Loop Until textline Is Nothing
        objReader.Close()

        For Each row As DataRow In dt.Select
            For i = 0 To 9
                If Not IsDBNull(row(19 + i * 4)) And Not IsDBNull(row(20 + i * 4)) Then
                    For j = Licenties.Count - 1 To 0 Step -1
                        Dim Licentie = Licenties(j)
                        If Licentie.Code = row(20 + i * 4) Then
                            row(19 + i * 4) = Licentie.Programma
                            row(20 + i * 4) = Licentie.VolledigeCode
                            row(21 + i * 4) = Licentie.Type
                            row(22 + i * 4) = Licentie.Account
                            Licenties.Remove(Licentie)
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub WriteLicentieToArray(ByRef myLine As String)
        Dim myLicentie As Licentie
        Dim info() As String
        info = Split(myLine, ": ")
        myLicentie.Programma = info(0)
        myLicentie.Code = info(1)
        myLicentie.VolledigeCode = info(2)
        myLicentie.Type = info(3)
        myLicentie.Account = info(4)
        Licenties.Add(myLicentie)
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
        Dim SubjectLicentie As String = ""
        Dim iHardDisks As Integer = 0
        Dim iLicenties As Integer = -1
        Dim textline As String
        ReDim Preserve myComputer.Disks(iHardDisks)

        Dim objReader As New StreamReader(FileName)
        Do
            textline = objReader.ReadLine()
            If Not textline Is Nothing Then
                WriteToArray(textline, myComputer, Subject, SubjectLicentie, iHardDisks, iLicenties)
            End If
        Loop Until textline Is Nothing
        objReader.Close()

        Dim AantalDisks As Integer = myComputer.Disks.Length
        Dim AantalLicenties As Integer = myComputer.Disks.Length
        If Not myComputer.Model = "VMware Virtual Platform" Then
            WriteComputerToData(myComputer, AantalDisks, AantalLicenties)
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
        ReDim Preserve CPUs(iCPUs - 1)
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
        ReDim Preserve GPUs(iGPUs - 1)
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

    Private Sub WriteToArray(textline As String, ByRef myComputer As Computer, ByRef Subject As String, ByRef SubjectLicentie As String, ByRef iHardDisks As Integer, ByRef iLicenties As Integer)
        Dim info() As String
        If textline.Contains(":") Then
            info = Split(textline, ": ")
        ElseIf textline.Contains("p") Then
            info = Split(textline, "p")
        Else
            info = Split(textline, "-")
        End If

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
                    If Not info(1) Like "*USB*" Then
                        myComputer.GPU.Name = info(1)
                    End If
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
                Case "LICENSE NAME"
                    SubjectLicentie = info(1)
                    If (Not SubjectLicentie = "Office 14, OfficeAccessRuntime-ByPass edition" And Not SubjectLicentie = "Office 16, Office16HomeBusinessR_Grace edition" And Not SubjectLicentie = "Office 15, OfficeHomeBusinessR_Grace edition" And Not SubjectLicentie = "Office 16, Office16O365HomePremR_Grace edition" And Not SubjectLicentie = "Office 15, OfficeProjectStdR_Grace edition") Then
                        iLicenties += 1
                        ReDim Preserve myComputer.Licenties(iLicenties)
                        myComputer.Licenties(iLicenties).Programma = info(1)
                    End If
                Case "Last 5 characters of installed product key"
                    If (Not SubjectLicentie = "Office 14, OfficeAccessRuntime-ByPass edition" And Not SubjectLicentie = "Office 16, Office16HomeBusinessR_Grace edition" And Not SubjectLicentie = "Office 15, OfficeHomeBusinessR_Grace edition" And Not SubjectLicentie = "Office 16, Office16O365HomePremR_Grace edition" And Not SubjectLicentie = "Office 15, OfficeProjectStdR_Grace edition") Then
                        myComputer.Licenties(iLicenties).Code = info(1)
                    End If
            End Select
        End If
        iHardDisks += 1
    End Sub

    Private Sub WriteComputerToData(ByRef myComputer As Computer, ByRef AantalDisks As Integer, ByRef AantalLicenties As Integer)
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
             myComputer.FreeSpace)
            If Not IsNothing(myComputer.Disks) Then
                For i = 0 To UBound(myComputer.Disks)
                    dt.Rows(dt.Rows.Count - 1).Item(13 + i * 3) = myComputer.Disks(i).DiskName
                    dt.Rows(dt.Rows.Count - 1).Item(14 + i * 3) = myComputer.Disks(i).DiskMediaType
                    dt.Rows(dt.Rows.Count - 1).Item(15 + i * 3) = myComputer.Disks(i).DiskTotalSpace
                Next
            End If
            If Not IsNothing(myComputer.Licenties) Then
                For j = 0 To UBound(myComputer.Licenties)
                    dt.Rows(dt.Rows.Count - 1).Item(19 + j * 4) = myComputer.Licenties(j).Programma
                    dt.Rows(dt.Rows.Count - 1).Item(20 + j * 4) = myComputer.Licenties(j).Code
                    dt.Rows(dt.Rows.Count - 1).Item(21 + j * 4) = myComputer.Licenties(j).Type
                    dt.Rows(dt.Rows.Count - 1).Item(22 + j * 4) = myComputer.Licenties(j).Account
                Next
            End If
        End With
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        bs.Filter = VulFilter(PCTable, sender.Text)
    End Sub

    Private Sub ExportToExcel_Click(sender As Object, e As EventArgs) Handles ExportToExcel.Click
        If dataGeladen = True Then
            ExportToExcelAction()
        Else
            MessageBox.Show("De tabel is leeg, er kan dus niets geëxporteerd worden.", "Probleem gevonden", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Form_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
        PositionControls()
    End Sub

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        Datum.Text = "Datum: " + Format(Now, "dd-MM-yyyy")
        Tijd.Text = "Tijd: " + Format(Now, "HH:mm:ss")
    End Sub

    Private Sub ImageTimer_Tick(sender As Object, e As EventArgs) Handles ImageTimer.Tick
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
            ImageTimer.Enabled = False
        End If
    End Sub

    Private Sub ImageTimer2_Tick(sender As Object, e As EventArgs) Handles ImageTimer2.Tick
        If (kroonTeller <= 65) Then
            KroonImage.Location = New Point(KroonImage.Location.X - 1, KroonImage.Location.Y)
            kroonTeller += 1
        ElseIf (kroonTeller > 65 And kroonTeller <= 200) Then
            KroonImage.Location = New Point(KroonImage.Location.X + 1, KroonImage.Location.Y)
            kroonTeller += 1
        ElseIf (kroonTeller > 200 And kroonTeller <= 270) Then
            KroonImage.Location = New Point(KroonImage.Location.X - 1, KroonImage.Location.Y)
            kroonTeller += 1
        End If
        If kroonTeller = 270 Then
            kroonTeller = 0
            ImageTimer2.Enabled = False
        End If
    End Sub

    Private Sub LogoGDK1_Click(sender As Object, e As EventArgs) Handles LogoGDK1.Click
        ImageTimer.Enabled = True
    End Sub

    Private Sub KroonImage_Click(sender As Object, e As EventArgs) Handles KroonImage.Click
        ImageTimer2.Enabled = True
    End Sub
End Class
