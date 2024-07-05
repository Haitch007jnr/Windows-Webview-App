Imports System.Runtime.CompilerServices

Public Class Form1

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

        AboutBox1 = New AboutBox1()
        AboutBox1.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox1.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Form2 = New Form2()
        Form2.Show()
        Me.Hide()

    End Sub

End Class
