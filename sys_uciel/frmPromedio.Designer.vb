<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromedio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromedio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.txtMayores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 49)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Promedio "
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sys_uciel.My.Resources.Resources.minimize_icon
        Me.PictureBox1.Location = New System.Drawing.Point(589, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.sys_uciel.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(615, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'txtMayores
        '
        Me.txtMayores.Enabled = False
        Me.txtMayores.Location = New System.Drawing.Point(508, 158)
        Me.txtMayores.Name = "txtMayores"
        Me.txtMayores.ReadOnly = True
        Me.txtMayores.Size = New System.Drawing.Size(76, 20)
        Me.txtMayores.TabIndex = 27
        Me.txtMayores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(324, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Edades mayores a 17"
        '
        'txtCant
        '
        Me.txtCant.Enabled = False
        Me.txtCant.Location = New System.Drawing.Point(508, 132)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.ReadOnly = True
        Me.txtCant.Size = New System.Drawing.Size(76, 20)
        Me.txtCant.TabIndex = 25
        Me.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(324, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cantindad de edades"
        '
        'txtPromedio
        '
        Me.txtPromedio.Enabled = False
        Me.txtPromedio.Location = New System.Drawing.Point(508, 106)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.ReadOnly = True
        Me.txtPromedio.Size = New System.Drawing.Size(76, 20)
        Me.txtPromedio.TabIndex = 23
        Me.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(324, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Promedio (Edades > 17)"
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.Location = New System.Drawing.Point(85, 238)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(189, 23)
        Me.btnCalcular.TabIndex = 19
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Location = New System.Drawing.Point(85, 180)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(189, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(180, 107)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(94, 20)
        Me.txtDni.TabIndex = 17
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(180, 143)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(94, 20)
        Me.txtEdad.TabIndex = 16
        Me.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ingresar DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(82, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Ingresar edad"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Location = New System.Drawing.Point(-1, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 20)
        Me.Panel2.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sys_uciel.My.Resources.Resources.user_icon
        Me.PictureBox2.Location = New System.Drawing.Point(58, 143)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.sys_uciel.My.Resources.Resources.dni_icon
        Me.PictureBox3.Location = New System.Drawing.Point(58, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = Global.sys_uciel.My.Resources.Resources.refresh_icon
        Me.btnRefresh.Location = New System.Drawing.Point(541, 218)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(43, 43)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(85, 209)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(189, 23)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmPromedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(646, 324)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtMayores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPromedio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promedio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMayores As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSave As Button
End Class
