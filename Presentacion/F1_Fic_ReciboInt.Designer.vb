<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Fic_ReciboInt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Fic_ReciboInt))
        Me.gpDatosGral = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtObservacionI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtObservacion = New DevComponents.DotNetBar.LabelX()
        Me.txtTratamiento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbTratamiento = New DevComponents.DotNetBar.LabelX()
        Me.lbFechaI = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaRI = New System.Windows.Forms.DateTimePicker()
        Me.lbPaciente = New DevComponents.DotNetBar.LabelX()
        Me.txtPacienteI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbPropietario = New DevComponents.DotNetBar.LabelX()
        Me.txtPropietarioI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAgregarI = New DevComponents.DotNetBar.ButtonX()
        Me.diPrecio = New DevComponents.Editors.DoubleInput()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescripcion = New DevComponents.DotNetBar.LabelX()
        Me.lbIdReciboI = New DevComponents.DotNetBar.LabelX()
        Me.lbPrecio = New DevComponents.DotNetBar.LabelX()
        Me.txtIdReciboI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTotalR = New DevComponents.Editors.DoubleInput()
        Me.lbTotalR = New DevComponents.DotNetBar.LabelX()
        Me.gpReciboInt = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelServicios = New System.Windows.Forms.Panel()
        Me.JGDetalleReciboInt = New Janus.Windows.GridEX.GridEX()
        Me.gpBusqRecibos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelBusqRecibos = New System.Windows.Forms.Panel()
        Me.JGBusqRecibosI = New Janus.Windows.GridEX.GridEX()
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
        Me.gpDatosGral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpReciboInt.SuspendLayout()
        Me.panelServicios.SuspendLayout()
        CType(Me.JGDetalleReciboInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqRecibos.SuspendLayout()
        Me.panelBusqRecibos.SuspendLayout()
        CType(Me.JGBusqRecibosI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.BackColor = System.Drawing.Color.DodgerBlue
        Me.MpanelSuperior.Controls.Add(Me.gpReciboInt)
        Me.MpanelSuperior.Controls.Add(Me.gpDatosGral)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(984, 437)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(984, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 509)
        Me.PanelInferior.Size = New System.Drawing.Size(984, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(784, 0)
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
        Me.MpanelBuscador.Size = New System.Drawing.Size(984, 548)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(253, 231)
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
        Me.superTabControl1.Size = New System.Drawing.Size(984, 573)
        '
        'gpDatosGral
        '
        Me.gpDatosGral.BackColor = System.Drawing.Color.Transparent
        Me.gpDatosGral.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosGral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosGral.Controls.Add(Me.Panel2)
        Me.gpDatosGral.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosGral.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpDatosGral.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosGral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpDatosGral.Location = New System.Drawing.Point(0, 0)
        Me.gpDatosGral.Name = "gpDatosGral"
        Me.gpDatosGral.Size = New System.Drawing.Size(984, 174)
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
        Me.gpDatosGral.TabIndex = 263
        Me.gpDatosGral.Text = "DATOS RECIBO INTERNACIÓN"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.txtObservacionI)
        Me.Panel2.Controls.Add(Me.txtObservacion)
        Me.Panel2.Controls.Add(Me.txtTratamiento)
        Me.Panel2.Controls.Add(Me.lbTratamiento)
        Me.Panel2.Controls.Add(Me.lbFechaI)
        Me.Panel2.Controls.Add(Me.dtpFechaRI)
        Me.Panel2.Controls.Add(Me.lbPaciente)
        Me.Panel2.Controls.Add(Me.txtPacienteI)
        Me.Panel2.Controls.Add(Me.lbPropietario)
        Me.Panel2.Controls.Add(Me.txtPropietarioI)
        Me.Panel2.Controls.Add(Me.btnAgregarI)
        Me.Panel2.Controls.Add(Me.diPrecio)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.lbDescripcion)
        Me.Panel2.Controls.Add(Me.lbIdReciboI)
        Me.Panel2.Controls.Add(Me.lbPrecio)
        Me.Panel2.Controls.Add(Me.txtIdReciboI)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 151)
        Me.Panel2.TabIndex = 234
        '
        'txtObservacionI
        '
        Me.txtObservacionI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObservacionI.Border.Class = "TextBoxBorder"
        Me.txtObservacionI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacionI.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservacionI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionI.ForeColor = System.Drawing.Color.Black
        Me.txtObservacionI.Location = New System.Drawing.Point(570, 40)
        Me.txtObservacionI.Multiline = True
        Me.txtObservacionI.Name = "txtObservacionI"
        Me.txtObservacionI.PreventEnterBeep = True
        Me.txtObservacionI.Size = New System.Drawing.Size(253, 24)
        Me.txtObservacionI.TabIndex = 2
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.txtObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtObservacion.Location = New System.Drawing.Point(458, 40)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.txtObservacion.Size = New System.Drawing.Size(93, 23)
        Me.txtObservacion.TabIndex = 349
        Me.txtObservacion.Text = "Observación:"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTratamiento.Border.Class = "TextBoxBorder"
        Me.txtTratamiento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTratamiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTratamiento.ForeColor = System.Drawing.Color.Black
        Me.txtTratamiento.Location = New System.Drawing.Point(570, 11)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.PreventEnterBeep = True
        Me.txtTratamiento.Size = New System.Drawing.Size(253, 24)
        Me.txtTratamiento.TabIndex = 1
        '
        'lbTratamiento
        '
        Me.lbTratamiento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTratamiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTratamiento.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTratamiento.Location = New System.Drawing.Point(458, 11)
        Me.lbTratamiento.Name = "lbTratamiento"
        Me.lbTratamiento.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTratamiento.Size = New System.Drawing.Size(106, 23)
        Me.lbTratamiento.TabIndex = 347
        Me.lbTratamiento.Text = "Tratamiento(*):"
        '
        'lbFechaI
        '
        Me.lbFechaI.AutoSize = True
        Me.lbFechaI.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaI.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaI.Location = New System.Drawing.Point(17, 107)
        Me.lbFechaI.Name = "lbFechaI"
        Me.lbFechaI.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaI.Size = New System.Drawing.Size(44, 16)
        Me.lbFechaI.TabIndex = 344
        Me.lbFechaI.Text = "Fecha:"
        '
        'dtpFechaRI
        '
        Me.dtpFechaRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRI.Location = New System.Drawing.Point(123, 102)
        Me.dtpFechaRI.Name = "dtpFechaRI"
        Me.dtpFechaRI.Size = New System.Drawing.Size(110, 22)
        Me.dtpFechaRI.TabIndex = 345
        Me.dtpFechaRI.TabStop = False
        '
        'lbPaciente
        '
        Me.lbPaciente.AutoSize = True
        Me.lbPaciente.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPaciente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPaciente.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPaciente.Location = New System.Drawing.Point(17, 76)
        Me.lbPaciente.Name = "lbPaciente"
        Me.lbPaciente.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPaciente.Size = New System.Drawing.Size(60, 16)
        Me.lbPaciente.TabIndex = 266
        Me.lbPaciente.Text = "Paciente:"
        '
        'txtPacienteI
        '
        Me.txtPacienteI.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtPacienteI.Border.Class = "TextBoxBorder"
        Me.txtPacienteI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPacienteI.DisabledBackColor = System.Drawing.Color.White
        Me.txtPacienteI.Enabled = False
        Me.txtPacienteI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacienteI.ForeColor = System.Drawing.Color.Black
        Me.txtPacienteI.Location = New System.Drawing.Point(123, 74)
        Me.txtPacienteI.Name = "txtPacienteI"
        Me.txtPacienteI.PreventEnterBeep = True
        Me.txtPacienteI.Size = New System.Drawing.Size(232, 22)
        Me.txtPacienteI.TabIndex = 265
        '
        'lbPropietario
        '
        Me.lbPropietario.AutoSize = True
        Me.lbPropietario.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPropietario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPropietario.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPropietario.Location = New System.Drawing.Point(17, 45)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPropietario.Size = New System.Drawing.Size(78, 16)
        Me.lbPropietario.TabIndex = 264
        Me.lbPropietario.Text = "Propietario:"
        '
        'txtPropietarioI
        '
        Me.txtPropietarioI.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtPropietarioI.Border.Class = "TextBoxBorder"
        Me.txtPropietarioI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPropietarioI.DisabledBackColor = System.Drawing.Color.White
        Me.txtPropietarioI.Enabled = False
        Me.txtPropietarioI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioI.ForeColor = System.Drawing.Color.Black
        Me.txtPropietarioI.Location = New System.Drawing.Point(123, 43)
        Me.txtPropietarioI.Name = "txtPropietarioI"
        Me.txtPropietarioI.PreventEnterBeep = True
        Me.txtPropietarioI.Size = New System.Drawing.Size(232, 22)
        Me.txtPropietarioI.TabIndex = 263
        '
        'btnAgregarI
        '
        Me.btnAgregarI.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarI.BackColor = System.Drawing.Color.White
        Me.btnAgregarI.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarI.FadeEffect = False
        Me.btnAgregarI.FocusCuesEnabled = False
        Me.btnAgregarI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarI.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAgregarI.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarI.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarI.Location = New System.Drawing.Point(712, 100)
        Me.btnAgregarI.Name = "btnAgregarI"
        Me.btnAgregarI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarI.Size = New System.Drawing.Size(110, 39)
        Me.btnAgregarI.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarI.TabIndex = 5
        Me.btnAgregarI.Text = "Agregar"
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
        Me.diPrecio.Location = New System.Drawing.Point(570, 101)
        Me.diPrecio.LockUpdateChecked = False
        Me.diPrecio.MinValue = 0R
        Me.diPrecio.Name = "diPrecio"
        Me.diPrecio.Size = New System.Drawing.Size(91, 21)
        Me.diPrecio.TabIndex = 4
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
        Me.txtDescripcion.Location = New System.Drawing.Point(570, 70)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PreventEnterBeep = True
        Me.txtDescripcion.Size = New System.Drawing.Size(253, 24)
        Me.txtDescripcion.TabIndex = 3
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
        Me.lbDescripcion.Location = New System.Drawing.Point(458, 70)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescripcion.Size = New System.Drawing.Size(106, 23)
        Me.lbDescripcion.TabIndex = 249
        Me.lbDescripcion.Text = "Descripción(*):"
        '
        'lbIdReciboI
        '
        Me.lbIdReciboI.AutoSize = True
        Me.lbIdReciboI.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdReciboI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdReciboI.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdReciboI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdReciboI.Location = New System.Drawing.Point(17, 15)
        Me.lbIdReciboI.Name = "lbIdReciboI"
        Me.lbIdReciboI.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdReciboI.Size = New System.Drawing.Size(66, 16)
        Me.lbIdReciboI.TabIndex = 224
        Me.lbIdReciboI.Text = "Id Recibo:"
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
        Me.lbPrecio.Location = New System.Drawing.Point(458, 99)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPrecio.Size = New System.Drawing.Size(66, 23)
        Me.lbPrecio.TabIndex = 226
        Me.lbPrecio.Text = "Precio(*):"
        '
        'txtIdReciboI
        '
        Me.txtIdReciboI.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdReciboI.Border.Class = "TextBoxBorder"
        Me.txtIdReciboI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdReciboI.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdReciboI.Enabled = False
        Me.txtIdReciboI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReciboI.ForeColor = System.Drawing.Color.Black
        Me.txtIdReciboI.Location = New System.Drawing.Point(123, 12)
        Me.txtIdReciboI.Name = "txtIdReciboI"
        Me.txtIdReciboI.PreventEnterBeep = True
        Me.txtIdReciboI.Size = New System.Drawing.Size(73, 22)
        Me.txtIdReciboI.TabIndex = 100
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
        Me.txtTotalR.Location = New System.Drawing.Point(840, 211)
        Me.txtTotalR.MinValue = 0R
        Me.txtTotalR.Name = "txtTotalR"
        Me.txtTotalR.Size = New System.Drawing.Size(119, 21)
        Me.txtTotalR.TabIndex = 350
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
        Me.lbTotalR.Location = New System.Drawing.Point(781, 211)
        Me.lbTotalR.Name = "lbTotalR"
        Me.lbTotalR.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTotalR.Size = New System.Drawing.Size(41, 18)
        Me.lbTotalR.TabIndex = 351
        Me.lbTotalR.Text = "Total:"
        '
        'gpReciboInt
        '
        Me.gpReciboInt.BackColor = System.Drawing.Color.Transparent
        Me.gpReciboInt.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpReciboInt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpReciboInt.Controls.Add(Me.panelServicios)
        Me.gpReciboInt.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpReciboInt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpReciboInt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpReciboInt.Location = New System.Drawing.Point(0, 174)
        Me.gpReciboInt.Name = "gpReciboInt"
        Me.gpReciboInt.Size = New System.Drawing.Size(984, 263)
        '
        '
        '
        Me.gpReciboInt.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpReciboInt.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpReciboInt.Style.BackColorGradientAngle = 90
        Me.gpReciboInt.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpReciboInt.Style.BorderBottomWidth = 1
        Me.gpReciboInt.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpReciboInt.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpReciboInt.Style.BorderLeftWidth = 1
        Me.gpReciboInt.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpReciboInt.Style.BorderRightWidth = 1
        Me.gpReciboInt.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpReciboInt.Style.BorderTopWidth = 1
        Me.gpReciboInt.Style.CornerDiameter = 4
        Me.gpReciboInt.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpReciboInt.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpReciboInt.Style.TextColor = System.Drawing.Color.White
        Me.gpReciboInt.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpReciboInt.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpReciboInt.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpReciboInt.TabIndex = 387
        Me.gpReciboInt.Text = "DETALLE   RECIBO  INTERNACIÓN"
        '
        'panelServicios
        '
        Me.panelServicios.BackColor = System.Drawing.Color.Transparent
        Me.panelServicios.Controls.Add(Me.lbTotalR)
        Me.panelServicios.Controls.Add(Me.txtTotalR)
        Me.panelServicios.Controls.Add(Me.JGDetalleReciboInt)
        Me.panelServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelServicios.Location = New System.Drawing.Point(0, 0)
        Me.panelServicios.Name = "panelServicios"
        Me.panelServicios.Size = New System.Drawing.Size(978, 240)
        Me.panelServicios.TabIndex = 0
        '
        'JGDetalleReciboInt
        '
        Me.JGDetalleReciboInt.BackColor = System.Drawing.Color.GhostWhite
        Me.JGDetalleReciboInt.Dock = System.Windows.Forms.DockStyle.Top
        Me.JGDetalleReciboInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGDetalleReciboInt.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGDetalleReciboInt.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGDetalleReciboInt.Location = New System.Drawing.Point(0, 0)
        Me.JGDetalleReciboInt.Name = "JGDetalleReciboInt"
        Me.JGDetalleReciboInt.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGDetalleReciboInt.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGDetalleReciboInt.Size = New System.Drawing.Size(978, 194)
        Me.JGDetalleReciboInt.TabIndex = 0
        Me.JGDetalleReciboInt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.gpBusqRecibos.Size = New System.Drawing.Size(984, 548)
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
        Me.panelBusqRecibos.Controls.Add(Me.JGBusqRecibosI)
        Me.panelBusqRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBusqRecibos.Location = New System.Drawing.Point(0, 0)
        Me.panelBusqRecibos.Name = "panelBusqRecibos"
        Me.panelBusqRecibos.Size = New System.Drawing.Size(978, 525)
        Me.panelBusqRecibos.TabIndex = 0
        '
        'JGBusqRecibosI
        '
        Me.JGBusqRecibosI.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGBusqRecibosI.BackColor = System.Drawing.Color.GhostWhite
        Me.JGBusqRecibosI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqRecibosI.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGBusqRecibosI.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGBusqRecibosI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGBusqRecibosI.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGBusqRecibosI.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibosI.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGBusqRecibosI.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqRecibosI.Name = "JGBusqRecibosI"
        Me.JGBusqRecibosI.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGBusqRecibosI.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibosI.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibosI.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibosI.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGBusqRecibosI.SelectOnExpand = False
        Me.JGBusqRecibosI.Size = New System.Drawing.Size(978, 525)
        Me.JGBusqRecibosI.TabIndex = 0
        Me.JGBusqRecibosI.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_Fic_ReciboInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 573)
        Me.Name = "F1_Fic_ReciboInt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBO INTERNACIÓN"
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
        Me.gpDatosGral.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpReciboInt.ResumeLayout(False)
        Me.panelServicios.ResumeLayout(False)
        CType(Me.JGDetalleReciboInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqRecibos.ResumeLayout(False)
        Me.panelBusqRecibos.ResumeLayout(False)
        CType(Me.JGBusqRecibosI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpDatosGral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents diPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDescripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdReciboI As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbPrecio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdReciboI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpReciboInt As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelServicios As Panel
    Friend WithEvents JGDetalleReciboInt As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgregarI As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpBusqRecibos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqRecibos As Panel
    Friend WithEvents JGBusqRecibosI As Janus.Windows.GridEX.GridEX
    Friend WithEvents lbPaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPacienteI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbPropietario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPropietarioI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbFechaI As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaRI As DateTimePicker
    Friend WithEvents txtTratamiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbTratamiento As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObservacionI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalR As DevComponents.Editors.DoubleInput
    Friend WithEvents lbTotalR As DevComponents.DotNetBar.LabelX
End Class
