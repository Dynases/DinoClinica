<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnIngresar = New DevComponents.DotNetBar.ButtonX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(346, 470)
        Me.Panel2.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImage = Global.Presentacion.My.Resources.Resources.Fondo2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 364)
        Me.Panel1.TabIndex = 16
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnCancelar.HoverImage = Global.Presentacion.My.Resources.Resources.CAN02
        Me.btnCancelar.Image = Global.Presentacion.My.Resources.Resources.CAN01
        Me.btnCancelar.ImageFixedSize = New System.Drawing.Size(85, 35)
        Me.btnCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancelar.Location = New System.Drawing.Point(184, 281)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 42)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 327
        '
        'btnIngresar
        '
        Me.btnIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnIngresar.FadeEffect = False
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnIngresar.HoverImage = Global.Presentacion.My.Resources.Resources.IN02
        Me.btnIngresar.Image = Global.Presentacion.My.Resources.Resources.IN01
        Me.btnIngresar.ImageFixedSize = New System.Drawing.Size(85, 35)
        Me.btnIngresar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnIngresar.Location = New System.Drawing.Point(83, 281)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(95, 42)
        Me.btnIngresar.StopPulseOnMouseOver = False
        Me.btnIngresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.btnIngresar.TabIndex = 326
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BackgroundImage = Global.Presentacion.My.Resources.Resources.R02
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(47, 228)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(40, 40)
        Me.Panel4.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BackgroundImage = Global.Presentacion.My.Resources.Resources.R01
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(46, 155)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(40, 40)
        Me.Panel5.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(93, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(93, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtUsuario.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtUsuario.Border.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtUsuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtUsuario.Border.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtUsuario.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtUsuario.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtUsuario.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtUsuario.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.DisabledBackColor = System.Drawing.Color.Black
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(92, 155)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PreventEnterBeep = True
        Me.txtUsuario.Size = New System.Drawing.Size(200, 40)
        Me.txtUsuario.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtPassword.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtPassword.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.DisabledBackColor = System.Drawing.Color.Black
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(92, 228)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PreventEnterBeep = True
        Me.txtPassword.Size = New System.Drawing.Size(200, 40)
        Me.txtPassword.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = Global.Presentacion.My.Resources.Resources.LogoDynasys
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 100)
        Me.Panel3.TabIndex = 17
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(346, 470)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIngresar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel3 As Panel
End Class
