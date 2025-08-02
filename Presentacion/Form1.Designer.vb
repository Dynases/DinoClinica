<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim cbgrupo1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim cbUMedida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbgrupo2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbgrupo3_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.intStockMinimo = New DevComponents.Editors.IntegerInput()
        Me.lbStockMin = New DevComponents.DotNetBar.LabelX()
        Me.txtIdProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdProducto = New DevComponents.DotNetBar.LabelX()
        Me.lbDescProducto = New DevComponents.DotNetBar.LabelX()
        Me.txtDescProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swEstadoP = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbgrupo1 = New DevComponents.DotNetBar.LabelX()
        Me.btgrupo3 = New DevComponents.DotNetBar.ButtonX()
        Me.btgrupo4 = New DevComponents.DotNetBar.ButtonX()
        Me.lbgrupo2 = New DevComponents.DotNetBar.LabelX()
        Me.btgrupo2 = New DevComponents.DotNetBar.ButtonX()
        Me.lbgrupo3 = New DevComponents.DotNetBar.LabelX()
        Me.lbUnidadMedida = New DevComponents.DotNetBar.LabelX()
        Me.btgrupo1 = New DevComponents.DotNetBar.ButtonX()
        Me.cbgrupo1 = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbUMedida = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbgrupo2 = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbgrupo3 = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.btUMedida = New DevComponents.DotNetBar.ButtonX()
        Me.JGFichasAtencion = New Janus.Windows.GridEX.GridEX()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavegacion.SuspendLayout()
        Me.MpanelBuscador.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.intStockMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgrupo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgrupo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgrupo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGFichasAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(927, 670)
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.TableLayoutPanel1)
        Me.MpanelSuperior.Size = New System.Drawing.Size(927, 534)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.MpanelSuperior.Controls.SetChildIndex(Me.PanelUsuario, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(927, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 606)
        Me.PanelInferior.Size = New System.Drawing.Size(927, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(727, 0)
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
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Controls.Add(Me.JGFichasAtencion)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 366.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(927, 534)
        Me.TableLayoutPanel1.TabIndex = 229
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(457, 528)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
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
        Me.GroupPanel1.TabIndex = 227
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.intStockMinimo)
        Me.Panel3.Controls.Add(Me.lbStockMin)
        Me.Panel3.Controls.Add(Me.txtIdProducto)
        Me.Panel3.Controls.Add(Me.lbIdProducto)
        Me.Panel3.Controls.Add(Me.lbDescProducto)
        Me.Panel3.Controls.Add(Me.txtDescProducto)
        Me.Panel3.Controls.Add(Me.swEstadoP)
        Me.Panel3.Controls.Add(Me.lbEstado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 505)
        Me.Panel3.TabIndex = 227
        '
        'intStockMinimo
        '
        '
        '
        '
        Me.intStockMinimo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.intStockMinimo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.intStockMinimo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.intStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intStockMinimo.Location = New System.Drawing.Point(198, 122)
        Me.intStockMinimo.Name = "intStockMinimo"
        Me.intStockMinimo.Size = New System.Drawing.Size(126, 21)
        Me.intStockMinimo.TabIndex = 329
        '
        'lbStockMin
        '
        Me.lbStockMin.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbStockMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbStockMin.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStockMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbStockMin.Location = New System.Drawing.Point(38, 120)
        Me.lbStockMin.Name = "lbStockMin"
        Me.lbStockMin.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbStockMin.Size = New System.Drawing.Size(125, 23)
        Me.lbStockMin.TabIndex = 330
        Me.lbStockMin.Text = "Stock Minimo:"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdProducto.Border.Class = "TextBoxBorder"
        Me.txtIdProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdProducto.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.ForeColor = System.Drawing.Color.Black
        Me.txtIdProducto.Location = New System.Drawing.Point(198, 25)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.PreventEnterBeep = True
        Me.txtIdProducto.Size = New System.Drawing.Size(96, 21)
        Me.txtIdProducto.TabIndex = 1
        '
        'lbIdProducto
        '
        Me.lbIdProducto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdProducto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdProducto.Location = New System.Drawing.Point(37, 25)
        Me.lbIdProducto.Name = "lbIdProducto"
        Me.lbIdProducto.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdProducto.Size = New System.Drawing.Size(86, 23)
        Me.lbIdProducto.TabIndex = 23
        Me.lbIdProducto.Text = "Id Producto:"
        '
        'lbDescProducto
        '
        Me.lbDescProducto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDescProducto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDescProducto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDescProducto.Location = New System.Drawing.Point(37, 58)
        Me.lbDescProducto.Name = "lbDescProducto"
        Me.lbDescProducto.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescProducto.Size = New System.Drawing.Size(148, 23)
        Me.lbDescProducto.TabIndex = 25
        Me.lbDescProducto.Text = "Descripción Producto:"
        '
        'txtDescProducto
        '
        Me.txtDescProducto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDescProducto.Border.Class = "TextBoxBorder"
        Me.txtDescProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescProducto.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescProducto.ForeColor = System.Drawing.Color.Black
        Me.txtDescProducto.Location = New System.Drawing.Point(198, 58)
        Me.txtDescProducto.Multiline = True
        Me.txtDescProducto.Name = "txtDescProducto"
        Me.txtDescProducto.PreventEnterBeep = True
        Me.txtDescProducto.Size = New System.Drawing.Size(243, 52)
        Me.txtDescProducto.TabIndex = 2
        '
        'swEstadoP
        '
        '
        '
        '
        Me.swEstadoP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstadoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstadoP.Location = New System.Drawing.Point(198, 154)
        Me.swEstadoP.Name = "swEstadoP"
        Me.swEstadoP.OffBackColor = System.Drawing.Color.Gray
        Me.swEstadoP.OffText = "PASIVO"
        Me.swEstadoP.OffTextColor = System.Drawing.Color.White
        Me.swEstadoP.OnBackColor = System.Drawing.Color.Green
        Me.swEstadoP.OnText = "ACTIVO"
        Me.swEstadoP.OnTextColor = System.Drawing.Color.White
        Me.swEstadoP.ReadOnlyMarkerColor = System.Drawing.Color.Crimson
        Me.swEstadoP.Size = New System.Drawing.Size(136, 22)
        Me.swEstadoP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstadoP.SwitchBackColor = System.Drawing.Color.Gainsboro
        Me.swEstadoP.SwitchBorderColor = System.Drawing.Color.Black
        Me.swEstadoP.TabIndex = 4
        Me.swEstadoP.Value = True
        Me.swEstadoP.ValueObject = "Y"
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
        Me.lbEstado.Location = New System.Drawing.Point(37, 153)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(79, 23)
        Me.lbEstado.TabIndex = 216
        Me.lbEstado.Text = "Estado:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(466, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(458, 528)
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
        Me.GroupPanel2.TabIndex = 228
        Me.GroupPanel2.Text = "GRUPOS Y MEDIDAS"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lbgrupo1)
        Me.Panel2.Controls.Add(Me.btgrupo3)
        Me.Panel2.Controls.Add(Me.btgrupo4)
        Me.Panel2.Controls.Add(Me.lbgrupo2)
        Me.Panel2.Controls.Add(Me.btgrupo2)
        Me.Panel2.Controls.Add(Me.lbgrupo3)
        Me.Panel2.Controls.Add(Me.lbUnidadMedida)
        Me.Panel2.Controls.Add(Me.btgrupo1)
        Me.Panel2.Controls.Add(Me.cbgrupo1)
        Me.Panel2.Controls.Add(Me.cbUMedida)
        Me.Panel2.Controls.Add(Me.cbgrupo2)
        Me.Panel2.Controls.Add(Me.cbgrupo3)
        Me.Panel2.Controls.Add(Me.btUMedida)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 505)
        Me.Panel2.TabIndex = 216
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.pie_chart1
        Me.PictureBox1.Location = New System.Drawing.Point(54, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 216
        Me.PictureBox1.TabStop = False
        '
        'lbgrupo1
        '
        Me.lbgrupo1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo1.Location = New System.Drawing.Point(19, 21)
        Me.lbgrupo1.Name = "lbgrupo1"
        Me.lbgrupo1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo1.Size = New System.Drawing.Size(116, 23)
        Me.lbgrupo1.TabIndex = 29
        Me.lbgrupo1.Text = "Acción:"
        '
        'btgrupo3
        '
        Me.btgrupo3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btgrupo3.BackColor = System.Drawing.Color.Transparent
        Me.btgrupo3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btgrupo3.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btgrupo3.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btgrupo3.Location = New System.Drawing.Point(295, 81)
        Me.btgrupo3.Name = "btgrupo3"
        Me.btgrupo3.Size = New System.Drawing.Size(28, 23)
        Me.btgrupo3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btgrupo3.TabIndex = 211
        Me.btgrupo3.Visible = False
        '
        'btgrupo4
        '
        Me.btgrupo4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btgrupo4.BackColor = System.Drawing.Color.Transparent
        Me.btgrupo4.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btgrupo4.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btgrupo4.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btgrupo4.Location = New System.Drawing.Point(295, 112)
        Me.btgrupo4.Name = "btgrupo4"
        Me.btgrupo4.Size = New System.Drawing.Size(28, 23)
        Me.btgrupo4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btgrupo4.TabIndex = 212
        Me.btgrupo4.Visible = False
        '
        'lbgrupo2
        '
        Me.lbgrupo2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo2.Location = New System.Drawing.Point(20, 49)
        Me.lbgrupo2.Name = "lbgrupo2"
        Me.lbgrupo2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo2.Size = New System.Drawing.Size(116, 23)
        Me.lbgrupo2.TabIndex = 30
        Me.lbgrupo2.Text = "Presentación:"
        '
        'btgrupo2
        '
        Me.btgrupo2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btgrupo2.BackColor = System.Drawing.Color.Transparent
        Me.btgrupo2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btgrupo2.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btgrupo2.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btgrupo2.Location = New System.Drawing.Point(295, 52)
        Me.btgrupo2.Name = "btgrupo2"
        Me.btgrupo2.Size = New System.Drawing.Size(28, 23)
        Me.btgrupo2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btgrupo2.TabIndex = 210
        Me.btgrupo2.Visible = False
        '
        'lbgrupo3
        '
        Me.lbgrupo3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo3.Location = New System.Drawing.Point(19, 78)
        Me.lbgrupo3.Name = "lbgrupo3"
        Me.lbgrupo3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo3.Size = New System.Drawing.Size(116, 23)
        Me.lbgrupo3.TabIndex = 31
        Me.lbgrupo3.Text = "Laboratorio:"
        '
        'lbUnidadMedida
        '
        Me.lbUnidadMedida.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbUnidadMedida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbUnidadMedida.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbUnidadMedida.Location = New System.Drawing.Point(18, 112)
        Me.lbUnidadMedida.Name = "lbUnidadMedida"
        Me.lbUnidadMedida.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbUnidadMedida.Size = New System.Drawing.Size(117, 23)
        Me.lbUnidadMedida.TabIndex = 213
        Me.lbUnidadMedida.Text = "Unidad Medida:"
        '
        'btgrupo1
        '
        Me.btgrupo1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btgrupo1.BackColor = System.Drawing.Color.Transparent
        Me.btgrupo1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btgrupo1.Image = Global.Presentacion.My.Resources.Resources.ic_r
        Me.btgrupo1.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btgrupo1.Location = New System.Drawing.Point(295, 19)
        Me.btgrupo1.Name = "btgrupo1"
        Me.btgrupo1.Size = New System.Drawing.Size(28, 27)
        Me.btgrupo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btgrupo1.TabIndex = 209
        Me.btgrupo1.Visible = False
        '
        'cbgrupo1
        '
        Me.cbgrupo1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cbgrupo1_DesignTimeLayout.LayoutString = resources.GetString("cbgrupo1_DesignTimeLayout.LayoutString")
        Me.cbgrupo1.DesignTimeLayout = cbgrupo1_DesignTimeLayout
        Me.cbgrupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo1.Location = New System.Drawing.Point(145, 20)
        Me.cbgrupo1.Name = "cbgrupo1"
        Me.cbgrupo1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbgrupo1.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbgrupo1.SelectedIndex = -1
        Me.cbgrupo1.SelectedItem = Nothing
        Me.cbgrupo1.Size = New System.Drawing.Size(144, 22)
        Me.cbgrupo1.TabIndex = 0
        Me.cbgrupo1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbUMedida
        '
        cbUMedida_DesignTimeLayout.LayoutString = resources.GetString("cbUMedida_DesignTimeLayout.LayoutString")
        Me.cbUMedida.DesignTimeLayout = cbUMedida_DesignTimeLayout
        Me.cbUMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUMedida.Location = New System.Drawing.Point(145, 112)
        Me.cbUMedida.Name = "cbUMedida"
        Me.cbUMedida.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbUMedida.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbUMedida.SelectedIndex = -1
        Me.cbUMedida.SelectedItem = Nothing
        Me.cbUMedida.Size = New System.Drawing.Size(144, 22)
        Me.cbUMedida.TabIndex = 4
        Me.cbUMedida.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbgrupo2
        '
        cbgrupo2_DesignTimeLayout.LayoutString = resources.GetString("cbgrupo2_DesignTimeLayout.LayoutString")
        Me.cbgrupo2.DesignTimeLayout = cbgrupo2_DesignTimeLayout
        Me.cbgrupo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo2.Location = New System.Drawing.Point(145, 50)
        Me.cbgrupo2.Name = "cbgrupo2"
        Me.cbgrupo2.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbgrupo2.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbgrupo2.SelectedIndex = -1
        Me.cbgrupo2.SelectedItem = Nothing
        Me.cbgrupo2.Size = New System.Drawing.Size(144, 22)
        Me.cbgrupo2.TabIndex = 1
        Me.cbgrupo2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbgrupo3
        '
        cbgrupo3_DesignTimeLayout.LayoutString = resources.GetString("cbgrupo3_DesignTimeLayout.LayoutString")
        Me.cbgrupo3.DesignTimeLayout = cbgrupo3_DesignTimeLayout
        Me.cbgrupo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo3.Location = New System.Drawing.Point(145, 80)
        Me.cbgrupo3.Name = "cbgrupo3"
        Me.cbgrupo3.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbgrupo3.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbgrupo3.SelectedIndex = -1
        Me.cbgrupo3.SelectedItem = Nothing
        Me.cbgrupo3.Size = New System.Drawing.Size(144, 22)
        Me.cbgrupo3.TabIndex = 2
        Me.cbgrupo3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btUMedida
        '
        Me.btUMedida.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btUMedida.BackColor = System.Drawing.Color.Transparent
        Me.btUMedida.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btUMedida.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btUMedida.Location = New System.Drawing.Point(296, 112)
        Me.btUMedida.Name = "btUMedida"
        Me.btUMedida.Size = New System.Drawing.Size(28, 23)
        Me.btUMedida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btUMedida.TabIndex = 215
        Me.btUMedida.Visible = False
        '
        'JGFichasAtencion
        '
        Me.JGFichasAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGFichasAtencion.Location = New System.Drawing.Point(59, 31)
        Me.JGFichasAtencion.Name = "JGFichasAtencion"
        Me.JGFichasAtencion.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.JGFichasAtencion.Size = New System.Drawing.Size(808, 376)
        Me.JGFichasAtencion.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(927, 670)
        Me.Name = "Form1"
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MpanelBuscador.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.intStockMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgrupo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgrupo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgrupo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGFichasAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents intStockMinimo As DevComponents.Editors.IntegerInput
    Friend WithEvents lbStockMin As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbIdProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbDescProducto As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents swEstadoP As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbgrupo1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btgrupo3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btgrupo4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbgrupo2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btgrupo2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbgrupo3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbUnidadMedida As DevComponents.DotNetBar.LabelX
    Friend WithEvents btgrupo1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbgrupo1 As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbUMedida As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbgrupo2 As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbgrupo3 As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents btUMedida As DevComponents.DotNetBar.ButtonX
    Friend WithEvents JGFichasAtencion As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As PictureBox
End Class
