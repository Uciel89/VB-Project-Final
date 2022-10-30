Imports System.Runtime.InteropServices

Public Class frmConversor

    ':: Variable global
    Dim resultado As String

    ':: Variables para archivos
    Dim ruta As String = "F:\Proyectos\proyectos\Desarrollador de software\sys_uciel\sys_uciel\recursos\documentos\"
    Dim archivo As String = "Afip.txt"
    Dim EditarDocumento As New ReadWriteCreate(ruta, archivo)

    Private Sub FrmConversor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtBoxDni.Select()
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        resultado = Val(Me.txtBoxImpor.Text) * Val(Me.txtBoxCot.Text)
        Me.txtBoxResult.Text = resultado

        ':: Manejo de archivos
        If Me.txtBoxDni.Text IsNot "" And Me.txtBoxCot.Text IsNot "" And Me.txtBoxImpor.Text IsNot "" Then
            Me.txtBoxDni.Enabled = False

            If Val(Me.txtBoxImpor.Text) >= 100 Then
                Try
                    EditarDocumento.ReadAndWite("El DNI es: " + Me.txtBoxDni.Text)
                    EditarDocumento.ReadAndWite("Cantidad de dolares comprados son: " + Me.txtBoxImpor.Text)
                    EditarDocumento.ReadAndWite("")

                    MsgBox("Registro guardado exitosamente", MsgBoxStyle.Information, "Multi App")
                Catch ex As Exception
                    MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "Multi App")
                End Try
            End If
        Else
            MsgBox("Por favor ingresar datos en dni, cotizacion y importe", MsgBoxStyle.Critical, "Multi App")
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.txtBoxCot.Clear()
        Me.txtBoxImpor.Clear()
        Me.txtBoxResult.Clear()
        Me.txtBoxDni.Clear()
        Me.txtBoxDni.Enabled = True
    End Sub

End Class