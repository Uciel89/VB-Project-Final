<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.txtBoxImpor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtBoxCot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 49)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conversor "
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.sys_uciel.My.Resources.Resources.minimize_icon
        Me.btnMinimize.Location = New System.Drawing.Point(407, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(18, 18)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.sys_uciel.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(433, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'txtBoxImpor
        '
        Me.txtBoxImpor.Location = New System.Drawing.Point(244, 113)
        Me.txtBoxImpor.Name = "txtBoxImpor"
        Me.txtBoxImpor.Size = New System.Drawing.Size(92, 20)
        Me.txtBoxImpor.TabIndex = 0
        Me.txtBoxImpor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(114, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Ingresar cotización:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(117, 198)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(219, 29)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtBoxCot
        '
        Me.txtBoxCot.Location = New System.Drawing.Point(244, 144)
        Me.txtBoxCot.Name = "txtBoxCot"
        Me.txtBoxCot.Size = New System.Drawing.Size(92, 20)
        Me.txtBoxCot.TabIndex = 1
        Me.txtBoxCot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(114, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Ingresar importe:"
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Enabled = False
        Me.txtBoxResult.Location = New System.Drawing.Point(244, 233)
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.Size = New System.Drawing.Size(92, 20)
        Me.txtBoxResult.TabIndex = 7
        Me.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(169, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Resultado:"
        '
        'txtBoxDni
        '
        Me.txtBoxDni.Location = New System.Drawing.Point(244, 81)
        Me.txtBoxDni.Name = "txtBoxDni"
        Me.txtBoxDni.Size = New System.Drawing.Size(92, 20)
        Me.txtBoxDni.TabIndex = 26
        Me.txtBoxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(114, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ingresar dni:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Location = New System.Drawing.Point(0, 327)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(462, 20)
        Me.Panel2.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sys_uciel.My.Resources.Resources.money_icon
        Me.PictureBox1.Location = New System.Drawing.Point(90, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.sys_uciel.My.Resources.Resources.dni_icon
        Me.PictureBox3.Location = New System.Drawing.Point(90, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.Image = Global.sys_uciel.My.Resources.Resources.refresh_icon
        Me.btnRefresh.Location = New System.Drawing.Point(207, 278)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(43, 43)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sys_uciel.My.Resources.Resources.cotizacion_icon
        Me.PictureBox2.Location = New System.Drawing.Point(90, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'frmConversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(462, 346)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBoxDni)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxCot)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoxImpor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConversor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents txtBoxImpor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtBoxCot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxResult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtBoxDni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
