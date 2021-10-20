﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMachineLearning
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
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrReceiverExpressionFitModel = New instat.ucrReceiverExpression()
        Me.lblExplanatoryModel = New System.Windows.Forms.Label()
        Me.ucrReceiverResponseVariable = New instat.ucrReceiverSingle()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.ucrSelectorMachineLearning = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrPnlExplanatoryVariable = New instat.UcrPanel()
        Me.rdoExplanatoryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoExplanatoryModel = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverMultipleExplanatoryVariable = New instat.ucrReceiverMultiple()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(8, 316)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(302, 24)
        Me.ucrModelName.TabIndex = 23
        '
        'ucrReceiverExpressionFitModel
        '
        Me.ucrReceiverExpressionFitModel.frmParent = Me
        Me.ucrReceiverExpressionFitModel.Location = New System.Drawing.Point(245, 146)
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        Me.ucrReceiverExpressionFitModel.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverExpressionFitModel.strNcFilePath = ""
        Me.ucrReceiverExpressionFitModel.TabIndex = 22
        Me.ucrReceiverExpressionFitModel.ucrSelector = Nothing
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(247, 131)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(97, 13)
        Me.lblExplanatoryModel.TabIndex = 21
        Me.lblExplanatoryModel.Text = "Explanatory Model:"
        '
        'ucrReceiverResponseVariable
        '
        Me.ucrReceiverResponseVariable.frmParent = Me
        Me.ucrReceiverResponseVariable.Location = New System.Drawing.Point(245, 59)
        Me.ucrReceiverResponseVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVariable.Name = "ucrReceiverResponseVariable"
        Me.ucrReceiverResponseVariable.Selector = Nothing
        Me.ucrReceiverResponseVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVariable.strNcFilePath = ""
        Me.ucrReceiverResponseVariable.TabIndex = 20
        Me.ucrReceiverResponseVariable.ucrSelector = Nothing
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponseVariable.Location = New System.Drawing.Point(246, 44)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblResponseVariable.TabIndex = 19
        Me.lblResponseVariable.Text = "Response Variable:"
        '
        'ucrSelectorMachineLearning
        '
        Me.ucrSelectorMachineLearning.bDropUnusedFilterLevels = False
        Me.ucrSelectorMachineLearning.bShowHiddenColumns = False
        Me.ucrSelectorMachineLearning.bUseCurrentFilter = True
        Me.ucrSelectorMachineLearning.Location = New System.Drawing.Point(8, 11)
        Me.ucrSelectorMachineLearning.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMachineLearning.Name = "ucrSelectorMachineLearning"
        Me.ucrSelectorMachineLearning.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMachineLearning.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 344)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoExplanatoryModel)
        Me.GroupBox1.Controls.Add(Me.ucrPnlExplanatoryVariable)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 43)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ucrPnlExplanatoryVariable
        '
        Me.ucrPnlExplanatoryVariable.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlExplanatoryVariable.Name = "ucrPnlExplanatoryVariable"
        Me.ucrPnlExplanatoryVariable.Size = New System.Drawing.Size(137, 22)
        Me.ucrPnlExplanatoryVariable.TabIndex = 0
        '
        'rdoExplanatoryVariable
        '
        Me.rdoExplanatoryVariable.AutoSize = True
        Me.rdoExplanatoryVariable.Location = New System.Drawing.Point(252, 100)
        Me.rdoExplanatoryVariable.Name = "rdoExplanatoryVariable"
        Me.rdoExplanatoryVariable.Size = New System.Drawing.Size(63, 17)
        Me.rdoExplanatoryVariable.TabIndex = 26
        Me.rdoExplanatoryVariable.TabStop = True
        Me.rdoExplanatoryVariable.Text = "Variable"
        Me.rdoExplanatoryVariable.UseVisualStyleBackColor = True
        '
        'rdoExplanatoryModel
        '
        Me.rdoExplanatoryModel.AutoSize = True
        Me.rdoExplanatoryModel.Location = New System.Drawing.Point(80, 17)
        Me.rdoExplanatoryModel.Name = "rdoExplanatoryModel"
        Me.rdoExplanatoryModel.Size = New System.Drawing.Size(54, 17)
        Me.rdoExplanatoryModel.TabIndex = 27
        Me.rdoExplanatoryModel.TabStop = True
        Me.rdoExplanatoryModel.Text = "Model"
        Me.rdoExplanatoryModel.UseVisualStyleBackColor = True
        '
        'ucrReceiverMultipleExplanatoryVariable
        '
        Me.ucrReceiverMultipleExplanatoryVariable.frmParent = Me
        Me.ucrReceiverMultipleExplanatoryVariable.Location = New System.Drawing.Point(245, 146)
        Me.ucrReceiverMultipleExplanatoryVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleExplanatoryVariable.Name = "ucrReceiverMultipleExplanatoryVariable"
        Me.ucrReceiverMultipleExplanatoryVariable.Selector = Nothing
        Me.ucrReceiverMultipleExplanatoryVariable.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleExplanatoryVariable.strNcFilePath = ""
        Me.ucrReceiverMultipleExplanatoryVariable.TabIndex = 27
        Me.ucrReceiverMultipleExplanatoryVariable.ucrSelector = Nothing
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(62, 208)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputMethod.TabIndex = 28
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(10, 212)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 29
        Me.lblMethod.Text = "Method:"
        '
        'dlgMachineLearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 399)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.rdoExplanatoryVariable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.ucrReceiverExpressionFitModel)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.ucrReceiverResponseVariable)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorMachineLearning)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleExplanatoryVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMachineLearning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Learning (caret) "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents ucrReceiverExpressionFitModel As ucrReceiverExpression
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents ucrReceiverResponseVariable As ucrReceiverSingle
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrSelectorMachineLearning As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoExplanatoryVariable As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoExplanatoryModel As RadioButton
    Friend WithEvents ucrPnlExplanatoryVariable As UcrPanel
    Friend WithEvents ucrReceiverMultipleExplanatoryVariable As ucrReceiverMultiple
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
End Class
