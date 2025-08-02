<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Fic_ReciboCirugia
    Inherits Modelo.Modelo1

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Fic_ReciboCirugia))
        Me.gpDatosGral = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.gpReciboInt = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbInternacion = New DevComponents.DotNetBar.LabelX()
        Me.lbIdRecibo = New DevComponents.DotNetBar.LabelX()
        Me.txtIdReciboI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swInternacion = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbCtrlEnter = New DevComponents.DotNetBar.LabelX()
        Me.txtCirugia = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lbFechaC = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaRC = New System.Windows.Forms.DateTimePicker()
        Me.lbPaciente = New DevComponents.DotNetBar.LabelX()
        Me.txtPacienteC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbPropietario = New DevComponents.DotNetBar.LabelX()
        Me.txtPropietarioC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAgregarC = New DevComponents.DotNetBar.ButtonX()
        Me.diPrecio = New DevComponents.Editors.DoubleInput()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescripcion = New DevComponents.DotNetBar.LabelX()
        Me.lbIdReciboI = New DevComponents.DotNetBar.LabelX()
        Me.lbPrecio = New DevComponents.DotNetBar.LabelX()
        Me.txtIdReciboC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelDetalleRecibo = New System.Windows.Forms.Panel()
        Me.gpDetalleRecibo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtTotalRC = New DevComponents.Editors.DoubleInput()
        Me.lbTotal = New DevComponents.DotNetBar.LabelX()
        Me.JGDetalleReciboCir = New Janus.Windows.GridEX.GridEX()
        Me.gpBusqRecibos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelBusqRecibos = New System.Windows.Forms.Panel()
        Me.JGBusqRecibosC = New Janus.Windows.GridEX.GridEX()
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
        Me.gpReciboInt.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleRecibo.SuspendLayout()
        Me.gpDetalleRecibo.SuspendLayout()
        CType(Me.txtTotalRC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGDetalleReciboCir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqRecibos.SuspendLayout()
        Me.panelBusqRecibos.SuspendLayout()
        CType(Me.JGBusqRecibosC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.PanelDetalleRecibo)
        Me.MpanelSuperior.Controls.Add(Me.gpDatosGral)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(984, 545)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 617)
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
        Me.MpanelBuscador.Size = New System.Drawing.Size(984, 656)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(220, 273)
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
        Me.superTabControl1.Size = New System.Drawing.Size(984, 681)
        '
        'gpDatosGral
        '
        Me.gpDatosGral.BackColor = System.Drawing.Color.White
        Me.gpDatosGral.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosGral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosGral.Controls.Add(Me.Panel2)
        Me.gpDatosGral.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosGral.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpDatosGral.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosGral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpDatosGral.Location = New System.Drawing.Point(0, 0)
        Me.gpDatosGral.Name = "gpDatosGral"
        Me.gpDatosGral.Size = New System.Drawing.Size(984, 243)
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
        Me.gpDatosGral.TabIndex = 264
        Me.gpDatosGral.Text = "DATOS RECIBO CIRUGÍA"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Controls.Add(Me.gpReciboInt)
        Me.Panel2.Controls.Add(Me.txtCirugia)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.lbFechaC)
        Me.Panel2.Controls.Add(Me.dtpFechaRC)
        Me.Panel2.Controls.Add(Me.lbPaciente)
        Me.Panel2.Controls.Add(Me.txtPacienteC)
        Me.Panel2.Controls.Add(Me.lbPropietario)
        Me.Panel2.Controls.Add(Me.txtPropietarioC)
        Me.Panel2.Controls.Add(Me.btnAgregarC)
        Me.Panel2.Controls.Add(Me.diPrecio)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.lbDescripcion)
        Me.Panel2.Controls.Add(Me.lbIdReciboI)
        Me.Panel2.Controls.Add(Me.lbPrecio)
        Me.Panel2.Controls.Add(Me.txtIdReciboC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 220)
        Me.Panel2.TabIndex = 234
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(212, 52)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(68, 15)
        Me.LabelX1.TabIndex = 369
        Me.LabelX1.Text = "Ctrl+Enter"
        '
        'gpReciboInt
        '
        Me.gpReciboInt.BackColor = System.Drawing.Color.Transparent
        Me.gpReciboInt.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpReciboInt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpReciboInt.Controls.Add(Me.Panel3)
        Me.gpReciboInt.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpReciboInt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpReciboInt.Location = New System.Drawing.Point(458, 99)
        Me.gpReciboInt.Name = "gpReciboInt"
        Me.gpReciboInt.Size = New System.Drawing.Size(409, 107)
        '
        '
        '
        Me.gpReciboInt.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpReciboInt.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedShadow
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
        Me.gpReciboInt.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpReciboInt.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpReciboInt.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpReciboInt.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpReciboInt.TabIndex = 368
        Me.gpReciboInt.Text = "Recibo Internación"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.lbInternacion)
        Me.Panel3.Controls.Add(Me.lbIdRecibo)
        Me.Panel3.Controls.Add(Me.txtIdReciboI)
        Me.Panel3.Controls.Add(Me.swInternacion)
        Me.Panel3.Controls.Add(Me.lbCtrlEnter)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 84)
        Me.Panel3.TabIndex = 216
        '
        'lbInternacion
        '
        Me.lbInternacion.AutoSize = True
        Me.lbInternacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbInternacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbInternacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInternacion.ForeColor = System.Drawing.Color.Black
        Me.lbInternacion.Location = New System.Drawing.Point(30, 15)
        Me.lbInternacion.Name = "lbInternacion"
        Me.lbInternacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbInternacion.Size = New System.Drawing.Size(80, 16)
        Me.lbInternacion.TabIndex = 365
        Me.lbInternacion.Text = "Internación:"
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
        Me.lbIdRecibo.ForeColor = System.Drawing.Color.Black
        Me.lbIdRecibo.Location = New System.Drawing.Point(30, 45)
        Me.lbIdRecibo.Name = "lbIdRecibo"
        Me.lbIdRecibo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdRecibo.Size = New System.Drawing.Size(91, 16)
        Me.lbIdRecibo.TabIndex = 362
        Me.lbIdRecibo.Text = "Id Recibo Int.:"
        '
        'txtIdReciboI
        '
        Me.txtIdReciboI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdReciboI.Border.Class = "TextBoxBorder"
        Me.txtIdReciboI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdReciboI.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdReciboI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReciboI.ForeColor = System.Drawing.Color.Black
        Me.txtIdReciboI.Location = New System.Drawing.Point(135, 43)
        Me.txtIdReciboI.Name = "txtIdReciboI"
        Me.txtIdReciboI.PreventEnterBeep = True
        Me.txtIdReciboI.Size = New System.Drawing.Size(73, 22)
        Me.txtIdReciboI.TabIndex = 8
        Me.txtIdReciboI.TabStop = False
        Me.txtIdReciboI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'swInternacion
        '
        '
        '
        '
        Me.swInternacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swInternacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swInternacion.Location = New System.Drawing.Point(135, 12)
        Me.swInternacion.Name = "swInternacion"
        Me.swInternacion.OffBackColor = System.Drawing.Color.Gold
        Me.swInternacion.OffText = "NO"
        Me.swInternacion.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swInternacion.OnText = "SI"
        Me.swInternacion.OnTextColor = System.Drawing.Color.Black
        Me.swInternacion.Size = New System.Drawing.Size(73, 22)
        Me.swInternacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swInternacion.SwitchBackColor = System.Drawing.Color.Gray
        Me.swInternacion.TabIndex = 7
        '
        'lbCtrlEnter
        '
        Me.lbCtrlEnter.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCtrlEnter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCtrlEnter.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCtrlEnter.ForeColor = System.Drawing.Color.Black
        Me.lbCtrlEnter.Location = New System.Drawing.Point(214, 47)
        Me.lbCtrlEnter.Name = "lbCtrlEnter"
        Me.lbCtrlEnter.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCtrlEnter.Size = New System.Drawing.Size(68, 15)
        Me.lbCtrlEnter.TabIndex = 363
        Me.lbCtrlEnter.Text = "Ctrl+Enter"
        '
        'txtCirugia
        '
        Me.txtCirugia.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCirugia.Border.Class = "TextBoxBorder"
        Me.txtCirugia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCirugia.DisabledBackColor = System.Drawing.Color.White
        Me.txtCirugia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCirugia.ForeColor = System.Drawing.Color.Black
        Me.txtCirugia.Location = New System.Drawing.Point(133, 48)
        Me.txtCirugia.Name = "txtCirugia"
        Me.txtCirugia.PreventEnterBeep = True
        Me.txtCirugia.Size = New System.Drawing.Size(73, 22)
        Me.txtCirugia.TabIndex = 1
        Me.txtCirugia.TabStop = False
        Me.txtCirugia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(27, 50)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(69, 16)
        Me.LabelX2.TabIndex = 367
        Me.LabelX2.Text = "Id Cirugia:"
        '
        'lbFechaC
        '
        Me.lbFechaC.AutoSize = True
        Me.lbFechaC.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaC.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaC.Location = New System.Drawing.Point(27, 149)
        Me.lbFechaC.Name = "lbFechaC"
        Me.lbFechaC.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaC.Size = New System.Drawing.Size(44, 16)
        Me.lbFechaC.TabIndex = 344
        Me.lbFechaC.Text = "Fecha:"
        '
        'dtpFechaRC
        '
        Me.dtpFechaRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRC.Location = New System.Drawing.Point(133, 144)
        Me.dtpFechaRC.Name = "dtpFechaRC"
        Me.dtpFechaRC.Size = New System.Drawing.Size(110, 22)
        Me.dtpFechaRC.TabIndex = 2
        Me.dtpFechaRC.TabStop = False
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
        Me.lbPaciente.Location = New System.Drawing.Point(27, 114)
        Me.lbPaciente.Name = "lbPaciente"
        Me.lbPaciente.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPaciente.Size = New System.Drawing.Size(60, 16)
        Me.lbPaciente.TabIndex = 266
        Me.lbPaciente.Text = "Paciente:"
        '
        'txtPacienteC
        '
        Me.txtPacienteC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPacienteC.Border.Class = "TextBoxBorder"
        Me.txtPacienteC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPacienteC.DisabledBackColor = System.Drawing.Color.White
        Me.txtPacienteC.Enabled = False
        Me.txtPacienteC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacienteC.ForeColor = System.Drawing.Color.Black
        Me.txtPacienteC.Location = New System.Drawing.Point(133, 112)
        Me.txtPacienteC.Name = "txtPacienteC"
        Me.txtPacienteC.PreventEnterBeep = True
        Me.txtPacienteC.Size = New System.Drawing.Size(272, 22)
        Me.txtPacienteC.TabIndex = 265
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
        Me.lbPropietario.Location = New System.Drawing.Point(27, 82)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPropietario.Size = New System.Drawing.Size(78, 16)
        Me.lbPropietario.TabIndex = 264
        Me.lbPropietario.Text = "Propietario:"
        '
        'txtPropietarioC
        '
        Me.txtPropietarioC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPropietarioC.Border.Class = "TextBoxBorder"
        Me.txtPropietarioC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPropietarioC.DisabledBackColor = System.Drawing.Color.White
        Me.txtPropietarioC.Enabled = False
        Me.txtPropietarioC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioC.ForeColor = System.Drawing.Color.Black
        Me.txtPropietarioC.Location = New System.Drawing.Point(133, 80)
        Me.txtPropietarioC.Name = "txtPropietarioC"
        Me.txtPropietarioC.PreventEnterBeep = True
        Me.txtPropietarioC.Size = New System.Drawing.Size(272, 22)
        Me.txtPropietarioC.TabIndex = 263
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
        Me.btnAgregarC.Location = New System.Drawing.Point(757, 53)
        Me.btnAgregarC.Name = "btnAgregarC"
        Me.btnAgregarC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarC.Size = New System.Drawing.Size(110, 39)
        Me.btnAgregarC.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarC.SymbolSize = 5.0!
        Me.btnAgregarC.TabIndex = 262
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
        Me.diPrecio.Location = New System.Drawing.Point(567, 55)
        Me.diPrecio.LockUpdateChecked = False
        Me.diPrecio.MinValue = 0R
        Me.diPrecio.Name = "diPrecio"
        Me.diPrecio.Size = New System.Drawing.Size(110, 21)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(567, 10)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PreventEnterBeep = True
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 35)
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
        Me.lbDescripcion.Location = New System.Drawing.Point(457, 11)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescripcion.Size = New System.Drawing.Size(104, 22)
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
        Me.lbIdReciboI.Location = New System.Drawing.Point(27, 19)
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
        Me.lbPrecio.Location = New System.Drawing.Point(457, 55)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPrecio.Size = New System.Drawing.Size(66, 19)
        Me.lbPrecio.TabIndex = 226
        Me.lbPrecio.Text = "Precio(*):"
        '
        'txtIdReciboC
        '
        Me.txtIdReciboC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdReciboC.Border.Class = "TextBoxBorder"
        Me.txtIdReciboC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdReciboC.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdReciboC.Enabled = False
        Me.txtIdReciboC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReciboC.ForeColor = System.Drawing.Color.Black
        Me.txtIdReciboC.Location = New System.Drawing.Point(133, 16)
        Me.txtIdReciboC.Name = "txtIdReciboC"
        Me.txtIdReciboC.PreventEnterBeep = True
        Me.txtIdReciboC.Size = New System.Drawing.Size(73, 22)
        Me.txtIdReciboC.TabIndex = 100
        '
        'PanelDetalleRecibo
        '
        Me.PanelDetalleRecibo.Controls.Add(Me.gpDetalleRecibo)
        Me.PanelDetalleRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalleRecibo.Location = New System.Drawing.Point(0, 243)
        Me.PanelDetalleRecibo.Name = "PanelDetalleRecibo"
        Me.PanelDetalleRecibo.Size = New System.Drawing.Size(984, 302)
        Me.PanelDetalleRecibo.TabIndex = 303
        '
        'gpDetalleRecibo
        '
        Me.gpDetalleRecibo.BackColor = System.Drawing.Color.White
        Me.gpDetalleRecibo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDetalleRecibo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDetalleRecibo.Controls.Add(Me.txtTotalRC)
        Me.gpDetalleRecibo.Controls.Add(Me.lbTotal)
        Me.gpDetalleRecibo.Controls.Add(Me.JGDetalleReciboCir)
        Me.gpDetalleRecibo.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDetalleRecibo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDetalleRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleRecibo.Location = New System.Drawing.Point(0, 0)
        Me.gpDetalleRecibo.Name = "gpDetalleRecibo"
        Me.gpDetalleRecibo.Size = New System.Drawing.Size(984, 302)
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
        Me.gpDetalleRecibo.TabIndex = 6
        Me.gpDetalleRecibo.Text = "DETALLE  RECIBO"
        '
        'txtTotalRC
        '
        '
        '
        '
        Me.txtTotalRC.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotalRC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalRC.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotalRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRC.Increment = 1.0R
        Me.txtTotalRC.Location = New System.Drawing.Point(830, 240)
        Me.txtTotalRC.MinValue = 0R
        Me.txtTotalRC.Name = "txtTotalRC"
        Me.txtTotalRC.Size = New System.Drawing.Size(139, 21)
        Me.txtTotalRC.TabIndex = 3
        Me.txtTotalRC.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTotal.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.White
        Me.lbTotal.Location = New System.Drawing.Point(783, 241)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTotal.Size = New System.Drawing.Size(41, 18)
        Me.lbTotal.TabIndex = 259
        Me.lbTotal.Text = "Total:"
        '
        'JGDetalleReciboCir
        '
        Me.JGDetalleReciboCir.Dock = System.Windows.Forms.DockStyle.Top
        Me.JGDetalleReciboCir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGDetalleReciboCir.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGDetalleReciboCir.Location = New System.Drawing.Point(0, 0)
        Me.JGDetalleReciboCir.Name = "JGDetalleReciboCir"
        Me.JGDetalleReciboCir.Size = New System.Drawing.Size(978, 222)
        Me.JGDetalleReciboCir.TabIndex = 257
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
        Me.gpBusqRecibos.Size = New System.Drawing.Size(984, 656)
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
        Me.gpBusqRecibos.TabIndex = 6
        Me.gpBusqRecibos.Text = "BUSCADOR  RECIBOS CIRUGÍA"
        '
        'panelBusqRecibos
        '
        Me.panelBusqRecibos.BackColor = System.Drawing.Color.White
        Me.panelBusqRecibos.Controls.Add(Me.JGBusqRecibosC)
        Me.panelBusqRecibos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBusqRecibos.Location = New System.Drawing.Point(0, 0)
        Me.panelBusqRecibos.Name = "panelBusqRecibos"
        Me.panelBusqRecibos.Size = New System.Drawing.Size(978, 633)
        Me.panelBusqRecibos.TabIndex = 0
        '
        'JGBusqRecibosC
        '
        Me.JGBusqRecibosC.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGBusqRecibosC.BackColor = System.Drawing.Color.GhostWhite
        Me.JGBusqRecibosC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqRecibosC.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGBusqRecibosC.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGBusqRecibosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGBusqRecibosC.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGBusqRecibosC.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibosC.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGBusqRecibosC.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqRecibosC.Name = "JGBusqRecibosC"
        Me.JGBusqRecibosC.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGBusqRecibosC.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibosC.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqRecibosC.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqRecibosC.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGBusqRecibosC.SelectOnExpand = False
        Me.JGBusqRecibosC.Size = New System.Drawing.Size(978, 633)
        Me.JGBusqRecibosC.TabIndex = 0
        Me.JGBusqRecibosC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_Fic_ReciboCirugia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 681)
        Me.Name = "F1_Fic_ReciboCirugia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBO CIRUGÍA"
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
        Me.gpReciboInt.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleRecibo.ResumeLayout(False)
        Me.gpDetalleRecibo.ResumeLayout(False)
        CType(Me.txtTotalRC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGDetalleReciboCir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqRecibos.ResumeLayout(False)
        Me.panelBusqRecibos.ResumeLayout(False)
        CType(Me.JGBusqRecibosC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpDatosGral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbFechaC As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaRC As DateTimePicker
    Friend WithEvents lbPaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPacienteC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbPropietario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPropietarioC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAgregarC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents diPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDescripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdReciboI As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbPrecio As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdReciboC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelDetalleRecibo As Panel
    Friend WithEvents gpDetalleRecibo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtTotalRC As DevComponents.Editors.DoubleInput
    Friend WithEvents lbTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents JGDetalleReciboCir As Janus.Windows.GridEX.GridEX
    Friend WithEvents swInternacion As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbInternacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCtrlEnter As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdReciboI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbIdRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCirugia As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpReciboInt As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents gpBusqRecibos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqRecibos As Panel
    Friend WithEvents JGBusqRecibosC As Janus.Windows.GridEX.GridEX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
