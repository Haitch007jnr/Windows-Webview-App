Imports System.Runtime.CompilerServices

Public Class Form2

    Private Sub VendorToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form1 = New Form1()
        Form1.Show()
        Me.Hide()

    End Sub
    Private Sub VendorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VendorToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

        AboutBox1 = New AboutBox1()
        AboutBox1.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox1.Show()

    End Sub
End Class