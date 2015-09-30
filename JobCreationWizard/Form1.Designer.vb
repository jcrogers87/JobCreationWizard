<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPlanName = New System.Windows.Forms.Label()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.lblOutputDevice = New System.Windows.Forms.Label()
        Me.txtPlanName = New System.Windows.Forms.TextBox()
        Me.lblMaterialsFile = New System.Windows.Forms.Label()
        Me.btnBrowseMaterial = New System.Windows.Forms.Button()
        Me.lblMaterials = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.gridData = New System.Windows.Forms.DataGridView()
        Me.colWorkOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPartNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMixingGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.browseMaterials = New System.Windows.Forms.OpenFileDialog()
        Me.lblOutputDir = New System.Windows.Forms.Label()
        Me.lblmatcol = New System.Windows.Forms.Label()
        Me.txtMatCol = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlanName
        '
        Me.lblPlanName.AutoSize = True
        Me.lblPlanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanName.Location = New System.Drawing.Point(15, 10)
        Me.lblPlanName.Name = "lblPlanName"
        Me.lblPlanName.Size = New System.Drawing.Size(78, 16)
        Me.lblPlanName.TabIndex = 2
        Me.lblPlanName.Text = "Plan Name:"
        '
        'cboOutput
        '
        Me.cboOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(132, 37)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(342, 23)
        Me.cboOutput.TabIndex = 3
        '
        'lblOutputDevice
        '
        Me.lblOutputDevice.AutoSize = True
        Me.lblOutputDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputDevice.Location = New System.Drawing.Point(15, 40)
        Me.lblOutputDevice.Name = "lblOutputDevice"
        Me.lblOutputDevice.Size = New System.Drawing.Size(95, 16)
        Me.lblOutputDevice.TabIndex = 4
        Me.lblOutputDevice.Text = "Output Device:"
        '
        'txtPlanName
        '
        Me.txtPlanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanName.Location = New System.Drawing.Point(132, 7)
        Me.txtPlanName.Name = "txtPlanName"
        Me.txtPlanName.Size = New System.Drawing.Size(342, 21)
        Me.txtPlanName.TabIndex = 5
        '
        'lblMaterialsFile
        '
        Me.lblMaterialsFile.AutoSize = True
        Me.lblMaterialsFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialsFile.Location = New System.Drawing.Point(15, 70)
        Me.lblMaterialsFile.Name = "lblMaterialsFile"
        Me.lblMaterialsFile.Size = New System.Drawing.Size(91, 16)
        Me.lblMaterialsFile.TabIndex = 6
        Me.lblMaterialsFile.Text = "Materials File:"
        '
        'btnBrowseMaterial
        '
        Me.btnBrowseMaterial.Location = New System.Drawing.Point(132, 67)
        Me.btnBrowseMaterial.Name = "btnBrowseMaterial"
        Me.btnBrowseMaterial.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseMaterial.TabIndex = 13
        Me.btnBrowseMaterial.Text = "Browse"
        Me.btnBrowseMaterial.UseVisualStyleBackColor = True
        '
        'lblMaterials
        '
        Me.lblMaterials.AutoSize = True
        Me.lblMaterials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterials.Location = New System.Drawing.Point(213, 70)
        Me.lblMaterials.Name = "lblMaterials"
        Me.lblMaterials.Size = New System.Drawing.Size(0, 15)
        Me.lblMaterials.TabIndex = 14
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(753, 445)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(107, 47)
        Me.btnCreate.TabIndex = 15
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(15, 445)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(107, 47)
        Me.btnQuit.TabIndex = 16
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'gridData
        '
        Me.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWorkOrder, Me.colPartNo, Me.colMaterial, Me.colQty, Me.colMixingGroup})
        Me.gridData.Location = New System.Drawing.Point(15, 131)
        Me.gridData.Name = "gridData"
        Me.gridData.Size = New System.Drawing.Size(695, 276)
        Me.gridData.TabIndex = 17
        '
        'colWorkOrder
        '
        Me.colWorkOrder.HeaderText = "Work Order"
        Me.colWorkOrder.Name = "colWorkOrder"
        Me.colWorkOrder.Width = 110
        '
        'colPartNo
        '
        Me.colPartNo.HeaderText = "Part Number"
        Me.colPartNo.Name = "colPartNo"
        Me.colPartNo.Width = 110
        '
        'colMaterial
        '
        Me.colMaterial.HeaderText = "Material"
        Me.colMaterial.Name = "colMaterial"
        Me.colMaterial.Width = 200
        '
        'colQty
        '
        Me.colQty.HeaderText = "Quantity"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 80
        '
        'colMixingGroup
        '
        Me.colMixingGroup.HeaderText = "Mixing Group"
        Me.colMixingGroup.Name = "colMixingGroup"
        Me.colMixingGroup.Width = 110
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(718, 131)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 36)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add Entry"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(718, 173)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(142, 36)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'browseMaterials
        '
        Me.browseMaterials.FileName = "OpenFileDialog1"
        '
        'lblOutputDir
        '
        Me.lblOutputDir.AutoSize = True
        Me.lblOutputDir.Location = New System.Drawing.Point(15, 410)
        Me.lblOutputDir.Name = "lblOutputDir"
        Me.lblOutputDir.Size = New System.Drawing.Size(63, 13)
        Me.lblOutputDir.TabIndex = 20
        Me.lblOutputDir.Text = "outputplace"
        '
        'lblmatcol
        '
        Me.lblmatcol.AutoSize = True
        Me.lblmatcol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatcol.Location = New System.Drawing.Point(15, 100)
        Me.lblmatcol.Name = "lblmatcol"
        Me.lblmatcol.Size = New System.Drawing.Size(107, 16)
        Me.lblmatcol.TabIndex = 21
        Me.lblmatcol.Text = "Material Column:"
        '
        'txtMatCol
        '
        Me.txtMatCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatCol.Location = New System.Drawing.Point(132, 97)
        Me.txtMatCol.Name = "txtMatCol"
        Me.txtMatCol.Size = New System.Drawing.Size(81, 21)
        Me.txtMatCol.TabIndex = 22
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Location = New System.Drawing.Point(15, 427)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 15)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(870, 498)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtMatCol)
        Me.Controls.Add(Me.lblmatcol)
        Me.Controls.Add(Me.lblOutputDir)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gridData)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnBrowseMaterial)
        Me.Controls.Add(Me.lblMaterials)
        Me.Controls.Add(Me.lblMaterialsFile)
        Me.Controls.Add(Me.txtPlanName)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.lblOutputDevice)
        Me.Controls.Add(Me.lblPlanName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "TPO Order Creation Wizard"
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlanName As Label
    Friend WithEvents cboOutput As ComboBox
    Friend WithEvents lblOutputDevice As Label
    Friend WithEvents txtPlanName As TextBox
    Friend WithEvents lblMaterialsFile As Label
    Friend WithEvents btnBrowseMaterial As Button
    Friend WithEvents lblMaterials As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents gridData As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents colWorkOrder As DataGridViewTextBoxColumn
    Friend WithEvents colPartNo As DataGridViewTextBoxColumn
    Friend WithEvents colMaterial As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colMixingGroup As DataGridViewTextBoxColumn
    Friend WithEvents browseMaterials As OpenFileDialog
    Friend WithEvents lblOutputDir As Label
    Friend WithEvents lblmatcol As Label
    Friend WithEvents txtMatCol As TextBox
    Friend WithEvents lblStatus As Label
End Class
