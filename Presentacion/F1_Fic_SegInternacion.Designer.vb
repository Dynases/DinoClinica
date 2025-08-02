<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Fic_SegInternacion
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
        Dim cbTurno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Fic_SegInternacion))
        Me.gpSegInternacion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelDatosInternacion = New System.Windows.Forms.Panel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtOtros = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnTurno = New DevComponents.DotNetBar.ButtonX()
        Me.txtFrecuencias = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbPasoTurno = New DevComponents.DotNetBar.LabelX()
        Me.txtPasoTurno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtHora = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.gpSeguimiento = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelSeguimiento = New System.Windows.Forms.Panel()
        Me.JGSeguimiento = New Janus.Windows.GridEX.GridEX()
        Me.lbRequerimientos = New DevComponents.DotNetBar.LabelX()
        Me.lbAlimentacion = New DevComponents.DotNetBar.LabelX()
        Me.txtAlimentacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbProtocolo = New DevComponents.DotNetBar.LabelX()
        Me.lbMedicacion = New DevComponents.DotNetBar.LabelX()
        Me.txtResponsable = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbResponsable = New DevComponents.DotNetBar.LabelX()
        Me.lbTurno = New DevComponents.DotNetBar.LabelX()
        Me.cbTurno = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.txtPacienteI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbPacienteI = New DevComponents.DotNetBar.LabelX()
        Me.txtDiagnostico = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDiagnostico = New DevComponents.DotNetBar.LabelX()
        Me.txtMedProtocolo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbFrecuencias = New DevComponents.DotNetBar.LabelX()
        Me.lbIdFicha = New DevComponents.DotNetBar.LabelX()
        Me.txtIdFicClinica = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbFechaI = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaSeg = New System.Windows.Forms.DateTimePicker()
        Me.txtObsRequerimientos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbObservaciones = New DevComponents.DotNetBar.LabelX()
        Me.gpBusqSeguimiento = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelBusqSeguimiento = New System.Windows.Forms.Panel()
        Me.JGBusqSeguimiento = New Janus.Windows.GridEX.GridEX()
        Me.btnFClinica = New DevComponents.DotNetBar.ButtonX()
        Me.btnReciboI = New DevComponents.DotNetBar.ButtonX()
        Me.btnSeguimiento = New DevComponents.DotNetBar.ButtonX()
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
        Me.gpSegInternacion.SuspendLayout()
        Me.panelDatosInternacion.SuspendLayout()
        Me.gpSeguimiento.SuspendLayout()
        Me.panelSeguimiento.SuspendLayout()
        CType(Me.JGSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqSeguimiento.SuspendLayout()
        Me.panelBusqSeguimiento.SuspendLayout()
        CType(Me.JGBusqSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpSegInternacion)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(929, 555)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.btnSeguimiento)
        Me.PanelSuperior.Controls.Add(Me.btnReciboI)
        Me.PanelSuperior.Controls.Add(Me.btnFClinica)
        Me.PanelSuperior.Size = New System.Drawing.Size(929, 72)
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
        Me.PanelSuperior.Controls.SetChildIndex(Me.btnFClinica, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.btnReciboI, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.btnSeguimiento, 0)
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 627)
        Me.PanelInferior.Size = New System.Drawing.Size(929, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(729, 0)
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
        Me.MpanelBuscador.BackgroundImage = Global.Presentacion.My.Resources.Resources.Fondo2
        Me.MpanelBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MpanelBuscador.Controls.Add(Me.gpBusqSeguimiento)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(317, 273)
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
        Me.superTabControl1.Size = New System.Drawing.Size(929, 691)
        '
        'gpSegInternacion
        '
        Me.gpSegInternacion.BackColor = System.Drawing.Color.Transparent
        Me.gpSegInternacion.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpSegInternacion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpSegInternacion.Controls.Add(Me.panelDatosInternacion)
        Me.gpSegInternacion.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpSegInternacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSegInternacion.Location = New System.Drawing.Point(3, 3)
        Me.gpSegInternacion.Name = "gpSegInternacion"
        Me.gpSegInternacion.Size = New System.Drawing.Size(922, 549)
        '
        '
        '
        Me.gpSegInternacion.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSegInternacion.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSegInternacion.Style.BackColorGradientAngle = 90
        Me.gpSegInternacion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSegInternacion.Style.BorderBottomWidth = 1
        Me.gpSegInternacion.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSegInternacion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSegInternacion.Style.BorderLeftWidth = 1
        Me.gpSegInternacion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSegInternacion.Style.BorderRightWidth = 1
        Me.gpSegInternacion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSegInternacion.Style.BorderTopWidth = 1
        Me.gpSegInternacion.Style.CornerDiameter = 4
        Me.gpSegInternacion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpSegInternacion.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSegInternacion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpSegInternacion.Style.TextColor = System.Drawing.Color.White
        Me.gpSegInternacion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpSegInternacion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpSegInternacion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpSegInternacion.TabIndex = 348
        Me.gpSegInternacion.Text = "SEGUIMIENTO INTERNACIÓN"
        '
        'panelDatosInternacion
        '
        Me.panelDatosInternacion.AutoScroll = True
        Me.panelDatosInternacion.BackColor = System.Drawing.Color.White
        Me.panelDatosInternacion.Controls.Add(Me.LabelX4)
        Me.panelDatosInternacion.Controls.Add(Me.txtOtros)
        Me.panelDatosInternacion.Controls.Add(Me.LabelX1)
        Me.panelDatosInternacion.Controls.Add(Me.btnTurno)
        Me.panelDatosInternacion.Controls.Add(Me.txtFrecuencias)
        Me.panelDatosInternacion.Controls.Add(Me.lbPasoTurno)
        Me.panelDatosInternacion.Controls.Add(Me.txtPasoTurno)
        Me.panelDatosInternacion.Controls.Add(Me.txtHora)
        Me.panelDatosInternacion.Controls.Add(Me.LabelX2)
        Me.panelDatosInternacion.Controls.Add(Me.gpSeguimiento)
        Me.panelDatosInternacion.Controls.Add(Me.lbRequerimientos)
        Me.panelDatosInternacion.Controls.Add(Me.lbAlimentacion)
        Me.panelDatosInternacion.Controls.Add(Me.txtAlimentacion)
        Me.panelDatosInternacion.Controls.Add(Me.lbProtocolo)
        Me.panelDatosInternacion.Controls.Add(Me.lbMedicacion)
        Me.panelDatosInternacion.Controls.Add(Me.txtResponsable)
        Me.panelDatosInternacion.Controls.Add(Me.lbResponsable)
        Me.panelDatosInternacion.Controls.Add(Me.lbTurno)
        Me.panelDatosInternacion.Controls.Add(Me.cbTurno)
        Me.panelDatosInternacion.Controls.Add(Me.txtPacienteI)
        Me.panelDatosInternacion.Controls.Add(Me.lbPacienteI)
        Me.panelDatosInternacion.Controls.Add(Me.txtDiagnostico)
        Me.panelDatosInternacion.Controls.Add(Me.lbDiagnostico)
        Me.panelDatosInternacion.Controls.Add(Me.txtMedProtocolo)
        Me.panelDatosInternacion.Controls.Add(Me.lbFrecuencias)
        Me.panelDatosInternacion.Controls.Add(Me.lbIdFicha)
        Me.panelDatosInternacion.Controls.Add(Me.txtIdFicClinica)
        Me.panelDatosInternacion.Controls.Add(Me.lbFechaI)
        Me.panelDatosInternacion.Controls.Add(Me.dtpFechaSeg)
        Me.panelDatosInternacion.Controls.Add(Me.txtObsRequerimientos)
        Me.panelDatosInternacion.Controls.Add(Me.lbObservaciones)
        Me.panelDatosInternacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosInternacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelDatosInternacion.Location = New System.Drawing.Point(0, 0)
        Me.panelDatosInternacion.Name = "panelDatosInternacion"
        Me.panelDatosInternacion.Size = New System.Drawing.Size(916, 526)
        Me.panelDatosInternacion.TabIndex = 235
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(225, 8)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 23)
        Me.LabelX4.TabIndex = 396
        Me.LabelX4.Text = "Ctrl+Enter"
        '
        'txtOtros
        '
        Me.txtOtros.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtOtros.Border.Class = "TextBoxBorder"
        Me.txtOtros.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOtros.DisabledBackColor = System.Drawing.Color.White
        Me.txtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.ForeColor = System.Drawing.Color.Black
        Me.txtOtros.Location = New System.Drawing.Point(105, 247)
        Me.txtOtros.MaxLength = 400
        Me.txtOtros.Multiline = True
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.PreventEnterBeep = True
        Me.txtOtros.Size = New System.Drawing.Size(200, 45)
        Me.txtOtros.TabIndex = 394
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(13, 247)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(54, 19)
        Me.LabelX1.TabIndex = 393
        Me.LabelX1.Text = "Otros:"
        '
        'btnTurno
        '
        Me.btnTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnTurno.Image = Global.Presentacion.My.Resources.Resources.nuevo
        Me.btnTurno.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnTurno.Location = New System.Drawing.Point(234, 87)
        Me.btnTurno.Name = "btnTurno"
        Me.btnTurno.Size = New System.Drawing.Size(28, 29)
        Me.btnTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTurno.TabIndex = 391
        Me.btnTurno.Visible = False
        '
        'txtFrecuencias
        '
        Me.txtFrecuencias.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFrecuencias.Border.Class = "TextBoxBorder"
        Me.txtFrecuencias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFrecuencias.DisabledBackColor = System.Drawing.Color.White
        Me.txtFrecuencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrecuencias.ForeColor = System.Drawing.Color.Black
        Me.txtFrecuencias.Location = New System.Drawing.Point(105, 173)
        Me.txtFrecuencias.MaxLength = 400
        Me.txtFrecuencias.Multiline = True
        Me.txtFrecuencias.Name = "txtFrecuencias"
        Me.txtFrecuencias.PreventEnterBeep = True
        Me.txtFrecuencias.Size = New System.Drawing.Size(200, 65)
        Me.txtFrecuencias.TabIndex = 2
        '
        'lbPasoTurno
        '
        '
        '
        '
        Me.lbPasoTurno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPasoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPasoTurno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPasoTurno.Location = New System.Drawing.Point(364, 218)
        Me.lbPasoTurno.Name = "lbPasoTurno"
        Me.lbPasoTurno.Size = New System.Drawing.Size(100, 19)
        Me.lbPasoTurno.TabIndex = 390
        Me.lbPasoTurno.Text = "Paso de Turno:"
        '
        'txtPasoTurno
        '
        Me.txtPasoTurno.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPasoTurno.Border.Class = "TextBoxBorder"
        Me.txtPasoTurno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPasoTurno.DisabledBackColor = System.Drawing.Color.White
        Me.txtPasoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasoTurno.ForeColor = System.Drawing.Color.Black
        Me.txtPasoTurno.Location = New System.Drawing.Point(470, 212)
        Me.txtPasoTurno.MaxLength = 500
        Me.txtPasoTurno.Multiline = True
        Me.txtPasoTurno.Name = "txtPasoTurno"
        Me.txtPasoTurno.PreventEnterBeep = True
        Me.txtPasoTurno.Size = New System.Drawing.Size(430, 80)
        Me.txtPasoTurno.TabIndex = 6
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHora.Border.Class = "TextBoxBorder"
        Me.txtHora.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHora.DisabledBackColor = System.Drawing.Color.White
        Me.txtHora.ForeColor = System.Drawing.Color.Black
        Me.txtHora.Location = New System.Drawing.Point(381, 255)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.PreventEnterBeep = True
        Me.txtHora.Size = New System.Drawing.Size(74, 22)
        Me.txtHora.TabIndex = 387
        Me.txtHora.Visible = False
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(338, 254)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(37, 23)
        Me.LabelX2.TabIndex = 386
        Me.LabelX2.Text = "Hora:"
        Me.LabelX2.Visible = False
        '
        'gpSeguimiento
        '
        Me.gpSeguimiento.BackColor = System.Drawing.Color.White
        Me.gpSeguimiento.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpSeguimiento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpSeguimiento.Controls.Add(Me.panelSeguimiento)
        Me.gpSeguimiento.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpSeguimiento.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSeguimiento.Location = New System.Drawing.Point(10, 298)
        Me.gpSeguimiento.Name = "gpSeguimiento"
        Me.gpSeguimiento.Size = New System.Drawing.Size(897, 224)
        '
        '
        '
        Me.gpSeguimiento.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSeguimiento.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSeguimiento.Style.BackColorGradientAngle = 90
        Me.gpSeguimiento.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSeguimiento.Style.BorderBottomWidth = 1
        Me.gpSeguimiento.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpSeguimiento.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSeguimiento.Style.BorderLeftWidth = 1
        Me.gpSeguimiento.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSeguimiento.Style.BorderRightWidth = 1
        Me.gpSeguimiento.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSeguimiento.Style.BorderTopWidth = 1
        Me.gpSeguimiento.Style.CornerDiameter = 4
        Me.gpSeguimiento.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpSeguimiento.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpSeguimiento.Style.TextColor = System.Drawing.Color.White
        Me.gpSeguimiento.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpSeguimiento.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpSeguimiento.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpSeguimiento.TabIndex = 385
        Me.gpSeguimiento.Text = "S E G U I M I E N T O"
        '
        'panelSeguimiento
        '
        Me.panelSeguimiento.BackColor = System.Drawing.Color.White
        Me.panelSeguimiento.Controls.Add(Me.JGSeguimiento)
        Me.panelSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.panelSeguimiento.Name = "panelSeguimiento"
        Me.panelSeguimiento.Size = New System.Drawing.Size(891, 201)
        Me.panelSeguimiento.TabIndex = 0
        '
        'JGSeguimiento
        '
        Me.JGSeguimiento.BackColor = System.Drawing.Color.GhostWhite
        Me.JGSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGSeguimiento.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGSeguimiento.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGSeguimiento.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.JGSeguimiento.Name = "JGSeguimiento"
        Me.JGSeguimiento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGSeguimiento.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGSeguimiento.Size = New System.Drawing.Size(891, 201)
        Me.JGSeguimiento.TabIndex = 0
        Me.JGSeguimiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbRequerimientos
        '
        '
        '
        '
        Me.lbRequerimientos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRequerimientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbRequerimientos.Location = New System.Drawing.Point(364, 133)
        Me.lbRequerimientos.Name = "lbRequerimientos"
        Me.lbRequerimientos.Size = New System.Drawing.Size(100, 19)
        Me.lbRequerimientos.TabIndex = 384
        Me.lbRequerimientos.Text = "Requerimientos:"
        '
        'lbAlimentacion
        '
        '
        '
        '
        Me.lbAlimentacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbAlimentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlimentacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbAlimentacion.Location = New System.Drawing.Point(364, 75)
        Me.lbAlimentacion.Name = "lbAlimentacion"
        Me.lbAlimentacion.Size = New System.Drawing.Size(84, 19)
        Me.lbAlimentacion.TabIndex = 383
        Me.lbAlimentacion.Text = "Alimentación:"
        '
        'txtAlimentacion
        '
        Me.txtAlimentacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAlimentacion.Border.Class = "TextBoxBorder"
        Me.txtAlimentacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlimentacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtAlimentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlimentacion.ForeColor = System.Drawing.Color.Black
        Me.txtAlimentacion.Location = New System.Drawing.Point(470, 79)
        Me.txtAlimentacion.MaxLength = 400
        Me.txtAlimentacion.Multiline = True
        Me.txtAlimentacion.Name = "txtAlimentacion"
        Me.txtAlimentacion.PreventEnterBeep = True
        Me.txtAlimentacion.Size = New System.Drawing.Size(430, 34)
        Me.txtAlimentacion.TabIndex = 4
        '
        'lbProtocolo
        '
        '
        '
        '
        Me.lbProtocolo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbProtocolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProtocolo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbProtocolo.Location = New System.Drawing.Point(364, 25)
        Me.lbProtocolo.Name = "lbProtocolo"
        Me.lbProtocolo.Size = New System.Drawing.Size(84, 19)
        Me.lbProtocolo.TabIndex = 381
        Me.lbProtocolo.Text = "Protocolo:"
        '
        'lbMedicacion
        '
        '
        '
        '
        Me.lbMedicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMedicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMedicacion.Location = New System.Drawing.Point(364, 10)
        Me.lbMedicacion.Name = "lbMedicacion"
        Me.lbMedicacion.Size = New System.Drawing.Size(84, 19)
        Me.lbMedicacion.TabIndex = 380
        Me.lbMedicacion.Text = "Medicación"
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtResponsable.Border.Class = "TextBoxBorder"
        Me.txtResponsable.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtResponsable.DisabledBackColor = System.Drawing.Color.White
        Me.txtResponsable.ForeColor = System.Drawing.Color.Black
        Me.txtResponsable.Location = New System.Drawing.Point(105, 146)
        Me.txtResponsable.MaxLength = 50
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.PreventEnterBeep = True
        Me.txtResponsable.Size = New System.Drawing.Size(200, 22)
        Me.txtResponsable.TabIndex = 1
        '
        'lbResponsable
        '
        '
        '
        '
        Me.lbResponsable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResponsable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbResponsable.Location = New System.Drawing.Point(13, 145)
        Me.lbResponsable.Name = "lbResponsable"
        Me.lbResponsable.Size = New System.Drawing.Size(86, 23)
        Me.lbResponsable.TabIndex = 377
        Me.lbResponsable.Text = "Responsable:"
        '
        'lbTurno
        '
        '
        '
        '
        Me.lbTurno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTurno.Location = New System.Drawing.Point(13, 89)
        Me.lbTurno.Name = "lbTurno"
        Me.lbTurno.Size = New System.Drawing.Size(63, 23)
        Me.lbTurno.TabIndex = 376
        Me.lbTurno.Text = "Turno:"
        '
        'cbTurno
        '
        cbTurno_DesignTimeLayout.LayoutString = resources.GetString("cbTurno_DesignTimeLayout.LayoutString")
        Me.cbTurno.DesignTimeLayout = cbTurno_DesignTimeLayout
        Me.cbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurno.Location = New System.Drawing.Point(105, 90)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTurno.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTurno.SelectedIndex = -1
        Me.cbTurno.SelectedItem = Nothing
        Me.cbTurno.Size = New System.Drawing.Size(122, 22)
        Me.cbTurno.TabIndex = 374
        Me.cbTurno.Tag = "1"
        Me.cbTurno.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtPacienteI
        '
        Me.txtPacienteI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPacienteI.Border.Class = "TextBoxBorder"
        Me.txtPacienteI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPacienteI.DisabledBackColor = System.Drawing.Color.White
        Me.txtPacienteI.Enabled = False
        Me.txtPacienteI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacienteI.ForeColor = System.Drawing.Color.Black
        Me.txtPacienteI.Location = New System.Drawing.Point(105, 35)
        Me.txtPacienteI.Name = "txtPacienteI"
        Me.txtPacienteI.PreventEnterBeep = True
        Me.txtPacienteI.Size = New System.Drawing.Size(244, 22)
        Me.txtPacienteI.TabIndex = 373
        '
        'lbPacienteI
        '
        Me.lbPacienteI.AutoSize = True
        Me.lbPacienteI.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbPacienteI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPacienteI.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPacienteI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbPacienteI.Location = New System.Drawing.Point(13, 37)
        Me.lbPacienteI.Name = "lbPacienteI"
        Me.lbPacienteI.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbPacienteI.Size = New System.Drawing.Size(60, 16)
        Me.lbPacienteI.TabIndex = 372
        Me.lbPacienteI.Text = "Paciente:"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDiagnostico.Border.Class = "TextBoxBorder"
        Me.txtDiagnostico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDiagnostico.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiagnostico.ForeColor = System.Drawing.Color.Black
        Me.txtDiagnostico.Location = New System.Drawing.Point(105, 118)
        Me.txtDiagnostico.MaxLength = 50
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.PreventEnterBeep = True
        Me.txtDiagnostico.Size = New System.Drawing.Size(200, 22)
        Me.txtDiagnostico.TabIndex = 0
        '
        'lbDiagnostico
        '
        '
        '
        '
        Me.lbDiagnostico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiagnostico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDiagnostico.Location = New System.Drawing.Point(13, 117)
        Me.lbDiagnostico.Name = "lbDiagnostico"
        Me.lbDiagnostico.Size = New System.Drawing.Size(85, 23)
        Me.lbDiagnostico.TabIndex = 360
        Me.lbDiagnostico.Text = "Diagnóstico:"
        '
        'txtMedProtocolo
        '
        Me.txtMedProtocolo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMedProtocolo.Border.Class = "TextBoxBorder"
        Me.txtMedProtocolo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMedProtocolo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMedProtocolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedProtocolo.ForeColor = System.Drawing.Color.Black
        Me.txtMedProtocolo.Location = New System.Drawing.Point(470, 11)
        Me.txtMedProtocolo.MaxLength = 400
        Me.txtMedProtocolo.Multiline = True
        Me.txtMedProtocolo.Name = "txtMedProtocolo"
        Me.txtMedProtocolo.PreventEnterBeep = True
        Me.txtMedProtocolo.Size = New System.Drawing.Size(430, 60)
        Me.txtMedProtocolo.TabIndex = 3
        '
        'lbFrecuencias
        '
        '
        '
        '
        Me.lbFrecuencias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFrecuencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrecuencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFrecuencias.Location = New System.Drawing.Point(13, 174)
        Me.lbFrecuencias.Name = "lbFrecuencias"
        Me.lbFrecuencias.Size = New System.Drawing.Size(84, 19)
        Me.lbFrecuencias.TabIndex = 355
        Me.lbFrecuencias.Text = "Frecuencias:"
        '
        'lbIdFicha
        '
        '
        '
        '
        Me.lbIdFicha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdFicha.Location = New System.Drawing.Point(13, 10)
        Me.lbIdFicha.Name = "lbIdFicha"
        Me.lbIdFicha.Size = New System.Drawing.Size(56, 23)
        Me.lbIdFicha.TabIndex = 343
        Me.lbIdFicha.Text = "Id Ficha:"
        '
        'txtIdFicClinica
        '
        Me.txtIdFicClinica.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdFicClinica.Border.Class = "TextBoxBorder"
        Me.txtIdFicClinica.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdFicClinica.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdFicClinica.ForeColor = System.Drawing.Color.Black
        Me.txtIdFicClinica.Location = New System.Drawing.Point(105, 9)
        Me.txtIdFicClinica.Name = "txtIdFicClinica"
        Me.txtIdFicClinica.PreventEnterBeep = True
        Me.txtIdFicClinica.Size = New System.Drawing.Size(115, 22)
        Me.txtIdFicClinica.TabIndex = 342
        '
        'lbFechaI
        '
        '
        '
        '
        Me.lbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaI.Location = New System.Drawing.Point(13, 61)
        Me.lbFechaI.Name = "lbFechaI"
        Me.lbFechaI.Size = New System.Drawing.Size(63, 23)
        Me.lbFechaI.TabIndex = 341
        Me.lbFechaI.Text = "Fecha:"
        '
        'dtpFechaSeg
        '
        Me.dtpFechaSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSeg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSeg.Location = New System.Drawing.Point(105, 62)
        Me.dtpFechaSeg.Name = "dtpFechaSeg"
        Me.dtpFechaSeg.Size = New System.Drawing.Size(122, 22)
        Me.dtpFechaSeg.TabIndex = 340
        Me.dtpFechaSeg.TabStop = False
        '
        'txtObsRequerimientos
        '
        Me.txtObsRequerimientos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObsRequerimientos.Border.Class = "TextBoxBorder"
        Me.txtObsRequerimientos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObsRequerimientos.DisabledBackColor = System.Drawing.Color.White
        Me.txtObsRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsRequerimientos.ForeColor = System.Drawing.Color.Black
        Me.txtObsRequerimientos.Location = New System.Drawing.Point(470, 123)
        Me.txtObsRequerimientos.MaxLength = 500
        Me.txtObsRequerimientos.Multiline = True
        Me.txtObsRequerimientos.Name = "txtObsRequerimientos"
        Me.txtObsRequerimientos.PreventEnterBeep = True
        Me.txtObsRequerimientos.Size = New System.Drawing.Size(430, 79)
        Me.txtObsRequerimientos.TabIndex = 5
        '
        'lbObservaciones
        '
        '
        '
        '
        Me.lbObservaciones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbObservaciones.Location = New System.Drawing.Point(364, 117)
        Me.lbObservaciones.Name = "lbObservaciones"
        Me.lbObservaciones.Size = New System.Drawing.Size(100, 19)
        Me.lbObservaciones.TabIndex = 339
        Me.lbObservaciones.Text = "Observaciones"
        '
        'gpBusqSeguimiento
        '
        Me.gpBusqSeguimiento.BackColor = System.Drawing.Color.Transparent
        Me.gpBusqSeguimiento.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqSeguimiento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqSeguimiento.Controls.Add(Me.panelBusqSeguimiento)
        Me.gpBusqSeguimiento.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqSeguimiento.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqSeguimiento.Location = New System.Drawing.Point(9, 14)
        Me.gpBusqSeguimiento.Name = "gpBusqSeguimiento"
        Me.gpBusqSeguimiento.Size = New System.Drawing.Size(909, 640)
        '
        '
        '
        Me.gpBusqSeguimiento.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqSeguimiento.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqSeguimiento.Style.BackColorGradientAngle = 90
        Me.gpBusqSeguimiento.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqSeguimiento.Style.BorderBottomWidth = 1
        Me.gpBusqSeguimiento.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqSeguimiento.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqSeguimiento.Style.BorderLeftWidth = 1
        Me.gpBusqSeguimiento.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqSeguimiento.Style.BorderRightWidth = 1
        Me.gpBusqSeguimiento.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqSeguimiento.Style.BorderTopWidth = 1
        Me.gpBusqSeguimiento.Style.CornerDiameter = 4
        Me.gpBusqSeguimiento.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusqSeguimiento.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqSeguimiento.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusqSeguimiento.Style.TextColor = System.Drawing.Color.White
        Me.gpBusqSeguimiento.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusqSeguimiento.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusqSeguimiento.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusqSeguimiento.TabIndex = 5
        Me.gpBusqSeguimiento.Text = "BUSCADOR  SEGUIMIENTO INTERNACIÓN"
        '
        'panelBusqSeguimiento
        '
        Me.panelBusqSeguimiento.BackColor = System.Drawing.Color.White
        Me.panelBusqSeguimiento.Controls.Add(Me.JGBusqSeguimiento)
        Me.panelBusqSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBusqSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.panelBusqSeguimiento.Name = "panelBusqSeguimiento"
        Me.panelBusqSeguimiento.Size = New System.Drawing.Size(903, 617)
        Me.panelBusqSeguimiento.TabIndex = 0
        '
        'JGBusqSeguimiento
        '
        Me.JGBusqSeguimiento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGBusqSeguimiento.BackColor = System.Drawing.Color.GhostWhite
        Me.JGBusqSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGBusqSeguimiento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGBusqSeguimiento.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGBusqSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGBusqSeguimiento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGBusqSeguimiento.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqSeguimiento.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGBusqSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.JGBusqSeguimiento.Name = "JGBusqSeguimiento"
        Me.JGBusqSeguimiento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGBusqSeguimiento.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqSeguimiento.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGBusqSeguimiento.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGBusqSeguimiento.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGBusqSeguimiento.SelectOnExpand = False
        Me.JGBusqSeguimiento.Size = New System.Drawing.Size(903, 617)
        Me.JGBusqSeguimiento.TabIndex = 0
        Me.JGBusqSeguimiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnFClinica
        '
        Me.btnFClinica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFClinica.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnFClinica.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFClinica.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFClinica.Image = Global.Presentacion.My.Resources.Resources.fichaclinica1
        Me.btnFClinica.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnFClinica.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFClinica.Location = New System.Drawing.Point(841, 0)
        Me.btnFClinica.Name = "btnFClinica"
        Me.btnFClinica.Size = New System.Drawing.Size(88, 72)
        Me.btnFClinica.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnFClinica.TabIndex = 17
        Me.btnFClinica.Text = "FICHA CLÍNICA"
        Me.btnFClinica.TextColor = System.Drawing.Color.White
        '
        'btnReciboI
        '
        Me.btnReciboI.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReciboI.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnReciboI.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReciboI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReciboI.Image = Global.Presentacion.My.Resources.Resources.recibo
        Me.btnReciboI.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnReciboI.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnReciboI.Location = New System.Drawing.Point(761, 0)
        Me.btnReciboI.Name = "btnReciboI"
        Me.btnReciboI.Size = New System.Drawing.Size(80, 72)
        Me.btnReciboI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReciboI.TabIndex = 19
        Me.btnReciboI.Text = "RECIBO"
        Me.btnReciboI.TextColor = System.Drawing.Color.White
        '
        'btnSeguimiento
        '
        Me.btnSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeguimiento.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnSeguimiento.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSeguimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguimiento.Image = Global.Presentacion.My.Resources.Resources.hojaruta
        Me.btnSeguimiento.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnSeguimiento.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSeguimiento.Location = New System.Drawing.Point(673, 0)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(88, 72)
        Me.btnSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSeguimiento.TabIndex = 20
        Me.btnSeguimiento.Text = "SEGUIMIENTO"
        Me.btnSeguimiento.TextColor = System.Drawing.Color.White
        '
        'F1_Fic_SegInternacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 691)
        Me.Name = "F1_Fic_SegInternacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEGUIMIENTO INTERNACIÓN"
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
        Me.gpSegInternacion.ResumeLayout(False)
        Me.panelDatosInternacion.ResumeLayout(False)
        Me.panelDatosInternacion.PerformLayout()
        Me.gpSeguimiento.ResumeLayout(False)
        Me.panelSeguimiento.ResumeLayout(False)
        CType(Me.JGSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqSeguimiento.ResumeLayout(False)
        Me.panelBusqSeguimiento.ResumeLayout(False)
        CType(Me.JGBusqSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents gpSegInternacion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelDatosInternacion As Panel
    Friend WithEvents txtOtros As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnTurno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtFrecuencias As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbPasoTurno As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPasoTurno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHora As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpSeguimiento As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelSeguimiento As Panel
    Friend WithEvents JGSeguimiento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lbRequerimientos As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbAlimentacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAlimentacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbProtocolo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMedicacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtResponsable As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbResponsable As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTurno As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTurno As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents txtPacienteI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbPacienteI As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDiagnostico As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDiagnostico As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMedProtocolo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbFrecuencias As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdFicha As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdFicClinica As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbFechaI As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaSeg As DateTimePicker
    Friend WithEvents txtObsRequerimientos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbObservaciones As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpBusqSeguimiento As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqSeguimiento As Panel
    Friend WithEvents JGBusqSeguimiento As Janus.Windows.GridEX.GridEX
    Protected WithEvents btnFClinica As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Protected WithEvents btnSeguimiento As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnReciboI As DevComponents.DotNetBar.ButtonX
End Class
