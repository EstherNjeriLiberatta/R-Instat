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
        Me.lblColour = New System.Windows.Forms.Label()
        Me.rdoSimple = New instat.ucrRadio()
        Me.rdoClustered = New instat.ucrRadio()
        Me.rdoStacked = New instat.ucrRadio()
        Me.grpBarChartType = New System.Windows.Forms.GroupBox()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
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
        Me.ucrColors.Location = New System.Drawing.Point(264, 201)
        Me.ucrColors.Name = "ucrColors"
        Me.ucrColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrColors.TabIndex = 6
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(261, 182)
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
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(12, -1)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrame.TabIndex = 15
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(264, 48)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 16
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(264, 111)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 17
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(261, 35)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblXVariable.TabIndex = 18
        Me.lblXVariable.Text = "X Variable"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(261, 98)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 19
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(264, 237)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(313, 32)
        Me.ucrSaveGraph.TabIndex = 20
        '
        'dlgBarChartDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 353)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.grpBarChartType)
        Me.Controls.Add(Me.lblColour)
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
    Friend WithEvents lblColour As Label
    Friend WithEvents rdoSimple As ucrRadio
    Friend WithEvents rdoClustered As ucrRadio
    Friend WithEvents rdoStacked As ucrRadio
    Friend WithEvents grpBarChartType As GroupBox
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
End Class
