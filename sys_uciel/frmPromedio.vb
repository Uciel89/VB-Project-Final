Imports System.Runtime.InteropServices
Imports System.Math

Public Class frmPromedio

    ':: Variables de calculo y dni
    Dim promedio As Integer
    Dim acumlador_edades As String
    Dim dni As String

    ':: Variables para archivos
    Dim ruta As String = "F:\Proyectos\proyectos\Desarrollador de software\sys_uciel\sys_uciel\recursos\documentos\"
    Dim archivo As String = "Historial.txt"
    Dim EditarDocumento As New ReadWriteCreate(ruta, archivo)

    Private Sub FrmPromedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDni.Select()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
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

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDni.Text IsNot "" And txtEdad.Text IsNot "" Then
            Me.txtCant.Text = Val(Me.txtCant.Text) + 1

            If Val(Me.txtEdad.Text) > 17 Then
                ':: Inicializamos el acumulador de edades, solo con las edades mayores
                acumlador_edades = acumlador_edades + Val(Me.txtEdad.Text)

                ':: Aumentamos el valor que contiene el txtMayores, para mostrar que estamos agregando edades mayores
                Me.txtMayores.Text = Val(Me.txtMayores.Text) + 1
            End If

            ':: Validamos que el campo DNI no este vacio, y guardamos el valor ingresado y despues bloqueamos su modificación
            If txtDni.Text IsNot "" Then
                dni = Me.txtDni.Text
                Me.txtDni.Enabled = False
            End If

            MsgBox("Edad guardada con exito", MsgBoxStyle.Information, "Multi App")
            Me.txtEdad.Clear()

            btnCalcular.Enabled = True
        Else
            MsgBox("Por favor ingresar datos en DNI y edad", MsgBoxStyle.Critical, "Multi App")
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        promedio = acumlador_edades / Val(Me.txtMayores.Text)
        Me.txtPromedio.Text = Round(promedio, 2).ToString

        ':: Limpiamos el textBox de DNI, para generar otro registro
        Me.txtDni.Clear()
        Me.txtDni.Enabled = True
        Me.txtDni.Select()

        ':: Manejo de archivos
        Try
            EditarDocumento.ReadAndWite("El DNI es: " + dni)
            EditarDocumento.ReadAndWite("La cantidad de edades ingresadas son: " + txtCant.Text)
            EditarDocumento.ReadAndWite("El promedio de las edades generado por este DNI: " + dni + " son: " + promedio.ToString)

            ':: Mandamos un mensaje con la confimación de que guardamos los datos dentro de Bloc de notas
            MsgBox("Registro guardado exitosamente", MsgBoxStyle.Information, "Multi App")

            ':: Limpiamos las cajas de txto
            txtEdad.Text = ""
            txtPromedio.Text = ""
            txtMayores.Text = ""
            txtCant.Text = ""
            dni = ""

        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "Multi App")
        End Try
    End Sub

End Class