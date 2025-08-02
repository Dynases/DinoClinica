<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Fic_Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Fic_Recibo))
        Me.gpRecibo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelDatosR = New System.Windows.Forms.Panel()
        Me.tbPagado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtEstadoVenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAgregarC = New DevComponents.DotNetBar.ButtonX()
        Me.diPrecio = New DevComponents.Editors.DoubleInput()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescripcion = New DevComponents.DotNetBar.LabelX()
        Me.lbPrecio = New DevComponents.DotNetBar.LabelX()
        Me.lbObservacion = New DevComponents.DotNetBar.LabelX()
        Me.txtObservacionR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpFrecibo = New System.Windows.Forms.DateTimePicker()
        Me.lbIdRecibo = New DevComponents.DotNetBar.LabelX()
        Me.lbPropietarioR = New DevComponents.DotNetBar.LabelX()
        Me.lbFRecibo = New DevComponents.DotNetBar.LabelX()
        Me.txtNPropietarioR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPacienteR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbPacienteR = New DevComponents.DotNetBar.LabelX()
        Me.txtIdRecibo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelDatosRecibo = New System.Windows.Forms.Panel()
        Me.PanelDetalleRecibo = New System.Windows.Forms.Panel()
        Me.gpDetalleRecibo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GpPanelServicio = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGServicio = New Janus.Windows.GridEX.GridEX()
        Me.JGDetalleRecibo = New Janus.Windows.GridEX.GridEX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtTotalR = New DevComponents.Editors.DoubleInput()
        Me.lbTotalR = New DevComponents.DotNetBar.LabelX()
        Me.gpBusqRecibos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelBusqRecibos = New System.Windows.Forms.Panel()
        Me.JGBusqRecibos = New Janus.Windows.GridEX.GridEX()
        Me.PanelToolBar2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MpanelBuscador.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpRecibo.SuspendLayout()
        Me.PanelDatosR.SuspendLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosRecibo.SuspendLayout()
        Me.PanelDetalleRecibo.SuspendLayout()
        Me.gpDetalleRecibo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GpPanelServicio.SuspendLayout()
        CType(Me.JGServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGDetalleRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtTotalR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqRecibos.SuspendLayout()
        Me.panelBusqRecibos.SuspendLayout()
        CType(Me.JGBusqRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.PanelDetalleRecibo)
        Me.MpanelSuperior.Controls.Add(Me.PanelDatosRecibo)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(913, 534)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.PanelToolBar2)
        Me.PanelSuperior.Size = New System.Drawing.Size(913, 72)
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
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar2, 0)
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 606)
        Me.PanelInferior.Size = New System.Drawing.Size(913, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(713, 0)
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
        'MpanelBuscador
        '
        Me.MpanelBuscador.Controls.Add(Me.gpBusqRecibos)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(675, 174)
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
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(913, 670)
        '
        'gpRecibo
        '
        Me.gpRecibo.BackColor = System.Drawing.Color.White
        Me.gpRecibo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRecibo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRecibo.Controls.Add(Me.PanelDatosR)
        Me.gpRecibo.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpRecibo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpRecibo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpRecibo.Location = New System.Drawing.Point(0, 0)
        Me.gpRecibo.Name = "gpRecibo"
        Me.gpRecibo.Size = New System.Drawing.Size(913, 190)
        '
        '
        '
        Me.gpRecibo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.gpRecibo.Style.BackColorGradientAngle = 90
        Me.gpRecibo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.gpRecibo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRecibo.Style.BorderBottomWidth = 1
        Me.gpRecibo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpRecibo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRecibo.Style.BorderLeftWidth = 1
        Me.gpRecibo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRecibo.Style.BorderRightWidth = 1
        Me.gpRecibo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRecibo.Style.BorderTopWidth = 1
        Me.gpRecibo.Style.CornerDiameter = 4
        Me.gpRecibo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpRecibo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpRecibo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpRecibo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpRecibo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpRecibo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpRecibo.TabIndex = 300
        Me.gpRecibo.Text = "DATOS RECIBO"
        '
        'PanelDatosR
        '
        Me.PanelDatosR.AutoScroll = True
        Me.PanelDatosR.Controls.Add(Me.tbPagado)
        Me.PanelDatosR.Controls.Add(Me.LabelX1)
        Me.PanelDatosR.Controls.Add(Me.txtEstadoVenta)
        Me.PanelDatosR.Controls.Add(Me.btnAgregarC)
        Me.PanelDatosR.Controls.Add(Me.diPrecio)
        Me.PanelDatosR.Controls.Add(Me.txtDescripcion)
        Me.PanelDatosR.Controls.Add(Me.lbDescripcion)
        Me.PanelDatosR.Controls.Add(Me.lbPrecio)
        Me.PanelDatosR.Controls.Add(Me.lbObservacion)
        Me.PanelDatosR.Controls.Add(Me.txtObservacionR)
        Me.PanelDatosR.Controls.Add(Me.dtpFrecibo)
        Me.PanelDatosR.Controls.Add(Me.lbIdRecibo)
        Me.PanelDatosR.Controls.Add(Me.lbPropietarioR)
        Me.PanelDatosR.Controls.Add(Me.lbFRecibo)
        Me.PanelDatosR.Controls.Add(Me.txtNPropietarioR)
        Me.PanelDatosR.Controls.Add(Me.txtPacienteR)
        Me.PanelDatosR.Controls.Add(Me.lbPacienteR)
        Me.PanelDatosR.Controls.Add(Me.txtIdRecibo)
        Me.PanelDatosR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatosR.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatosR.Name = "PanelDatosR"
        Me.PanelDatosR.Size = New System.Drawing.Size(907, 167)
        Me.PanelDatosR.TabIndex = 234
        '
        'tbPagado
        '
        Me.tbPagado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbPagado.Border.Class = "TextBoxBorder"
        Me.tbPagado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPagado.DisabledBackColor = System.Drawing.Color.White
        Me.tbPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPagado.ForeColor = System.Drawing.Color.Black
        Me.tbPagado.Location = New System.Drawing.Point(547, 9)
        Me.tbPagado.MaxLength = 200
        Me.tbPagado.Multiline = True
        Me.tbPagado.Name = "tbPagado"
        Me.tbPagado.PreventEnterBeep = True
        Me.tbPagado.Size = New System.Drawing.Size(300, 22)
        Me.tbPagado.TabIndex = 269
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
        Me.LabelX1.Location = New System.Drawing.Point(451, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(86, 21)
        Me.LabelX1.TabIndex = 270
        Me.LabelX1.Text = "Pagado Por:"
        '
        'txtEstadoVenta
        '
        Me.txtEstadoVenta.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEstadoVenta.Border.Class = "TextBoxBorder"
        Me.txtEstadoVenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEstadoVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtEstadoVenta.Enabled = False
        Me.txtEstadoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoVenta.ForeColor = System.Drawing.Color.Black
        Me.txtEstadoVenta.Location = New System.Drawing.Point(453, 127)
        Me.txtEstadoVenta.Name = "txtEstadoVenta"
        Me.txtEstadoVenta.PreventEnterBeep = True
        Me.txtEstadoVenta.Size = New System.Drawing.Size(60, 22)
        Me.txtEstadoVenta.TabIndex = 268
        Me.txtEstadoVenta.Visible = False
        '
        'btnAgregarC
        '
        Me.btnAgregarC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarC.BackColor = System.Drawing.Color.White
        Me.btnAgregarC.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarC.FadeEffect = False
        Me.btnAgregarC.FocusCuesEnabled = False
        Me.btnAgregarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarC.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAgregarC.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarC.Location = New System.Drawing.Point(547, 127)
        Me.btnAgregarC.Name = "btnAgregarC"
        Me.btnAgregarC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarC.Size = New System.Drawing.Size(110, 39)
        Me.btnAgregarC.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarC.SymbolSize = 5.0!
        Me.btnAgregarC.TabIndex = 267
        Me.btnAgregarC.Text = "Agregar"
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
        Me.diPrecio.Location = New System.Drawing.Point(547, 92)
        Me.diPrecio.LockUpdateChecked = False
        Me.diPrecio.MinValue = 0R
        Me.diPrecio.Name = "diPrecio"
        Me.diPrecio.Size = New System.Drawing.Size(110, 21)
        Me.diPrecio.TabIndex = 264
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
        Me.txtDescripcion.Location = New System.Drawing.Point(547, 40)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PreventEnterBeep = True
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 35)
        Me.txtDescripcion.TabIndex = 263
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
        Me.lbDescripcion.Location = New System.Drawing.Point(451, 41)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescripcion.Size = New System.Drawing.Size(86, 22)
        Me.lbDescripcion.TabIndex = 266
        Me.lbDescripcion.Text = "Descripción:"
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
        Me.lbPrecio.Location = New System.Drawing.Point(451, 93)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPrecio.Size = New System.Drawing.Size(77, 19)
        Me.lbPrecio.TabIndex = 265
        Me.lbPrecio.Text = "Precio Bs.:"
        '
        'lbObservacion
        '
        Me.lbObservacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbObservacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbObservacion.Location = New System.Drawing.Point(37, 94)
        Me.lbObservacion.Name = "lbObservacion"
        Me.lbObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbObservacion.Size = New System.Drawing.Size(87, 23)
        Me.lbObservacion.TabIndex = 262
        Me.lbObservacion.Text = "Observación:"
        '
        'txtObservacionR
        '
        Me.txtObservacionR.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObservacionR.Border.Class = "TextBoxBorder"
        Me.txtObservacionR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacionR.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservacionR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionR.ForeColor = System.Drawing.Color.Black
        Me.txtObservacionR.Location = New System.Drawing.Point(139, 93)
        Me.txtObservacionR.Multiline = True
        Me.txtObservacionR.Name = "txtObservacionR"
        Me.txtObservacionR.PreventEnterBeep = True
        Me.txtObservacionR.Size = New System.Drawing.Size(280, 40)
        Me.txtObservacionR.TabIndex = 261
        '
        'dtpFrecibo
        '
        Me.dtpFrecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrecibo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrecibo.Location = New System.Drawing.Point(139, 39)
        Me.dtpFrecibo.Name = "dtpFrecibo"
        Me.dtpFrecibo.Size = New System.Drawing.Size(122, 22)
        Me.dtpFrecibo.TabIndex = 260
        Me.dtpFrecibo.TabStop = False
        '
        'lbIdRecibo
        '
        Me.lbIdRecibo.AutoSize = True
        Me.lbIdRecibo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdRecibo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdRecibo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdRecibo.Location = New System.Drawing.Point(37, 15)
        Me.lbIdRecibo.Name = "lbIdRecibo"
        Me.lbIdRecibo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdRecibo.Size = New System.Drawing.Size(66, 16)
        Me.lbIdRecibo.TabIndex = 224
        Me.lbIdRecibo.Text = "Id Recibo:"
        '
        'lbPropietarioR
        '
        Me.lbPropietarioR.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPropietarioR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPropietarioR.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPropietarioR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPropietarioR.Location = New System.Drawing.Point(37, 67)
        Me.lbPropietarioR.Name = "lbPropietarioR"
        Me.lbPropietarioR.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPropietarioR.Size = New System.Drawing.Size(78, 23)
        Me.lbPropietarioR.TabIndex = 227
        Me.lbPropietarioR.Text = "Paciente:"
        '
        'lbFRecibo
        '
        Me.lbFRecibo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFRecibo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFRecibo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFRecibo.Location = New System.Drawing.Point(37, 38)
        Me.lbFRecibo.Name = "lbFRecibo"
        Me.lbFRecibo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFRecibo.Size = New System.Drawing.Size(90, 23)
        Me.lbFRecibo.TabIndex = 226
        Me.lbFRecibo.Text = "Fecha Recibo:"
        '
        'txtNPropietarioR
        '
        Me.txtNPropietarioR.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNPropietarioR.Border.Class = "TextBoxBorder"
        Me.txtNPropietarioR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNPropietarioR.DisabledBackColor = System.Drawing.Color.White
        Me.txtNPropietarioR.Enabled = False
        Me.txtNPropietarioR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPropietarioR.ForeColor = System.Drawing.Color.Black
        Me.txtNPropietarioR.Location = New System.Drawing.Point(139, 67)
        Me.txtNPropietarioR.Name = "txtNPropietarioR"
        Me.txtNPropietarioR.PreventEnterBeep = True
        Me.txtNPropietarioR.Size = New System.Drawing.Size(280, 22)
        Me.txtNPropietarioR.TabIndex = 1
        '
        'txtPacienteR
        '
        Me.txtPacienteR.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPacienteR.Border.Class = "TextBoxBorder"
        Me.txtPacienteR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPacienteR.DisabledBackColor = System.Drawing.Color.White
        Me.txtPacienteR.Enabled = False
        Me.txtPacienteR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacienteR.ForeColor = System.Drawing.Color.Black
        Me.txtPacienteR.Location = New System.Drawing.Point(139, 139)
        Me.txtPacienteR.Name = "txtPacienteR"
        Me.txtPacienteR.PreventEnterBeep = True
        Me.txtPacienteR.Size = New System.Drawing.Size(280, 22)
        Me.txtPacienteR.TabIndex = 2
        Me.txtPacienteR.Visible = False
        '
        'lbPacienteR
        '
        Me.lbPacienteR.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPacienteR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPacienteR.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPacienteR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPacienteR.Location = New System.Drawing.Point(40, 138)
        Me.lbPacienteR.Name = "lbPacienteR"
        Me.lbPacienteR.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPacienteR.Size = New System.Drawing.Size(64, 23)
        Me.lbPacienteR.TabIndex = 225
        Me.lbPacienteR.Text = "Paciente:"
        Me.lbPacienteR.Visible = False
        '
        'txtIdRecibo
        '
        Me.txtIdRecibo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdRecibo.Border.Class = "TextBoxBorder"
        Me.txtIdRecibo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdRecibo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdRecibo.Enabled = False
        Me.txtIdRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRecibo.ForeColor = System.Drawing.Color.Black
        Me.txtIdRecibo.Location = New System.Drawing.Point(139, 11)
        Me.txtIdRecibo.Name = "txtIdRecibo"
        Me.txtIdRecibo.PreventEnterBeep = True
        Me.txtIdRecibo.Size = New System.Drawing.Size(63, 22)
        Me.txtIdRecibo.TabIndex = 0
        '
        'PanelDatosRecibo
        '
        Me.PanelDatosRecibo.Controls.Add(Me.gpRecibo)
        Me.PanelDatosRecibo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDatosRecibo.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatosRecibo.Name = "PanelDatosRecibo"
        Me.PanelDatosRecibo.Size = New System.Drawing.Size(913, 190)
        Me.PanelDatosRecibo.TabIndex = 301
        '
        'PanelDetalleRecibo
        '
        Me.PanelDetalleRecibo.Controls.Add(Me.gpDetalleRecibo)
        Me.PanelDetalleRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalleRecibo.Location = New System.Drawing.Point(0, 190)
        Me.PanelDetalleRecibo.Name = "PanelDetalleRecibo"
        Me.PanelDetalleRecibo.Size = New System.Drawing.Size(913, 344)
        Me.PanelDetalleRecibo.TabIndex = 302
        '
        'gpDetalleRecibo
        '
        Me.gpDetalleRecibo.BackColor = System.Drawing.Color.White
        Me.gpDetalleRecibo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDetalleRecibo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDetalleRecibo.Controls.Add(Me.Panel2)
        Me.gpDetalleRecibo.Controls.Add(Me.Panel3)
        Me.gpDetalleRecibo.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDetalleRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDetalleRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleRecibo.Location = New System.Drawing.Point(0, 0)
        Me.gpDetalleRecibo.Name = "gpDetalleRecibo"
        Me.gpDetalleRecibo.Size = New System.Drawing.Size(913, 344)
        '
        '
        '
        Me.gpDetalleRecibo.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleRecibo.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleRecibo.Style.BackColorGradientAngle = 90
        Me.gpDetalleRecibo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleRecibo.Style.BorderBottomWidth = 1
        Me.gpDetalleRecibo.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleRecibo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleRecibo.Style.BorderLeftWidth = 1
        Me.gpDetalleRecibo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleRecibo.Style.BorderRightWidth = 1
        Me.gpDetalleRecibo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleRecibo.Style.BorderTopWidth = 1
        Me.gpDetalleRecibo.Style.CornerDiameter = 4
        Me.gpDetalleRecibo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDetalleRecibo.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleRecibo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDetalleRecibo.Style.TextColor = System.Drawing.Color.White
        Me.gpDetalleRecibo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDetalleRecibo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDetalleRecibo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDetalleRecibo.TabIndex = 110
        Me.gpDetalleRecibo.Text = "DETALLE  RECIBO"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GpPanelServicio)
        Me.Panel2.Controls.Add(Me.JGDetalleRecibo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 281)
        Me.Panel2.TabIndex = 261
        '
        'GpPanelServicio
        '
        Me.GpPanelServicio.BackColor = System.Drawing.Color.White
        Me.GpPanelServicio.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpPanelServicio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpPanelServicio.Controls.Add(Me.JGServicio)
        Me.GpPanelServicio.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpPanelServicio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpPanelServicio.Location = New System.Drawing.Point(15, 79)
        Me.GpPanelServicio.Name = "GpPanelServicio"
        Me.GpPanelServicio.Padding = New System.Windows.Forms.Padding(5)
        Me.GpPanelServicio.Size = New System.Drawing.Size(882, 114)
        '
        '
        '
        Me.GpPanelServicio.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GpPanelServicio.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GpPanelServicio.Style.BackColorGradientAngle = 90
        Me.GpPanelServicio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpPanelServicio.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GpPanelServicio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpPanelServicio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpPanelServicio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpPanelServicio.Style.CornerDiameter = 0
        Me.GpPanelServicio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpPanelServicio.Style.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpPanelServicio.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpPanelServicio.Style.TextColor = System.Drawing.Color.White
        Me.GpPanelServicio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpPanelServicio.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpPanelServicio.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpPanelServicio.TabIndex = 260
        Me.GpPanelServicio.Text = "S E R V I C I O"
        Me.GpPanelServicio.Visible = False
        '
        'JGServicio
        '
        Me.JGServicio.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGServicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGServicio.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGServicio.Location = New System.Drawing.Point(5, 5)
        Me.JGServicio.Name = "JGServicio"
        Me.JGServicio.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGServicio.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGServicio.Size = New System.Drawing.Size(872, 88)
        Me.JGServicio.TabIndex = 0
        Me.JGServicio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'JGDetalleRecibo
        '
        Me.JGDetalleRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGDetalleRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGDetalleRecibo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGDetalleRecibo.Location = New System.Drawing.Point(0, 0)
        Me.JGDetalleRecibo.Name = "JGDetalleRecibo"
        Me.JGDetalleRecibo.Size = New System.Drawing.Size(907, 281)
        Me.JGDetalleRecibo.TabIndex = 257
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 281)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(907, 40)
        Me.Panel3.TabIndex = 261
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtTotalR)
        Me.Panel4.Controls.Add(Me.lbTotalR)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(707, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 40)
        Me.Panel4.TabIndex = 260
        '
        'txtTotalR
        '
        '
        '
        '
        Me.txtTotalR.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotalR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalR.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalR.Increment = 1.0R
        Me.txtTotalR.Location = New System.Drawing.Point(76, 11)
        Me.txtTotalR.MinValue = 0R
        Me.txtTotalR.Name = "txtTotalR"
        Me.txtTotalR.Size = New System.Drawing.Size(119, 21)
        Me.txtTotalR.TabIndex = 3
        Me.txtTotalR.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbTotalR
        '
        Me.lbTotalR.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTotalR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTotalR.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalR.ForeColor = System.Drawing.Color.White
        Me.lbTotalR.Location = New System.Drawing.Point(25, 11)
        Me.lbTotalR.Name = "lbTotalR"
        Me.lbTotalR.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTotalR.Size = New System.Drawing.Size(41, 18)
        Me.lbTotalR.TabIndex = 259
        Me.lbTotalR.Text = "Total:"
        '
        'gpBusqRecibos
        '
        Me.gpBusqRecibos.BackColor = System.Drawing.Color.White
        Me.gpBusqRecibos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqRecibos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqRecibos.Controls.Add(Me.panelBusqRecibos)
        Me.gpBusqRecibos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpBusqRecibos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqRecibos.Location = New System.Drawing.Point(0, 0)
        Me.gpBusqRecibos.Name = "gpBusqRecibos"
        Me.gpBusqRecibos.Size = New System.Drawing.Size(930, 477)
        '
        '
        '
        Me.gpBusqRecibos.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BackColorGradientAngle = 90
        Me.gpBusqRecibos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderBottomWidth = 1
        Me.gpBusqRecibos.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderLeftWidth = 1
        Me.gpBusqRecibos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderRightWidth = 1
        Me.gpBusqRecibos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderTopWidth = 1
        Me.gpBusqRecibos.Style.CornerDiameter = 4
        Me.gpBusqRecibos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusqRecibos.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqRecibos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusqRecibos.Style.TextColor = System.Drawing.Color.White
        Me.gpBusqRecibos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusqRecibos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusqRecibos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusqRecibos.TabIndex = 5
        Me.gpBusqRecibos.Text = "BUSCADOR  RECIBOS"
        '
        'panelBusqRecibos
        '
        Me.panelBusqRecibos.BackColor = System.Drawing.Color.White
        Me.panelBusqRecibos.Controls.Add(Me.JGBusqRecibos)
        Me.panelBusqRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBusqRecibos.Location = New System.Drawing.Point(0, 0)
        Me.panelBusqRecibos.Name = "panelBusqRecibos"
        Me.panelBusqRecibos.Size = New System.Drawing.Size(924, 454)
        Me.panelBusqRecibos.TabIndex = 0
        '
        'JGBusqRecibos
        '
        Me.JGBusqRecibos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGBusqRecibos.BackColor = System.Drawing.Color.GhostWhite
        Me.JGBusqRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqRecibos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGBusqRecibos.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGBusqRecibos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGBusqRecibos.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGBusqRecibos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibos.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGBusqRecibos.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqRecibos.Name = "JGBusqRecibos"
        Me.JGBusqRecibos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGBusqRecibos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibos.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibos.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibos.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGBusqRecibos.SelectOnExpand = False
        Me.JGBusqRecibos.Size = New System.Drawing.Size(924, 454)
        Me.JGBusqRecibos.TabIndex = 0
        Me.JGBusqRecibos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Controls.Add(Me.btnImprimir)
        Me.PanelToolBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelToolBar2.Location = New System.Drawing.Point(833, 0)
        Me.PanelToolBar2.Name = "PanelToolBar2"
        Me.PanelToolBar2.Size = New System.Drawing.Size(80, 72)
        Me.PanelToolBar2.TabIndex = 8
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Presentacion.My.Resources.Resources.printee1
        Me.btnImprimir.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 72)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.TextColor = System.Drawing.Color.White
        Me.btnImprimir.Visible = False
        '
        'F1_Fic_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(913, 670)
        Me.Name = "F1_Fic_Recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBOS"
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MpanelBuscador.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpRecibo.ResumeLayout(False)
        Me.PanelDatosR.ResumeLayout(False)
        Me.PanelDatosR.PerformLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosRecibo.ResumeLayout(False)
        Me.PanelDetalleRecibo.ResumeLayout(False)
        Me.gpDetalleRecibo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GpPanelServicio.ResumeLayout(False)
        CType(Me.JGServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGDetalleRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtTotalR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqRecibos.ResumeLayout(False)
        Me.panelBusqRecibos.ResumeLayout(False)
        CType(Me.JGBusqRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpRecibo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelDatosR As Panel
    Friend WithEvents lbIdRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbPropietarioR As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbFRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNPropietarioR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPacienteR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbPacienteR As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdRecibo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelDetalleRecibo As Panel
    Friend WithEvents PanelDatosRecibo As Panel
    Friend WithEvents JGDetalleRecibo As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpFrecibo As DateTimePicker
    Friend WithEvents gpBusqRecibos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqRecibos As Panel
    Friend WithEvents JGBusqRecibos As Janus.Windows.GridEX.GridEX
    Friend WithEvents lbObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObservacionR As DevComponents.DotNetBar.Controls.TextBoxX
    Protected WithEvents PanelToolBar2 As Panel
    Protected WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpDetalleRecibo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnAgregarC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents diPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDescripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbPrecio As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GpPanelServicio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGServicio As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotalR As DevComponents.Editors.DoubleInput
    Friend WithEvents lbTotalR As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtEstadoVenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbPagado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
