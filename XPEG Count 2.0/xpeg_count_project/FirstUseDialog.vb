﻿Imports System.Windows.Forms

Public Class FirstUseDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FirstUseDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FirstUseDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'My.Settings.FIRST_USE = False

    End Sub
End Class