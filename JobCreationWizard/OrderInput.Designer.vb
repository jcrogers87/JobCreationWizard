<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderInput))
        Me.lblPartFolder = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblMixing = New System.Windows.Forms.Label()
        Me.lblWO = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblPartDisplay = New System.Windows.Forms.Label()
        Me.cboMaterial = New System.Windows.Forms.ComboBox()
        Me.txtMixing = New System.Windows.Forms.TextBox()
        Me.txtWo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.partBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPartFolder
        '
        Me.lblPartFolder.AutoSize = True
        Me.lblPartFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartFolder.Location = New System.Drawing.Point(15, 10)
        Me.lblPartFolder.Name = "lblPartFolder"
        Me.lblPartFolder.Size = New System.Drawing.Size(77, 16)
        Me.lblPartFolder.TabIndex = 1
        Me.lblPartFolder.Text = "Part Folder:"
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.Location = New System.Drawing.Point(15, 40)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(59, 16)
        Me.lblMaterial.TabIndex = 2
        Me.lblMaterial.Text = "Material:"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(15, 70)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(108, 16)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Nesting Quantity:"
        '
        'lblMixing
        '
        Me.lblMixing.AutoSize = True
        Me.lblMixing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMixing.Location = New System.Drawing.Point(15, 100)
        Me.lblMixing.Name = "lblMixing"
        Me.lblMixing.Size = New System.Drawing.Size(89, 16)
        Me.lblMixing.TabIndex = 4
        Me.lblMixing.Text = "Mixing Group:"
        '
        'lblWO
        '
        Me.lblWO.AutoSize = True
        Me.lblWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWO.Location = New System.Drawing.Point(15, 130)
        Me.lblWO.Name = "lblWO"
        Me.lblWO.Size = New System.Drawing.Size(80, 16)
        Me.lblWO.TabIndex = 5
        Me.lblWO.Text = "Work Order:"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(140, 67)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(55, 21)
        Me.txtQty.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(140, 7)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblPartDisplay
        '
        Me.lblPartDisplay.AutoSize = True
        Me.lblPartDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartDisplay.Location = New System.Drawing.Point(221, 10)
        Me.lblPartDisplay.Name = "lblPartDisplay"
        Me.lblPartDisplay.Size = New System.Drawing.Size(29, 15)
        Me.lblPartDisplay.TabIndex = 12
        Me.lblPartDisplay.Text = "Part"
        '
        'cboMaterial
        '
        Me.cboMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterial.FormattingEnabled = True
        Me.cboMaterial.Location = New System.Drawing.Point(140, 37)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(342, 23)
        Me.cboMaterial.TabIndex = 2
        '
        'txtMixing
        '
        Me.txtMixing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMixing.Location = New System.Drawing.Point(140, 97)
        Me.txtMixing.Name = "txtMixing"
        Me.txtMixing.Size = New System.Drawing.Size(155, 21)
        Me.txtMixing.TabIndex = 4
        '
        'txtWo
        '
        Me.txtWo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWo.Location = New System.Drawing.Point(140, 127)
        Me.txtWo.Name = "txtWo"
        Me.txtWo.Size = New System.Drawing.Size(155, 21)
        Me.txtWo.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAppend
        '
        Me.btnAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppend.Location = New System.Drawing.Point(417, 160)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(75, 35)
        Me.btnAppend.TabIndex = 14
        Me.btnAppend.Text = "Add"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Location = New System.Drawing.Point(137, 170)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 16)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "status"
        '
        'OrderInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(504, 207)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtWo)
        Me.Controls.Add(Me.txtMixing)
        Me.Controls.Add(Me.cboMaterial)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblPartDisplay)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblWO)
        Me.Controls.Add(Me.lblMixing)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblMaterial)
        Me.Controls.Add(Me.lblPartFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderInput"
        Me.Text = "TPO Order Creation Wizard - Order Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPartFolder As Label
    Friend WithEvents lblMaterial As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblMixing As Label
    Friend WithEvents lblWO As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblPartDisplay As Label
    Friend WithEvents cboMaterial As ComboBox
    Friend WithEvents txtMixing As TextBox
    Friend WithEvents txtWo As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents partBrowser As FolderBrowserDialog
    Friend WithEvents lblStatus As Label
End Class
