Imports System.Runtime.InteropServices

Public Class frmConversor

    ':: Variable global
    Dim resultado As String

    ':: Variables para archivos
    Private ReadOnly ruta As String = "F:\Proyectos\proyectos\Desarrollador de software\sys_uciel\sys_uciel\recursos\documentos\"
    Private ReadOnly archivo As String = "Afip.txt"
    Private ReadOnly EditarDocumento As New ReadWriteCreate(ruta, archivo)

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

    ':: Botones de navegación
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ':: Configuración del boton para realizar la conversión 
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        ':: Validamos que el txtBoxImport no contenga 0
        Select Case Val(Me.txtBoxImpor.Text)
            Case 0
                MsgBox("No se permite ingresar un importe en 0", MsgBoxStyle.Critical, "Multi App")

            Case > 0
                resultado = Val(Me.txtBoxImpor.Text) * Val(Me.txtBoxCot.Text)
                Me.txtBoxResult.Text = resultado

                ':: Manejo de archivos
                If Me.txtBoxDni.Text IsNot "" And Me.txtBoxCot.Text IsNot "" And Me.txtBoxImpor.Text IsNot "" Then
                    Me.txtBoxDni.Enabled = False

                    ':: Si el valor ingresado por el txtBoxImport es superior o igual 100, guardamos ese importe junto al DNI del usuario que realizo la conversión
                    If Val(Me.txtBoxImpor.Text) >= 100 And (Not Val(Me.txtBoxImpor.Text) = 0) Then
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
        End Select
    End Sub

    ':: Configurando el botón para refrescar todos los campos de texto del la ventana.
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.txtBoxCot.Clear()
        Me.txtBoxImpor.Clear()
        Me.txtBoxResult.Clear()
        Me.txtBoxDni.Clear()
        Me.txtBoxDni.Enabled = True

        resultado = 0
    End Sub

End Class