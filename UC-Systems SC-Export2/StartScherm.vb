Imports System.Configuration
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Public Class StartScherm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ToolButton.Click
        Tool.Show() '' Laad het Tool scherm
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ControleButton.Click
        Controle.Show() '' Laad het controle scherm
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles FacturerenButton.Click
        Factureren.Show() '' Laad het factureren scherm
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles GoedkeuringButton.Click
        Goedkeuring.Show() '' Laad het Goedkeuren scherm
        Me.Hide()
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason <> CloseReason.TaskManagerClosing AndAlso e.CloseReason <> CloseReason.WindowsShutDown Then
            e.Cancel = System.Windows.MessageBox.Show("Wilt u afsluiten?", "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No
        End If
    End Sub


   


End Class