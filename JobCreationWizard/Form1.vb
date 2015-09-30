Imports System.IO
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmMain
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.lblMaterialsFile.Text = "" Or Me.txtMatCol.Text = "" Then
            MsgBox("Select a valid materials file and column index", vbOKOnly, "Select a valid materials spreadsheet")
        Else
            ' show the order input form
            OrderInput.txtMixing.Clear()
            OrderInput.txtQty.Text = "1"
            'OrderInput.txtWo.Clear()
            OrderInput.lblPartDisplay.Text = ""
            OrderInput.lblStatus.Text = ""
            materialsColumn = ColumnLetterToColumnIndex(Me.txtMatCol.Text)
            ParseMaterials(materialsFile)
            OrderInput.Show()
        End If
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If Me.gridData.RowCount > 1 Then
            If MsgBox("Are you sure?", vbYesNo, "Quit?") = vbYes Then
                BuildNewConfig()
                Me.Close()
            End If
        Else
            BuildNewConfig()
            Me.Close()
        End If
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'drop the entire datagrid into a csv file
        If Me.txtPlanName.Text = "" Then
            MsgBox("Please enter a plan name", vbOKOnly, "Enter Plan Name")
        Else
            Dim strOutputDevice As String
            If Me.cboOutput.SelectedItem = "" Then
                strOutputDevice = "default"
            Else
                strOutputDevice = Me.cboOutput.SelectedItem
            End If
            Dim dt As New DataTable("output")
            Dim row As DataRow
            Dim gridCols As Integer = gridData.ColumnCount - 1
            For Each c As DataGridViewColumn In Me.gridData.Columns
                Dim idColumn As DataColumn = New DataColumn()
                idColumn.ColumnName = c.Name
                dt.Columns.Add(idColumn)
            Next
            For Each dr As DataGridViewRow In gridData.Rows
                row = dt.NewRow
                For cn As Integer = 0 To gridCols
                    If dr.Cells(cn).Value <> "" Then
                        row.Item(cn) = dr.Cells(cn).Value
                    End If
                Next
                dt.Rows.Add(row)
            Next

            dt.Columns.Add("colOutputDevice")
            For Each row In dt.Rows
                If row.Item(0).ToString <> "" Then
                    row.Item("colOutputDevice") = strOutputDevice
                End If
            Next

            Dim delim As String = ""
            Dim outputHeaders As String = ""
            For i = 0 To gridData.ColumnCount - 1
                outputHeaders = outputHeaders & delim & gridData.Columns(i).Name
                delim = ","
            Next
            outputHeaders = outputHeaders & ",OutputDevice"

            dt.Rows(dt.Rows.Count - 1).Delete()
            WriteMe(dt, outputFolder & Me.txtPlanName.Text, outputHeaders)

            Me.gridData.Rows.Clear()
        End If
    End Sub
    Private Sub btnBrowseMaterial_Click(sender As Object, e As EventArgs) Handles btnBrowseMaterial.Click
        ' browse to a folder to find the materials file
        If Not IsNothing(materialsFile) Then
            Me.browseMaterials.InitialDirectory = Path.GetDirectoryName(materialsFile)
            Me.browseMaterials.FileName = Path.GetFileName(materialsFile)
        End If
        Me.browseMaterials.Title = "Browse To valid Materials File"
        Me.browseMaterials.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
        Me.browseMaterials.ShowDialog()
        materialsFile = Me.browseMaterials.FileName
        Me.lblMaterials.Text = materialsFile

        materialsColumn = ColumnLetterToColumnIndex(Me.txtMatCol.Text)
        ParseMaterials(materialsFile)

    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            For Each row As DataGridViewRow In Me.gridData.SelectedRows
                Me.gridData.Rows.Remove(row)
            Next
        Catch ex As Exception
            MsgBox("Invalid Selection", vbOKOnly, "Error")
        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' load in the output device combobox
        Me.lblStatus.Text = ""
        Call ReadConfig()
        'ParseMaterials(materialsFile)
        Me.txtMatCol.Text = ColumnIndexToColumnLetter(materialsColumn)
        Me.txtPlanName.Text = "CreationWizard_" & DateTime.Now.ToString("MMdd.HHmm")
    End Sub
    Private Function ColumnIndexToColumnLetter(colIndex As Integer) As String
        Dim div As Integer = colIndex
        Dim colLetter As String = String.Empty
        Dim modnum As Integer = 0

        While div > 0
            modnum = (div - 1) Mod 26
            colLetter = Chr(65 + modnum) & colLetter
            div = CInt((div - modnum) \ 26)
        End While

        Return colLetter
    End Function
    Public Function ColumnLetterToColumnIndex(columnLetter As String) As Integer
        Dim singlechar As String
        Dim intCode As Integer
        Dim loopCounter As Integer
        loopCounter = 0
        intCode = 0
        Do While Len(columnLetter) > 0
            singlechar = Strings.Right(columnLetter, 1)
            intCode = intCode + (26 ^ loopCounter) * (Asc(singlechar) - 64)
            loopCounter = loopCounter + 1
            columnLetter = Strings.Left(columnLetter, Len(columnLetter) - 1)
        Loop
        Return intCode
    End Function
    Public Sub ParseMaterials(input As String)
        Dim data As DataTable = New DataTable()
        Dim row As DataRow
        Try
            If Path.GetExtension(input) = ".csv" Then 'if the file is a csv file then use SR to fill the datatable
                Dim SR As StreamReader = New StreamReader(input)
                Dim line As String = SR.ReadLine()
                Dim strArray As String() = line.Split(", ")
                For Each s As String In strArray
                    data.Columns.Add(New DataColumn())
                Next
                Do
                    If Not line = String.Empty Then
                        row = data.NewRow()
                        row.ItemArray = line.Split(", ")
                        data.Rows.Add(row)
                    Else
                        Exit Do
                    End If
                    line = SR.ReadLine
                Loop
                SR.Close()
            Else ' if it's an xlsx file then fill the datatable using oledb
                Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & input & ";Extended Properties=""Excel 12.0;HDR=YES"""
                Dim SelectCmd As String = "Select * FROM [" & "Sheet1" & "$]"
                Using conn As New OleDbConnection(connString)
                    Dim adapter As New OleDbDataAdapter(selectCmd, conn)
                    adapter.Fill(data)
                    conn.Close()
                End Using

            End If

            'fill the materials cbo with available items
            Dim i As Integer
            OrderInput.cboMaterial.Items.Clear()
            For i = 0 To data.Rows.Count - 1
                OrderInput.cboMaterial.Items.Add(data.Rows(i).Item(materialsColumn - 1))
            Next

        Catch ex As Exception
            MsgBox("There was a problem with the material input file. Ensure the inputs are correct and available" & Chr(13) & Chr(13) & ex.ToString, vbOKOnly, "Error")
            Me.lblMaterials.Text = "Error with file: " & Me.lblMaterials.Text & "!"
        End Try

        Me.lblStatus.Text = "Loaded material file"

    End Sub
    Public Sub ReadConfig()
        If Not File.Exists("C:\ProgramData\Plataine\CreationWizard.config") Then
            BuildDefaultConfig()
        End If
        Try
            Dim configFile() As String = File.ReadAllLines("C:\ProgramData\Plataine\CreationWizard.config")
            For Each line As String In configFile
                Dim setting() As String = Split(line, "=")
                If UCase(setting(0)) = "OUTPUTFOLDER" Then
                    If Directory.Exists(setting(1).ToString) Then
                        outputFolder = setting(1).ToString
                        If Strings.Right(outputFolder, 1) <> "\" Then
                            outputFolder = outputFolder & "\"
                        End If
                        Me.lblOutputDir.Text = "Destination: " & outputFolder
                    End If
                ElseIf UCase(setting(0)) = "MATERIALS" Then
                    If File.Exists(setting(1).ToString) Then
                        materialsFile = setting(1).ToString
                        Me.lblMaterials.Text = materialsFile
                    End If
                ElseIf UCase(setting(0)) = "MATERIALNAMECOLUMN" Then
                    materialsColumn = CInt(ColumnLetterToColumnIndex(setting(1).ToString))
                    Me.txtMatCol.Text = ColumnLetterToColumnIndex(materialsColumn)
                ElseIf UCase(setting(0)) = "TEMPLATE" Then
                    If File.Exists(setting(1).ToString) And Path.GetExtension(setting(1).ToString) = ".xlsx" Then
                        outputTemplate = setting(1).ToString
                        Me.lblStatus.Text = "Found template: " & outputTemplate
                    End If
                ElseIf UCase(setting(0)) = "OUTPUTDEVICES" Then
                    outputDevices = Split(setting(1), ";")
                    For i As Integer = 0 To outputDevices.Length - 1
                        Me.cboOutput.Items.Add(outputDevices(i))
                    Next
                    For i = 0 To Me.cboOutput.Items.Count - 2
                        For j As Integer = Me.cboOutput.Items.Count - 1 To i + 1 Step -1
                            If Me.cboOutput.Items(i).ToString = Me.cboOutput.Items(j).ToString Then
                                Me.cboOutput.Items.RemoveAt(j)
                            End If
                        Next
                    Next
                ElseIf UCase(setting(0)) = "PARTDIRECTORY"
                    If Directory.Exists(setting(1).ToString) Then
                        partFolder = setting(1).ToString
                    End If
                End If
            Next
            If IsNothing(outputFolder) Or IsNothing(outputDevices) Or IsNothing(partFolder) Or IsNothing(materialsFile) Or IsNothing(materialsColumn) Then
                Call MsgBox("Your config file is invalid. Must be of the form:" _
                           & Chr(13) & "outputfolder=validpath" _
                           & Chr(13) & "materials=valid materials xlsx" _
                           & Chr(13) & "materialnamecolumn=an integer representing the column where material names are stored" _
                           & Chr(13) & "outputdevices=names separated by ;" _
                           & Chr(13) & "partdirectory=valid path to styles" _
                           & Chr(13) & "Config location must be: C:\ProgramData\Plataine\CreationWizard.config")
                End
            End If
        Catch ex As Exception
            Call MsgBox("Your config file is missing, or missing required column mappings." _
                               & Chr(13) & "Config location must be: C:\ProgramData\Plataine\CreationWizard.config" _
                               & Chr(13) & "Delete existing config files to generate a fresh one.")
            End
        End Try
    End Sub
    Public Sub BuildDefaultConfig()
        If (Not Directory.Exists("C:\ProgramData\Plataine\")) Then
            Directory.CreateDirectory("C:\ProgramData\Plataine\")
        End If
        Dim sw As New StreamWriter("C:\ProgramData\Plataine\CreationWizard.config", False)
        sw.WriteLine("##Auto Config##")
        sw.WriteLine("outputfolder=C:\TPO\integration")
        sw.WriteLine("materials=C:\TPO\Materials.xlsx")
        sw.WriteLine("## :colWorkOrder template:colPartNo template:colMaterial template:colQty template:colMixingGroup template:colOutputDevice")
        sw.WriteLine("template=C:\TPO\wizardtemplate.xlsx")
        sw.WriteLine("materialnamecolumn=A")
        sw.WriteLine("outputdevices=output1;output2;output3")
        sw.WriteLine("partdirectory=C:\TPO\Library")
        sw.Close()
    End Sub
    Public Sub BuildNewConfig()
        If (Not Directory.Exists("C:\ProgramData\Plataine\")) Then
            Directory.CreateDirectory("C:\ProgramData\Plataine\")
        End If
        File.Delete("C:\ProgramData\Plataine\CreationWizard.config")

        Dim sw As New StreamWriter("C:\ProgramData\Plataine\CreationWizard.config", False)
        sw.WriteLine("##Auto Config##")
        sw.WriteLine("outputfolder=" & outputFolder)
        sw.WriteLine("materials=" & materialsFile)
        sw.WriteLine("## template:colWorkOrder template:colPartNo template:colMaterial template:colQty template:colMixingGroup template:colOutputDevice")
        sw.WriteLine("template=" & outputTemplate)
        sw.WriteLine("materialnamecolumn=" & ColumnIndexToColumnLetter(materialsColumn))
        Dim delim As String = ""
        Dim outputString As String = ""
        For i As Integer = 0 To Me.cboOutput.Items.Count - 1
            outputString = outputString & delim & Me.cboOutput.Items(i)
            delim = ";"
        Next
        sw.WriteLine("outputdevices=" & outputString)
        sw.WriteLine("partdirectory=" & partFolder)
        sw.Close()
    End Sub
    Public Sub WriteMe(ByVal output As DataTable, ByVal fileName As String, headers As String)
        ' if no template spreadsheet found, then output the data as a csv in generic format. If found, then find proper cells and output data.
        fileName = fileName & ".csv"
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If
        If outputTemplate = "" Then
            Dim delim As String = Nothing, first As Boolean
            first = True
            Dim sw As New StreamWriter(fileName, True)
            Dim builder As New System.Text.StringBuilder
            For Each row As DataRow In output.Rows
                delim = ""
                If Not first Then builder.AppendLine()
                first = False
                For Each col As DataColumn In output.Columns
                    builder.Append(delim)
                    delim = ","
                    builder.Append(row(col.ColumnName))
                Next
            Next
            sw.WriteLine(headers)
            sw.WriteLine(builder.ToString())
            sw.Close()
        Else
            Dim _excel As New Excel.Application
            Dim wBook As Excel.Workbook
            Dim wSheet As Excel.Worksheet
            Dim i As Integer = 0
            Try
                wBook = _excel.Workbooks.Open(outputTemplate)
                wSheet = wBook.Worksheets(1)
                ' template variables
                Dim colWo(2) As String, colPartNo(2) As String, colMaterial(2) As String, colQty(2) As String, colMixingGroup(2) As String, colOutputDevice(2) As String
                For i = 0 To output.Columns.Count - 1
                    If output.Columns(i).ColumnName = "colWorkOrder" Then colWo(0) = i
                    If output.Columns(i).ColumnName = "colPartNo" Then colPartNo(0) = i
                    If output.Columns(i).ColumnName = "colMaterial" Then colMaterial(0) = i
                    If output.Columns(i).ColumnName = "colQty" Then colQty(0) = i
                    If output.Columns(i).ColumnName = "colMixingGroup" Then colMixingGroup(0) = i
                    If output.Columns(i).ColumnName = "colOutputDevice" Then colOutputDevice(0) = i
                Next
                Dim column As Integer, row As Integer
                'find the location of the template variables
                For row = 1 To 25
                    For column = 1 To 25
                        If UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLWORKORDER" Then
                            colWo(1) = row
                            colWo(2) = column
                        ElseIf UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLPARTNO" Then
                            colPartNo(1) = row
                            colPartNo(2) = column
                        ElseIf UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLMATERIAL" Then
                            colMaterial(1) = row
                            colMaterial(2) = column
                        ElseIf UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLQTY" Then
                            colQty(1) = row
                            colQty(2) = column
                        ElseIf UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLMIXINGGROUP" Then
                            colMixingGroup(1) = row
                            colMixingGroup(2) = column
                        ElseIf UCase(wBook.ActiveSheet.cells(row, column).value) = "TEMPLATE:COLOUTPUTDEVICE" Then
                            colOutputDevice(1) = row
                            colOutputDevice(2) = column
                        End If
                    Next
                Next
                'loop through output and drop in values into template
                For i = 0 To output.Rows.Count - 1
                    wSheet.Cells(CInt(colWo(1)), CInt(colWo(2))) = output.Rows(i).Item(CInt(colWo(0))).ToString
                    colWo(1) = colWo(1) + 1
                    wSheet.Cells(CInt(colPartNo(1)), CInt(colPartNo(2))) = output.Rows(i).Item(CInt(colPartNo(0))).ToString
                    colPartNo(1) = colPartNo(1) + 1
                    wSheet.Cells(CInt(colMaterial(1)), CInt(colMaterial(2))) = output.Rows(i).Item(CInt(colMaterial(0))).ToString
                    colMaterial(1) = colMaterial(1) + 1
                    wSheet.Cells(CInt(colQty(1)), CInt(colQty(2))) = output.Rows(i).Item(CInt(colQty(0))).ToString
                    colQty(1) = colQty(1) + 1
                    wSheet.Cells(CInt(colMixingGroup(1)), CInt(colMixingGroup(2))) = output.Rows(i).Item(CInt(colMixingGroup(0))).ToString
                    colMixingGroup(1) = colMixingGroup(1) + 1
                    wSheet.Cells(CInt(colOutputDevice(1)), CInt(colOutputDevice(2))) = output.Rows(i).Item(CInt(colOutputDevice(0))).ToString
                    colOutputDevice(1) = colOutputDevice(1) + 1
                Next
                wBook.SaveAs(fileName, Excel.XlFileFormat.xlCSV)
                ReleaseObject(wSheet)
                wBook.Close(False)
                ReleaseObject(wBook)
                _excel.Quit()
                ReleaseObject(_excel)
                GC.Collect()
            Catch ex As Exception
                MsgBox("There is an error with the output template: " & outputTemplate & Chr(13) & ex.ToString, vbOKOnly, "error")
                wBook.Close(False)
                ReleaseObject(wBook)
                _excel.Quit()
                ReleaseObject(_excel)
                GC.Collect()
                Threading.Thread.Sleep(2000)
            End Try
        End If

        Me.lblStatus.Text = "Wrote file: " & fileName

    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
End Class