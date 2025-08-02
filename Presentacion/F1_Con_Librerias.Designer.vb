<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Con_Librerias
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
        Dim cbCategoria_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Con_Librerias))
        Dim cbPrograma_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.gpGrupos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgregarLib = New DevComponents.DotNetBar.ButtonX()
        Me.txtDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDescripcion = New DevComponents.DotNetBar.LabelX()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbCategoria = New DevComponents.DotNetBar.LabelX()
        Me.cbCategoria = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbPrograma = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbPrograma = New DevComponents.DotNetBar.LabelX()
        Me.gpDatosL = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.JGLibrerias = New Janus.Windows.GridEX.GridEX()
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
        Me.gpGrupos.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatosL.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.JGLibrerias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpDatosL)
        Me.MpanelSuperior.Controls.Add(Me.gpGrupos)
        Me.MpanelSuperior.Size = New System.Drawing.Size(924, 475)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(931, 72)
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
        'btnEliminar
        '
        Me.btnEliminar.Visible = False
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 553)
        Me.PanelInferior.Size = New System.Drawing.Size(931, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(731, 0)
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
        Me.BubbleBarUsuario.Visible = False
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
        Me.superTabControl1.Size = New System.Drawing.Size(931, 617)
        '
        'gpGrupos
        '
        Me.gpGrupos.BackColor = System.Drawing.Color.White
        Me.gpGrupos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpGrupos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpGrupos.Controls.Add(Me.Panel4)
        Me.gpGrupos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpGrupos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpGrupos.Location = New System.Drawing.Point(0, 0)
        Me.gpGrupos.Name = "gpGrupos"
        Me.gpGrupos.Size = New System.Drawing.Size(924, 124)
        '
        '
        '
        Me.gpGrupos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpGrupos.Style.BackColorGradientAngle = 90
        Me.gpGrupos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpGrupos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrupos.Style.BorderBottomWidth = 1
        Me.gpGrupos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpGrupos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrupos.Style.BorderLeftWidth = 1
        Me.gpGrupos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrupos.Style.BorderRightWidth = 1
        Me.gpGrupos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGrupos.Style.BorderTopWidth = 1
        Me.gpGrupos.Style.CornerDiameter = 4
        Me.gpGrupos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpGrupos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpGrupos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpGrupos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpGrupos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpGrupos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpGrupos.TabIndex = 1
        Me.gpGrupos.Text = "GRUPOS"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(918, 101)
        Me.Panel4.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 101)
        Me.TableLayoutPanel1.TabIndex = 236
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAgregarLib)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.lbDescripcion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 95)
        Me.Panel2.TabIndex = 35
        Me.Panel2.Visible = False
        '
        'btnAgregarLib
        '
        Me.btnAgregarLib.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarLib.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnAgregarLib.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnAgregarLib.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnAgregarLib.Location = New System.Drawing.Point(236, 20)
        Me.btnAgregarLib.Name = "btnAgregarLib"
        Me.btnAgregarLib.Size = New System.Drawing.Size(28, 29)
        Me.btnAgregarLib.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAgregarLib.TabIndex = 326
        Me.btnAgregarLib.Visible = False
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
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(3, 25)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PreventEnterBeep = True
        Me.txtDescripcion.Size = New System.Drawing.Size(227, 21)
        Me.txtDescripcion.TabIndex = 241
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDescripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDescripcion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDescripcion.Location = New System.Drawing.Point(3, 3)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDescripcion.Size = New System.Drawing.Size(81, 16)
        Me.lbDescripcion.TabIndex = 244
        Me.lbDescripcion.Text = "Descripción:"
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.lbCategoria)
        Me.Panel6.Controls.Add(Me.cbCategoria)
        Me.Panel6.Controls.Add(Me.cbPrograma)
        Me.Panel6.Controls.Add(Me.lbPrograma)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(278, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.Panel6.Size = New System.Drawing.Size(361, 95)
        Me.Panel6.TabIndex = 34
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCategoria.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCategoria.Location = New System.Drawing.Point(1, 50)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.PaddingTop = 4
        Me.lbCategoria.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCategoria.Size = New System.Drawing.Size(66, 20)
        Me.lbCategoria.TabIndex = 34
        Me.lbCategoria.Text = "Categoria:"
        '
        'cbCategoria
        '
        Me.cbCategoria.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.cbCategoria.ControlThemedAreas = Janus.Windows.GridEX.ControlThemedAreas.Button
        cbCategoria_DesignTimeLayout.LayoutString = resources.GetString("cbCategoria_DesignTimeLayout.LayoutString")
        Me.cbCategoria.DesignTimeLayout = cbCategoria_DesignTimeLayout
        Me.cbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.Location = New System.Drawing.Point(68, 50)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCategoria.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCategoria.SelectedIndex = -1
        Me.cbCategoria.SelectedItem = Nothing
        Me.cbCategoria.Size = New System.Drawing.Size(166, 21)
        Me.cbCategoria.TabIndex = 33
        Me.cbCategoria.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbPrograma
        '
        Me.cbPrograma.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.cbPrograma.ControlThemedAreas = Janus.Windows.GridEX.ControlThemedAreas.Button
        cbPrograma_DesignTimeLayout.LayoutString = resources.GetString("cbPrograma_DesignTimeLayout.LayoutString")
        Me.cbPrograma.DesignTimeLayout = cbPrograma_DesignTimeLayout
        Me.cbPrograma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrograma.Location = New System.Drawing.Point(69, 20)
        Me.cbPrograma.Name = "cbPrograma"
        Me.cbPrograma.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbPrograma.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbPrograma.SelectedIndex = -1
        Me.cbPrograma.SelectedItem = Nothing
        Me.cbPrograma.Size = New System.Drawing.Size(292, 21)
        Me.cbPrograma.TabIndex = 31
        Me.cbPrograma.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbPrograma
        '
        Me.lbPrograma.AutoSize = True
        Me.lbPrograma.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPrograma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPrograma.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbPrograma.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrograma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPrograma.Location = New System.Drawing.Point(0, 20)
        Me.lbPrograma.Name = "lbPrograma"
        Me.lbPrograma.PaddingTop = 4
        Me.lbPrograma.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPrograma.Size = New System.Drawing.Size(69, 20)
        Me.lbPrograma.TabIndex = 32
        Me.lbPrograma.Text = "Programa:"
        '
        'gpDatosL
        '
        Me.gpDatosL.BackColor = System.Drawing.Color.White
        Me.gpDatosL.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosL.Controls.Add(Me.Panel5)
        Me.gpDatosL.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDatosL.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosL.Location = New System.Drawing.Point(0, 124)
        Me.gpDatosL.Name = "gpDatosL"
        Me.gpDatosL.Size = New System.Drawing.Size(924, 351)
        '
        '
        '
        Me.gpDatosL.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDatosL.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDatosL.Style.BackColorGradientAngle = 90
        Me.gpDatosL.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosL.Style.BorderBottomWidth = 1
        Me.gpDatosL.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosL.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosL.Style.BorderLeftWidth = 1
        Me.gpDatosL.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosL.Style.BorderRightWidth = 1
        Me.gpDatosL.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosL.Style.BorderTopWidth = 1
        Me.gpDatosL.Style.CornerDiameter = 4
        Me.gpDatosL.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosL.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosL.Style.TextColor = System.Drawing.Color.White
        Me.gpDatosL.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatosL.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosL.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosL.TabIndex = 2
        Me.gpDatosL.Text = "DATOS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.JGLibrerias)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(918, 328)
        Me.Panel5.TabIndex = 0
        '
        'JGLibrerias
        '
        Me.JGLibrerias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGLibrerias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGLibrerias.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGLibrerias.Location = New System.Drawing.Point(0, 0)
        Me.JGLibrerias.Name = "JGLibrerias"
        Me.JGLibrerias.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGLibrerias.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGLibrerias.Size = New System.Drawing.Size(918, 328)
        Me.JGLibrerias.TabIndex = 0
        Me.JGLibrerias.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_Con_Librerias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 617)
        Me.MaximizeBox = False
        Me.Name = "F1_Con_Librerias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIBERIAS"
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
        Me.gpGrupos.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.cbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatosL.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.JGLibrerias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpDatosL As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents JGLibrerias As Janus.Windows.GridEX.GridEX
    Friend WithEvents gpGrupos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDescripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbCategoria As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbCategoria As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbPrograma As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbPrograma As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAgregarLib As DevComponents.DotNetBar.ButtonX
End Class
