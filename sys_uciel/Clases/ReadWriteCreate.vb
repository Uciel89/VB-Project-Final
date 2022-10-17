Imports System.IO
Public Class ReadWriteCreate

    ':: Atributos
    Public Ruta As String
    Public Archivo As String

    ':: Constructor
    Public Sub New(ByVal ruta As String, ByVal archivo As String)
        Me.Ruta = ruta
        Me.Archivo = archivo
    End Sub

    ':: Métodos
    Public Sub ReadAndWite(ByVal Mensaje As String)
        Dim escribir As New StreamWriter(Ruta & Archivo, True)
        escribir.WriteLine(Mensaje)
        escribir.Close()
    End Sub
End Class
