Imports System.IO
Public Class OrderInput
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Clean()
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'browse to the parts directory
        Me.partBrowser.SelectedPath = partFolder
        Me.partBrowser.ShowDialog()
        partFolder = Me.partBrowser.SelectedPath
        Me.lblPartDisplay.Text = partFolder
    End Sub
    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        If Me.txtWo.Text = "" Or Me.lblPartDisplay.Text = "" Or Me.cboMaterial.Text = "" Or Me.txtQty.Text = "" Then
            Me.lblStatus.Text = "Fill in all the fields"
        Else
            Dim n As Integer = frmMain.gridData.Rows.Add
            frmMain.gridData.Rows.Item(n).Cells(0).Value = Me.txtWo.Text
            frmMain.gridData.Rows.Item(n).Cells(1).Value = Path.GetFileName(Me.lblPartDisplay.Text)
            frmMain.gridData.Rows.Item(n).Cells(2).Value = Me.cboMaterial.Text
            frmMain.gridData.Rows.Item(n).Cells(3).Value = Me.txtQty.Text
            frmMain.gridData.Rows.Item(n).Cells(4).Value = Me.txtMixing.Text

            Clean()

            Me.Close()
        End If
    End Sub
    Public Sub Clean()
        Me.txtMixing.Clear()
        Me.txtQty.Text = "1"
        Me.lblPartDisplay.Text = ""
        Me.lblStatus.Text = ""
    End Sub
End Class