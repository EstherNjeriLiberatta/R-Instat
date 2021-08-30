' R- Instat
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
Partial Class dlgReorderLevels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderLevels))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.rdoProperty = New System.Windows.Forms.RadioButton()
        Me.rdoHand = New System.Windows.Forms.RadioButton()
        Me.grpPropertyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoShift = New System.Windows.Forms.RadioButton()
        Me.rdoShuffle = New System.Windows.Forms.RadioButton()
        Me.rdoAnonymise = New System.Windows.Forms.RadioButton()
        Me.rdoAsIs = New System.Windows.Forms.RadioButton()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.rdoFrequencyDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAppearance = New System.Windows.Forms.RadioButton()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.ucrChkReverseOrder = New instat.ucrCheck()
        Me.ucrInputTextPrefix = New instat.ucrInputTextBox()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.ucrNudShift = New instat.ucrNud()
        Me.UcrSave1 = New instat.ucrSave()
        Me.ucrPnlReorderOptions = New instat.UcrPanel()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.grpPropertyOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
        '
        'rdoVariable
        '
        resources.ApplyResources(Me.rdoVariable, "rdoVariable")
        Me.rdoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatAppearance.BorderSize = 2
        Me.rdoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Tag = "Variable"
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoProperty
        '
        resources.ApplyResources(Me.rdoProperty, "rdoProperty")
        Me.rdoProperty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.FlatAppearance.BorderSize = 2
        Me.rdoProperty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.Name = "rdoProperty"
        Me.rdoProperty.TabStop = True
        Me.rdoProperty.Tag = "Property"
        Me.rdoProperty.UseVisualStyleBackColor = True
        '
        'rdoHand
        '
        resources.ApplyResources(Me.rdoHand, "rdoHand")
        Me.rdoHand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.FlatAppearance.BorderSize = 2
        Me.rdoHand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.Name = "rdoHand"
        Me.rdoHand.TabStop = True
        Me.rdoHand.Tag = "Hand"
        Me.rdoHand.UseVisualStyleBackColor = True
        '
        'grpPropertyOptions
        '
        Me.grpPropertyOptions.Controls.Add(Me.rdoShift)
        Me.grpPropertyOptions.Controls.Add(Me.rdoShuffle)
        Me.grpPropertyOptions.Controls.Add(Me.rdoAnonymise)
        Me.grpPropertyOptions.Controls.Add(Me.rdoAsIs)
        Me.grpPropertyOptions.Controls.Add(Me.rdoSequence)
        Me.grpPropertyOptions.Controls.Add(Me.rdoFrequencyDescending)
        Me.grpPropertyOptions.Controls.Add(Me.rdoAppearance)
        resources.ApplyResources(Me.grpPropertyOptions, "grpPropertyOptions")
        Me.grpPropertyOptions.Name = "grpPropertyOptions"
        Me.grpPropertyOptions.TabStop = False
        '
        'rdoShift
        '
        resources.ApplyResources(Me.rdoShift, "rdoShift")
        Me.rdoShift.Name = "rdoShift"
        Me.rdoShift.TabStop = True
        Me.rdoShift.UseVisualStyleBackColor = True
        '
        'rdoShuffle
        '
        resources.ApplyResources(Me.rdoShuffle, "rdoShuffle")
        Me.rdoShuffle.Name = "rdoShuffle"
        Me.rdoShuffle.TabStop = True
        Me.rdoShuffle.UseVisualStyleBackColor = True
        '
        'rdoAnonymise
        '
        resources.ApplyResources(Me.rdoAnonymise, "rdoAnonymise")
        Me.rdoAnonymise.Name = "rdoAnonymise"
        Me.rdoAnonymise.TabStop = True
        Me.rdoAnonymise.UseVisualStyleBackColor = True
        '
        'rdoAsIs
        '
        resources.ApplyResources(Me.rdoAsIs, "rdoAsIs")
        Me.rdoAsIs.Name = "rdoAsIs"
        Me.rdoAsIs.TabStop = True
        Me.rdoAsIs.UseVisualStyleBackColor = True
        '
        'rdoSequence
        '
        resources.ApplyResources(Me.rdoSequence, "rdoSequence")
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.TabStop = True
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'rdoFrequencyDescending
        '
        resources.ApplyResources(Me.rdoFrequencyDescending, "rdoFrequencyDescending")
        Me.rdoFrequencyDescending.Name = "rdoFrequencyDescending"
        Me.rdoFrequencyDescending.TabStop = True
        Me.rdoFrequencyDescending.UseVisualStyleBackColor = True
        '
        'rdoAppearance
        '
        resources.ApplyResources(Me.rdoAppearance, "rdoAppearance")
        Me.rdoAppearance.Name = "rdoAppearance"
        Me.rdoAppearance.TabStop = True
        Me.rdoAppearance.UseVisualStyleBackColor = True
        '
        'lblSummary
        '
        resources.ApplyResources(Me.lblSummary, "lblSummary")
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Tag = "Summary:"
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = "Variable:"
        '
        'lblBy
        '
        resources.ApplyResources(Me.lblBy, "lblBy")
        Me.lblBy.Name = "lblBy"
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'lblPrefix
        '
        resources.ApplyResources(Me.lblPrefix, "lblPrefix")
        Me.lblPrefix.Name = "lblPrefix"
        '
        'ucrChkReverseOrder
        '
        Me.ucrChkReverseOrder.Checked = False
        resources.ApplyResources(Me.ucrChkReverseOrder, "ucrChkReverseOrder")
        Me.ucrChkReverseOrder.Name = "ucrChkReverseOrder"
        '
        'ucrInputTextPrefix
        '
        Me.ucrInputTextPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputTextPrefix.IsMultiline = False
        Me.ucrInputTextPrefix.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextPrefix, "ucrInputTextPrefix")
        Me.ucrInputTextPrefix.Name = "ucrInputTextPrefix"
        '
        'ucrReceiverVariable
        '
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummary, "ucrInputSummary")
        Me.ucrInputSummary.Name = "ucrInputSummary"
        '
        'ucrNudShift
        '
        Me.ucrNudShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudShift, "ucrNudShift")
        Me.ucrNudShift.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Name = "ucrNudShift"
        Me.ucrNudShift.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrSave1
        '
        resources.ApplyResources(Me.UcrSave1, "UcrSave1")
        Me.UcrSave1.Name = "UcrSave1"
        '
        'ucrPnlReorderOptions
        '
        resources.ApplyResources(Me.ucrPnlReorderOptions, "ucrPnlReorderOptions")
        Me.ucrPnlReorderOptions.Name = "ucrPnlReorderOptions"
        '
        'ucrReceiverFactor
        '
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactorLevelsToReorder, "ucrSelectorFactorLevelsToReorder")
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        '
        'ucrReorderFactor
        '
        resources.ApplyResources(Me.ucrReorderFactor, "ucrReorderFactor")
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'dlgReorderLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrChkReverseOrder)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrInputTextPrefix)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.ucrNudShift)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.UcrSave1)
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoProperty)
        Me.Controls.Add(Me.rdoHand)
        Me.Controls.Add(Me.ucrPnlReorderOptions)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.grpPropertyOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderLevels"
        Me.Tag = "Reorder_Levels"
        Me.grpPropertyOptions.ResumeLayout(False)
        Me.grpPropertyOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoProperty As RadioButton
    Friend WithEvents rdoHand As RadioButton
    Friend WithEvents ucrPnlReorderOptions As UcrPanel
    Friend WithEvents UcrSave1 As ucrSave
    Friend WithEvents grpPropertyOptions As GroupBox
    Friend WithEvents rdoAsIs As RadioButton
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents rdoFrequencyDescending As RadioButton
    Friend WithEvents rdoAppearance As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents rdoShift As RadioButton
    Friend WithEvents rdoShuffle As RadioButton
    Friend WithEvents rdoAnonymise As RadioButton
    Friend WithEvents ucrChkReverseOrder As ucrCheck
    Friend WithEvents lblPrefix As Label
    Friend WithEvents ucrInputTextPrefix As ucrInputTextBox
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrNudShift As ucrNud
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrInputSummary As ucrInputComboBox
End Class
