<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Reg_Emergencia
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtContraseña = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAsignarEmergencia = New DevComponents.DotNetBar.ButtonX()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbVeterinario = New DevComponents.DotNetBar.LabelX()
        Me.txtId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 5, 0, 5)
        Me.Panel1.Size = New System.Drawing.Size(347, 63)
        Me.Panel1.TabIndex = 158
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.FontBold = True
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Location = New System.Drawing.Point(84, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(192, 43)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "PERMISO VETERINARIO"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(12, 108)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(73, 16)
        Me.LabelX6.TabIndex = 160
        Me.LabelX6.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.AcceptsTab = True
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtContraseña.Border.Class = "TextBoxBorder"
        Me.txtContraseña.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContraseña.DisabledBackColor = System.Drawing.Color.White
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Black
        Me.txtContraseña.Location = New System.Drawing.Point(91, 107)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PreventEnterBeep = True
        Me.txtContraseña.Size = New System.Drawing.Size(228, 22)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btnAsignarEmergencia
        '
        Me.btnAsignarEmergencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAsignarEmergencia.BackColor = System.Drawing.Color.White
        Me.btnAsignarEmergencia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAsignarEmergencia.FadeEffect = False
        Me.btnAsignarEmergencia.FocusCuesEnabled = False
        Me.btnAsignarEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarEmergencia.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAsignarEmergencia.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAsignarEmergencia.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAsignarEmergencia.Location = New System.Drawing.Point(69, 139)
        Me.btnAsignarEmergencia.Name = "btnAsignarEmergencia"
        Me.btnAsignarEmergencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAsignarEmergencia.Size = New System.Drawing.Size(101, 40)
        Me.btnAsignarEmergencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAsignarEmergencia.TabIndex = 262
        Me.btnAsignarEmergencia.Text = "Asignar Ficha"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.DisabledBackColor = System.Drawing.Color.White
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(91, 76)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PreventEnterBeep = True
        Me.txtUsuario.Size = New System.Drawing.Size(228, 21)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Tag = ""
        '
        'lbVeterinario
        '
        Me.lbVeterinario.AutoSize = True
        Me.lbVeterinario.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVeterinario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVeterinario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVeterinario.Location = New System.Drawing.Point(12, 78)
        Me.lbVeterinario.Name = "lbVeterinario"
        Me.lbVeterinario.Size = New System.Drawing.Size(69, 16)
        Me.lbVeterinario.TabIndex = 264
        Me.lbVeterinario.Text = "Veterinario:"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtId.Border.Class = "TextBoxBorder"
        Me.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId.DisabledBackColor = System.Drawing.Color.White
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(3, 130)
        Me.txtId.Name = "txtId"
        Me.txtId.PreventEnterBeep = True
        Me.txtId.Size = New System.Drawing.Size(65, 21)
        Me.txtId.TabIndex = 265
        Me.txtId.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnSalir.FadeEffect = False
        Me.btnSalir.FocusCuesEnabled = False
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Presentacion.My.Resources.Resources.cancel
        Me.btnSalir.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(183, 139)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSalir.Size = New System.Drawing.Size(101, 40)
        Me.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnSalir.TabIndex = 266
        Me.btnSalir.Text = "Salir"
        '
        'F_Reg_Emergencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(347, 188)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lbVeterinario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnAsignarEmergencia)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Reg_Emergencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emergencia"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContraseña As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAsignarEmergencia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbVeterinario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
End Class
