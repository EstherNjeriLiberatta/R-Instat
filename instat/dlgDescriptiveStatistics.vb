﻿Public Class dlgDescriptiveStatistics
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpgraphics.Visible = False
        GroupBox2.Visible = False

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

        If CheckBox7.Checked = True Then
            GroupBox2.Visible = True

        End If

        If CheckBox7.Checked = False Then
            GroupBox2.Visible = False

        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            grpgraphics.Visible = True
        End If
        If CheckBox14.Checked = False Then
            grpgraphics.Visible = False
        End If
    End Sub
End Class
