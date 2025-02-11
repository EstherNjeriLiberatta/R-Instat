﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgScatterPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgScatterPlot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.cmdPointOptions = New System.Windows.Forms.Button()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrChkAddRugPlot = New instat.ucrCheck()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.ucrSelectorForScatter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactorForScatter = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudSize = New instat.ucrNud()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.ucrInputSides = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'cmdPointOptions
        '
        resources.ApplyResources(Me.cmdPointOptions, "cmdPointOptions")
        Me.cmdPointOptions.Name = "cmdPointOptions"
        Me.cmdPointOptions.Tag = "Point_Options"
        Me.cmdPointOptions.UseVisualStyleBackColor = True
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        '
        'ucrChkAddRugPlot
        '
        Me.ucrChkAddRugPlot.Checked = False
        resources.ApplyResources(Me.ucrChkAddRugPlot, "ucrChkAddRugPlot")
        Me.ucrChkAddRugPlot.Name = "ucrChkAddRugPlot"
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLabel, "ucrReceiverLabel")
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.ucrSelector = Nothing
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.Checked = False
        resources.ApplyResources(Me.ucrChkWithSE, "ucrChkWithSE")
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.Checked = False
        resources.ApplyResources(Me.ucrChkLineofBestFit, "ucrChkLineofBestFit")
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        '
        'ucrSaveScatterPlot
        '
        resources.ApplyResources(Me.ucrSaveScatterPlot, "ucrSaveScatterPlot")
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        '
        'ucrSelectorForScatter
        '
        Me.ucrSelectorForScatter.bDropUnusedFilterLevels = False
        Me.ucrSelectorForScatter.bShowHiddenColumns = False
        Me.ucrSelectorForScatter.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForScatter, "ucrSelectorForScatter")
        Me.ucrSelectorForScatter.Name = "ucrSelectorForScatter"
        '
        'ucrVariablesAsFactorForScatter
        '
        Me.ucrVariablesAsFactorForScatter.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForScatter, "ucrVariablesAsFactorForScatter")
        Me.ucrVariablesAsFactorForScatter.Name = "ucrVariablesAsFactorForScatter"
        Me.ucrVariablesAsFactorForScatter.Selector = Nothing
        Me.ucrVariablesAsFactorForScatter.strNcFilePath = ""
        Me.ucrVariablesAsFactorForScatter.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForScatter.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorOptionalReceiver, "ucrFactorOptionalReceiver")
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNudSize
        '
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSize, "ucrNudSize")
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSize
        '
        resources.ApplyResources(Me.lblSize, "lblSize")
        Me.lblSize.Name = "lblSize"
        '
        'lblSides
        '
        resources.ApplyResources(Me.lblSides, "lblSides")
        Me.lblSides.Name = "lblSides"
        '
        'ucrInputSides
        '
        Me.ucrInputSides.AddQuotesIfUnrecognised = True
        Me.ucrInputSides.GetSetSelectedIndex = -1
        Me.ucrInputSides.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSides, "ucrInputSides")
        Me.ucrInputSides.Name = "ucrInputSides"
        '
        'dlgScatterPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSides)
        Me.Controls.Add(Me.lblSides)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.ucrNudSize)
        Me.Controls.Add(Me.ucrChkAddRugPlot)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.ucrSelectorForScatter)
        Me.Controls.Add(Me.ucrVariablesAsFactorForScatter)
        Me.Controls.Add(Me.cmdPointOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScatterPlot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents cmdPointOptions As Button
    Friend WithEvents ucrVariablesAsFactorForScatter As ucrVariablesAsFactor
    Friend WithEvents ucrSelectorForScatter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents ucrChkAddRugPlot As ucrCheck
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents lblSides As Label
    Friend WithEvents ucrInputSides As ucrInputComboBox
End Class
