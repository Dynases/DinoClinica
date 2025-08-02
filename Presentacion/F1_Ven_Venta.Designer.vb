<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Ven_Venta
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
        Dim cbTipoVenta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Ven_Venta))
        Dim cbEmision_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbSucursal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelContentSup = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.cbTipoVenta = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cbEmision = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.swCirugia = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.swInternacion = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtIdPaciente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPaciente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lbCtrlEnter = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.cbSucursal = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.swServicio = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbServicio = New DevComponents.DotNetBar.LabelX()
        Me.dtpFCredito = New System.Windows.Forms.DateTimePicker()
        Me.dtpFVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtIdReciboV = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdRecibo = New DevComponents.DotNetBar.LabelX()
        Me.txtIdVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdVenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanelFactura2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.QrFactura = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.TbNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.TbNombre1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tbCodigoControl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.dtiFechaFactura = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbNroFactura = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbNroAutoriz = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.lbVencCredito = New DevComponents.DotNetBar.LabelX()
        Me.lbTipoVenta = New DevComponents.DotNetBar.LabelX()
        Me.lbFVenta = New DevComponents.DotNetBar.LabelX()
        Me.lbIdVenta = New DevComponents.DotNetBar.LabelX()
        Me.txtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbVendedor = New DevComponents.DotNetBar.LabelX()
        Me.lbObservacion = New DevComponents.DotNetBar.LabelX()
        Me.txtCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbCliente = New DevComponents.DotNetBar.LabelX()
        Me.PanelDetalle = New System.Windows.Forms.Panel()
        Me.gpDetalleVenta = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GPanelProductos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.JGProductos = New Janus.Windows.GridEX.GridEX()
        Me.JGdetalleVenta = New Janus.Windows.GridEX.GridEX()
        Me.panelResultados = New System.Windows.Forms.Panel()
        Me.txtPDesc = New DevComponents.Editors.DoubleInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtCambio = New DevComponents.Editors.DoubleInput()
        Me.txtMontoPagado = New DevComponents.Editors.DoubleInput()
        Me.txtSaldo = New DevComponents.Editors.DoubleInput()
        Me.txtAcuenta = New DevComponents.Editors.DoubleInput()
        Me.txtTotalNeto = New DevComponents.Editors.DoubleInput()
        Me.txtMdesc = New DevComponents.Editors.DoubleInput()
        Me.txtSubTotal = New DevComponents.Editors.DoubleInput()
        Me.lbCambio = New DevComponents.DotNetBar.LabelX()
        Me.lbMontoPagado = New DevComponents.DotNetBar.LabelX()
        Me.lbSaldo = New DevComponents.DotNetBar.LabelX()
        Me.lbAcuenta = New DevComponents.DotNetBar.LabelX()
        Me.lbSubTotal = New DevComponents.DotNetBar.LabelX()
        Me.lbTotalNeto = New DevComponents.DotNetBar.LabelX()
        Me.lbMdesc = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.grVentas = New Janus.Windows.GridEX.GridEX()
        Me.PanelToolBar2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX()
        Me.swMostrar = New DevComponents.DotNetBar.Controls.SwitchButton()
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
        Me.PanelContentSup.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cbTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelFactura2.SuspendLayout()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtiFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalle.SuspendLayout()
        Me.gpDetalleVenta.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GPanelProductos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.JGProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGdetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResultados.SuspendLayout()
        CType(Me.txtPDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.PanelDetalle)
        Me.MpanelSuperior.Controls.Add(Me.PanelContentSup)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(1334, 534)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.swMostrar)
        Me.PanelSuperior.Controls.Add(Me.PanelToolBar2)
        Me.PanelSuperior.Size = New System.Drawing.Size(1334, 72)
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
        Me.PanelSuperior.Controls.SetChildIndex(Me.swMostrar, 0)
        '
        'btnGrabar
        '
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 606)
        Me.PanelInferior.Size = New System.Drawing.Size(1334, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(1134, 0)
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
        Me.MpanelBuscador.Controls.Add(Me.GroupPanel2)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(796, 185)
        Me.PanelUsuario.Size = New System.Drawing.Size(197, 91)
        '
        'lbHora
        '
        Me.lbHora.Location = New System.Drawing.Point(107, 65)
        '
        'lbFecha
        '
        Me.lbFecha.Location = New System.Drawing.Point(108, 42)
        '
        'lbUsuario
        '
        Me.lbUsuario.Location = New System.Drawing.Point(108, 19)
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(12, 65)
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(12, 42)
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(12, 19)
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
        Me.superTabControl1.Size = New System.Drawing.Size(1334, 670)
        '
        'PanelContentSup
        '
        Me.PanelContentSup.BackColor = System.Drawing.Color.White
        Me.PanelContentSup.Controls.Add(Me.GroupPanel1)
        Me.PanelContentSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelContentSup.Location = New System.Drawing.Point(0, 0)
        Me.PanelContentSup.Name = "PanelContentSup"
        Me.PanelContentSup.Size = New System.Drawing.Size(1334, 220)
        Me.PanelContentSup.TabIndex = 1
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1334, 220)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 228
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LabelX10)
        Me.Panel2.Controls.Add(Me.LabelX9)
        Me.Panel2.Controls.Add(Me.cbTipoVenta)
        Me.Panel2.Controls.Add(Me.LabelX6)
        Me.Panel2.Controls.Add(Me.cbEmision)
        Me.Panel2.Controls.Add(Me.swCirugia)
        Me.Panel2.Controls.Add(Me.LabelX5)
        Me.Panel2.Controls.Add(Me.swInternacion)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.txtIdPaciente)
        Me.Panel2.Controls.Add(Me.txtPaciente)
        Me.Panel2.Controls.Add(Me.LabelX3)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.lbCtrlEnter)
        Me.Panel2.Controls.Add(Me.LabelX17)
        Me.Panel2.Controls.Add(Me.cbSucursal)
        Me.Panel2.Controls.Add(Me.swServicio)
        Me.Panel2.Controls.Add(Me.lbServicio)
        Me.Panel2.Controls.Add(Me.dtpFCredito)
        Me.Panel2.Controls.Add(Me.dtpFVenta)
        Me.Panel2.Controls.Add(Me.txtIdReciboV)
        Me.Panel2.Controls.Add(Me.lbIdRecibo)
        Me.Panel2.Controls.Add(Me.txtIdVendedor)
        Me.Panel2.Controls.Add(Me.txtIdCliente)
        Me.Panel2.Controls.Add(Me.txtVendedor)
        Me.Panel2.Controls.Add(Me.txtIdVenta)
        Me.Panel2.Controls.Add(Me.GroupPanelFactura2)
        Me.Panel2.Controls.Add(Me.lbVencCredito)
        Me.Panel2.Controls.Add(Me.lbTipoVenta)
        Me.Panel2.Controls.Add(Me.lbFVenta)
        Me.Panel2.Controls.Add(Me.lbIdVenta)
        Me.Panel2.Controls.Add(Me.txtObservacion)
        Me.Panel2.Controls.Add(Me.lbVendedor)
        Me.Panel2.Controls.Add(Me.lbObservacion)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.lbCliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1328, 197)
        Me.Panel2.TabIndex = 234
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(94, 91)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX10.Size = New System.Drawing.Size(59, 11)
        Me.LabelX10.TabIndex = 367
        Me.LabelX10.Text = "Ctrl+Enter"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(93, 160)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX9.Size = New System.Drawing.Size(59, 11)
        Me.LabelX9.TabIndex = 366
        Me.LabelX9.Text = "Ctrl+Enter"
        Me.LabelX9.Visible = False
        '
        'cbTipoVenta
        '
        cbTipoVenta_DesignTimeLayout.LayoutString = resources.GetString("cbTipoVenta_DesignTimeLayout.LayoutString")
        Me.cbTipoVenta.DesignTimeLayout = cbTipoVenta_DesignTimeLayout
        Me.cbTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoVenta.Location = New System.Drawing.Point(606, 74)
        Me.cbTipoVenta.Name = "cbTipoVenta"
        Me.cbTipoVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoVenta.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoVenta.SelectedIndex = -1
        Me.cbTipoVenta.SelectedItem = Nothing
        Me.cbTipoVenta.Size = New System.Drawing.Size(164, 22)
        Me.cbTipoVenta.TabIndex = 365
        Me.cbTipoVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(491, 40)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX6.Size = New System.Drawing.Size(85, 23)
        Me.LabelX6.TabIndex = 364
        Me.LabelX6.Text = "Emision:"
        '
        'cbEmision
        '
        cbEmision_DesignTimeLayout.LayoutString = resources.GetString("cbEmision_DesignTimeLayout.LayoutString")
        Me.cbEmision.DesignTimeLayout = cbEmision_DesignTimeLayout
        Me.cbEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmision.Location = New System.Drawing.Point(606, 41)
        Me.cbEmision.Name = "cbEmision"
        Me.cbEmision.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbEmision.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbEmision.SelectedIndex = -1
        Me.cbEmision.SelectedItem = Nothing
        Me.cbEmision.Size = New System.Drawing.Size(164, 22)
        Me.cbEmision.TabIndex = 363
        Me.cbEmision.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'swCirugia
        '
        '
        '
        '
        Me.swCirugia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swCirugia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swCirugia.Location = New System.Drawing.Point(389, 38)
        Me.swCirugia.Name = "swCirugia"
        Me.swCirugia.OffBackColor = System.Drawing.Color.Gold
        Me.swCirugia.OffText = "NO"
        Me.swCirugia.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swCirugia.OnText = "SI"
        Me.swCirugia.OnTextColor = System.Drawing.Color.Black
        Me.swCirugia.Size = New System.Drawing.Size(68, 22)
        Me.swCirugia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swCirugia.SwitchBackColor = System.Drawing.Color.Gray
        Me.swCirugia.TabIndex = 361
        Me.swCirugia.Visible = False
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(331, 41)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX5.Size = New System.Drawing.Size(52, 16)
        Me.LabelX5.TabIndex = 362
        Me.LabelX5.Text = "Cirugía:"
        Me.LabelX5.Visible = False
        '
        'swInternacion
        '
        '
        '
        '
        Me.swInternacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swInternacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swInternacion.Location = New System.Drawing.Point(252, 38)
        Me.swInternacion.Name = "swInternacion"
        Me.swInternacion.OffBackColor = System.Drawing.Color.Gold
        Me.swInternacion.OffText = "NO"
        Me.swInternacion.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swInternacion.OnText = "SI"
        Me.swInternacion.OnTextColor = System.Drawing.Color.Black
        Me.swInternacion.Size = New System.Drawing.Size(68, 22)
        Me.swInternacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swInternacion.SwitchBackColor = System.Drawing.Color.Gray
        Me.swInternacion.TabIndex = 359
        Me.swInternacion.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(171, 41)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(80, 16)
        Me.LabelX4.TabIndex = 360
        Me.LabelX4.Text = "Internación:"
        Me.LabelX4.Visible = False
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdPaciente.Border.Class = "TextBoxBorder"
        Me.txtIdPaciente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdPaciente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPaciente.ForeColor = System.Drawing.Color.Black
        Me.txtIdPaciente.Location = New System.Drawing.Point(94, 172)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.PreventEnterBeep = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(58, 22)
        Me.txtIdPaciente.TabIndex = 356
        Me.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdPaciente.Visible = False
        '
        'txtPaciente
        '
        Me.txtPaciente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPaciente.Border.Class = "TextBoxBorder"
        Me.txtPaciente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPaciente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaciente.ForeColor = System.Drawing.Color.Black
        Me.txtPaciente.Location = New System.Drawing.Point(158, 172)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.PreventEnterBeep = True
        Me.txtPaciente.Size = New System.Drawing.Size(299, 22)
        Me.txtPaciente.TabIndex = 357
        Me.txtPaciente.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(12, 171)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(63, 23)
        Me.LabelX3.TabIndex = 358
        Me.LabelX3.Text = "Paciente:"
        Me.LabelX3.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(93, 125)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(59, 11)
        Me.LabelX2.TabIndex = 355
        Me.LabelX2.Text = "Ctrl+Enter"
        '
        'lbCtrlEnter
        '
        Me.lbCtrlEnter.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCtrlEnter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCtrlEnter.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCtrlEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCtrlEnter.Location = New System.Drawing.Point(158, 72)
        Me.lbCtrlEnter.Name = "lbCtrlEnter"
        Me.lbCtrlEnter.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCtrlEnter.Size = New System.Drawing.Size(68, 15)
        Me.lbCtrlEnter.TabIndex = 352
        Me.lbCtrlEnter.Text = "Ctrl+Enter"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX17.Location = New System.Drawing.Point(791, 10)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX17.Size = New System.Drawing.Size(138, 23)
        Me.LabelX17.TabIndex = 268
        Me.LabelX17.Text = "Almacen-Sucursal:"
        '
        'cbSucursal
        '
        cbSucursal_DesignTimeLayout.LayoutString = resources.GetString("cbSucursal_DesignTimeLayout.LayoutString")
        Me.cbSucursal.DesignTimeLayout = cbSucursal_DesignTimeLayout
        Me.cbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Location = New System.Drawing.Point(791, 40)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbSucursal.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbSucursal.SelectedIndex = -1
        Me.cbSucursal.SelectedItem = Nothing
        Me.cbSucursal.Size = New System.Drawing.Size(164, 22)
        Me.cbSucursal.TabIndex = 267
        Me.cbSucursal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'swServicio
        '
        '
        '
        '
        Me.swServicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swServicio.Location = New System.Drawing.Point(94, 38)
        Me.swServicio.Name = "swServicio"
        Me.swServicio.OffBackColor = System.Drawing.Color.Gold
        Me.swServicio.OffText = "NO"
        Me.swServicio.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swServicio.OnText = "SI"
        Me.swServicio.OnTextColor = System.Drawing.Color.Black
        Me.swServicio.Size = New System.Drawing.Size(68, 22)
        Me.swServicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swServicio.SwitchBackColor = System.Drawing.Color.Gray
        Me.swServicio.TabIndex = 265
        Me.swServicio.Value = True
        Me.swServicio.ValueObject = "Y"
        '
        'lbServicio
        '
        Me.lbServicio.AutoSize = True
        Me.lbServicio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbServicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbServicio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbServicio.Location = New System.Drawing.Point(13, 41)
        Me.lbServicio.Name = "lbServicio"
        Me.lbServicio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbServicio.Size = New System.Drawing.Size(62, 16)
        Me.lbServicio.TabIndex = 266
        Me.lbServicio.Text = "Consulta:"
        '
        'dtpFCredito
        '
        Me.dtpFCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFCredito.Location = New System.Drawing.Point(606, 106)
        Me.dtpFCredito.Name = "dtpFCredito"
        Me.dtpFCredito.Size = New System.Drawing.Size(122, 22)
        Me.dtpFCredito.TabIndex = 262
        Me.dtpFCredito.TabStop = False
        Me.dtpFCredito.Visible = False
        '
        'dtpFVenta
        '
        Me.dtpFVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFVenta.Location = New System.Drawing.Point(606, 10)
        Me.dtpFVenta.Name = "dtpFVenta"
        Me.dtpFVenta.Size = New System.Drawing.Size(122, 22)
        Me.dtpFVenta.TabIndex = 261
        Me.dtpFVenta.TabStop = False
        '
        'txtIdReciboV
        '
        Me.txtIdReciboV.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdReciboV.Border.Class = "TextBoxBorder"
        Me.txtIdReciboV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdReciboV.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdReciboV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReciboV.ForeColor = System.Drawing.Color.Black
        Me.txtIdReciboV.Location = New System.Drawing.Point(94, 69)
        Me.txtIdReciboV.Name = "txtIdReciboV"
        Me.txtIdReciboV.PreventEnterBeep = True
        Me.txtIdReciboV.Size = New System.Drawing.Size(58, 22)
        Me.txtIdReciboV.TabIndex = 20
        Me.txtIdReciboV.TabStop = False
        Me.txtIdReciboV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lbIdRecibo.Location = New System.Drawing.Point(13, 73)
        Me.lbIdRecibo.Name = "lbIdRecibo"
        Me.lbIdRecibo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdRecibo.Size = New System.Drawing.Size(66, 16)
        Me.lbIdRecibo.TabIndex = 247
        Me.lbIdRecibo.Text = "Id Recibo:"
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdVendedor.Border.Class = "TextBoxBorder"
        Me.txtIdVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdVendedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVendedor.ForeColor = System.Drawing.Color.Black
        Me.txtIdVendedor.Location = New System.Drawing.Point(94, 136)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.PreventEnterBeep = True
        Me.txtIdVendedor.Size = New System.Drawing.Size(58, 22)
        Me.txtIdVendedor.TabIndex = 21
        Me.txtIdVendedor.Text = "2076"
        Me.txtIdVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdVendedor.WordWrap = False
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdCliente.Border.Class = "TextBoxBorder"
        Me.txtIdCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.Location = New System.Drawing.Point(94, 103)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.PreventEnterBeep = True
        Me.txtIdCliente.Size = New System.Drawing.Size(58, 22)
        Me.txtIdCliente.TabIndex = 1
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtVendedor.Border.Class = "TextBoxBorder"
        Me.txtVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVendedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.ForeColor = System.Drawing.Color.Black
        Me.txtVendedor.Location = New System.Drawing.Point(158, 136)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.PreventEnterBeep = True
        Me.txtVendedor.Size = New System.Drawing.Size(299, 22)
        Me.txtVendedor.TabIndex = 243
        Me.txtVendedor.WordWrap = False
        '
        'txtIdVenta
        '
        Me.txtIdVenta.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdVenta.Border.Class = "TextBoxBorder"
        Me.txtIdVenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVenta.ForeColor = System.Drawing.Color.Black
        Me.txtIdVenta.Location = New System.Drawing.Point(94, 10)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.PreventEnterBeep = True
        Me.txtIdVenta.Size = New System.Drawing.Size(58, 22)
        Me.txtIdVenta.TabIndex = 242
        Me.txtIdVenta.TabStop = False
        '
        'GroupPanelFactura2
        '
        Me.GroupPanelFactura2.BackColor = System.Drawing.Color.White
        Me.GroupPanelFactura2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelFactura2.Controls.Add(Me.QrFactura)
        Me.GroupPanelFactura2.Controls.Add(Me.TbNit)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX12)
        Me.GroupPanelFactura2.Controls.Add(Me.TbNombre1)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX8)
        Me.GroupPanelFactura2.Controls.Add(Me.tbCodigoControl)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX16)
        Me.GroupPanelFactura2.Controls.Add(Me.dtiFechaFactura)
        Me.GroupPanelFactura2.Controls.Add(Me.tbNroFactura)
        Me.GroupPanelFactura2.Controls.Add(Me.tbNroAutoriz)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX15)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX14)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX7)
        Me.GroupPanelFactura2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelFactura2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupPanelFactura2.Location = New System.Drawing.Point(978, 0)
        Me.GroupPanelFactura2.Name = "GroupPanelFactura2"
        Me.GroupPanelFactura2.Size = New System.Drawing.Size(350, 197)
        '
        '
        '
        Me.GroupPanelFactura2.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.Style.BackColorGradientAngle = 90
        Me.GroupPanelFactura2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderBottomWidth = 1
        Me.GroupPanelFactura2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelFactura2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderLeftWidth = 1
        Me.GroupPanelFactura2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderRightWidth = 1
        Me.GroupPanelFactura2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderTopWidth = 1
        Me.GroupPanelFactura2.Style.CornerDiameter = 4
        Me.GroupPanelFactura2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelFactura2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelFactura2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelFactura2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelFactura2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelFactura2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelFactura2.TabIndex = 236
        Me.GroupPanelFactura2.Text = "DATOS FACTURACIÓN"
        '
        'QrFactura
        '
        Me.QrFactura.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrFactura.Image = CType(resources.GetObject("QrFactura.Image"), System.Drawing.Image)
        Me.QrFactura.Location = New System.Drawing.Point(264, 30)
        Me.QrFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.QrFactura.Name = "QrFactura"
        Me.QrFactura.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrFactura.Size = New System.Drawing.Size(75, 73)
        Me.QrFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrFactura.TabIndex = 248
        Me.QrFactura.TabStop = False
        Me.QrFactura.Text = "QrCodeImgControl1"
        Me.QrFactura.Visible = False
        '
        'TbNit
        '
        Me.TbNit.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TbNit.Border.Class = "TextBoxBorder"
        Me.TbNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNit.DisabledBackColor = System.Drawing.Color.White
        Me.TbNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TbNit.ForeColor = System.Drawing.Color.Black
        Me.TbNit.Location = New System.Drawing.Point(105, 116)
        Me.TbNit.MaxLength = 20
        Me.TbNit.Name = "TbNit"
        Me.TbNit.PreventEnterBeep = True
        Me.TbNit.Size = New System.Drawing.Size(232, 21)
        Me.TbNit.TabIndex = 244
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX12.Location = New System.Drawing.Point(3, 139)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(90, 23)
        Me.LabelX12.TabIndex = 247
        Me.LabelX12.Text = "Razon Social:"
        '
        'TbNombre1
        '
        Me.TbNombre1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TbNombre1.Border.Class = "TextBoxBorder"
        Me.TbNombre1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombre1.DisabledBackColor = System.Drawing.Color.White
        Me.TbNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TbNombre1.ForeColor = System.Drawing.Color.Black
        Me.TbNombre1.Location = New System.Drawing.Point(105, 140)
        Me.TbNombre1.MaxLength = 100
        Me.TbNombre1.Multiline = True
        Me.TbNombre1.Name = "TbNombre1"
        Me.TbNombre1.PreventEnterBeep = True
        Me.TbNombre1.Size = New System.Drawing.Size(232, 34)
        Me.TbNombre1.TabIndex = 246
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(3, 115)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(90, 23)
        Me.LabelX8.TabIndex = 245
        Me.LabelX8.Text = "Nit:"
        '
        'tbCodigoControl
        '
        Me.tbCodigoControl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbCodigoControl.Border.Class = "TextBoxBorder"
        Me.tbCodigoControl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoControl.DisabledBackColor = System.Drawing.Color.White
        Me.tbCodigoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoControl.ForeColor = System.Drawing.Color.Black
        Me.tbCodigoControl.Location = New System.Drawing.Point(139, 81)
        Me.tbCodigoControl.Name = "tbCodigoControl"
        Me.tbCodigoControl.PreventEnterBeep = True
        Me.tbCodigoControl.Size = New System.Drawing.Size(120, 22)
        Me.tbCodigoControl.TabIndex = 243
        Me.tbCodigoControl.TabStop = False
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX16.Location = New System.Drawing.Point(3, 80)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX16.Size = New System.Drawing.Size(130, 23)
        Me.LabelX16.TabIndex = 242
        Me.LabelX16.Text = "Código de Control:"
        '
        'dtiFechaFactura
        '
        '
        '
        '
        Me.dtiFechaFactura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaFactura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaFactura.ButtonDropDown.Visible = True
        Me.dtiFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiFechaFactura.IsPopupCalendarOpen = False
        Me.dtiFechaFactura.Location = New System.Drawing.Point(139, 26)
        '
        '
        '
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaFactura.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.dtiFechaFactura.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaFactura.Name = "dtiFechaFactura"
        Me.dtiFechaFactura.Size = New System.Drawing.Size(120, 22)
        Me.dtiFechaFactura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaFactura.TabIndex = 241
        Me.dtiFechaFactura.TabStop = False
        '
        'tbNroFactura
        '
        Me.tbNroFactura.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbNroFactura.Border.Class = "TextBoxBorder"
        Me.tbNroFactura.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroFactura.DisabledBackColor = System.Drawing.Color.White
        Me.tbNroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroFactura.ForeColor = System.Drawing.Color.Black
        Me.tbNroFactura.Location = New System.Drawing.Point(139, 53)
        Me.tbNroFactura.Name = "tbNroFactura"
        Me.tbNroFactura.PreventEnterBeep = True
        Me.tbNroFactura.Size = New System.Drawing.Size(120, 22)
        Me.tbNroFactura.TabIndex = 240
        Me.tbNroFactura.TabStop = False
        Me.tbNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNroAutoriz
        '
        Me.tbNroAutoriz.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbNroAutoriz.Border.Class = "TextBoxBorder"
        Me.tbNroAutoriz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroAutoriz.DisabledBackColor = System.Drawing.Color.White
        Me.tbNroAutoriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroAutoriz.ForeColor = System.Drawing.Color.Black
        Me.tbNroAutoriz.Location = New System.Drawing.Point(139, 1)
        Me.tbNroAutoriz.Name = "tbNroAutoriz"
        Me.tbNroAutoriz.PreventEnterBeep = True
        Me.tbNroAutoriz.Size = New System.Drawing.Size(200, 22)
        Me.tbNroAutoriz.TabIndex = 239
        Me.tbNroAutoriz.TabStop = False
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX15.Location = New System.Drawing.Point(3, 52)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX15.Size = New System.Drawing.Size(130, 23)
        Me.LabelX15.TabIndex = 237
        Me.LabelX15.Text = "Nro. Factura:"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX14.Location = New System.Drawing.Point(3, 26)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX14.Size = New System.Drawing.Size(130, 23)
        Me.LabelX14.TabIndex = 233
        Me.LabelX14.Text = "Fecha Factura:"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(3, 0)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX7.Size = New System.Drawing.Size(130, 23)
        Me.LabelX7.TabIndex = 232
        Me.LabelX7.Text = "Nro de Autorización:"
        '
        'lbVencCredito
        '
        Me.lbVencCredito.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVencCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVencCredito.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVencCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbVencCredito.Location = New System.Drawing.Point(491, 106)
        Me.lbVencCredito.Name = "lbVencCredito"
        Me.lbVencCredito.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbVencCredito.Size = New System.Drawing.Size(109, 23)
        Me.lbVencCredito.TabIndex = 233
        Me.lbVencCredito.Text = "Venc. de Crédito:"
        Me.lbVencCredito.Visible = False
        '
        'lbTipoVenta
        '
        Me.lbTipoVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTipoVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTipoVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTipoVenta.Location = New System.Drawing.Point(491, 74)
        Me.lbTipoVenta.Name = "lbTipoVenta"
        Me.lbTipoVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTipoVenta.Size = New System.Drawing.Size(85, 23)
        Me.lbTipoVenta.TabIndex = 232
        Me.lbTipoVenta.Text = "Tipo Venta:"
        '
        'lbFVenta
        '
        Me.lbFVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFVenta.Location = New System.Drawing.Point(491, 11)
        Me.lbFVenta.Name = "lbFVenta"
        Me.lbFVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFVenta.Size = New System.Drawing.Size(88, 23)
        Me.lbFVenta.TabIndex = 231
        Me.lbFVenta.Text = "Fecha Venta:"
        '
        'lbIdVenta
        '
        Me.lbIdVenta.AutoSize = True
        Me.lbIdVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdVenta.Location = New System.Drawing.Point(13, 13)
        Me.lbIdVenta.Name = "lbIdVenta"
        Me.lbIdVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdVenta.Size = New System.Drawing.Size(59, 16)
        Me.lbIdVenta.TabIndex = 224
        Me.lbIdVenta.Text = "Id Venta:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObservacion.Border.Class = "TextBoxBorder"
        Me.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Black
        Me.txtObservacion.Location = New System.Drawing.Point(606, 142)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PreventEnterBeep = True
        Me.txtObservacion.Size = New System.Drawing.Size(292, 47)
        Me.txtObservacion.TabIndex = 22
        '
        'lbVendedor
        '
        Me.lbVendedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVendedor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbVendedor.Location = New System.Drawing.Point(13, 136)
        Me.lbVendedor.Name = "lbVendedor"
        Me.lbVendedor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbVendedor.Size = New System.Drawing.Size(70, 23)
        Me.lbVendedor.TabIndex = 227
        Me.lbVendedor.Text = "Vendedor:"
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
        Me.lbObservacion.Location = New System.Drawing.Point(491, 136)
        Me.lbObservacion.Name = "lbObservacion"
        Me.lbObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbObservacion.Size = New System.Drawing.Size(92, 23)
        Me.lbObservacion.TabIndex = 226
        Me.lbObservacion.Text = "Observacion:"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCliente.Border.Class = "TextBoxBorder"
        Me.txtCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Black
        Me.txtCliente.Location = New System.Drawing.Point(158, 103)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PreventEnterBeep = True
        Me.txtCliente.Size = New System.Drawing.Size(299, 22)
        Me.txtCliente.TabIndex = 1
        '
        'lbCliente
        '
        Me.lbCliente.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCliente.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCliente.Location = New System.Drawing.Point(12, 102)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCliente.Size = New System.Drawing.Size(67, 23)
        Me.lbCliente.TabIndex = 225
        Me.lbCliente.Text = "Paciente:"
        '
        'PanelDetalle
        '
        Me.PanelDetalle.BackColor = System.Drawing.Color.White
        Me.PanelDetalle.Controls.Add(Me.gpDetalleVenta)
        Me.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalle.Location = New System.Drawing.Point(0, 220)
        Me.PanelDetalle.Name = "PanelDetalle"
        Me.PanelDetalle.Size = New System.Drawing.Size(1334, 314)
        Me.PanelDetalle.TabIndex = 2
        '
        'gpDetalleVenta
        '
        Me.gpDetalleVenta.BackColor = System.Drawing.Color.White
        Me.gpDetalleVenta.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDetalleVenta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDetalleVenta.Controls.Add(Me.Panel5)
        Me.gpDetalleVenta.Controls.Add(Me.panelResultados)
        Me.gpDetalleVenta.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDetalleVenta.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.gpDetalleVenta.Name = "gpDetalleVenta"
        Me.gpDetalleVenta.Size = New System.Drawing.Size(1334, 314)
        '
        '
        '
        Me.gpDetalleVenta.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BackColorGradientAngle = 90
        Me.gpDetalleVenta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderBottomWidth = 1
        Me.gpDetalleVenta.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderLeftWidth = 1
        Me.gpDetalleVenta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderRightWidth = 1
        Me.gpDetalleVenta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderTopWidth = 1
        Me.gpDetalleVenta.Style.CornerDiameter = 4
        Me.gpDetalleVenta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDetalleVenta.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleVenta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDetalleVenta.Style.TextColor = System.Drawing.Color.White
        Me.gpDetalleVenta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDetalleVenta.TabIndex = 1
        Me.gpDetalleVenta.Text = "DETALLE DE LA VENTA"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.GPanelProductos)
        Me.Panel5.Controls.Add(Me.JGdetalleVenta)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1096, 291)
        Me.Panel5.TabIndex = 0
        '
        'GPanelProductos
        '
        Me.GPanelProductos.BackColor = System.Drawing.Color.White
        Me.GPanelProductos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPanelProductos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPanelProductos.Controls.Add(Me.Panel7)
        Me.GPanelProductos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPanelProductos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPanelProductos.Location = New System.Drawing.Point(9, 88)
        Me.GPanelProductos.Name = "GPanelProductos"
        Me.GPanelProductos.Size = New System.Drawing.Size(1084, 215)
        '
        '
        '
        Me.GPanelProductos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GPanelProductos.Style.BackColorGradientAngle = 90
        Me.GPanelProductos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GPanelProductos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderBottomWidth = 1
        Me.GPanelProductos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPanelProductos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderLeftWidth = 1
        Me.GPanelProductos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderRightWidth = 1
        Me.GPanelProductos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderTopWidth = 1
        Me.GPanelProductos.Style.CornerDiameter = 4
        Me.GPanelProductos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPanelProductos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPanelProductos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPanelProductos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPanelProductos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPanelProductos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPanelProductos.TabIndex = 4
        Me.GPanelProductos.Text = "PRODUCTOS"
        Me.GPanelProductos.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.JGProductos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1078, 192)
        Me.Panel7.TabIndex = 0
        '
        'JGProductos
        '
        Me.JGProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGProductos.BackColor = System.Drawing.Color.GhostWhite
        Me.JGProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGProductos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGProductos.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGProductos.Location = New System.Drawing.Point(0, 0)
        Me.JGProductos.Name = "JGProductos"
        Me.JGProductos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGProductos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGProductos.Size = New System.Drawing.Size(1078, 192)
        Me.JGProductos.TabIndex = 0
        Me.JGProductos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'JGdetalleVenta
        '
        Me.JGdetalleVenta.BackColor = System.Drawing.Color.GhostWhite
        Me.JGdetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGdetalleVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGdetalleVenta.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGdetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.JGdetalleVenta.Name = "JGdetalleVenta"
        Me.JGdetalleVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGdetalleVenta.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGdetalleVenta.Size = New System.Drawing.Size(1096, 291)
        Me.JGdetalleVenta.TabIndex = 0
        Me.JGdetalleVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'panelResultados
        '
        Me.panelResultados.BackColor = System.Drawing.Color.Transparent
        Me.panelResultados.Controls.Add(Me.txtPDesc)
        Me.panelResultados.Controls.Add(Me.LabelX1)
        Me.panelResultados.Controls.Add(Me.txtCambio)
        Me.panelResultados.Controls.Add(Me.txtMontoPagado)
        Me.panelResultados.Controls.Add(Me.txtSaldo)
        Me.panelResultados.Controls.Add(Me.txtAcuenta)
        Me.panelResultados.Controls.Add(Me.txtTotalNeto)
        Me.panelResultados.Controls.Add(Me.txtMdesc)
        Me.panelResultados.Controls.Add(Me.txtSubTotal)
        Me.panelResultados.Controls.Add(Me.lbCambio)
        Me.panelResultados.Controls.Add(Me.lbMontoPagado)
        Me.panelResultados.Controls.Add(Me.lbSaldo)
        Me.panelResultados.Controls.Add(Me.lbAcuenta)
        Me.panelResultados.Controls.Add(Me.lbSubTotal)
        Me.panelResultados.Controls.Add(Me.lbTotalNeto)
        Me.panelResultados.Controls.Add(Me.lbMdesc)
        Me.panelResultados.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelResultados.Location = New System.Drawing.Point(1096, 0)
        Me.panelResultados.Name = "panelResultados"
        Me.panelResultados.Size = New System.Drawing.Size(232, 291)
        Me.panelResultados.TabIndex = 39
        '
        'txtPDesc
        '
        '
        '
        '
        Me.txtPDesc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtPDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPDesc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtPDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDesc.Increment = 1.0R
        Me.txtPDesc.Location = New System.Drawing.Point(127, 157)
        Me.txtPDesc.LockUpdateChecked = False
        Me.txtPDesc.MinValue = 0R
        Me.txtPDesc.Name = "txtPDesc"
        Me.txtPDesc.Size = New System.Drawing.Size(89, 21)
        Me.txtPDesc.TabIndex = 59
        Me.txtPDesc.Visible = False
        Me.txtPDesc.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(20, 162)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(86, 18)
        Me.LabelX1.TabIndex = 58
        Me.LabelX1.Text = "P. Descuento:"
        Me.LabelX1.Visible = False
        '
        'txtCambio
        '
        '
        '
        '
        Me.txtCambio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCambio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio.Increment = 1.0R
        Me.txtCambio.Location = New System.Drawing.Point(127, 251)
        Me.txtCambio.LockUpdateChecked = False
        Me.txtCambio.MinValue = 0R
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(89, 21)
        Me.txtCambio.TabIndex = 57
        Me.txtCambio.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtMontoPagado
        '
        '
        '
        '
        Me.txtMontoPagado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMontoPagado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtMontoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagado.Increment = 1.0R
        Me.txtMontoPagado.Location = New System.Drawing.Point(127, 223)
        Me.txtMontoPagado.LockUpdateChecked = False
        Me.txtMontoPagado.MinValue = 0R
        Me.txtMontoPagado.Name = "txtMontoPagado"
        Me.txtMontoPagado.Size = New System.Drawing.Size(89, 21)
        Me.txtMontoPagado.TabIndex = 56
        Me.txtMontoPagado.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtSaldo
        '
        '
        '
        '
        Me.txtSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Increment = 1.0R
        Me.txtSaldo.Location = New System.Drawing.Point(127, 123)
        Me.txtSaldo.LockUpdateChecked = False
        Me.txtSaldo.MinValue = 0R
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(89, 21)
        Me.txtSaldo.TabIndex = 55
        Me.txtSaldo.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtAcuenta
        '
        '
        '
        '
        Me.txtAcuenta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAcuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAcuenta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcuenta.Increment = 1.0R
        Me.txtAcuenta.Location = New System.Drawing.Point(127, 96)
        Me.txtAcuenta.LockUpdateChecked = False
        Me.txtAcuenta.MinValue = 0R
        Me.txtAcuenta.Name = "txtAcuenta"
        Me.txtAcuenta.Size = New System.Drawing.Size(89, 21)
        Me.txtAcuenta.TabIndex = 54
        Me.txtAcuenta.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtTotalNeto
        '
        '
        '
        '
        Me.txtTotalNeto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotalNeto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalNeto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotalNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNeto.Increment = 1.0R
        Me.txtTotalNeto.Location = New System.Drawing.Point(127, 69)
        Me.txtTotalNeto.LockUpdateChecked = False
        Me.txtTotalNeto.MinValue = 0R
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.Size = New System.Drawing.Size(89, 21)
        Me.txtTotalNeto.TabIndex = 53
        Me.txtTotalNeto.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtMdesc
        '
        '
        '
        '
        Me.txtMdesc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtMdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMdesc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtMdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdesc.Increment = 1.0R
        Me.txtMdesc.Location = New System.Drawing.Point(127, 41)
        Me.txtMdesc.LockUpdateChecked = False
        Me.txtMdesc.MinValue = 0R
        Me.txtMdesc.Name = "txtMdesc"
        Me.txtMdesc.Size = New System.Drawing.Size(89, 21)
        Me.txtMdesc.TabIndex = 52
        Me.txtMdesc.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtSubTotal
        '
        '
        '
        '
        Me.txtSubTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSubTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSubTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Increment = 1.0R
        Me.txtSubTotal.Location = New System.Drawing.Point(127, 13)
        Me.txtSubTotal.LockUpdateChecked = False
        Me.txtSubTotal.MinValue = 0R
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(89, 21)
        Me.txtSubTotal.TabIndex = 51
        Me.txtSubTotal.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbCambio
        '
        Me.lbCambio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCambio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCambio.ForeColor = System.Drawing.Color.White
        Me.lbCambio.Location = New System.Drawing.Point(20, 251)
        Me.lbCambio.Name = "lbCambio"
        Me.lbCambio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCambio.Size = New System.Drawing.Size(65, 18)
        Me.lbCambio.TabIndex = 50
        Me.lbCambio.Text = "Cambio:"
        '
        'lbMontoPagado
        '
        Me.lbMontoPagado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMontoPagado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoPagado.ForeColor = System.Drawing.Color.White
        Me.lbMontoPagado.Location = New System.Drawing.Point(20, 227)
        Me.lbMontoPagado.Name = "lbMontoPagado"
        Me.lbMontoPagado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMontoPagado.Size = New System.Drawing.Size(101, 18)
        Me.lbMontoPagado.TabIndex = 48
        Me.lbMontoPagado.Text = "Monto Pagado:"
        '
        'lbSaldo
        '
        Me.lbSaldo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSaldo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.ForeColor = System.Drawing.Color.White
        Me.lbSaldo.Location = New System.Drawing.Point(21, 125)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSaldo.Size = New System.Drawing.Size(75, 18)
        Me.lbSaldo.TabIndex = 46
        Me.lbSaldo.Text = "Saldo:"
        '
        'lbAcuenta
        '
        Me.lbAcuenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbAcuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbAcuenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAcuenta.ForeColor = System.Drawing.Color.White
        Me.lbAcuenta.Location = New System.Drawing.Point(21, 100)
        Me.lbAcuenta.Name = "lbAcuenta"
        Me.lbAcuenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbAcuenta.Size = New System.Drawing.Size(75, 18)
        Me.lbAcuenta.TabIndex = 44
        Me.lbAcuenta.Text = "A cuenta:"
        '
        'lbSubTotal
        '
        Me.lbSubTotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSubTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSubTotal.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTotal.ForeColor = System.Drawing.Color.White
        Me.lbSubTotal.Location = New System.Drawing.Point(20, 18)
        Me.lbSubTotal.Name = "lbSubTotal"
        Me.lbSubTotal.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSubTotal.Size = New System.Drawing.Size(86, 18)
        Me.lbSubTotal.TabIndex = 42
        Me.lbSubTotal.Text = "Sub Total:"
        '
        'lbTotalNeto
        '
        Me.lbTotalNeto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTotalNeto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTotalNeto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalNeto.ForeColor = System.Drawing.Color.White
        Me.lbTotalNeto.Location = New System.Drawing.Point(21, 72)
        Me.lbTotalNeto.Name = "lbTotalNeto"
        Me.lbTotalNeto.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTotalNeto.Size = New System.Drawing.Size(75, 18)
        Me.lbTotalNeto.TabIndex = 38
        Me.lbTotalNeto.Text = "Total Neto:"
        '
        'lbMdesc
        '
        Me.lbMdesc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMdesc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMdesc.ForeColor = System.Drawing.Color.White
        Me.lbMdesc.Location = New System.Drawing.Point(21, 45)
        Me.lbMdesc.Name = "lbMdesc"
        Me.lbMdesc.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMdesc.Size = New System.Drawing.Size(101, 18)
        Me.lbMdesc.TabIndex = 36
        Me.lbMdesc.Text = "M. Descuento:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel6)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(930, 477)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 4
        Me.GroupPanel2.Text = "BUSCADOR  VENTAS"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.grVentas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(924, 454)
        Me.Panel6.TabIndex = 0
        '
        'grVentas
        '
        Me.grVentas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grVentas.BackColor = System.Drawing.Color.GhostWhite
        Me.grVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVentas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grVentas.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grVentas.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.grVentas.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grVentas.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grVentas.Location = New System.Drawing.Point(0, 0)
        Me.grVentas.Name = "grVentas"
        Me.grVentas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grVentas.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grVentas.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grVentas.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grVentas.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grVentas.SelectOnExpand = False
        Me.grVentas.Size = New System.Drawing.Size(924, 454)
        Me.grVentas.TabIndex = 0
        Me.grVentas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Controls.Add(Me.btnImprimir)
        Me.PanelToolBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelToolBar2.Location = New System.Drawing.Point(1254, 0)
        Me.PanelToolBar2.Name = "PanelToolBar2"
        Me.PanelToolBar2.Size = New System.Drawing.Size(80, 72)
        Me.PanelToolBar2.TabIndex = 7
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
        '
        'swMostrar
        '
        '
        '
        '
        Me.swMostrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swMostrar.Location = New System.Drawing.Point(476, 25)
        Me.swMostrar.Name = "swMostrar"
        Me.swMostrar.OffBackColor = System.Drawing.Color.Gold
        Me.swMostrar.OffText = "MOSTRAR ÚLT. 300"
        Me.swMostrar.OnBackColor = System.Drawing.Color.ForestGreen
        Me.swMostrar.OnText = "MOSTRAR TODOS"
        Me.swMostrar.Size = New System.Drawing.Size(190, 22)
        Me.swMostrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swMostrar.TabIndex = 424
        '
        'F1_Ven_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1334, 670)
        Me.Name = "F1_Ven_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA"
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
        Me.PanelContentSup.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelFactura2.ResumeLayout(False)
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtiFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalle.ResumeLayout(False)
        Me.gpDetalleVenta.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GPanelProductos.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.JGProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGdetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResultados.ResumeLayout(False)
        CType(Me.txtPDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContentSup As Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtIdVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdVenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanelFactura2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbCodigoControl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiFechaFactura As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbNroFactura As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbNroAutoriz As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbVencCredito As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTipoVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbFVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbVendedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbCliente As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelDetalle As Panel
    Friend WithEvents gpDetalleVenta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents JGdetalleVenta As Janus.Windows.GridEX.GridEX
    Friend WithEvents panelResultados As Panel
    Friend WithEvents lbSubTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTotalNeto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMdesc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdReciboV As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbIdRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFCredito As DateTimePicker
    Friend WithEvents dtpFVenta As DateTimePicker
    Friend WithEvents lbCambio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMontoPagado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbSaldo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbAcuenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents swServicio As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbServicio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents grVentas As Janus.Windows.GridEX.GridEX
    Friend WithEvents GPanelProductos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents JGProductos As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtTotalNeto As DevComponents.Editors.DoubleInput
    Friend WithEvents txtMdesc As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSubTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents txtAcuenta As DevComponents.Editors.DoubleInput
    Friend WithEvents txtCambio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtMontoPagado As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSaldo As DevComponents.Editors.DoubleInput
    Friend WithEvents txtPDesc As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbSucursal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Protected WithEvents PanelToolBar2 As Panel
    Protected WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbCtrlEnter As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdPaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swCirugia As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swInternacion As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTipoVenta As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbEmision As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents TbNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbNombre1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents QrFactura As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents swMostrar As DevComponents.DotNetBar.Controls.SwitchButton
End Class
