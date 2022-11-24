Imports System.Runtime.InteropServices
Imports System.Math

Public Class frmPromedio

    ':: Variables de calculo y dni
    Private promedio As Integer
    Private edades_mayores As Integer
    Private dni As String

    ':: Variables para archivos
    Private ReadOnly ruta As String = "F:\Proyectos\proyectos\Desarrollador de software\sys_uciel\sys_uciel\recursos\documentos\"
    Private ReadOnly archivo As String = "Historial.txt"
    Private ReadOnly EditarDocumento As New ReadWriteCreate(ruta, archivo)

    Private Sub FrmPromedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDni.Select()
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    ':: Botón para agregar y incrementar los diferentes contadores, y que nos da el paso a poder realizar el promedio de edades
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtDni.Text IsNot "" And txtEdad.Text IsNot "" Then

            ':: Validamos que el txtBoxImport, txtBoxCotizacion y txtDni no contengan 0
            If Not Val(Me.txtDni.Text) = 0 And Not Val(Me.txtEdad.Text) = 0 Then

                ':: Contador de edades
                Me.txtCant.Text = Val(Me.txtCant.Text) + 1

                ':: Guardamos el valor ingresado y despues bloqueamos su modificación
                dni = Me.txtDni.Text
                Me.txtDni.Enabled = False

                If Val(Me.txtEdad.Text) > 17 Then
                    ':: Inicializamos el acumulador de edades, solo con las edades mayores
                    edades_mayores += Val(Me.txtEdad.Text)

                    ':: Aumentamos el valor que contiene el txtMayores, para mostrar que estamos agregando edades mayores
                    Me.txtMayores.Text = Val(Me.txtMayores.Text) + 1

                End If

                MsgBox("Edad guardada con exito", MsgBoxStyle.Information, "Multi App")
                Me.txtEdad.Clear()
                Me.btnSave.Enabled = True

                ':: Pequeña validación para activar o desactivar botones
                If Me.txtMayores.Text Is "" Then
                    Me.btnCalcular.Enabled = False

                Else
                    Me.btnCalcular.Enabled = True
                    Me.btnSave.Enabled = False

                End If
            Else
                MsgBox("No se permite ingresar 0", MsgBoxStyle.Critical, "Multi App")

            End If
        Else
            MsgBox("Por favor ingresar datos en DNI y edad", MsgBoxStyle.Critical, "Multi App")

        End If
    End Sub

    ':: Botón para guardar datos en un documento sin promedio
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ':: Manejo de archivos
        Try
            Me.txtEdad.Enabled = False

            EditarDocumento.ReadAndWite("El DNI es: " + dni)
            EditarDocumento.ReadAndWite("La cantidad de edades ingresadas son: " + txtCant.Text)
            EditarDocumento.ReadAndWite("")

            ':: Mandamos un mensaje con la confimación de que guardamos los datos dentro de Bloc de notas
            MsgBox("Datos guardados exitosamente", MsgBoxStyle.Information, "Multi App")

            Me.btnAgregar.Enabled = False
            Me.btnSave.Enabled = False

        Catch ex As Exception
            MsgBox("Se presentó un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "Multi App")
        End Try
    End Sub

    ':: Con esté botón para hacer tanto el calculo de promedio como el almacenamiento de los datos dentro de un documento de texto
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If Me.txtMayores IsNot "" Then
            promedio = edades_mayores / Val(Me.txtMayores.Text)
            Me.txtPromedio.Text = Round(promedio, 2).ToString

            Me.txtEdad.Enabled = False
        End If

        ':: Manejo de archivos
        Try
            EditarDocumento.ReadAndWite("El DNI es: " + dni)
            EditarDocumento.ReadAndWite("La cantidad de edades ingresadas son: " + txtCant.Text)
            EditarDocumento.ReadAndWite("El promedio de las edades generado por este DNI: " + dni + " son: " + promedio.ToString)
            EditarDocumento.ReadAndWite("")

            ':: Mandamos un mensaje con la confimación de que guardamos los datos dentro de Bloc de notas
            MsgBox("Datos guardados exitosamente", MsgBoxStyle.Information, "Multi App")

            Me.btnAgregar.Enabled = False
            Me.btnCalcular.Enabled = False

        Catch ex As Exception
            MsgBox("Se presentó un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "Multi App")
        End Try
    End Sub

    ':: Botón para refrescar la ventana
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        ':: Limpiamos el textBox de DNI, para generar otro registro
        Me.txtDni.Clear()
        Me.txtDni.Enabled = True
        Me.txtDni.Select()

        ':: Limpiamos el textBox de edad, para generar otro registro
        Me.txtEdad.Text = ""
        Me.txtEdad.Enabled = True

        ':: Limpiamos las cajas de txto
        Me.txtPromedio.Text = ""
        Me.txtMayores.Text = ""
        Me.txtCant.Text = ""
        Me.dni = ""

        ':: Establecemos el acumulador y contador a 0 
        promedio = 0
        edades_mayores = 0

        Me.btnAgregar.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnCalcular.Enabled = False

    End Sub
End Class