<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Con_Consultorios
    Inherits Modelo.Modelo1

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Con_Consultorios))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbFechaIngr = New DevComponents.DotNetBar.LabelX()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.swEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lbIdUsuario = New DevComponents.DotNetBar.LabelX()
        Me.txtIdConsultorio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpBusquedaUsuarios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGBusqConsultorios = New Janus.Windows.GridEX.GridEX()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gpBusquedaUsuarios.SuspendLayout()
        CType(Me.JGBusqConsultorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpBusquedaUsuarios)
        Me.MpanelSuperior.Controls.Add(Me.Panel2)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(882, 435)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(882, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        '
        'btnGrabar
        '
        '
        'btnNuevo
        '
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 507)
        Me.PanelInferior.Size = New System.Drawing.Size(882, 39)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(682, 0)
        '
        'btnUltimo
        '
        '
        'btnSiguiente
        '
        '
        'btnAnterior
        '
        '
        'btnPrimero
        '
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Enabled = False
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Location = New System.Drawing.Point(637, 146)
        '
        'superTabItem2
        '
        Me.superTabItem2.Visible = False
        '
        'superTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.superTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabControl1.ControlBox.MenuBox.Name = ""
        Me.superTabControl1.ControlBox.Name = ""
        Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
        Me.superTabControl1.Size = New System.Drawing.Size(882, 571)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNro)
        Me.Panel2.Controls.Add(Me.lbFechaIngr)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.swEstado)
        Me.Panel2.Controls.Add(Me.lbEstado)
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Controls.Add(Me.lbIdUsuario)
        Me.Panel2.Controls.Add(Me.txtIdConsultorio)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 153)
        Me.Panel2.TabIndex = 46
        '
        'txtNro
        '
        Me.txtNro.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNro.Border.Class = "TextBoxBorder"
        Me.txtNro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNro.DisabledBackColor = System.Drawing.Color.White
        Me.txtNro.ForeColor = System.Drawing.Color.Black
        Me.txtNro.Location = New System.Drawing.Point(141, 77)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.PreventEnterBeep = True
        Me.txtNro.Size = New System.Drawing.Size(120, 20)
        Me.txtNro.TabIndex = 248
        '
        'lbFechaIngr
        '
        Me.lbFechaIngr.AutoSize = True
        Me.lbFechaIngr.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaIngr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaIngr.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaIngr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaIngr.Location = New System.Drawing.Point(24, 52)
        Me.lbFechaIngr.Name = "lbFechaIngr"
        Me.lbFechaIngr.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaIngr.Size = New System.Drawing.Size(44, 16)
        Me.lbFechaIngr.TabIndex = 247
        Me.lbFechaIngr.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(140, 47)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 22)
        Me.dtpFecha.TabIndex = 5
        Me.dtpFecha.TabStop = False
        '
        'swEstado
        '
        '
        '
        '
        Me.swEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstado.Location = New System.Drawing.Point(140, 110)
        Me.swEstado.Name = "swEstado"
        Me.swEstado.OffBackColor = System.Drawing.Color.Silver
        Me.swEstado.OffText = "PASIVO"
        Me.swEstado.OffTextColor = System.Drawing.Color.White
        Me.swEstado.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.swEstado.OnText = "ACTIVO"
        Me.swEstado.OnTextColor = System.Drawing.Color.White
        Me.swEstado.ReadOnlyMarkerColor = System.Drawing.Color.Crimson
        Me.swEstado.Size = New System.Drawing.Size(121, 22)
        Me.swEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstado.SwitchBackColor = System.Drawing.Color.Gray
        Me.swEstado.TabIndex = 6
        Me.swEstado.Value = True
        Me.swEstado.ValueObject = "Y"
        '
        'lbEstado
        '
        Me.lbEstado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbEstado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbEstado.Location = New System.Drawing.Point(24, 109)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(57, 23)
        Me.lbEstado.TabIndex = 233
        Me.lbEstado.Text = "Estado:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(24, 75)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(110, 23)
        Me.LabelX1.TabIndex = 227
        Me.LabelX1.Text = "Consultorio Nro.:"
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdUsuario.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdUsuario.Location = New System.Drawing.Point(24, 19)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdUsuario.Size = New System.Drawing.Size(105, 23)
        Me.lbIdUsuario.TabIndex = 226
        Me.lbIdUsuario.Text = "Id Consultorio:"
        '
        'txtIdConsultorio
        '
        Me.txtIdConsultorio.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdConsultorio.Border.Class = "TextBoxBorder"
        Me.txtIdConsultorio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdConsultorio.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdConsultorio.Enabled = False
        Me.txtIdConsultorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdConsultorio.ForeColor = System.Drawing.Color.Black
        Me.txtIdConsultorio.Location = New System.Drawing.Point(140, 17)
        Me.txtIdConsultorio.Name = "txtIdConsultorio"
        Me.txtIdConsultorio.PreventEnterBeep = True
        Me.txtIdConsultorio.Size = New System.Drawing.Size(100, 21)
        Me.txtIdConsultorio.TabIndex = 0
        '
        'gpBusquedaUsuarios
        '
        Me.gpBusquedaUsuarios.BackColor = System.Drawing.Color.White
        Me.gpBusquedaUsuarios.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusquedaUsuarios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.gpBusquedaUsuarios.Controls.Add(Me.JGBusqConsultorios)
        Me.gpBusquedaUsuarios.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusquedaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpBusquedaUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusquedaUsuarios.Location = New System.Drawing.Point(0, 153)
        Me.gpBusquedaUsuarios.Name = "gpBusquedaUsuarios"
        Me.gpBusquedaUsuarios.Size = New System.Drawing.Size(882, 282)
        '
        '
        '
        Me.gpBusquedaUsuarios.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusquedaUsuarios.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusquedaUsuarios.Style.BackColorGradientAngle = 90
        Me.gpBusquedaUsuarios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusquedaUsuarios.Style.BorderBottomWidth = 1
        Me.gpBusquedaUsuarios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpBusquedaUsuarios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusquedaUsuarios.Style.BorderLeftWidth = 1
        Me.gpBusquedaUsuarios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusquedaUsuarios.Style.BorderRightWidth = 1
        Me.gpBusquedaUsuarios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusquedaUsuarios.Style.BorderTopWidth = 1
        Me.gpBusquedaUsuarios.Style.CornerDiameter = 4
        Me.gpBusquedaUsuarios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusquedaUsuarios.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusquedaUsuarios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusquedaUsuarios.Style.TextColor = System.Drawing.Color.White
        Me.gpBusquedaUsuarios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusquedaUsuarios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusquedaUsuarios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusquedaUsuarios.TabIndex = 47
        Me.gpBusquedaUsuarios.Text = "B Ú S Q U E D A  D E  C O N S  U L T O R I O S"
        '
        'JGBusqConsultorios
        '
        Me.JGBusqConsultorios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JGBusqConsultorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqConsultorios.FlatBorderColor = System.Drawing.Color.AliceBlue
        Me.JGBusqConsultorios.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGBusqConsultorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGBusqConsultorios.HeaderFormatStyle.Alpha = 0
        Me.JGBusqConsultorios.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGBusqConsultorios.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqConsultorios.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGBusqConsultorios.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqConsultorios.Name = "JGBusqConsultorios"
        Me.JGBusqConsultorios.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGBusqConsultorios.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqConsultorios.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqConsultorios.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqConsultorios.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGBusqConsultorios.Size = New System.Drawing.Size(876, 259)
        Me.JGBusqConsultorios.TabIndex = 0
        Me.JGBusqConsultorios.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_Con_Consultorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 571)
        Me.Name = "F1_Con_Consultorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE CONSULTORIOS"
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gpBusquedaUsuarios.ResumeLayout(False)
        CType(Me.JGBusqConsultorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpBusquedaUsuarios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGBusqConsultorios As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbFechaIngr As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents swEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdConsultorio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNro As DevComponents.DotNetBar.Controls.TextBoxX
End Class
