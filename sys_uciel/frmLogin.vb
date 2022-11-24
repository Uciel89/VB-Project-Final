Imports System.Runtime.InteropServices

Public Class frmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtBoxUser.Select()
    End Sub

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ':: Botón para acceder al programa
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Me.txtBoxPassword.Text = "123" And Me.txtBoxUser.Text = "admin" Then
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Multi App")
        End If
    End Sub
End Class