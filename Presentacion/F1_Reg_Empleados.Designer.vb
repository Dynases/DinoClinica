<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Reg_Empleados
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
        Dim cbTipoEmpleado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Reg_Empleados))
        Me.GPDatosGral = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTipoEmpleado = New DevComponents.DotNetBar.ButtonX()
        Me.cbTipoEmpleado = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbTipoEmpleado = New DevComponents.DotNetBar.LabelX()
        Me.txtCIEmpleado = New DevComponents.Editors.IntegerInput()
        Me.txtNombApellE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbNombre = New DevComponents.DotNetBar.LabelX()
        Me.txtCelE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdEmpleado = New DevComponents.DotNetBar.LabelX()
        Me.txtDireccionE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbMail = New DevComponents.DotNetBar.LabelX()
        Me.lbDirección = New DevComponents.DotNetBar.LabelX()
        Me.txtMailE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbCelular = New DevComponents.DotNetBar.LabelX()
        Me.lbCi = New DevComponents.DotNetBar.LabelX()
        Me.txtIdEmpleado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbFechaIngr = New DevComponents.DotNetBar.LabelX()
        Me.dtpFIngresoE = New System.Windows.Forms.DateTimePicker()
        Me.lbFNac = New DevComponents.DotNetBar.LabelX()
        Me.dtpFnacE = New System.Windows.Forms.DateTimePicker()
        Me.swEstadoE = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gpBusqEmpleados = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGBusqEmpleados = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SuperTabControl2 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtAdicionar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
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
        Me.GPDatosGral.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cbTipoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCIEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gpBusqEmpleados.SuspendLayout()
        CType(Me.JGBusqEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl2.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.GroupPanel3)
        Me.MpanelSuperior.Controls.Add(Me.gpBusqEmpleados)
        Me.MpanelSuperior.Controls.Add(Me.GroupPanel2)
        Me.MpanelSuperior.Controls.Add(Me.GPDatosGral)
        Me.MpanelSuperior.Size = New System.Drawing.Size(961, 507)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(967, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 582)
        Me.PanelInferior.Size = New System.Drawing.Size(967, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(767, 0)
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
        Me.MpanelBuscador.Size = New System.Drawing.Size(967, 621)
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
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(967, 646)
        '
        'GPDatosGral
        '
        Me.GPDatosGral.BackColor = System.Drawing.Color.White
        Me.GPDatosGral.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPDatosGral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPDatosGral.Controls.Add(Me.Panel2)
        Me.GPDatosGral.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPDatosGral.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPDatosGral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GPDatosGral.Location = New System.Drawing.Point(5, 6)
        Me.GPDatosGral.Name = "GPDatosGral"
        Me.GPDatosGral.Size = New System.Drawing.Size(402, 240)
        '
        '
        '
        Me.GPDatosGral.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GPDatosGral.Style.BackColorGradientAngle = 90
        Me.GPDatosGral.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.GPDatosGral.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDatosGral.Style.BorderBottomWidth = 1
        Me.GPDatosGral.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GPDatosGral.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDatosGral.Style.BorderLeftWidth = 1
        Me.GPDatosGral.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDatosGral.Style.BorderRightWidth = 1
        Me.GPDatosGral.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPDatosGral.Style.BorderTopWidth = 1
        Me.GPDatosGral.Style.CornerDiameter = 4
        Me.GPDatosGral.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPDatosGral.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPDatosGral.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GPDatosGral.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPDatosGral.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPDatosGral.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPDatosGral.TabIndex = 1
        Me.GPDatosGral.Text = "DATOS PERSONAL"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btnTipoEmpleado)
        Me.Panel2.Controls.Add(Me.cbTipoEmpleado)
        Me.Panel2.Controls.Add(Me.lbTipoEmpleado)
        Me.Panel2.Controls.Add(Me.txtCIEmpleado)
        Me.Panel2.Controls.Add(Me.txtNombApellE)
        Me.Panel2.Controls.Add(Me.lbNombre)
        Me.Panel2.Controls.Add(Me.txtCelE)
        Me.Panel2.Controls.Add(Me.lbIdEmpleado)
        Me.Panel2.Controls.Add(Me.txtDireccionE)
        Me.Panel2.Controls.Add(Me.lbMail)
        Me.Panel2.Controls.Add(Me.lbDirección)
        Me.Panel2.Controls.Add(Me.txtMailE)
        Me.Panel2.Controls.Add(Me.lbCelular)
        Me.Panel2.Controls.Add(Me.lbCi)
        Me.Panel2.Controls.Add(Me.txtIdEmpleado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 217)
        Me.Panel2.TabIndex = 234
        '
        'btnTipoEmpleado
        '
        Me.btnTipoEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTipoEmpleado.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnTipoEmpleado.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnTipoEmpleado.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnTipoEmpleado.Location = New System.Drawing.Point(257, 36)
        Me.btnTipoEmpleado.Name = "btnTipoEmpleado"
        Me.btnTipoEmpleado.Size = New System.Drawing.Size(28, 29)
        Me.btnTipoEmpleado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTipoEmpleado.TabIndex = 328
        Me.btnTipoEmpleado.Visible = False
        '
        'cbTipoEmpleado
        '
        cbTipoEmpleado_DesignTimeLayout.LayoutString = resources.GetString("cbTipoEmpleado_DesignTimeLayout.LayoutString")
        Me.cbTipoEmpleado.DesignTimeLayout = cbTipoEmpleado_DesignTimeLayout
        Me.cbTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoEmpleado.Location = New System.Drawing.Point(138, 40)
        Me.cbTipoEmpleado.Name = "cbTipoEmpleado"
        Me.cbTipoEmpleado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoEmpleado.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoEmpleado.SelectedIndex = -1
        Me.cbTipoEmpleado.SelectedItem = Nothing
        Me.cbTipoEmpleado.Size = New System.Drawing.Size(113, 22)
        Me.cbTipoEmpleado.TabIndex = 1
        Me.cbTipoEmpleado.Tag = "1"
        Me.cbTipoEmpleado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbTipoEmpleado
        '
        Me.lbTipoEmpleado.AutoSize = True
        Me.lbTipoEmpleado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTipoEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTipoEmpleado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTipoEmpleado.Location = New System.Drawing.Point(4, 43)
        Me.lbTipoEmpleado.Name = "lbTipoEmpleado"
        Me.lbTipoEmpleado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTipoEmpleado.Size = New System.Drawing.Size(93, 16)
        Me.lbTipoEmpleado.TabIndex = 327
        Me.lbTipoEmpleado.Text = "Tipo Personal:"
        '
        'txtCIEmpleado
        '
        '
        '
        '
        Me.txtCIEmpleado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtCIEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCIEmpleado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtCIEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIEmpleado.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtCIEmpleado.Location = New System.Drawing.Point(138, 68)
        Me.txtCIEmpleado.Name = "txtCIEmpleado"
        Me.txtCIEmpleado.Size = New System.Drawing.Size(113, 21)
        Me.txtCIEmpleado.TabIndex = 2
        '
        'txtNombApellE
        '
        Me.txtNombApellE.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombApellE.Border.Class = "TextBoxBorder"
        Me.txtNombApellE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombApellE.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombApellE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombApellE.ForeColor = System.Drawing.Color.Black
        Me.txtNombApellE.Location = New System.Drawing.Point(138, 93)
        Me.txtNombApellE.MaxLength = 50
        Me.txtNombApellE.Multiline = True
        Me.txtNombApellE.Name = "txtNombApellE"
        Me.txtNombApellE.PreventEnterBeep = True
        Me.txtNombApellE.Size = New System.Drawing.Size(248, 24)
        Me.txtNombApellE.TabIndex = 3
        '
        'lbNombre
        '
        Me.lbNombre.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbNombre.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbNombre.Location = New System.Drawing.Point(3, 94)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbNombre.Size = New System.Drawing.Size(133, 23)
        Me.lbNombre.TabIndex = 249
        Me.lbNombre.Text = "Nombre y Apellidos:"
        '
        'txtCelE
        '
        Me.txtCelE.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCelE.Border.Class = "TextBoxBorder"
        Me.txtCelE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCelE.DisabledBackColor = System.Drawing.Color.White
        Me.txtCelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelE.ForeColor = System.Drawing.Color.Black
        Me.txtCelE.Location = New System.Drawing.Point(138, 153)
        Me.txtCelE.MaxLength = 30
        Me.txtCelE.Name = "txtCelE"
        Me.txtCelE.PreventEnterBeep = True
        Me.txtCelE.Size = New System.Drawing.Size(248, 22)
        Me.txtCelE.TabIndex = 5
        '
        'lbIdEmpleado
        '
        Me.lbIdEmpleado.AutoSize = True
        Me.lbIdEmpleado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdEmpleado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdEmpleado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdEmpleado.Location = New System.Drawing.Point(3, 14)
        Me.lbIdEmpleado.Name = "lbIdEmpleado"
        Me.lbIdEmpleado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdEmpleado.Size = New System.Drawing.Size(67, 16)
        Me.lbIdEmpleado.TabIndex = 224
        Me.lbIdEmpleado.Text = "Id Cliente:"
        '
        'txtDireccionE
        '
        Me.txtDireccionE.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDireccionE.Border.Class = "TextBoxBorder"
        Me.txtDireccionE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDireccionE.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccionE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionE.ForeColor = System.Drawing.Color.Black
        Me.txtDireccionE.Location = New System.Drawing.Point(138, 122)
        Me.txtDireccionE.MaxLength = 150
        Me.txtDireccionE.Multiline = True
        Me.txtDireccionE.Name = "txtDireccionE"
        Me.txtDireccionE.PreventEnterBeep = True
        Me.txtDireccionE.Size = New System.Drawing.Size(248, 24)
        Me.txtDireccionE.TabIndex = 4
        '
        'lbMail
        '
        Me.lbMail.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMail.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMail.Location = New System.Drawing.Point(6, 181)
        Me.lbMail.Name = "lbMail"
        Me.lbMail.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMail.Size = New System.Drawing.Size(65, 23)
        Me.lbMail.TabIndex = 227
        Me.lbMail.Text = "E-mail:"
        '
        'lbDirección
        '
        Me.lbDirección.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDirección.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDirección.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDirección.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDirección.Location = New System.Drawing.Point(4, 121)
        Me.lbDirección.Name = "lbDirección"
        Me.lbDirección.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDirección.Size = New System.Drawing.Size(80, 23)
        Me.lbDirección.TabIndex = 226
        Me.lbDirección.Text = "Dirección:"
        '
        'txtMailE
        '
        Me.txtMailE.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMailE.Border.Class = "TextBoxBorder"
        Me.txtMailE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMailE.DisabledBackColor = System.Drawing.Color.White
        Me.txtMailE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailE.ForeColor = System.Drawing.Color.Black
        Me.txtMailE.Location = New System.Drawing.Point(138, 182)
        Me.txtMailE.MaxLength = 50
        Me.txtMailE.Name = "txtMailE"
        Me.txtMailE.PreventEnterBeep = True
        Me.txtMailE.Size = New System.Drawing.Size(248, 22)
        Me.txtMailE.TabIndex = 6
        '
        'lbCelular
        '
        Me.lbCelular.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCelular.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCelular.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCelular.Location = New System.Drawing.Point(4, 153)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCelular.Size = New System.Drawing.Size(67, 23)
        Me.lbCelular.TabIndex = 229
        Me.lbCelular.Text = "Celular :"
        '
        'lbCi
        '
        Me.lbCi.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCi.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCi.Location = New System.Drawing.Point(3, 68)
        Me.lbCi.Name = "lbCi"
        Me.lbCi.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCi.Size = New System.Drawing.Size(68, 23)
        Me.lbCi.TabIndex = 225
        Me.lbCi.Text = "CI:"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdEmpleado.Border.Class = "TextBoxBorder"
        Me.txtIdEmpleado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdEmpleado.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEmpleado.ForeColor = System.Drawing.Color.Black
        Me.txtIdEmpleado.Location = New System.Drawing.Point(138, 12)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.PreventEnterBeep = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(70, 22)
        Me.txtIdEmpleado.TabIndex = 0
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
        Me.lbFechaIngr.Location = New System.Drawing.Point(8, 58)
        Me.lbFechaIngr.Name = "lbFechaIngr"
        Me.lbFechaIngr.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaIngr.Size = New System.Drawing.Size(66, 16)
        Me.lbFechaIngr.TabIndex = 245
        Me.lbFechaIngr.Text = "F.Ingreso:"
        '
        'dtpFIngresoE
        '
        Me.dtpFIngresoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFIngresoE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFIngresoE.Location = New System.Drawing.Point(116, 55)
        Me.dtpFIngresoE.Name = "dtpFIngresoE"
        Me.dtpFIngresoE.Size = New System.Drawing.Size(136, 22)
        Me.dtpFIngresoE.TabIndex = 8
        Me.dtpFIngresoE.TabStop = False
        '
        'lbFNac
        '
        Me.lbFNac.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFNac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFNac.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFNac.Location = New System.Drawing.Point(8, 12)
        Me.lbFNac.Name = "lbFNac"
        Me.lbFNac.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFNac.Size = New System.Drawing.Size(93, 23)
        Me.lbFNac.TabIndex = 254
        Me.lbFNac.Text = "F.Nacimiento:"
        '
        'dtpFnacE
        '
        Me.dtpFnacE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFnacE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFnacE.Location = New System.Drawing.Point(116, 12)
        Me.dtpFnacE.Name = "dtpFnacE"
        Me.dtpFnacE.Size = New System.Drawing.Size(136, 22)
        Me.dtpFnacE.TabIndex = 7
        '
        'swEstadoE
        '
        Me.swEstadoE.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.swEstadoE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoE.Location = New System.Drawing.Point(116, 98)
        Me.swEstadoE.Name = "swEstadoE"
        Me.swEstadoE.OffBackColor = System.Drawing.Color.Gray
        Me.swEstadoE.OffText = "PASIVO"
        Me.swEstadoE.OffTextColor = System.Drawing.Color.White
        Me.swEstadoE.OnBackColor = System.Drawing.Color.Green
        Me.swEstadoE.OnText = "ACTIVO"
        Me.swEstadoE.OnTextColor = System.Drawing.Color.White
        Me.swEstadoE.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoE.SwitchBackColor = System.Drawing.Color.Gainsboro
        Me.swEstadoE.SwitchBorderColor = System.Drawing.Color.Black
        Me.swEstadoE.TabIndex = 9
        Me.swEstadoE.Value = True
        Me.swEstadoE.ValueObject = "Y"
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
        Me.lbEstado.Location = New System.Drawing.Point(8, 98)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(79, 23)
        Me.lbEstado.TabIndex = 253
        Me.lbEstado.Text = "Estado:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(413, 7)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(273, 239)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedShadow
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 229
        Me.GroupPanel2.Text = "DATOS COMPLEMENTARIOS"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.lbFechaIngr)
        Me.Panel4.Controls.Add(Me.swEstadoE)
        Me.Panel4.Controls.Add(Me.lbFNac)
        Me.Panel4.Controls.Add(Me.dtpFnacE)
        Me.Panel4.Controls.Add(Me.lbEstado)
        Me.Panel4.Controls.Add(Me.dtpFIngresoE)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 216)
        Me.Panel4.TabIndex = 216
        '
        'gpBusqEmpleados
        '
        Me.gpBusqEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.gpBusqEmpleados.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqEmpleados.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqEmpleados.Controls.Add(Me.JGBusqEmpleados)
        Me.gpBusqEmpleados.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqEmpleados.Location = New System.Drawing.Point(10, 252)
        Me.gpBusqEmpleados.Name = "gpBusqEmpleados"
        Me.gpBusqEmpleados.Size = New System.Drawing.Size(939, 252)
        '
        '
        '
        Me.gpBusqEmpleados.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqEmpleados.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqEmpleados.Style.BackColorGradientAngle = 90
        Me.gpBusqEmpleados.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqEmpleados.Style.BorderBottomWidth = 1
        Me.gpBusqEmpleados.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqEmpleados.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqEmpleados.Style.BorderLeftWidth = 1
        Me.gpBusqEmpleados.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqEmpleados.Style.BorderRightWidth = 1
        Me.gpBusqEmpleados.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqEmpleados.Style.BorderTopWidth = 1
        Me.gpBusqEmpleados.Style.CornerDiameter = 4
        Me.gpBusqEmpleados.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusqEmpleados.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqEmpleados.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusqEmpleados.Style.TextColor = System.Drawing.Color.White
        Me.gpBusqEmpleados.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusqEmpleados.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusqEmpleados.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusqEmpleados.TabIndex = 261
        Me.gpBusqEmpleados.Text = "BÚSQUEDA DE EMPLEADOS"
        '
        'JGBusqEmpleados
        '
        Me.JGBusqEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGBusqEmpleados.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGBusqEmpleados.Location = New System.Drawing.Point(3, 3)
        Me.JGBusqEmpleados.Name = "JGBusqEmpleados"
        Me.JGBusqEmpleados.Size = New System.Drawing.Size(927, 223)
        Me.JGBusqEmpleados.TabIndex = 256
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.White
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.SuperTabControl2)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(692, 6)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(259, 240)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 262
        Me.GroupPanel3.Text = "INFORMACION ADICIONAL"
        '
        'SuperTabControl2
        '
        Me.SuperTabControl2.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl2.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl2.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl2.ControlBox.Name = ""
        Me.SuperTabControl2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl2.ControlBox.MenuBox, Me.SuperTabControl2.ControlBox.CloseBox})
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl2.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl2.Name = "SuperTabControl2"
        Me.SuperTabControl2.ReorderTabsEnabled = True
        Me.SuperTabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl2.SelectedTabIndex = 0
        Me.SuperTabControl2.Size = New System.Drawing.Size(253, 217)
        Me.SuperTabControl2.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl2.TabIndex = 223
        Me.SuperTabControl2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem3})
        Me.SuperTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl2.Text = "SuperTabControl2"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.Panel3)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 23)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(253, 194)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BtAdicionar)
        Me.Panel3.Controls.Add(Me.LabelX15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 194)
        Me.Panel3.TabIndex = 223
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.foto1
        Me.PictureBox1.Location = New System.Drawing.Point(78, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 222
        Me.PictureBox1.TabStop = False
        '
        'BtAdicionar
        '
        Me.BtAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.BtAdicionar.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAdicionar.Image = Global.Presentacion.My.Resources.Resources.adicionar3
        Me.BtAdicionar.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.BtAdicionar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtAdicionar.Location = New System.Drawing.Point(6, 33)
        Me.BtAdicionar.Name = "BtAdicionar"
        Me.BtAdicionar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.BtAdicionar.Size = New System.Drawing.Size(65, 61)
        Me.BtAdicionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BtAdicionar.SubItemsExpandWidth = 10
        Me.BtAdicionar.TabIndex = 1
        Me.BtAdicionar.Text = "Adicionar"
        Me.BtAdicionar.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
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
        Me.LabelX15.Location = New System.Drawing.Point(8, 6)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX15.Size = New System.Drawing.Size(63, 23)
        Me.LabelX15.TabIndex = 221
        Me.LabelX15.Text = "Imagen:"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Imagen"
        '
        'F1_Reg_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 646)
        Me.Name = "F1_Reg_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE PERSONAL"
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
        Me.GPDatosGral.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbTipoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCIEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gpBusqEmpleados.ResumeLayout(False)
        CType(Me.JGBusqEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl2.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GPDatosGral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCIEmpleado As DevComponents.Editors.IntegerInput
    Friend WithEvents txtNombApellE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbIdEmpleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDireccionE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbMail As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbDirección As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMailE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbCelular As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCi As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdEmpleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbFechaIngr As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFIngresoE As DateTimePicker
    Friend WithEvents lbFNac As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFnacE As DateTimePicker
    Friend WithEvents swEstadoE As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnTipoEmpleado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTipoEmpleado As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbTipoEmpleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Protected WithEvents gpBusqEmpleados As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGBusqEmpleados As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl2 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
