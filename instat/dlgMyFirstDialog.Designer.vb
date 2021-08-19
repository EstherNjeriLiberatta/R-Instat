<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBarChartDesign
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrColors = New instat.ucrColors()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrDataSelectionVariables = New instat.ucrDataSelection()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.rdoSimple = New instat.ucrRadio()
        Me.rdoClustered = New instat.ucrRadio()
        Me.rdoStacked = New instat.ucrRadio()
        Me.grpBarChartType = New System.Windows.Forms.GroupBox()
        Me.grpBarChartType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 288)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(414, 62)
        Me.ucrBase.TabIndex = 0
        Me.ucrBase.TabStop = False
        '
        'ucrColors
        '
        Me.ucrColors.AddQuotesIfUnrecognised = True
        Me.ucrColors.GetSetSelectedIndex = -1
        Me.ucrColors.IsReadOnly = False
        Me.ucrColors.Location = New System.Drawing.Point(203, 224)
        Me.ucrColors.Name = "ucrColors"
        Me.ucrColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrColors.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.bDropUnusedFilterLevels = False
        Me.ucrDataFrame.bUseCurrentFilter = True
        Me.ucrDataFrame.Location = New System.Drawing.Point(12, 9)
        Me.ucrDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrame.TabIndex = 8
        '
        'ucrDataSelectionVariables
        '
        Me.ucrDataSelectionVariables.Location = New System.Drawing.Point(12, 55)
        Me.ucrDataSelectionVariables.Name = "ucrDataSelectionVariables"
        Me.ucrDataSelectionVariables.Size = New System.Drawing.Size(285, 122)
        Me.ucrDataSelectionVariables.TabIndex = 9
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(200, 199)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 10
        Me.lblColour.Text = "Colour"
        '
        'rdoSimple
        '
        Me.rdoSimple.Location = New System.Drawing.Point(6, 19)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(100, 20)
        Me.rdoSimple.TabIndex = 11
        '
        'rdoClustered
        '
        Me.rdoClustered.Location = New System.Drawing.Point(6, 42)
        Me.rdoClustered.Name = "rdoClustered"
        Me.rdoClustered.Size = New System.Drawing.Size(100, 20)
        Me.rdoClustered.TabIndex = 12
        '
        'rdoStacked
        '
        Me.rdoStacked.Location = New System.Drawing.Point(6, 67)
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.Size = New System.Drawing.Size(100, 20)
        Me.rdoStacked.TabIndex = 13
        '
        'grpBarChartType
        '
        Me.grpBarChartType.Controls.Add(Me.rdoSimple)
        Me.grpBarChartType.Controls.Add(Me.rdoStacked)
        Me.grpBarChartType.Controls.Add(Me.rdoClustered)
        Me.grpBarChartType.Location = New System.Drawing.Point(12, 182)
        Me.grpBarChartType.Name = "grpBarChartType"
        Me.grpBarChartType.Size = New System.Drawing.Size(148, 100)
        Me.grpBarChartType.TabIndex = 14
        Me.grpBarChartType.TabStop = False
        Me.grpBarChartType.Text = "Bar Chart Design "
        '
        'dlgBarChartDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 353)
        Me.Controls.Add(Me.grpBarChartType)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrDataSelectionVariables)
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrColors)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarChartDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bar Chart Design"
        Me.grpBarChartType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrColors As ucrColors
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrDataSelectionVariables As ucrDataSelection
    Friend WithEvents lblColour As Label
    Friend WithEvents rdoSimple As ucrRadio
    Friend WithEvents rdoClustered As ucrRadio
    Friend WithEvents rdoStacked As ucrRadio
    Friend WithEvents grpBarChartType As GroupBox
End Class
