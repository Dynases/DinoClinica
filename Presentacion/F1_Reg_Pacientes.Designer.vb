<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Reg_Pacientes
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
        Dim cbRaza_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Reg_Pacientes))
        Dim cbEspecie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.gpDatosMascota = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelDatosMascota = New System.Windows.Forms.Panel()
        Me.dtpFnac = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnRaza = New DevComponents.DotNetBar.ButtonX()
        Me.btnEspecie = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEsterilizado = New System.Windows.Forms.Panel()
        Me.chbSi = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbNo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PanelSexo = New System.Windows.Forms.Panel()
        Me.chbMacho = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbHembra = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpFIngresoM = New System.Windows.Forms.DateTimePicker()
        Me.lbFIngreso = New DevComponents.DotNetBar.LabelX()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.txtEstado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbEsterilizado = New DevComponents.DotNetBar.LabelX()
        Me.lbSexo = New DevComponents.DotNetBar.LabelX()
        Me.txtSeñas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbSeñas = New DevComponents.DotNetBar.LabelX()
        Me.cbRaza = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbRaza = New DevComponents.DotNetBar.LabelX()
        Me.cbEspecie = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbEspecie = New DevComponents.DotNetBar.LabelX()
        Me.lbIdMascota = New DevComponents.DotNetBar.LabelX()
        Me.lbNombMasc = New DevComponents.DotNetBar.LabelX()
        Me.lbFNac = New DevComponents.DotNetBar.LabelX()
        Me.txtNMascota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtColor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbColor = New DevComponents.DotNetBar.LabelX()
        Me.txtIdMascota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGBPropietario = New Janus.Windows.GridEX.GridEX()
        Me.gpBusqMascotas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGBusqMascotas = New Janus.Windows.GridEX.GridEX()
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
        Me.gpDatosMascota.SuspendLayout()
        Me.panelDatosMascota.SuspendLayout()
        CType(Me.dtpFnac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEsterilizado.SuspendLayout()
        Me.PanelSexo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEspecie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.JGBPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqMascotas.SuspendLayout()
        CType(Me.JGBusqMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpDatosMascota)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(849, 344)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(849, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 416)
        Me.PanelInferior.Size = New System.Drawing.Size(849, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(649, 0)
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
        Me.MpanelBuscador.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MpanelBuscador.BackgroundImage = Global.Presentacion.My.Resources.Resources.Fondo2
        Me.MpanelBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MpanelBuscador.Controls.Add(Me.gpBusqMascotas)
        Me.MpanelBuscador.Size = New System.Drawing.Size(923, 455)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(317, 121)
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
        Me.superTabControl1.Size = New System.Drawing.Size(849, 480)
        '
        'gpDatosMascota
        '
        Me.gpDatosMascota.BackColor = System.Drawing.Color.White
        Me.gpDatosMascota.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosMascota.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosMascota.Controls.Add(Me.panelDatosMascota)
        Me.gpDatosMascota.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosMascota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDatosMascota.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosMascota.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpDatosMascota.Location = New System.Drawing.Point(0, 0)
        Me.gpDatosMascota.Name = "gpDatosMascota"
        Me.gpDatosMascota.Size = New System.Drawing.Size(849, 344)
        '
        '
        '
        Me.gpDatosMascota.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDatosMascota.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDatosMascota.Style.BackColorGradientAngle = 90
        Me.gpDatosMascota.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosMascota.Style.BorderBottomWidth = 1
        Me.gpDatosMascota.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosMascota.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosMascota.Style.BorderLeftWidth = 1
        Me.gpDatosMascota.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosMascota.Style.BorderRightWidth = 1
        Me.gpDatosMascota.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosMascota.Style.BorderTopWidth = 1
        Me.gpDatosMascota.Style.CornerDiameter = 4
        Me.gpDatosMascota.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosMascota.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosMascota.Style.TextColor = System.Drawing.Color.White
        '
        '
        '
        Me.gpDatosMascota.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosMascota.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosMascota.TabIndex = 2
        Me.gpDatosMascota.Text = "DATOS PACIENTES"
        '
        'panelDatosMascota
        '
        Me.panelDatosMascota.AutoScroll = True
        Me.panelDatosMascota.Controls.Add(Me.dtpFnac)
        Me.panelDatosMascota.Controls.Add(Me.btnRaza)
        Me.panelDatosMascota.Controls.Add(Me.btnEspecie)
        Me.panelDatosMascota.Controls.Add(Me.PanelEsterilizado)
        Me.panelDatosMascota.Controls.Add(Me.PanelSexo)
        Me.panelDatosMascota.Controls.Add(Me.pictureBox1)
        Me.panelDatosMascota.Controls.Add(Me.dtpFIngresoM)
        Me.panelDatosMascota.Controls.Add(Me.lbFIngreso)
        Me.panelDatosMascota.Controls.Add(Me.lbEstado)
        Me.panelDatosMascota.Controls.Add(Me.txtEstado)
        Me.panelDatosMascota.Controls.Add(Me.lbEsterilizado)
        Me.panelDatosMascota.Controls.Add(Me.lbSexo)
        Me.panelDatosMascota.Controls.Add(Me.txtSeñas)
        Me.panelDatosMascota.Controls.Add(Me.lbSeñas)
        Me.panelDatosMascota.Controls.Add(Me.cbRaza)
        Me.panelDatosMascota.Controls.Add(Me.lbRaza)
        Me.panelDatosMascota.Controls.Add(Me.cbEspecie)
        Me.panelDatosMascota.Controls.Add(Me.lbEspecie)
        Me.panelDatosMascota.Controls.Add(Me.lbIdMascota)
        Me.panelDatosMascota.Controls.Add(Me.lbNombMasc)
        Me.panelDatosMascota.Controls.Add(Me.lbFNac)
        Me.panelDatosMascota.Controls.Add(Me.txtNMascota)
        Me.panelDatosMascota.Controls.Add(Me.txtColor)
        Me.panelDatosMascota.Controls.Add(Me.lbColor)
        Me.panelDatosMascota.Controls.Add(Me.txtIdMascota)
        Me.panelDatosMascota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosMascota.Location = New System.Drawing.Point(0, 0)
        Me.panelDatosMascota.Name = "panelDatosMascota"
        Me.panelDatosMascota.Size = New System.Drawing.Size(843, 321)
        Me.panelDatosMascota.TabIndex = 234
        '
        'dtpFnac
        '
        '
        '
        '
        Me.dtpFnac.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFnac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFnac.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpFnac.ButtonDropDown.Visible = True
        Me.dtpFnac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFnac.IsPopupCalendarOpen = False
        Me.dtpFnac.Location = New System.Drawing.Point(155, 176)
        '
        '
        '
        '
        '
        '
        Me.dtpFnac.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFnac.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpFnac.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFnac.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFnac.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.dtpFnac.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtpFnac.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFnac.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFnac.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFnac.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFnac.MonthCalendar.TodayButtonVisible = True
        Me.dtpFnac.Name = "dtpFnac"
        Me.dtpFnac.Size = New System.Drawing.Size(114, 22)
        Me.dtpFnac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpFnac.TabIndex = 4
        '
        'btnRaza
        '
        Me.btnRaza.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRaza.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnRaza.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnRaza.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnRaza.Location = New System.Drawing.Point(275, 144)
        Me.btnRaza.Name = "btnRaza"
        Me.btnRaza.Size = New System.Drawing.Size(28, 27)
        Me.btnRaza.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRaza.TabIndex = 326
        Me.btnRaza.Visible = False
        '
        'btnEspecie
        '
        Me.btnEspecie.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEspecie.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnEspecie.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnEspecie.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnEspecie.Location = New System.Drawing.Point(275, 112)
        Me.btnEspecie.Name = "btnEspecie"
        Me.btnEspecie.Size = New System.Drawing.Size(28, 29)
        Me.btnEspecie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEspecie.TabIndex = 325
        Me.btnEspecie.Visible = False
        '
        'PanelEsterilizado
        '
        Me.PanelEsterilizado.Controls.Add(Me.chbSi)
        Me.PanelEsterilizado.Controls.Add(Me.chbNo)
        Me.PanelEsterilizado.Location = New System.Drawing.Point(509, 172)
        Me.PanelEsterilizado.Name = "PanelEsterilizado"
        Me.PanelEsterilizado.Size = New System.Drawing.Size(90, 30)
        Me.PanelEsterilizado.TabIndex = 324
        '
        'chbSi
        '
        '
        '
        '
        Me.chbSi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbSi.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbSi.Checked = True
        Me.chbSi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSi.CheckValue = "Y"
        Me.chbSi.Location = New System.Drawing.Point(1, 4)
        Me.chbSi.Name = "chbSi"
        Me.chbSi.Size = New System.Drawing.Size(38, 23)
        Me.chbSi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbSi.TabIndex = 10
        Me.chbSi.Text = "Si"
        '
        'chbNo
        '
        '
        '
        '
        Me.chbNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbNo.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbNo.Location = New System.Drawing.Point(43, 4)
        Me.chbNo.Name = "chbNo"
        Me.chbNo.Size = New System.Drawing.Size(44, 23)
        Me.chbNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbNo.TabIndex = 11
        Me.chbNo.Text = "No"
        '
        'PanelSexo
        '
        Me.PanelSexo.Controls.Add(Me.chbMacho)
        Me.PanelSexo.Controls.Add(Me.chbHembra)
        Me.PanelSexo.Location = New System.Drawing.Point(507, 80)
        Me.PanelSexo.Name = "PanelSexo"
        Me.PanelSexo.Size = New System.Drawing.Size(169, 30)
        Me.PanelSexo.TabIndex = 5
        '
        'chbMacho
        '
        '
        '
        '
        Me.chbMacho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbMacho.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbMacho.Checked = True
        Me.chbMacho.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbMacho.CheckValue = "Y"
        Me.chbMacho.Location = New System.Drawing.Point(1, 4)
        Me.chbMacho.Name = "chbMacho"
        Me.chbMacho.Size = New System.Drawing.Size(71, 23)
        Me.chbMacho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbMacho.TabIndex = 6
        Me.chbMacho.Text = "Macho"
        '
        'chbHembra
        '
        '
        '
        '
        Me.chbHembra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbHembra.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbHembra.Location = New System.Drawing.Point(80, 4)
        Me.chbHembra.Name = "chbHembra"
        Me.chbHembra.Size = New System.Drawing.Size(83, 23)
        Me.chbHembra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbHembra.TabIndex = 7
        Me.chbHembra.Text = "Hembra"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Presentacion.My.Resources.Resources.VidaVet5
        Me.pictureBox1.Location = New System.Drawing.Point(679, 11)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 268
        Me.pictureBox1.TabStop = False
        '
        'dtpFIngresoM
        '
        Me.dtpFIngresoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFIngresoM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFIngresoM.Location = New System.Drawing.Point(509, 206)
        Me.dtpFIngresoM.Name = "dtpFIngresoM"
        Me.dtpFIngresoM.Size = New System.Drawing.Size(122, 22)
        Me.dtpFIngresoM.TabIndex = 12
        Me.dtpFIngresoM.TabStop = False
        '
        'lbFIngreso
        '
        Me.lbFIngreso.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFIngreso.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFIngreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFIngreso.Location = New System.Drawing.Point(421, 208)
        Me.lbFIngreso.Name = "lbFIngreso"
        Me.lbFIngreso.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFIngreso.Size = New System.Drawing.Size(75, 23)
        Me.lbFIngreso.TabIndex = 266
        Me.lbFIngreso.Text = "F. Ingreso:"
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
        Me.lbEstado.Location = New System.Drawing.Point(51, 208)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(75, 23)
        Me.lbEstado.TabIndex = 265
        Me.lbEstado.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEstado.Border.Class = "TextBoxBorder"
        Me.txtEstado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEstado.DisabledBackColor = System.Drawing.Color.White
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.Black
        Me.txtEstado.Location = New System.Drawing.Point(155, 208)
        Me.txtEstado.MaxLength = 70
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PreventEnterBeep = True
        Me.txtEstado.Size = New System.Drawing.Size(242, 22)
        Me.txtEstado.TabIndex = 5
        '
        'lbEsterilizado
        '
        Me.lbEsterilizado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbEsterilizado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbEsterilizado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEsterilizado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbEsterilizado.Location = New System.Drawing.Point(421, 177)
        Me.lbEsterilizado.Name = "lbEsterilizado"
        Me.lbEsterilizado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEsterilizado.Size = New System.Drawing.Size(93, 23)
        Me.lbEsterilizado.TabIndex = 263
        Me.lbEsterilizado.Text = "Esterilizado:"
        '
        'lbSexo
        '
        Me.lbSexo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSexo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSexo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbSexo.Location = New System.Drawing.Point(421, 84)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSexo.Size = New System.Drawing.Size(64, 23)
        Me.lbSexo.TabIndex = 259
        Me.lbSexo.Text = "Sexo:"
        '
        'txtSeñas
        '
        Me.txtSeñas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSeñas.Border.Class = "TextBoxBorder"
        Me.txtSeñas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSeñas.DisabledBackColor = System.Drawing.Color.White
        Me.txtSeñas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeñas.ForeColor = System.Drawing.Color.Black
        Me.txtSeñas.Location = New System.Drawing.Point(508, 146)
        Me.txtSeñas.MaxLength = 50
        Me.txtSeñas.Name = "txtSeñas"
        Me.txtSeñas.PreventEnterBeep = True
        Me.txtSeñas.Size = New System.Drawing.Size(233, 22)
        Me.txtSeñas.TabIndex = 9
        '
        'lbSeñas
        '
        Me.lbSeñas.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSeñas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSeñas.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeñas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbSeñas.Location = New System.Drawing.Point(421, 146)
        Me.lbSeñas.Name = "lbSeñas"
        Me.lbSeñas.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSeñas.Size = New System.Drawing.Size(64, 23)
        Me.lbSeñas.TabIndex = 258
        Me.lbSeñas.Text = "Señas:"
        '
        'cbRaza
        '
        cbRaza_DesignTimeLayout.LayoutString = resources.GetString("cbRaza_DesignTimeLayout.LayoutString")
        Me.cbRaza.DesignTimeLayout = cbRaza_DesignTimeLayout
        Me.cbRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRaza.Location = New System.Drawing.Point(156, 147)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbRaza.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbRaza.SelectedIndex = -1
        Me.cbRaza.SelectedItem = Nothing
        Me.cbRaza.Size = New System.Drawing.Size(113, 22)
        Me.cbRaza.TabIndex = 3
        Me.cbRaza.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbRaza
        '
        Me.lbRaza.AutoSize = True
        Me.lbRaza.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbRaza.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbRaza.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRaza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbRaza.Location = New System.Drawing.Point(51, 151)
        Me.lbRaza.Name = "lbRaza"
        Me.lbRaza.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbRaza.Size = New System.Drawing.Size(37, 16)
        Me.lbRaza.TabIndex = 256
        Me.lbRaza.Text = "Raza:"
        '
        'cbEspecie
        '
        cbEspecie_DesignTimeLayout.LayoutString = resources.GetString("cbEspecie_DesignTimeLayout.LayoutString")
        Me.cbEspecie.DesignTimeLayout = cbEspecie_DesignTimeLayout
        Me.cbEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEspecie.Location = New System.Drawing.Point(156, 116)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbEspecie.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbEspecie.SelectedIndex = -1
        Me.cbEspecie.SelectedItem = Nothing
        Me.cbEspecie.Size = New System.Drawing.Size(113, 22)
        Me.cbEspecie.TabIndex = 2
        Me.cbEspecie.Tag = "1"
        Me.cbEspecie.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbEspecie
        '
        Me.lbEspecie.AutoSize = True
        Me.lbEspecie.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbEspecie.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbEspecie.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEspecie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbEspecie.Location = New System.Drawing.Point(51, 120)
        Me.lbEspecie.Name = "lbEspecie"
        Me.lbEspecie.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEspecie.Size = New System.Drawing.Size(54, 16)
        Me.lbEspecie.TabIndex = 254
        Me.lbEspecie.Text = "Especie:"
        '
        'lbIdMascota
        '
        Me.lbIdMascota.AutoSize = True
        Me.lbIdMascota.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdMascota.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdMascota.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdMascota.Location = New System.Drawing.Point(53, 54)
        Me.lbIdMascota.Name = "lbIdMascota"
        Me.lbIdMascota.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdMascota.Size = New System.Drawing.Size(75, 16)
        Me.lbIdMascota.TabIndex = 224
        Me.lbIdMascota.Text = "Id Mascota:"
        '
        'lbNombMasc
        '
        Me.lbNombMasc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbNombMasc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbNombMasc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombMasc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbNombMasc.Location = New System.Drawing.Point(52, 86)
        Me.lbNombMasc.Name = "lbNombMasc"
        Me.lbNombMasc.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbNombMasc.Size = New System.Drawing.Size(75, 23)
        Me.lbNombMasc.TabIndex = 227
        Me.lbNombMasc.Text = "Nombre:"
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
        Me.lbFNac.Location = New System.Drawing.Point(53, 176)
        Me.lbFNac.Name = "lbFNac"
        Me.lbFNac.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFNac.Size = New System.Drawing.Size(102, 23)
        Me.lbFNac.TabIndex = 226
        Me.lbFNac.Text = "F. Nacimiento:"
        '
        'txtNMascota
        '
        Me.txtNMascota.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNMascota.Border.Class = "TextBoxBorder"
        Me.txtNMascota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNMascota.DisabledBackColor = System.Drawing.Color.White
        Me.txtNMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMascota.ForeColor = System.Drawing.Color.Black
        Me.txtNMascota.Location = New System.Drawing.Point(156, 85)
        Me.txtNMascota.MaxLength = 25
        Me.txtNMascota.Name = "txtNMascota"
        Me.txtNMascota.PreventEnterBeep = True
        Me.txtNMascota.Size = New System.Drawing.Size(242, 22)
        Me.txtNMascota.TabIndex = 1
        Me.txtNMascota.Tag = ""
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtColor.Border.Class = "TextBoxBorder"
        Me.txtColor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtColor.DisabledBackColor = System.Drawing.Color.White
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.Black
        Me.txtColor.Location = New System.Drawing.Point(508, 116)
        Me.txtColor.MaxLength = 20
        Me.txtColor.Name = "txtColor"
        Me.txtColor.PreventEnterBeep = True
        Me.txtColor.Size = New System.Drawing.Size(233, 22)
        Me.txtColor.TabIndex = 8
        '
        'lbColor
        '
        Me.lbColor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbColor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbColor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbColor.Location = New System.Drawing.Point(421, 114)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbColor.Size = New System.Drawing.Size(64, 23)
        Me.lbColor.TabIndex = 225
        Me.lbColor.Text = "Color:"
        '
        'txtIdMascota
        '
        Me.txtIdMascota.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdMascota.Border.Class = "TextBoxBorder"
        Me.txtIdMascota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdMascota.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdMascota.Enabled = False
        Me.txtIdMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMascota.ForeColor = System.Drawing.Color.Black
        Me.txtIdMascota.Location = New System.Drawing.Point(156, 54)
        Me.txtIdMascota.Name = "txtIdMascota"
        Me.txtIdMascota.PreventEnterBeep = True
        Me.txtIdMascota.Size = New System.Drawing.Size(63, 22)
        Me.txtIdMascota.TabIndex = 0
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.JGBPropietario)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(88, 3)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(851, 243)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel3.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 259
        Me.GroupPanel3.Text = "BÚSQUEDA DE PROPIETARIOS"
        '
        'JGBPropietario
        '
        Me.JGBPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGBPropietario.Location = New System.Drawing.Point(3, 3)
        Me.JGBPropietario.Name = "JGBPropietario"
        Me.JGBPropietario.Size = New System.Drawing.Size(839, 214)
        Me.JGBPropietario.TabIndex = 256
        '
        'gpBusqMascotas
        '
        Me.gpBusqMascotas.BackColor = System.Drawing.Color.Transparent
        Me.gpBusqMascotas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqMascotas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqMascotas.Controls.Add(Me.JGBusqMascotas)
        Me.gpBusqMascotas.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqMascotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpBusqMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqMascotas.Location = New System.Drawing.Point(0, 0)
        Me.gpBusqMascotas.Name = "gpBusqMascotas"
        Me.gpBusqMascotas.Size = New System.Drawing.Size(923, 455)
        '
        '
        '
        Me.gpBusqMascotas.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqMascotas.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqMascotas.Style.BackColorGradientAngle = 90
        Me.gpBusqMascotas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqMascotas.Style.BorderBottomWidth = 1
        Me.gpBusqMascotas.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqMascotas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqMascotas.Style.BorderLeftWidth = 1
        Me.gpBusqMascotas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqMascotas.Style.BorderRightWidth = 1
        Me.gpBusqMascotas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqMascotas.Style.BorderTopWidth = 1
        Me.gpBusqMascotas.Style.CornerDiameter = 4
        Me.gpBusqMascotas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusqMascotas.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqMascotas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusqMascotas.Style.TextColor = System.Drawing.Color.White
        Me.gpBusqMascotas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusqMascotas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusqMascotas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusqMascotas.TabIndex = 260
        Me.gpBusqMascotas.Text = "BÚSQUEDA DE PACIENTES"
        '
        'JGBusqMascotas
        '
        Me.JGBusqMascotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqMascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGBusqMascotas.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGBusqMascotas.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqMascotas.Name = "JGBusqMascotas"
        Me.JGBusqMascotas.Size = New System.Drawing.Size(917, 432)
        Me.JGBusqMascotas.TabIndex = 256
        '
        'F1_Reg_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(849, 480)
        Me.Name = "F1_Reg_Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE PACIENTES"
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
        Me.gpDatosMascota.ResumeLayout(False)
        Me.panelDatosMascota.ResumeLayout(False)
        Me.panelDatosMascota.PerformLayout()
        CType(Me.dtpFnac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEsterilizado.ResumeLayout(False)
        Me.PanelSexo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEspecie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.JGBPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqMascotas.ResumeLayout(False)
        CType(Me.JGBusqMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpDatosMascota As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelDatosMascota As Panel
    Friend WithEvents dtpFIngresoM As DateTimePicker
    Friend WithEvents lbFIngreso As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEstado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbEsterilizado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbSexo As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSeñas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbSeñas As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbRaza As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbRaza As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbEspecie As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbEspecie As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdMascota As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbNombMasc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbFNac As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNMascota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtColor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbColor As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdMascota As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents PanelSexo As Panel
    Friend WithEvents chbMacho As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbHembra As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelEsterilizado As Panel
    Friend WithEvents chbSi As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbNo As DevComponents.DotNetBar.Controls.CheckBoxX
    Protected WithEvents gpBusqMascotas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGBusqMascotas As Janus.Windows.GridEX.GridEX
    Protected WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGBPropietario As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnEspecie As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRaza As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtpFnac As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
