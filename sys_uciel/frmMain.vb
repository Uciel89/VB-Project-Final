Imports System.Runtime.InteropServices

Public Class frmMain

    ':: Configuración para darle movimiento a la barra de navegación
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    ':: Botones de navegación
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ':: Asignación del funcionamiento de los dos opciones del menú
    Private Sub PromedioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioToolStripMenuItem.Click
        frmPromedio.ShowDialog()
    End Sub

    Private Sub ConversorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorToolStripMenuItem.Click
        frmConversor.ShowDialog()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
