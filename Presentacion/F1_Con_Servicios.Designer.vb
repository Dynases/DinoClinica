<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Con_Servicios
    Inherits Modelo.Modelo2

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Con_Servicios))
        Me.gpDatosGral = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.swEstadoS = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.diPrecio = New DevComponents.Editors.DoubleInput()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescripcion = New DevComponents.DotNetBar.LabelX()
        Me.lbIdServicio = New DevComponents.DotNetBar.LabelX()
        Me.lbPrecio = New DevComponents.DotNetBar.LabelX()
        Me.txtIdServicio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpServicios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGServicios = New Janus.Windows.GridEX.GridEX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatosGral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpServicios.SuspendLayout()
        CType(Me.JGServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.superTabControl1.Size = New System.Drawing.Size(846, 626)
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpServicios)
        Me.MpanelSuperior.Controls.Add(Me.Panel3)
        Me.MpanelSuperior.Size = New System.Drawing.Size(846, 490)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.Panel3, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.gpServicios, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(846, 72)
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
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 562)
        Me.PanelInferior.Size = New System.Drawing.Size(846, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(646, 0)
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
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Enabled = False
        Me.TxtNombreUsu.Text = "DEFAULT"
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
        'superTabItem2
        '
        Me.superTabItem2.Visible = False
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Location = New System.Drawing.Point(416, 21)
        '
        'gpDatosGral
        '
        Me.gpDatosGral.BackColor = System.Drawing.Color.White
        Me.gpDatosGral.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosGral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosGral.Controls.Add(Me.Panel2)
        Me.gpDatosGral.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDatosGral.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosGral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpDatosGral.Location = New System.Drawing.Point(0, 0)
        Me.gpDatosGral.Name = "gpDatosGral"
        Me.gpDatosGral.Size = New System.Drawing.Size(846, 167)
        '
        '
        '
        Me.gpDatosGral.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.gpDatosGral.Style.BackColorGradientAngle = 90
        Me.gpDatosGral.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.gpDatosGral.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosGral.Style.BorderBottomWidth = 1
        Me.gpDatosGral.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosGral.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosGral.Style.BorderLeftWidth = 1
        Me.gpDatosGral.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosGral.Style.BorderRightWidth = 1
        Me.gpDatosGral.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosGral.Style.BorderTopWidth = 1
        Me.gpDatosGral.Style.CornerDiameter = 4
        Me.gpDatosGral.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosGral.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosGral.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosGral.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatosGral.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosGral.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosGral.TabIndex = 262
        Me.gpDatosGral.Text = "DATOS SERVICIOS"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.swEstadoS)
        Me.Panel2.Controls.Add(Me.lbEstado)
        Me.Panel2.Controls.Add(Me.diPrecio)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.lbDescripcion)
        Me.Panel2.Controls.Add(Me.lbIdServicio)
        Me.Panel2.Controls.Add(Me.lbPrecio)
        Me.Panel2.Controls.Add(Me.txtIdServicio)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 144)
        Me.Panel2.TabIndex = 234
        '
        'swEstadoS
        '
        Me.swEstadoS.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.swEstadoS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoS.Location = New System.Drawing.Point(138, 98)
        Me.swEstadoS.Name = "swEstadoS"
        Me.swEstadoS.OffBackColor = System.Drawing.Color.Gray
        Me.swEstadoS.OffText = "INACTIVO"
        Me.swEstadoS.OffTextColor = System.Drawing.Color.White
        Me.swEstadoS.OnBackColor = System.Drawing.Color.Green
        Me.swEstadoS.OnText = "ACTIVO"
        Me.swEstadoS.OnTextColor = System.Drawing.Color.White
        Me.swEstadoS.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoS.SwitchBackColor = System.Drawing.Color.Gainsboro
        Me.swEstadoS.SwitchBorderColor = System.Drawing.Color.Black
        Me.swEstadoS.TabIndex = 330
        Me.swEstadoS.Value = True
        Me.swEstadoS.ValueObject = "Y"
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
        Me.lbEstado.Location = New System.Drawing.Point(18, 97)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(79, 23)
        Me.lbEstado.TabIndex = 331
        Me.lbEstado.Text = "Estado:"
        '
        'diPrecio
        '
        '
        '
        '
        Me.diPrecio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.diPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.diPrecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.diPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diPrecio.Increment = 1.0R
        Me.diPrecio.Location = New System.Drawing.Point(138, 70)
        Me.diPrecio.LockUpdateChecked = False
        Me.diPrecio.MinValue = 0R
        Me.diPrecio.Name = "diPrecio"
        Me.diPrecio.Size = New System.Drawing.Size(89, 21)
        Me.diPrecio.TabIndex = 1
        Me.diPrecio.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDescripcion.Border.Class = "TextBoxBorder"
        Me.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 40)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PreventEnterBeep = True
        Me.txtDescripcion.Size = New System.Drawing.Size(248, 24)
        Me.txtDescripcion.TabIndex = 0
        '
        'lbDescripcion
        '
        Me.lbDescripcion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDescripcion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDescripcion.Location = New System.Drawing.Point(18, 39)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescripcion.Size = New System.Drawing.Size(81, 23)
        Me.lbDescripcion.TabIndex = 249
        Me.lbDescripcion.Text = "Descripción:"
        '
        'lbIdServicio
        '
        Me.lbIdServicio.AutoSize = True
        Me.lbIdServicio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdServicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdServicio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdServicio.Location = New System.Drawing.Point(18, 14)
        Me.lbIdServicio.Name = "lbIdServicio"
        Me.lbIdServicio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdServicio.Size = New System.Drawing.Size(73, 16)
        Me.lbIdServicio.TabIndex = 224
        Me.lbIdServicio.Text = "Id Servicio:"
        '
        'lbPrecio
        '
        Me.lbPrecio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPrecio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPrecio.Location = New System.Drawing.Point(18, 68)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPrecio.Size = New System.Drawing.Size(66, 23)
        Me.lbPrecio.TabIndex = 226
        Me.lbPrecio.Text = "Precio:"
        '
        'txtIdServicio
        '
        Me.txtIdServicio.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdServicio.Border.Class = "TextBoxBorder"
        Me.txtIdServicio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdServicio.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdServicio.Enabled = False
        Me.txtIdServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdServicio.ForeColor = System.Drawing.Color.Black
        Me.txtIdServicio.Location = New System.Drawing.Point(138, 12)
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.PreventEnterBeep = True
        Me.txtIdServicio.Size = New System.Drawing.Size(70, 22)
        Me.txtIdServicio.TabIndex = 100
        '
        'gpServicios
        '
        Me.gpServicios.BackColor = System.Drawing.Color.White
        Me.gpServicios.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpServicios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpServicios.Controls.Add(Me.JGServicios)
        Me.gpServicios.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpServicios.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpServicios.Location = New System.Drawing.Point(0, 167)
        Me.gpServicios.Name = "gpServicios"
        Me.gpServicios.Size = New System.Drawing.Size(846, 323)
        '
        '
        '
        Me.gpServicios.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpServicios.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpServicios.Style.BackColorGradientAngle = 90
        Me.gpServicios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpServicios.Style.BorderBottomWidth = 1
        Me.gpServicios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpServicios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpServicios.Style.BorderLeftWidth = 1
        Me.gpServicios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpServicios.Style.BorderRightWidth = 1
        Me.gpServicios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpServicios.Style.BorderTopWidth = 1
        Me.gpServicios.Style.CornerDiameter = 4
        Me.gpServicios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpServicios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpServicios.Style.TextColor = System.Drawing.Color.White
        '
        '
        '
        Me.gpServicios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpServicios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpServicios.TabIndex = 386
        Me.gpServicios.Text = "S E R V I C I O S"
        '
        'JGServicios
        '
        Me.JGServicios.BackColor = System.Drawing.Color.GhostWhite
        Me.JGServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGServicios.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGServicios.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGServicios.Location = New System.Drawing.Point(0, 0)
        Me.JGServicios.Name = "JGServicios"
        Me.JGServicios.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGServicios.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGServicios.Size = New System.Drawing.Size(840, 300)
        Me.JGServicios.TabIndex = 0
        Me.JGServicios.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gpDatosGral)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(846, 167)
        Me.Panel3.TabIndex = 235
        '
        'F1_Con_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 626)
        Me.Name = "F1_Con_Servicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE SERVICIOS"
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatosGral.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpServicios.ResumeLayout(False)
        CType(Me.JGServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpDatosGral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDescripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdServicio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbPrecio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdServicio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpServicios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGServicios As Janus.Windows.GridEX.GridEX
    Friend WithEvents diPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents swEstadoS As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel3 As Panel
End Class
