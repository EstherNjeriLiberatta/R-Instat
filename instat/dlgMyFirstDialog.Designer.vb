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
        Me.UcrColors1 = New instat.ucrColors()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcrDataFrame1 = New instat.ucrDataFrame()
        Me.UcrDataSelection1 = New instat.ucrDataSelection()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcrRadio1 = New instat.ucrRadio()
        Me.UcrRadio2 = New instat.ucrRadio()
        Me.UcrRadio3 = New instat.ucrRadio()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 289)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'UcrColors1
        '
        Me.UcrColors1.AddQuotesIfUnrecognised = True
        Me.UcrColors1.GetSetSelectedIndex = -1
        Me.UcrColors1.IsReadOnly = False
        Me.UcrColors1.Location = New System.Drawing.Point(203, 224)
        Me.UcrColors1.Name = "UcrColors1"
        Me.UcrColors1.Size = New System.Drawing.Size(137, 21)
        Me.UcrColors1.TabIndex = 6
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
        'UcrDataFrame1
        '
        Me.UcrDataFrame1.bDropUnusedFilterLevels = False
        Me.UcrDataFrame1.bUseCurrentFilter = True
        Me.UcrDataFrame1.Location = New System.Drawing.Point(12, 9)
        Me.UcrDataFrame1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrDataFrame1.Name = "UcrDataFrame1"
        Me.UcrDataFrame1.Size = New System.Drawing.Size(148, 50)
        Me.UcrDataFrame1.TabIndex = 8
        '
        'UcrDataSelection1
        '
        Me.UcrDataSelection1.Location = New System.Drawing.Point(12, 62)
        Me.UcrDataSelection1.Name = "UcrDataSelection1"
        Me.UcrDataSelection1.Size = New System.Drawing.Size(285, 122)
        Me.UcrDataSelection1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'UcrRadio1
        '
        Me.UcrRadio1.Location = New System.Drawing.Point(12, 199)
        Me.UcrRadio1.Name = "UcrRadio1"
        Me.UcrRadio1.Size = New System.Drawing.Size(100, 20)
        Me.UcrRadio1.TabIndex = 11
        '
        'UcrRadio2
        '
        Me.UcrRadio2.Location = New System.Drawing.Point(12, 225)
        Me.UcrRadio2.Name = "UcrRadio2"
        Me.UcrRadio2.Size = New System.Drawing.Size(100, 20)
        Me.UcrRadio2.TabIndex = 12
        '
        'UcrRadio3
        '
        Me.UcrRadio3.Location = New System.Drawing.Point(12, 251)
        Me.UcrRadio3.Name = "UcrRadio3"
        Me.UcrRadio3.Size = New System.Drawing.Size(100, 20)
        Me.UcrRadio3.TabIndex = 13
        '
        'dlgBarChartDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 353)
        Me.Controls.Add(Me.UcrRadio3)
        Me.Controls.Add(Me.UcrRadio2)
        Me.Controls.Add(Me.UcrRadio1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UcrDataSelection1)
        Me.Controls.Add(Me.UcrDataFrame1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UcrColors1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarChartDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bar Chart Design"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrColors1 As ucrColors
    Friend WithEvents Label1 As Label
    Friend WithEvents UcrDataFrame1 As ucrDataFrame
    Friend WithEvents UcrDataSelection1 As ucrDataSelection
    Friend WithEvents Label2 As Label
    Friend WithEvents UcrRadio1 As ucrRadio
    Friend WithEvents UcrRadio2 As ucrRadio
    Friend WithEvents UcrRadio3 As ucrRadio
End Class
