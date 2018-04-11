Imports System
Imports System.Reflection
Imports System.Windows.Forms

Public Module ExtensionMethods

    Public Sub DoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty(“DoubleBuffered”, BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub

    Public Function VulFilter(ByRef Dgv As DataGridView, strZoekArg As String) As String
        '// Op basis van de kolommen die als string gedefinieerd zijn, wordt hier een WHERE clausule opgebouwd 
        '// Indien er niets ingegeven is, doe dan een reset  mbv 1=1
        If strZoekArg Is Nothing Or strZoekArg = "" Then
            Return " 1=1 "
        End If

        Dim strFilter As String = " 1=0 "

        Dim list As New List(Of String)

        For Each column As DataGridViewColumn In Dgv.Columns
            '// Als de kolom van het type STRING is, dan wordt een filter gemaakt: <kolomnaam> LIKE %<zoekargument>%
            If Not column.CellType.FullName = "System.Windows.Forms.DataGridViewButtonCell" And
                Not column.CellType.FullName = "System.Windows.Forms.DataGridViewImageCell" Then

                If column.ValueType.FullName.ToString() = "System.String" Then
                    strFilter = strFilter + " or [" + column.DataPropertyName.ToString() + "] Like '%" + strZoekArg + "%'"
                End If


                '// Als de kolom van het type INTEGER is, dan heb je mogelijk met een Combobox te maken. In dat geval 
                '// moet de FormattedValue doorzocht worden adhv het zoekargument omdat in de kolom het Id staat. 
                '// Uiteindelijk Is het de bedoeling om hel filter als volgt te vullen: <kolomnaam> in (0,<id>,<id>)

                If column.Index > 1 And Dgv.RowCount > 1 Then
                    If column.ValueType.FullName.ToString() = "System.Int32" Then
                        Dim strWhereIn As String = " "
                        strWhereIn = strWhereIn + " or [" + column.DataPropertyName.ToString() + "] in (-2"
                        list.Clear()
                        For i As Integer = 0 To Dgv.RowCount - 1
                            If Dgv.Item(column.Index, i).FormattedValue.tolower.Contains(strZoekArg.ToLower) Then
                                list.Add(Dgv.Item(column.Index, i).Value)
                            End If
                        Next
                        For Each value In list.Distinct()
                            strWhereIn = strWhereIn + "," + value
                        Next
                        strWhereIn = strWhereIn + ")"

                        strFilter = strFilter + strWhereIn
                    End If
                End If
            End If
        Next

        If strFilter = " 1=0 " Then
            strFilter = ""
        End If
        Return strFilter
    End Function
End Module