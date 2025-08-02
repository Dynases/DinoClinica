<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pr_MascotasAtendidas
    Inherits Modelo.ModeloR0

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pr_MascotasAtendidas))
        Dim cbGenero_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbVeterinario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.checkTodosGenero = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checkUnGenero = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckTodosVeterinario = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checkUnVeterinario = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbGenero = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lblGenero = New DevComponents.DotNetBar.LabelX()
        Me.cbVeterinario = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lblVeterinario = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaI = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lbIfechaFin = New DevComponents.DotNetBar.LabelX()
        Me.lbIfechaInicio = New DevComponents.DotNetBar.LabelX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGPFiltros.SuspendLayout()
        Me.PanelIzq.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbVeterinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Size = New System.Drawing.Size(789, 543)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(757, 543)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(757, 543)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelIzq, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 507)
        Me.PanelInferior.Size = New System.Drawing.Size(757, 36)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
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
        'btnSalir
        '
        '
        'btnGenerar
        '
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Size = New System.Drawing.Size(394, 507)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(557, 0)
        '
        'MReportViewer
        '
        Me.MReportViewer.Size = New System.Drawing.Size(394, 507)
        '
        'MGPFiltros
        '
        Me.MGPFiltros.Controls.Add(Me.Panel2)
        Me.MGPFiltros.Controls.Add(Me.Panel1)
        Me.MGPFiltros.Controls.Add(Me.cbGenero)
        Me.MGPFiltros.Controls.Add(Me.lblGenero)
        Me.MGPFiltros.Controls.Add(Me.cbVeterinario)
        Me.MGPFiltros.Controls.Add(Me.lblVeterinario)
        Me.MGPFiltros.Controls.Add(Me.tbFechaF)
        Me.MGPFiltros.Controls.Add(Me.tbFechaI)
        Me.MGPFiltros.Controls.Add(Me.lbIfechaFin)
        Me.MGPFiltros.Controls.Add(Me.lbIfechaInicio)
        Me.MGPFiltros.Size = New System.Drawing.Size(363, 435)
        '
        '
        '
        Me.MGPFiltros.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.MGPFiltros.Style.BackColorGradientAngle = 90
        Me.MGPFiltros.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.MGPFiltros.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderBottomWidth = 1
        Me.MGPFiltros.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MGPFiltros.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderLeftWidth = 1
        Me.MGPFiltros.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderRightWidth = 1
        Me.MGPFiltros.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderTopWidth = 1
        Me.MGPFiltros.Style.CornerDiameter = 4
        Me.MGPFiltros.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MGPFiltros.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MGPFiltros.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MGPFiltros.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MGPFiltros.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MGPFiltros.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'PanelIzq
        '
        Me.PanelIzq.Size = New System.Drawing.Size(363, 507)
        Me.PanelIzq.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.PanelIzq.Controls.SetChildIndex(Me.MGPFiltros, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.checkTodosGenero)
        Me.Panel2.Controls.Add(Me.checkUnGenero)
        Me.Panel2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(240, 117)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(119, 35)
        Me.Panel2.TabIndex = 277
        Me.Panel2.Visible = False
        '
        'checkTodosGenero
        '
        '
        '
        '
        Me.checkTodosGenero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkTodosGenero.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkTodosGenero.Checked = True
        Me.checkTodosGenero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkTodosGenero.CheckValue = "Y"
        Me.checkTodosGenero.Location = New System.Drawing.Point(60, 7)
        Me.checkTodosGenero.Name = "checkTodosGenero"
        Me.checkTodosGenero.Size = New System.Drawing.Size(55, 23)
        Me.checkTodosGenero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkTodosGenero.TabIndex = 252
        Me.checkTodosGenero.Text = "Todos"
        Me.checkTodosGenero.Visible = False
        '
        'checkUnGenero
        '
        '
        '
        '
        Me.checkUnGenero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkUnGenero.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkUnGenero.Location = New System.Drawing.Point(10, 7)
        Me.checkUnGenero.Name = "checkUnGenero"
        Me.checkUnGenero.Size = New System.Drawing.Size(44, 23)
        Me.checkUnGenero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkUnGenero.TabIndex = 251
        Me.checkUnGenero.Text = "Uno"
        Me.checkUnGenero.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CheckTodosVeterinario)
        Me.Panel1.Controls.Add(Me.checkUnVeterinario)
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 35)
        Me.Panel1.TabIndex = 276
        '
        'CheckTodosVeterinario
        '
        '
        '
        '
        Me.CheckTodosVeterinario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosVeterinario.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckTodosVeterinario.Checked = True
        Me.CheckTodosVeterinario.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckTodosVeterinario.CheckValue = "Y"
        Me.CheckTodosVeterinario.Location = New System.Drawing.Point(62, 7)
        Me.CheckTodosVeterinario.Name = "CheckTodosVeterinario"
        Me.CheckTodosVeterinario.Size = New System.Drawing.Size(55, 23)
        Me.CheckTodosVeterinario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosVeterinario.TabIndex = 252
        Me.CheckTodosVeterinario.Text = "Todos"
        '
        'checkUnVeterinario
        '
        '
        '
        '
        Me.checkUnVeterinario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkUnVeterinario.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkUnVeterinario.Location = New System.Drawing.Point(12, 7)
        Me.checkUnVeterinario.Name = "checkUnVeterinario"
        Me.checkUnVeterinario.Size = New System.Drawing.Size(44, 23)
        Me.checkUnVeterinario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkUnVeterinario.TabIndex = 251
        Me.checkUnVeterinario.Text = "Uno"
        '
        'cbGenero
        '
        Me.cbGenero.BackColor = System.Drawing.Color.White
        cbGenero_DesignTimeLayout.LayoutString = resources.GetString("cbGenero_DesignTimeLayout.LayoutString")
        Me.cbGenero.DesignTimeLayout = cbGenero_DesignTimeLayout
        Me.cbGenero.DisabledBackColor = System.Drawing.Color.White
        Me.cbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGenero.Location = New System.Drawing.Point(76, 125)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbGenero.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbGenero.SelectedIndex = -1
        Me.cbGenero.SelectedItem = Nothing
        Me.cbGenero.Size = New System.Drawing.Size(164, 22)
        Me.cbGenero.TabIndex = 275
        Me.cbGenero.Visible = False
        Me.cbGenero.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblGenero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGenero.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblGenero.Location = New System.Drawing.Point(18, 131)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lblGenero.Size = New System.Drawing.Size(54, 16)
        Me.lblGenero.TabIndex = 274
        Me.lblGenero.Text = "Especie:"
        Me.lblGenero.Visible = False
        '
        'cbVeterinario
        '
        Me.cbVeterinario.BackColor = System.Drawing.Color.White
        cbVeterinario_DesignTimeLayout.LayoutString = resources.GetString("cbVeterinario_DesignTimeLayout.LayoutString")
        Me.cbVeterinario.DesignTimeLayout = cbVeterinario_DesignTimeLayout
        Me.cbVeterinario.DisabledBackColor = System.Drawing.Color.White
        Me.cbVeterinario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVeterinario.Location = New System.Drawing.Point(76, 8)
        Me.cbVeterinario.Name = "cbVeterinario"
        Me.cbVeterinario.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbVeterinario.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbVeterinario.SelectedIndex = -1
        Me.cbVeterinario.SelectedItem = Nothing
        Me.cbVeterinario.Size = New System.Drawing.Size(164, 22)
        Me.cbVeterinario.TabIndex = 273
        Me.cbVeterinario.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lblVeterinario
        '
        Me.lblVeterinario.AutoSize = True
        Me.lblVeterinario.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblVeterinario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblVeterinario.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeterinario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblVeterinario.Location = New System.Drawing.Point(0, 11)
        Me.lblVeterinario.Name = "lblVeterinario"
        Me.lblVeterinario.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lblVeterinario.Size = New System.Drawing.Size(79, 16)
        Me.lblVeterinario.TabIndex = 272
        Me.lblVeterinario.Text = "Veterinario:"
        '
        'tbFechaF
        '
        '
        '
        '
        Me.tbFechaF.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaF.ButtonDropDown.Visible = True
        Me.tbFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaF.IsPopupCalendarOpen = False
        Me.tbFechaF.Location = New System.Drawing.Point(76, 86)
        '
        '
        '
        '
        '
        '
        Me.tbFechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaF.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaF.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaF.Name = "tbFechaF"
        Me.tbFechaF.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF.TabIndex = 271
        '
        'tbFechaI
        '
        '
        '
        '
        Me.tbFechaI.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaI.ButtonDropDown.Visible = True
        Me.tbFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaI.IsPopupCalendarOpen = False
        Me.tbFechaI.Location = New System.Drawing.Point(76, 45)
        '
        '
        '
        '
        '
        '
        Me.tbFechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaI.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaI.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaI.Name = "tbFechaI"
        Me.tbFechaI.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaI.TabIndex = 270
        '
        'lbIfechaFin
        '
        Me.lbIfechaFin.AutoSize = True
        Me.lbIfechaFin.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIfechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIfechaFin.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIfechaFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIfechaFin.Location = New System.Drawing.Point(51, 93)
        Me.lbIfechaFin.Name = "lbIfechaFin"
        Me.lbIfechaFin.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIfechaFin.Size = New System.Drawing.Size(20, 16)
        Me.lbIfechaFin.TabIndex = 269
        Me.lbIfechaFin.Text = "Al:"
        '
        'lbIfechaInicio
        '
        Me.lbIfechaInicio.AutoSize = True
        Me.lbIfechaInicio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIfechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIfechaInicio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIfechaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIfechaInicio.Location = New System.Drawing.Point(3, 52)
        Me.lbIfechaInicio.Name = "lbIfechaInicio"
        Me.lbIfechaInicio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIfechaInicio.Size = New System.Drawing.Size(68, 16)
        Me.lbIfechaInicio.TabIndex = 268
        Me.lbIfechaInicio.Text = "Fecha Del:"
        '
        'Pr_MascotasAtendidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 543)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "Pr_MascotasAtendidas"
        Me.Text = "REPORTE VETERINARIO-MASCOTAS ATENDIDAS"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.MPanelUserAct.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MGPFiltros.ResumeLayout(False)
        Me.MGPFiltros.PerformLayout()
        Me.PanelIzq.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.cbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbVeterinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents checkTodosGenero As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkUnGenero As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckTodosVeterinario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkUnVeterinario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbGenero As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lblGenero As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbVeterinario As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lblVeterinario As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaI As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lbIfechaFin As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIfechaInicio As DevComponents.DotNetBar.LabelX
End Class
