<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Fic_SegInternacion2
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
        Dim cbTurnoEF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTurnoF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTurno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Fic_SegInternacion2))
        Me.gpFichaInternacion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.stcFichaInternacion = New DevComponents.DotNetBar.SuperTabControl()
        Me.stcpExamenFisico = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelExamenFisico = New System.Windows.Forms.Panel()
        Me.gpExamenFisico = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.JGExamenFisico = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaEF = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraEF = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAgregarEF = New DevComponents.DotNetBar.ButtonX()
        Me.cbTurnoEF = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
        Me.PanelGradoConciencia = New System.Windows.Forms.Panel()
        Me.chbComa = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbEstable = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbSemicomatoso = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PanelDolor = New System.Windows.Forms.Panel()
        Me.chbSevero = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbLeve = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbModerado = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lbMucosas = New DevComponents.DotNetBar.LabelX()
        Me.PanelDeshidratacion = New System.Windows.Forms.Panel()
        Me.chb5_7 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chb0_5 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chb8_10 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lbDeshidratacion = New DevComponents.DotNetBar.LabelX()
        Me.PanelMucosas = New System.Windows.Forms.Panel()
        Me.chbCianoticas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbPalidas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbRosadas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chbIctericas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lbDolor = New DevComponents.DotNetBar.LabelX()
        Me.lbGradoConciencia = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpTratamiento = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelTratamiento = New System.Windows.Forms.Panel()
        Me.gpTratamiento = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.JGTratamiento = New Janus.Windows.GridEX.GridEX()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btnLimpiarT = New DevComponents.DotNetBar.ButtonX()
        Me.txtTratamiento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpFechaT = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarT = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtHoraT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem10 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpEstudiosComplem = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEstudiosComplemen = New System.Windows.Forms.Panel()
        Me.gpEstudiosComplem = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.JGEstudiosC = New Janus.Windows.GridEX.GridEX()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnLimpiarEC = New DevComponents.DotNetBar.ButtonX()
        Me.txtEstudiosComplem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpFechaEC = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarEC = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtHoraEC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem9 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpFluidoterapia = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelFluidoterapia = New System.Windows.Forms.Panel()
        Me.gpFluidoterapia = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.JGFluidoterapia = New Janus.Windows.GridEX.GridEX()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnLimpiarF = New DevComponents.DotNetBar.ButtonX()
        Me.dtpFechaF = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarF = New DevComponents.DotNetBar.ButtonX()
        Me.txtHoraTermino = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX53 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX54 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX55 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX56 = New DevComponents.DotNetBar.LabelX()
        Me.txtHoraInicio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFluidos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCantidad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtHoraF = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX57 = New DevComponents.DotNetBar.LabelX()
        Me.cbTurnoF = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.SuperTabItem8 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpAlimentacion = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelAlimentacion = New System.Windows.Forms.Panel()
        Me.gpAlimentacion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.JGAlimentacion = New Janus.Windows.GridEX.GridEX()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnLimpiarA = New DevComponents.DotNetBar.ButtonX()
        Me.txtRequerimiento = New DevComponents.Editors.IntegerInput()
        Me.txtObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaA = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarA = New DevComponents.DotNetBar.ButtonX()
        Me.txtRecovery = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX42 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX43 = New DevComponents.DotNetBar.LabelX()
        Me.txtNPO = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAgua = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX44 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX45 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX46 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX47 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX48 = New DevComponents.DotNetBar.LabelX()
        Me.txtPVM = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPolloLic = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPolloDesm = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtHoraA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem7 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpMonitoreo = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelMonitoreo = New System.Windows.Forms.Panel()
        Me.gpMonitoreo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelSeguimiento = New System.Windows.Forms.Panel()
        Me.JGMonitoreo = New Janus.Windows.GridEX.GridEX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLimpiarM = New DevComponents.DotNetBar.ButtonX()
        Me.dtpFechaM = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarM = New DevComponents.DotNetBar.ButtonX()
        Me.txtTRC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
        Me.txtPSys = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMED = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPDys = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX37 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX38 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX39 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX40 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX41 = New DevComponents.DotNetBar.LabelX()
        Me.txtFC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPeso = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSPO2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtHoraM = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem6 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpSignosVitales = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelSignosVitales = New System.Windows.Forms.Panel()
        Me.gpSignosVitales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.JGSignosVitales = New Janus.Windows.GridEX.GridEX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLimpiarSV = New DevComponents.DotNetBar.ButtonX()
        Me.dtpFechaSV = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraSV = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAgregarSV = New DevComponents.DotNetBar.ButtonX()
        Me.txtDefecacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbOtros = New DevComponents.DotNetBar.LabelX()
        Me.txtOtrosSV = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbDefecacion = New DevComponents.DotNetBar.LabelX()
        Me.txtDiarreas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVomitos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbVomitos = New DevComponents.DotNetBar.LabelX()
        Me.lbDiarreas = New DevComponents.DotNetBar.LabelX()
        Me.txtInfartos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtConvulsiones = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbMiccion = New DevComponents.DotNetBar.LabelX()
        Me.lbConvulsiones = New DevComponents.DotNetBar.LabelX()
        Me.txtMiccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbInfartos = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.stcpDatosGenerales = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.panelDatosGenerales = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.cbTurno = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.txtMotivoI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTelefonoI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEdadI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSexoI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEspecieI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPacienteI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPropietarioI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lbIdFicha = New DevComponents.DotNetBar.LabelX()
        Me.txtIdFicInter = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbFechaI = New DevComponents.DotNetBar.LabelX()
        Me.dtpFechaSeg = New System.Windows.Forms.DateTimePicker()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
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
        Me.gpFichaInternacion.SuspendLayout()
        CType(Me.stcFichaInternacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stcFichaInternacion.SuspendLayout()
        Me.stcpExamenFisico.SuspendLayout()
        Me.panelExamenFisico.SuspendLayout()
        Me.gpExamenFisico.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.JGExamenFisico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cbTurnoEF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGradoConciencia.SuspendLayout()
        Me.PanelDolor.SuspendLayout()
        Me.PanelDeshidratacion.SuspendLayout()
        Me.PanelMucosas.SuspendLayout()
        Me.stcpTratamiento.SuspendLayout()
        Me.PanelTratamiento.SuspendLayout()
        Me.gpTratamiento.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.JGTratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.stcpEstudiosComplem.SuspendLayout()
        Me.PanelEstudiosComplemen.SuspendLayout()
        Me.gpEstudiosComplem.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.JGEstudiosC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.stcpFluidoterapia.SuspendLayout()
        Me.panelFluidoterapia.SuspendLayout()
        Me.gpFluidoterapia.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.JGFluidoterapia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.cbTurnoF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stcpAlimentacion.SuspendLayout()
        Me.panelAlimentacion.SuspendLayout()
        Me.gpAlimentacion.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.JGAlimentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.txtRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stcpMonitoreo.SuspendLayout()
        Me.panelMonitoreo.SuspendLayout()
        Me.gpMonitoreo.SuspendLayout()
        Me.panelSeguimiento.SuspendLayout()
        CType(Me.JGMonitoreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.stcpSignosVitales.SuspendLayout()
        Me.panelSignosVitales.SuspendLayout()
        Me.gpSignosVitales.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.JGSignosVitales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.stcpDatosGenerales.SuspendLayout()
        Me.panelDatosGenerales.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.cbTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqSeguimiento.SuspendLayout()
        Me.panelBusqSeguimiento.SuspendLayout()
        CType(Me.JGBusqSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpFichaInternacion)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(1184, 555)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.btnSeguimiento)
        Me.PanelSuperior.Controls.Add(Me.btnReciboI)
        Me.PanelSuperior.Controls.Add(Me.btnFClinica)
        Me.PanelSuperior.Size = New System.Drawing.Size(1184, 72)
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
        Me.PanelInferior.Size = New System.Drawing.Size(1184, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(984, 0)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(941, 205)
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
        Me.superTabControl1.Size = New System.Drawing.Size(1184, 691)
        '
        'gpFichaInternacion
        '
        Me.gpFichaInternacion.BackColor = System.Drawing.Color.Transparent
        Me.gpFichaInternacion.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFichaInternacion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFichaInternacion.Controls.Add(Me.stcFichaInternacion)
        Me.gpFichaInternacion.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFichaInternacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpFichaInternacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFichaInternacion.Location = New System.Drawing.Point(0, 0)
        Me.gpFichaInternacion.Name = "gpFichaInternacion"
        Me.gpFichaInternacion.Size = New System.Drawing.Size(1184, 555)
        '
        '
        '
        Me.gpFichaInternacion.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichaInternacion.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichaInternacion.Style.BackColorGradientAngle = 90
        Me.gpFichaInternacion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichaInternacion.Style.BorderBottomWidth = 1
        Me.gpFichaInternacion.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichaInternacion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichaInternacion.Style.BorderLeftWidth = 1
        Me.gpFichaInternacion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichaInternacion.Style.BorderRightWidth = 1
        Me.gpFichaInternacion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichaInternacion.Style.BorderTopWidth = 1
        Me.gpFichaInternacion.Style.CornerDiameter = 4
        Me.gpFichaInternacion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFichaInternacion.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFichaInternacion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpFichaInternacion.Style.TextColor = System.Drawing.Color.White
        Me.gpFichaInternacion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFichaInternacion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFichaInternacion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFichaInternacion.TabIndex = 348
        Me.gpFichaInternacion.Text = "FICHA  DE  INTERNACIÓN"
        '
        'stcFichaInternacion
        '
        Me.stcFichaInternacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.stcFichaInternacion.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.stcFichaInternacion.ControlBox.MenuBox.Name = ""
        Me.stcFichaInternacion.ControlBox.Name = ""
        Me.stcFichaInternacion.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.stcFichaInternacion.ControlBox.MenuBox, Me.stcFichaInternacion.ControlBox.CloseBox})
        Me.stcFichaInternacion.Controls.Add(Me.stcpAlimentacion)
        Me.stcFichaInternacion.Controls.Add(Me.stcpDatosGenerales)
        Me.stcFichaInternacion.Controls.Add(Me.stcpExamenFisico)
        Me.stcFichaInternacion.Controls.Add(Me.stcpTratamiento)
        Me.stcFichaInternacion.Controls.Add(Me.stcpEstudiosComplem)
        Me.stcFichaInternacion.Controls.Add(Me.stcpFluidoterapia)
        Me.stcFichaInternacion.Controls.Add(Me.stcpMonitoreo)
        Me.stcFichaInternacion.Controls.Add(Me.stcpSignosVitales)
        Me.stcFichaInternacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcFichaInternacion.ForeColor = System.Drawing.Color.Black
        Me.stcFichaInternacion.Location = New System.Drawing.Point(0, 0)
        Me.stcFichaInternacion.Name = "stcFichaInternacion"
        Me.stcFichaInternacion.ReorderTabsEnabled = True
        Me.stcFichaInternacion.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stcFichaInternacion.SelectedTabIndex = 0
        Me.stcFichaInternacion.Size = New System.Drawing.Size(1178, 532)
        Me.stcFichaInternacion.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stcFichaInternacion.TabIndex = 224
        Me.stcFichaInternacion.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem3, Me.SuperTabItem5, Me.SuperTabItem4, Me.SuperTabItem6, Me.SuperTabItem7, Me.SuperTabItem8, Me.SuperTabItem9, Me.SuperTabItem10})
        Me.stcFichaInternacion.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.stcFichaInternacion.Text = "stcFichaClinica"
        '
        'stcpExamenFisico
        '
        Me.stcpExamenFisico.Controls.Add(Me.panelExamenFisico)
        Me.stcpExamenFisico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpExamenFisico.Location = New System.Drawing.Point(0, 25)
        Me.stcpExamenFisico.Name = "stcpExamenFisico"
        Me.stcpExamenFisico.Size = New System.Drawing.Size(1178, 507)
        Me.stcpExamenFisico.TabIndex = 2
        Me.stcpExamenFisico.TabItem = Me.SuperTabItem5
        '
        'panelExamenFisico
        '
        Me.panelExamenFisico.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelExamenFisico.Controls.Add(Me.gpExamenFisico)
        Me.panelExamenFisico.Controls.Add(Me.Panel2)
        Me.panelExamenFisico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelExamenFisico.Location = New System.Drawing.Point(0, 0)
        Me.panelExamenFisico.Name = "panelExamenFisico"
        Me.panelExamenFisico.Size = New System.Drawing.Size(1178, 507)
        Me.panelExamenFisico.TabIndex = 2
        '
        'gpExamenFisico
        '
        Me.gpExamenFisico.BackColor = System.Drawing.Color.White
        Me.gpExamenFisico.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpExamenFisico.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpExamenFisico.Controls.Add(Me.Panel4)
        Me.gpExamenFisico.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpExamenFisico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpExamenFisico.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpExamenFisico.Location = New System.Drawing.Point(0, 238)
        Me.gpExamenFisico.Name = "gpExamenFisico"
        Me.gpExamenFisico.Size = New System.Drawing.Size(1178, 269)
        '
        '
        '
        Me.gpExamenFisico.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpExamenFisico.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpExamenFisico.Style.BackColorGradientAngle = 90
        Me.gpExamenFisico.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpExamenFisico.Style.BorderBottomWidth = 1
        Me.gpExamenFisico.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpExamenFisico.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpExamenFisico.Style.BorderLeftWidth = 1
        Me.gpExamenFisico.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpExamenFisico.Style.BorderRightWidth = 1
        Me.gpExamenFisico.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpExamenFisico.Style.BorderTopWidth = 1
        Me.gpExamenFisico.Style.CornerDiameter = 4
        Me.gpExamenFisico.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpExamenFisico.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpExamenFisico.Style.TextColor = System.Drawing.Color.White
        Me.gpExamenFisico.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpExamenFisico.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpExamenFisico.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpExamenFisico.TabIndex = 400
        Me.gpExamenFisico.Text = "EXAMEN   FÍSICO"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.JGExamenFisico)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1172, 246)
        Me.Panel4.TabIndex = 0
        '
        'JGExamenFisico
        '
        Me.JGExamenFisico.BackColor = System.Drawing.Color.GhostWhite
        Me.JGExamenFisico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGExamenFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGExamenFisico.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGExamenFisico.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGExamenFisico.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGExamenFisico.Location = New System.Drawing.Point(0, 0)
        Me.JGExamenFisico.Name = "JGExamenFisico"
        Me.JGExamenFisico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGExamenFisico.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGExamenFisico.Size = New System.Drawing.Size(1172, 246)
        Me.JGExamenFisico.TabIndex = 0
        Me.JGExamenFisico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dtpFechaEF)
        Me.Panel2.Controls.Add(Me.txtHoraEF)
        Me.Panel2.Controls.Add(Me.btnAgregarEF)
        Me.Panel2.Controls.Add(Me.cbTurnoEF)
        Me.Panel2.Controls.Add(Me.LabelX32)
        Me.Panel2.Controls.Add(Me.PanelGradoConciencia)
        Me.Panel2.Controls.Add(Me.PanelDolor)
        Me.Panel2.Controls.Add(Me.lbMucosas)
        Me.Panel2.Controls.Add(Me.PanelDeshidratacion)
        Me.Panel2.Controls.Add(Me.lbDeshidratacion)
        Me.Panel2.Controls.Add(Me.PanelMucosas)
        Me.Panel2.Controls.Add(Me.lbDolor)
        Me.Panel2.Controls.Add(Me.lbGradoConciencia)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1178, 238)
        Me.Panel2.TabIndex = 399
        '
        'dtpFechaEF
        '
        Me.dtpFechaEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEF.Location = New System.Drawing.Point(532, 104)
        Me.dtpFechaEF.Name = "dtpFechaEF"
        Me.dtpFechaEF.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaEF.TabIndex = 438
        Me.dtpFechaEF.TabStop = False
        Me.dtpFechaEF.Visible = False
        '
        'txtHoraEF
        '
        Me.txtHoraEF.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraEF.Border.Class = "TextBoxBorder"
        Me.txtHoraEF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraEF.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraEF.ForeColor = System.Drawing.Color.Black
        Me.txtHoraEF.Location = New System.Drawing.Point(532, 76)
        Me.txtHoraEF.Name = "txtHoraEF"
        Me.txtHoraEF.PreventEnterBeep = True
        Me.txtHoraEF.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraEF.TabIndex = 437
        Me.txtHoraEF.Visible = False
        '
        'btnAgregarEF
        '
        Me.btnAgregarEF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarEF.BackColor = System.Drawing.Color.White
        Me.btnAgregarEF.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarEF.FadeEffect = False
        Me.btnAgregarEF.FocusCuesEnabled = False
        Me.btnAgregarEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEF.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarEF.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarEF.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarEF.Location = New System.Drawing.Point(774, 76)
        Me.btnAgregarEF.Name = "btnAgregarEF"
        Me.btnAgregarEF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarEF.Size = New System.Drawing.Size(162, 42)
        Me.btnAgregarEF.TabIndex = 399
        Me.btnAgregarEF.Text = "AGREGAR"
        '
        'cbTurnoEF
        '
        cbTurnoEF_DesignTimeLayout.LayoutString = resources.GetString("cbTurnoEF_DesignTimeLayout.LayoutString")
        Me.cbTurnoEF.DesignTimeLayout = cbTurnoEF_DesignTimeLayout
        Me.cbTurnoEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurnoEF.Location = New System.Drawing.Point(154, 22)
        Me.cbTurnoEF.Name = "cbTurnoEF"
        Me.cbTurnoEF.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTurnoEF.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTurnoEF.SelectedIndex = -1
        Me.cbTurnoEF.SelectedItem = Nothing
        Me.cbTurnoEF.Size = New System.Drawing.Size(122, 22)
        Me.cbTurnoEF.TabIndex = 396
        Me.cbTurnoEF.Tag = "1"
        Me.cbTurnoEF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX32
        '
        '
        '
        '
        Me.LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX32.Location = New System.Drawing.Point(15, 21)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(63, 23)
        Me.LabelX32.TabIndex = 397
        Me.LabelX32.Text = "Turno:"
        '
        'PanelGradoConciencia
        '
        Me.PanelGradoConciencia.Controls.Add(Me.chbComa)
        Me.PanelGradoConciencia.Controls.Add(Me.chbEstable)
        Me.PanelGradoConciencia.Controls.Add(Me.chbSemicomatoso)
        Me.PanelGradoConciencia.Location = New System.Drawing.Point(671, 21)
        Me.PanelGradoConciencia.Name = "PanelGradoConciencia"
        Me.PanelGradoConciencia.Size = New System.Drawing.Size(342, 30)
        Me.PanelGradoConciencia.TabIndex = 398
        '
        'chbComa
        '
        '
        '
        '
        Me.chbComa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbComa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbComa.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbComa.Location = New System.Drawing.Point(213, 3)
        Me.chbComa.Name = "chbComa"
        Me.chbComa.Size = New System.Drawing.Size(88, 23)
        Me.chbComa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbComa.TabIndex = 280
        Me.chbComa.Text = "Coma"
        '
        'chbEstable
        '
        '
        '
        '
        Me.chbEstable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbEstable.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbEstable.Checked = True
        Me.chbEstable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEstable.CheckValue = "Y"
        Me.chbEstable.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbEstable.Location = New System.Drawing.Point(5, 4)
        Me.chbEstable.Name = "chbEstable"
        Me.chbEstable.Size = New System.Drawing.Size(72, 23)
        Me.chbEstable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbEstable.TabIndex = 277
        Me.chbEstable.Text = "Estable"
        '
        'chbSemicomatoso
        '
        '
        '
        '
        Me.chbSemicomatoso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbSemicomatoso.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbSemicomatoso.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbSemicomatoso.Location = New System.Drawing.Point(86, 4)
        Me.chbSemicomatoso.Name = "chbSemicomatoso"
        Me.chbSemicomatoso.Size = New System.Drawing.Size(120, 23)
        Me.chbSemicomatoso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbSemicomatoso.TabIndex = 279
        Me.chbSemicomatoso.Text = "Semicomatoso"
        '
        'PanelDolor
        '
        Me.PanelDolor.Controls.Add(Me.chbSevero)
        Me.PanelDolor.Controls.Add(Me.chbLeve)
        Me.PanelDolor.Controls.Add(Me.chbModerado)
        Me.PanelDolor.Location = New System.Drawing.Point(154, 156)
        Me.PanelDolor.Name = "PanelDolor"
        Me.PanelDolor.Size = New System.Drawing.Size(342, 30)
        Me.PanelDolor.TabIndex = 342
        '
        'chbSevero
        '
        '
        '
        '
        Me.chbSevero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbSevero.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbSevero.Location = New System.Drawing.Point(212, 3)
        Me.chbSevero.Name = "chbSevero"
        Me.chbSevero.Size = New System.Drawing.Size(88, 23)
        Me.chbSevero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbSevero.TabIndex = 280
        Me.chbSevero.Text = "Severo"
        '
        'chbLeve
        '
        '
        '
        '
        Me.chbLeve.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbLeve.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbLeve.Location = New System.Drawing.Point(5, 4)
        Me.chbLeve.Name = "chbLeve"
        Me.chbLeve.Size = New System.Drawing.Size(53, 23)
        Me.chbLeve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbLeve.TabIndex = 277
        Me.chbLeve.Text = "Leve"
        '
        'chbModerado
        '
        '
        '
        '
        Me.chbModerado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbModerado.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbModerado.Location = New System.Drawing.Point(87, 4)
        Me.chbModerado.Name = "chbModerado"
        Me.chbModerado.Size = New System.Drawing.Size(99, 23)
        Me.chbModerado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbModerado.TabIndex = 279
        Me.chbModerado.Text = "Moderado"
        '
        'lbMucosas
        '
        Me.lbMucosas.AutoSize = True
        Me.lbMucosas.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMucosas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMucosas.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMucosas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMucosas.Location = New System.Drawing.Point(15, 67)
        Me.lbMucosas.Name = "lbMucosas"
        Me.lbMucosas.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMucosas.Size = New System.Drawing.Size(61, 16)
        Me.lbMucosas.TabIndex = 333
        Me.lbMucosas.Text = "Mucosas:"
        '
        'PanelDeshidratacion
        '
        Me.PanelDeshidratacion.Controls.Add(Me.chb5_7)
        Me.PanelDeshidratacion.Controls.Add(Me.chb0_5)
        Me.PanelDeshidratacion.Controls.Add(Me.chb8_10)
        Me.PanelDeshidratacion.Location = New System.Drawing.Point(154, 106)
        Me.PanelDeshidratacion.Name = "PanelDeshidratacion"
        Me.PanelDeshidratacion.Size = New System.Drawing.Size(342, 30)
        Me.PanelDeshidratacion.TabIndex = 336
        '
        'chb5_7
        '
        '
        '
        '
        Me.chb5_7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chb5_7.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chb5_7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chb5_7.Location = New System.Drawing.Point(80, 4)
        Me.chb5_7.Name = "chb5_7"
        Me.chb5_7.Size = New System.Drawing.Size(81, 23)
        Me.chb5_7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chb5_7.TabIndex = 277
        Me.chb5_7.Text = "5-7%"
        '
        'chb0_5
        '
        '
        '
        '
        Me.chb0_5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chb0_5.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chb0_5.Checked = True
        Me.chb0_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb0_5.CheckValue = "Y"
        Me.chb0_5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chb0_5.Location = New System.Drawing.Point(3, 4)
        Me.chb0_5.Name = "chb0_5"
        Me.chb0_5.Size = New System.Drawing.Size(71, 23)
        Me.chb0_5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chb0_5.TabIndex = 278
        Me.chb0_5.Text = "0-5%"
        '
        'chb8_10
        '
        '
        '
        '
        Me.chb8_10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chb8_10.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chb8_10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chb8_10.Location = New System.Drawing.Point(164, 4)
        Me.chb8_10.Name = "chb8_10"
        Me.chb8_10.Size = New System.Drawing.Size(148, 23)
        Me.chb8_10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chb8_10.TabIndex = 279
        Me.chb8_10.Text = "8-10%"
        '
        'lbDeshidratacion
        '
        Me.lbDeshidratacion.AutoSize = True
        Me.lbDeshidratacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDeshidratacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDeshidratacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDeshidratacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDeshidratacion.Location = New System.Drawing.Point(15, 115)
        Me.lbDeshidratacion.Name = "lbDeshidratacion"
        Me.lbDeshidratacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDeshidratacion.Size = New System.Drawing.Size(102, 16)
        Me.lbDeshidratacion.TabIndex = 335
        Me.lbDeshidratacion.Text = "Deshidratación:"
        '
        'PanelMucosas
        '
        Me.PanelMucosas.Controls.Add(Me.chbCianoticas)
        Me.PanelMucosas.Controls.Add(Me.chbPalidas)
        Me.PanelMucosas.Controls.Add(Me.chbRosadas)
        Me.PanelMucosas.Controls.Add(Me.chbIctericas)
        Me.PanelMucosas.Location = New System.Drawing.Point(154, 60)
        Me.PanelMucosas.Name = "PanelMucosas"
        Me.PanelMucosas.Size = New System.Drawing.Size(342, 30)
        Me.PanelMucosas.TabIndex = 334
        '
        'chbCianoticas
        '
        '
        '
        '
        Me.chbCianoticas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbCianoticas.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbCianoticas.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbCianoticas.Location = New System.Drawing.Point(244, 4)
        Me.chbCianoticas.Name = "chbCianoticas"
        Me.chbCianoticas.Size = New System.Drawing.Size(88, 23)
        Me.chbCianoticas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbCianoticas.TabIndex = 280
        Me.chbCianoticas.Text = "Cianóticas"
        '
        'chbPalidas
        '
        '
        '
        '
        Me.chbPalidas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbPalidas.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbPalidas.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbPalidas.Location = New System.Drawing.Point(80, 4)
        Me.chbPalidas.Name = "chbPalidas"
        Me.chbPalidas.Size = New System.Drawing.Size(81, 23)
        Me.chbPalidas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbPalidas.TabIndex = 277
        Me.chbPalidas.Text = "Pálidas"
        '
        'chbRosadas
        '
        '
        '
        '
        Me.chbRosadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbRosadas.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbRosadas.Checked = True
        Me.chbRosadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbRosadas.CheckValue = "Y"
        Me.chbRosadas.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbRosadas.Location = New System.Drawing.Point(3, 4)
        Me.chbRosadas.Name = "chbRosadas"
        Me.chbRosadas.Size = New System.Drawing.Size(75, 23)
        Me.chbRosadas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbRosadas.TabIndex = 278
        Me.chbRosadas.Text = "Rosadas"
        '
        'chbIctericas
        '
        '
        '
        '
        Me.chbIctericas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbIctericas.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.chbIctericas.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chbIctericas.Location = New System.Drawing.Point(164, 4)
        Me.chbIctericas.Name = "chbIctericas"
        Me.chbIctericas.Size = New System.Drawing.Size(79, 23)
        Me.chbIctericas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbIctericas.TabIndex = 279
        Me.chbIctericas.Text = "Ictéricas"
        '
        'lbDolor
        '
        Me.lbDolor.AutoSize = True
        Me.lbDolor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDolor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDolor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDolor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDolor.Location = New System.Drawing.Point(15, 165)
        Me.lbDolor.Name = "lbDolor"
        Me.lbDolor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDolor.Size = New System.Drawing.Size(43, 16)
        Me.lbDolor.TabIndex = 341
        Me.lbDolor.Text = "Dolor:"
        '
        'lbGradoConciencia
        '
        Me.lbGradoConciencia.AutoSize = True
        Me.lbGradoConciencia.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbGradoConciencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbGradoConciencia.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGradoConciencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbGradoConciencia.Location = New System.Drawing.Point(532, 30)
        Me.lbGradoConciencia.Name = "lbGradoConciencia"
        Me.lbGradoConciencia.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbGradoConciencia.Size = New System.Drawing.Size(134, 16)
        Me.lbGradoConciencia.TabIndex = 345
        Me.lbGradoConciencia.Text = "Grado de Conciencia:"
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.stcpExamenFisico
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "Examen Físico"
        '
        'stcpTratamiento
        '
        Me.stcpTratamiento.Controls.Add(Me.PanelTratamiento)
        Me.stcpTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpTratamiento.Location = New System.Drawing.Point(0, 25)
        Me.stcpTratamiento.Name = "stcpTratamiento"
        Me.stcpTratamiento.Size = New System.Drawing.Size(1178, 507)
        Me.stcpTratamiento.TabIndex = 6
        Me.stcpTratamiento.TabItem = Me.SuperTabItem10
        '
        'PanelTratamiento
        '
        Me.PanelTratamiento.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelTratamiento.Controls.Add(Me.gpTratamiento)
        Me.PanelTratamiento.Controls.Add(Me.Panel)
        Me.PanelTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.PanelTratamiento.Name = "PanelTratamiento"
        Me.PanelTratamiento.Size = New System.Drawing.Size(1178, 507)
        Me.PanelTratamiento.TabIndex = 3
        '
        'gpTratamiento
        '
        Me.gpTratamiento.BackColor = System.Drawing.Color.White
        Me.gpTratamiento.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTratamiento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTratamiento.Controls.Add(Me.Panel14)
        Me.gpTratamiento.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpTratamiento.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpTratamiento.Location = New System.Drawing.Point(0, 192)
        Me.gpTratamiento.Name = "gpTratamiento"
        Me.gpTratamiento.Size = New System.Drawing.Size(1178, 315)
        '
        '
        '
        Me.gpTratamiento.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpTratamiento.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpTratamiento.Style.BackColorGradientAngle = 90
        Me.gpTratamiento.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTratamiento.Style.BorderBottomWidth = 1
        Me.gpTratamiento.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTratamiento.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTratamiento.Style.BorderLeftWidth = 1
        Me.gpTratamiento.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTratamiento.Style.BorderRightWidth = 1
        Me.gpTratamiento.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTratamiento.Style.BorderTopWidth = 1
        Me.gpTratamiento.Style.CornerDiameter = 4
        Me.gpTratamiento.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTratamiento.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTratamiento.Style.TextColor = System.Drawing.Color.White
        Me.gpTratamiento.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpTratamiento.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpTratamiento.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpTratamiento.TabIndex = 390
        Me.gpTratamiento.Text = "TRATAMIENTO"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.JGTratamiento)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1172, 292)
        Me.Panel14.TabIndex = 0
        '
        'JGTratamiento
        '
        Me.JGTratamiento.BackColor = System.Drawing.Color.GhostWhite
        Me.JGTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGTratamiento.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGTratamiento.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGTratamiento.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.JGTratamiento.Name = "JGTratamiento"
        Me.JGTratamiento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGTratamiento.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGTratamiento.Size = New System.Drawing.Size(1172, 292)
        Me.JGTratamiento.TabIndex = 0
        Me.JGTratamiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel
        '
        Me.Panel.AutoScroll = True
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Controls.Add(Me.btnLimpiarT)
        Me.Panel.Controls.Add(Me.txtTratamiento)
        Me.Panel.Controls.Add(Me.dtpFechaT)
        Me.Panel.Controls.Add(Me.btnAgregarT)
        Me.Panel.Controls.Add(Me.LabelX1)
        Me.Panel.Controls.Add(Me.txtHoraT)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1178, 192)
        Me.Panel.TabIndex = 240
        '
        'btnLimpiarT
        '
        Me.btnLimpiarT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarT.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarT.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarT.FadeEffect = False
        Me.btnLimpiarT.FocusCuesEnabled = False
        Me.btnLimpiarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarT.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarT.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarT.Location = New System.Drawing.Point(659, 82)
        Me.btnLimpiarT.Name = "btnLimpiarT"
        Me.btnLimpiarT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarT.Size = New System.Drawing.Size(126, 42)
        Me.btnLimpiarT.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarT.TabIndex = 450
        Me.btnLimpiarT.Text = "LIMPIAR"
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
        Me.txtTratamiento.Location = New System.Drawing.Point(105, 27)
        Me.txtTratamiento.MaxLength = 2000
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.PreventEnterBeep = True
        Me.txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTratamiento.Size = New System.Drawing.Size(521, 123)
        Me.txtTratamiento.TabIndex = 437
        '
        'dtpFechaT
        '
        Me.dtpFechaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaT.Location = New System.Drawing.Point(13, 91)
        Me.dtpFechaT.Name = "dtpFechaT"
        Me.dtpFechaT.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaT.TabIndex = 436
        Me.dtpFechaT.TabStop = False
        Me.dtpFechaT.Visible = False
        '
        'btnAgregarT
        '
        Me.btnAgregarT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarT.BackColor = System.Drawing.Color.White
        Me.btnAgregarT.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarT.FadeEffect = False
        Me.btnAgregarT.FocusCuesEnabled = False
        Me.btnAgregarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarT.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarT.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarT.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarT.Location = New System.Drawing.Point(659, 27)
        Me.btnAgregarT.Name = "btnAgregarT"
        Me.btnAgregarT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarT.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarT.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarT.TabIndex = 435
        Me.btnAgregarT.Text = "Agregar"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(13, 27)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 23)
        Me.LabelX1.TabIndex = 420
        Me.LabelX1.Text = "Tratamiento:"
        '
        'txtHoraT
        '
        Me.txtHoraT.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraT.Border.Class = "TextBoxBorder"
        Me.txtHoraT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraT.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraT.ForeColor = System.Drawing.Color.Black
        Me.txtHoraT.Location = New System.Drawing.Point(13, 63)
        Me.txtHoraT.Name = "txtHoraT"
        Me.txtHoraT.PreventEnterBeep = True
        Me.txtHoraT.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraT.TabIndex = 413
        Me.txtHoraT.Visible = False
        '
        'SuperTabItem10
        '
        Me.SuperTabItem10.AttachedControl = Me.stcpTratamiento
        Me.SuperTabItem10.GlobalItem = False
        Me.SuperTabItem10.Name = "SuperTabItem10"
        Me.SuperTabItem10.Text = "Tratamiento"
        '
        'stcpEstudiosComplem
        '
        Me.stcpEstudiosComplem.Controls.Add(Me.PanelEstudiosComplemen)
        Me.stcpEstudiosComplem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpEstudiosComplem.Location = New System.Drawing.Point(0, 25)
        Me.stcpEstudiosComplem.Name = "stcpEstudiosComplem"
        Me.stcpEstudiosComplem.Size = New System.Drawing.Size(1178, 507)
        Me.stcpEstudiosComplem.TabIndex = 5
        Me.stcpEstudiosComplem.TabItem = Me.SuperTabItem9
        '
        'PanelEstudiosComplemen
        '
        Me.PanelEstudiosComplemen.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelEstudiosComplemen.Controls.Add(Me.gpEstudiosComplem)
        Me.PanelEstudiosComplemen.Controls.Add(Me.Panel11)
        Me.PanelEstudiosComplemen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEstudiosComplemen.Location = New System.Drawing.Point(0, 0)
        Me.PanelEstudiosComplemen.Name = "PanelEstudiosComplemen"
        Me.PanelEstudiosComplemen.Size = New System.Drawing.Size(1178, 507)
        Me.PanelEstudiosComplemen.TabIndex = 3
        '
        'gpEstudiosComplem
        '
        Me.gpEstudiosComplem.BackColor = System.Drawing.Color.White
        Me.gpEstudiosComplem.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEstudiosComplem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEstudiosComplem.Controls.Add(Me.Panel12)
        Me.gpEstudiosComplem.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpEstudiosComplem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpEstudiosComplem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpEstudiosComplem.Location = New System.Drawing.Point(0, 192)
        Me.gpEstudiosComplem.Name = "gpEstudiosComplem"
        Me.gpEstudiosComplem.Size = New System.Drawing.Size(1178, 315)
        '
        '
        '
        Me.gpEstudiosComplem.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpEstudiosComplem.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpEstudiosComplem.Style.BackColorGradientAngle = 90
        Me.gpEstudiosComplem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstudiosComplem.Style.BorderBottomWidth = 1
        Me.gpEstudiosComplem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEstudiosComplem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstudiosComplem.Style.BorderLeftWidth = 1
        Me.gpEstudiosComplem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstudiosComplem.Style.BorderRightWidth = 1
        Me.gpEstudiosComplem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstudiosComplem.Style.BorderTopWidth = 1
        Me.gpEstudiosComplem.Style.CornerDiameter = 4
        Me.gpEstudiosComplem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEstudiosComplem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEstudiosComplem.Style.TextColor = System.Drawing.Color.White
        Me.gpEstudiosComplem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpEstudiosComplem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpEstudiosComplem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpEstudiosComplem.TabIndex = 389
        Me.gpEstudiosComplem.Text = "ESTUDIOS  COMPLEMENTARIOS"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.JGEstudiosC)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1172, 292)
        Me.Panel12.TabIndex = 0
        '
        'JGEstudiosC
        '
        Me.JGEstudiosC.BackColor = System.Drawing.Color.GhostWhite
        Me.JGEstudiosC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGEstudiosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGEstudiosC.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGEstudiosC.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGEstudiosC.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGEstudiosC.Location = New System.Drawing.Point(0, 0)
        Me.JGEstudiosC.Name = "JGEstudiosC"
        Me.JGEstudiosC.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGEstudiosC.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGEstudiosC.Size = New System.Drawing.Size(1172, 292)
        Me.JGEstudiosC.TabIndex = 0
        Me.JGEstudiosC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel11
        '
        Me.Panel11.AutoScroll = True
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.btnLimpiarEC)
        Me.Panel11.Controls.Add(Me.txtEstudiosComplem)
        Me.Panel11.Controls.Add(Me.dtpFechaEC)
        Me.Panel11.Controls.Add(Me.btnAgregarEC)
        Me.Panel11.Controls.Add(Me.LabelX5)
        Me.Panel11.Controls.Add(Me.txtHoraEC)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1178, 192)
        Me.Panel11.TabIndex = 239
        '
        'btnLimpiarEC
        '
        Me.btnLimpiarEC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarEC.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarEC.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarEC.FadeEffect = False
        Me.btnLimpiarEC.FocusCuesEnabled = False
        Me.btnLimpiarEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarEC.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarEC.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarEC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarEC.Location = New System.Drawing.Point(447, 117)
        Me.btnLimpiarEC.Name = "btnLimpiarEC"
        Me.btnLimpiarEC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarEC.Size = New System.Drawing.Size(126, 42)
        Me.btnLimpiarEC.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarEC.TabIndex = 450
        Me.btnLimpiarEC.Text = "LIMPIAR"
        '
        'txtEstudiosComplem
        '
        Me.txtEstudiosComplem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEstudiosComplem.Border.Class = "TextBoxBorder"
        Me.txtEstudiosComplem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEstudiosComplem.DisabledBackColor = System.Drawing.Color.White
        Me.txtEstudiosComplem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstudiosComplem.ForeColor = System.Drawing.Color.Black
        Me.txtEstudiosComplem.Location = New System.Drawing.Point(199, 20)
        Me.txtEstudiosComplem.MaxLength = 100
        Me.txtEstudiosComplem.Multiline = True
        Me.txtEstudiosComplem.Name = "txtEstudiosComplem"
        Me.txtEstudiosComplem.PreventEnterBeep = True
        Me.txtEstudiosComplem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEstudiosComplem.Size = New System.Drawing.Size(457, 72)
        Me.txtEstudiosComplem.TabIndex = 437
        '
        'dtpFechaEC
        '
        Me.dtpFechaEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEC.Location = New System.Drawing.Point(18, 118)
        Me.dtpFechaEC.Name = "dtpFechaEC"
        Me.dtpFechaEC.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaEC.TabIndex = 436
        Me.dtpFechaEC.TabStop = False
        Me.dtpFechaEC.Visible = False
        '
        'btnAgregarEC
        '
        Me.btnAgregarEC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarEC.BackColor = System.Drawing.Color.White
        Me.btnAgregarEC.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarEC.FadeEffect = False
        Me.btnAgregarEC.FocusCuesEnabled = False
        Me.btnAgregarEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEC.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarEC.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarEC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarEC.Location = New System.Drawing.Point(285, 118)
        Me.btnAgregarEC.Name = "btnAgregarEC"
        Me.btnAgregarEC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarEC.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarEC.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarEC.TabIndex = 435
        Me.btnAgregarEC.Text = "Agregar"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(18, 19)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(175, 23)
        Me.LabelX5.TabIndex = 420
        Me.LabelX5.Text = "Estudios Complementarios:"
        '
        'txtHoraEC
        '
        Me.txtHoraEC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraEC.Border.Class = "TextBoxBorder"
        Me.txtHoraEC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraEC.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraEC.ForeColor = System.Drawing.Color.Black
        Me.txtHoraEC.Location = New System.Drawing.Point(18, 90)
        Me.txtHoraEC.Name = "txtHoraEC"
        Me.txtHoraEC.PreventEnterBeep = True
        Me.txtHoraEC.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraEC.TabIndex = 413
        Me.txtHoraEC.Visible = False
        '
        'SuperTabItem9
        '
        Me.SuperTabItem9.AttachedControl = Me.stcpEstudiosComplem
        Me.SuperTabItem9.GlobalItem = False
        Me.SuperTabItem9.Name = "SuperTabItem9"
        Me.SuperTabItem9.Text = "Estudios Complementarios"
        '
        'stcpFluidoterapia
        '
        Me.stcpFluidoterapia.Controls.Add(Me.panelFluidoterapia)
        Me.stcpFluidoterapia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpFluidoterapia.Location = New System.Drawing.Point(0, 25)
        Me.stcpFluidoterapia.Name = "stcpFluidoterapia"
        Me.stcpFluidoterapia.Size = New System.Drawing.Size(1178, 507)
        Me.stcpFluidoterapia.TabIndex = 4
        Me.stcpFluidoterapia.TabItem = Me.SuperTabItem8
        '
        'panelFluidoterapia
        '
        Me.panelFluidoterapia.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelFluidoterapia.Controls.Add(Me.gpFluidoterapia)
        Me.panelFluidoterapia.Controls.Add(Me.Panel9)
        Me.panelFluidoterapia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFluidoterapia.Location = New System.Drawing.Point(0, 0)
        Me.panelFluidoterapia.Name = "panelFluidoterapia"
        Me.panelFluidoterapia.Size = New System.Drawing.Size(1178, 507)
        Me.panelFluidoterapia.TabIndex = 4
        '
        'gpFluidoterapia
        '
        Me.gpFluidoterapia.BackColor = System.Drawing.Color.White
        Me.gpFluidoterapia.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFluidoterapia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFluidoterapia.Controls.Add(Me.Panel10)
        Me.gpFluidoterapia.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFluidoterapia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpFluidoterapia.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFluidoterapia.Location = New System.Drawing.Point(0, 212)
        Me.gpFluidoterapia.Name = "gpFluidoterapia"
        Me.gpFluidoterapia.Size = New System.Drawing.Size(1178, 295)
        '
        '
        '
        Me.gpFluidoterapia.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFluidoterapia.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFluidoterapia.Style.BackColorGradientAngle = 90
        Me.gpFluidoterapia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFluidoterapia.Style.BorderBottomWidth = 1
        Me.gpFluidoterapia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpFluidoterapia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFluidoterapia.Style.BorderLeftWidth = 1
        Me.gpFluidoterapia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFluidoterapia.Style.BorderRightWidth = 1
        Me.gpFluidoterapia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFluidoterapia.Style.BorderTopWidth = 1
        Me.gpFluidoterapia.Style.CornerDiameter = 4
        Me.gpFluidoterapia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFluidoterapia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpFluidoterapia.Style.TextColor = System.Drawing.Color.White
        Me.gpFluidoterapia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFluidoterapia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFluidoterapia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFluidoterapia.TabIndex = 388
        Me.gpFluidoterapia.Text = "FLUIDOTERAPIA"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.JGFluidoterapia)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1172, 272)
        Me.Panel10.TabIndex = 0
        '
        'JGFluidoterapia
        '
        Me.JGFluidoterapia.BackColor = System.Drawing.Color.GhostWhite
        Me.JGFluidoterapia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGFluidoterapia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGFluidoterapia.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGFluidoterapia.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGFluidoterapia.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGFluidoterapia.Location = New System.Drawing.Point(0, 0)
        Me.JGFluidoterapia.Name = "JGFluidoterapia"
        Me.JGFluidoterapia.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGFluidoterapia.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGFluidoterapia.Size = New System.Drawing.Size(1172, 272)
        Me.JGFluidoterapia.TabIndex = 0
        Me.JGFluidoterapia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel9
        '
        Me.Panel9.AutoScroll = True
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.btnLimpiarF)
        Me.Panel9.Controls.Add(Me.dtpFechaF)
        Me.Panel9.Controls.Add(Me.btnAgregarF)
        Me.Panel9.Controls.Add(Me.txtHoraTermino)
        Me.Panel9.Controls.Add(Me.LabelX53)
        Me.Panel9.Controls.Add(Me.LabelX54)
        Me.Panel9.Controls.Add(Me.LabelX55)
        Me.Panel9.Controls.Add(Me.LabelX56)
        Me.Panel9.Controls.Add(Me.txtHoraInicio)
        Me.Panel9.Controls.Add(Me.txtFluidos)
        Me.Panel9.Controls.Add(Me.txtCantidad)
        Me.Panel9.Controls.Add(Me.txtHoraF)
        Me.Panel9.Controls.Add(Me.LabelX57)
        Me.Panel9.Controls.Add(Me.cbTurnoF)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1178, 212)
        Me.Panel9.TabIndex = 238
        '
        'btnLimpiarF
        '
        Me.btnLimpiarF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarF.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarF.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarF.FadeEffect = False
        Me.btnLimpiarF.FocusCuesEnabled = False
        Me.btnLimpiarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarF.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarF.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarF.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarF.Location = New System.Drawing.Point(387, 82)
        Me.btnLimpiarF.Name = "btnLimpiarF"
        Me.btnLimpiarF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarF.Size = New System.Drawing.Size(126, 42)
        Me.btnLimpiarF.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarF.TabIndex = 449
        Me.btnLimpiarF.Text = "LIMPIAR"
        '
        'dtpFechaF
        '
        Me.dtpFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaF.Location = New System.Drawing.Point(611, 51)
        Me.dtpFechaF.Name = "dtpFechaF"
        Me.dtpFechaF.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaF.TabIndex = 436
        Me.dtpFechaF.TabStop = False
        Me.dtpFechaF.Visible = False
        '
        'btnAgregarF
        '
        Me.btnAgregarF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarF.BackColor = System.Drawing.Color.White
        Me.btnAgregarF.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarF.FadeEffect = False
        Me.btnAgregarF.FocusCuesEnabled = False
        Me.btnAgregarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarF.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarF.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarF.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarF.Location = New System.Drawing.Point(387, 24)
        Me.btnAgregarF.Name = "btnAgregarF"
        Me.btnAgregarF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarF.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarF.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarF.TabIndex = 435
        Me.btnAgregarF.Text = "Agregar"
        '
        'txtHoraTermino
        '
        Me.txtHoraTermino.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraTermino.Border.Class = "TextBoxBorder"
        Me.txtHoraTermino.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraTermino.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraTermino.ForeColor = System.Drawing.Color.Black
        Me.txtHoraTermino.Location = New System.Drawing.Point(153, 112)
        Me.txtHoraTermino.MaxLength = 5
        Me.txtHoraTermino.Name = "txtHoraTermino"
        Me.txtHoraTermino.PreventEnterBeep = True
        Me.txtHoraTermino.Size = New System.Drawing.Size(186, 22)
        Me.txtHoraTermino.TabIndex = 417
        '
        'LabelX53
        '
        '
        '
        '
        Me.LabelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX53.Location = New System.Drawing.Point(18, 140)
        Me.LabelX53.Name = "LabelX53"
        Me.LabelX53.Size = New System.Drawing.Size(130, 23)
        Me.LabelX53.TabIndex = 423
        Me.LabelX53.Text = "Cantidad Ingresada:"
        '
        'LabelX54
        '
        '
        '
        '
        Me.LabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX54.Location = New System.Drawing.Point(18, 112)
        Me.LabelX54.Name = "LabelX54"
        Me.LabelX54.Size = New System.Drawing.Size(108, 23)
        Me.LabelX54.TabIndex = 422
        Me.LabelX54.Text = "Hora de Termino:"
        '
        'LabelX55
        '
        '
        '
        '
        Me.LabelX55.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX55.Location = New System.Drawing.Point(18, 80)
        Me.LabelX55.Name = "LabelX55"
        Me.LabelX55.Size = New System.Drawing.Size(94, 23)
        Me.LabelX55.TabIndex = 421
        Me.LabelX55.Text = "Hora de Inicio:"
        '
        'LabelX56
        '
        '
        '
        '
        Me.LabelX56.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX56.Location = New System.Drawing.Point(18, 51)
        Me.LabelX56.Name = "LabelX56"
        Me.LabelX56.Size = New System.Drawing.Size(108, 23)
        Me.LabelX56.TabIndex = 420
        Me.LabelX56.Text = "Fluidos:"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraInicio.Border.Class = "TextBoxBorder"
        Me.txtHoraInicio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraInicio.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.Color.Black
        Me.txtHoraInicio.Location = New System.Drawing.Point(154, 81)
        Me.txtHoraInicio.MaxLength = 5
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.PreventEnterBeep = True
        Me.txtHoraInicio.Size = New System.Drawing.Size(186, 22)
        Me.txtHoraInicio.TabIndex = 416
        '
        'txtFluidos
        '
        Me.txtFluidos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFluidos.Border.Class = "TextBoxBorder"
        Me.txtFluidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFluidos.DisabledBackColor = System.Drawing.Color.White
        Me.txtFluidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFluidos.ForeColor = System.Drawing.Color.Black
        Me.txtFluidos.Location = New System.Drawing.Point(154, 52)
        Me.txtFluidos.MaxLength = 5
        Me.txtFluidos.Multiline = True
        Me.txtFluidos.Name = "txtFluidos"
        Me.txtFluidos.PreventEnterBeep = True
        Me.txtFluidos.Size = New System.Drawing.Size(186, 24)
        Me.txtFluidos.TabIndex = 415
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCantidad.Border.Class = "TextBoxBorder"
        Me.txtCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCantidad.DisabledBackColor = System.Drawing.Color.White
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.Black
        Me.txtCantidad.Location = New System.Drawing.Point(154, 140)
        Me.txtCantidad.MaxLength = 15
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PreventEnterBeep = True
        Me.txtCantidad.Size = New System.Drawing.Size(186, 22)
        Me.txtCantidad.TabIndex = 418
        '
        'txtHoraF
        '
        Me.txtHoraF.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraF.Border.Class = "TextBoxBorder"
        Me.txtHoraF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraF.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraF.ForeColor = System.Drawing.Color.Black
        Me.txtHoraF.Location = New System.Drawing.Point(611, 23)
        Me.txtHoraF.Name = "txtHoraF"
        Me.txtHoraF.PreventEnterBeep = True
        Me.txtHoraF.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraF.TabIndex = 413
        Me.txtHoraF.Visible = False
        '
        'LabelX57
        '
        '
        '
        '
        Me.LabelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX57.Location = New System.Drawing.Point(18, 23)
        Me.LabelX57.Name = "LabelX57"
        Me.LabelX57.Size = New System.Drawing.Size(63, 23)
        Me.LabelX57.TabIndex = 395
        Me.LabelX57.Text = "Turno:"
        '
        'cbTurnoF
        '
        cbTurnoF_DesignTimeLayout.LayoutString = resources.GetString("cbTurnoF_DesignTimeLayout.LayoutString")
        Me.cbTurnoF.DesignTimeLayout = cbTurnoF_DesignTimeLayout
        Me.cbTurnoF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurnoF.Location = New System.Drawing.Point(154, 24)
        Me.cbTurnoF.Name = "cbTurnoF"
        Me.cbTurnoF.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTurnoF.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTurnoF.SelectedIndex = -1
        Me.cbTurnoF.SelectedItem = Nothing
        Me.cbTurnoF.Size = New System.Drawing.Size(135, 22)
        Me.cbTurnoF.TabIndex = 394
        Me.cbTurnoF.Tag = "1"
        Me.cbTurnoF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SuperTabItem8
        '
        Me.SuperTabItem8.AttachedControl = Me.stcpFluidoterapia
        Me.SuperTabItem8.GlobalItem = False
        Me.SuperTabItem8.Name = "SuperTabItem8"
        Me.SuperTabItem8.Text = "Fluidoterapia"
        '
        'stcpAlimentacion
        '
        Me.stcpAlimentacion.Controls.Add(Me.panelAlimentacion)
        Me.stcpAlimentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpAlimentacion.Location = New System.Drawing.Point(0, 25)
        Me.stcpAlimentacion.Name = "stcpAlimentacion"
        Me.stcpAlimentacion.Size = New System.Drawing.Size(1178, 507)
        Me.stcpAlimentacion.TabIndex = 3
        Me.stcpAlimentacion.TabItem = Me.SuperTabItem7
        '
        'panelAlimentacion
        '
        Me.panelAlimentacion.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelAlimentacion.Controls.Add(Me.gpAlimentacion)
        Me.panelAlimentacion.Controls.Add(Me.Panel7)
        Me.panelAlimentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAlimentacion.Location = New System.Drawing.Point(0, 0)
        Me.panelAlimentacion.Name = "panelAlimentacion"
        Me.panelAlimentacion.Size = New System.Drawing.Size(1178, 507)
        Me.panelAlimentacion.TabIndex = 4
        '
        'gpAlimentacion
        '
        Me.gpAlimentacion.BackColor = System.Drawing.Color.White
        Me.gpAlimentacion.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAlimentacion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpAlimentacion.Controls.Add(Me.Panel8)
        Me.gpAlimentacion.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpAlimentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpAlimentacion.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpAlimentacion.Location = New System.Drawing.Point(0, 214)
        Me.gpAlimentacion.Name = "gpAlimentacion"
        Me.gpAlimentacion.Size = New System.Drawing.Size(1178, 293)
        '
        '
        '
        Me.gpAlimentacion.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpAlimentacion.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpAlimentacion.Style.BackColorGradientAngle = 90
        Me.gpAlimentacion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAlimentacion.Style.BorderBottomWidth = 1
        Me.gpAlimentacion.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpAlimentacion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAlimentacion.Style.BorderLeftWidth = 1
        Me.gpAlimentacion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAlimentacion.Style.BorderRightWidth = 1
        Me.gpAlimentacion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAlimentacion.Style.BorderTopWidth = 1
        Me.gpAlimentacion.Style.CornerDiameter = 4
        Me.gpAlimentacion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpAlimentacion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpAlimentacion.Style.TextColor = System.Drawing.Color.White
        Me.gpAlimentacion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpAlimentacion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpAlimentacion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpAlimentacion.TabIndex = 387
        Me.gpAlimentacion.Text = "ALIMENTACIÓN"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.JGAlimentacion)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1172, 270)
        Me.Panel8.TabIndex = 0
        '
        'JGAlimentacion
        '
        Me.JGAlimentacion.BackColor = System.Drawing.Color.GhostWhite
        Me.JGAlimentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGAlimentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGAlimentacion.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGAlimentacion.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGAlimentacion.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGAlimentacion.Location = New System.Drawing.Point(0, 0)
        Me.JGAlimentacion.Name = "JGAlimentacion"
        Me.JGAlimentacion.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGAlimentacion.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGAlimentacion.Size = New System.Drawing.Size(1172, 270)
        Me.JGAlimentacion.TabIndex = 0
        Me.JGAlimentacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.btnLimpiarA)
        Me.Panel7.Controls.Add(Me.txtRequerimiento)
        Me.Panel7.Controls.Add(Me.txtObs)
        Me.Panel7.Controls.Add(Me.LabelX3)
        Me.Panel7.Controls.Add(Me.dtpFechaA)
        Me.Panel7.Controls.Add(Me.btnAgregarA)
        Me.Panel7.Controls.Add(Me.txtRecovery)
        Me.Panel7.Controls.Add(Me.LabelX42)
        Me.Panel7.Controls.Add(Me.LabelX43)
        Me.Panel7.Controls.Add(Me.txtNPO)
        Me.Panel7.Controls.Add(Me.txtAgua)
        Me.Panel7.Controls.Add(Me.LabelX44)
        Me.Panel7.Controls.Add(Me.LabelX45)
        Me.Panel7.Controls.Add(Me.LabelX46)
        Me.Panel7.Controls.Add(Me.LabelX47)
        Me.Panel7.Controls.Add(Me.LabelX48)
        Me.Panel7.Controls.Add(Me.txtPVM)
        Me.Panel7.Controls.Add(Me.txtPolloLic)
        Me.Panel7.Controls.Add(Me.txtPolloDesm)
        Me.Panel7.Controls.Add(Me.txtHoraA)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1178, 214)
        Me.Panel7.TabIndex = 237
        '
        'btnLimpiarA
        '
        Me.btnLimpiarA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarA.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarA.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarA.FadeEffect = False
        Me.btnLimpiarA.FocusCuesEnabled = False
        Me.btnLimpiarA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarA.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarA.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarA.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarA.Location = New System.Drawing.Point(895, 69)
        Me.btnLimpiarA.Name = "btnLimpiarA"
        Me.btnLimpiarA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarA.Size = New System.Drawing.Size(126, 42)
        Me.btnLimpiarA.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarA.TabIndex = 448
        Me.btnLimpiarA.Text = "LIMPIAR"
        '
        'txtRequerimiento
        '
        '
        '
        '
        Me.txtRequerimiento.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtRequerimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRequerimiento.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequerimiento.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.txtRequerimiento.Location = New System.Drawing.Point(154, 18)
        Me.txtRequerimiento.Name = "txtRequerimiento"
        Me.txtRequerimiento.Size = New System.Drawing.Size(132, 21)
        Me.txtRequerimiento.TabIndex = 440
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObs.Border.Class = "TextBoxBorder"
        Me.txtObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObs.DisabledBackColor = System.Drawing.Color.White
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.Black
        Me.txtObs.Location = New System.Drawing.Point(536, 97)
        Me.txtObs.MaxLength = 500
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.PreventEnterBeep = True
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(343, 106)
        Me.txtObs.TabIndex = 447
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(432, 94)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(100, 23)
        Me.LabelX3.TabIndex = 438
        Me.LabelX3.Text = "Observaciones:"
        '
        'dtpFechaA
        '
        Me.dtpFechaA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaA.Location = New System.Drawing.Point(432, 168)
        Me.dtpFechaA.Name = "dtpFechaA"
        Me.dtpFechaA.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaA.TabIndex = 436
        Me.dtpFechaA.TabStop = False
        Me.dtpFechaA.Visible = False
        '
        'btnAgregarA
        '
        Me.btnAgregarA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarA.BackColor = System.Drawing.Color.White
        Me.btnAgregarA.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarA.FadeEffect = False
        Me.btnAgregarA.FocusCuesEnabled = False
        Me.btnAgregarA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarA.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarA.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarA.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarA.Location = New System.Drawing.Point(895, 17)
        Me.btnAgregarA.Name = "btnAgregarA"
        Me.btnAgregarA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarA.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarA.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarA.TabIndex = 435
        Me.btnAgregarA.Text = "Agregar"
        '
        'txtRecovery
        '
        Me.txtRecovery.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRecovery.Border.Class = "TextBoxBorder"
        Me.txtRecovery.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRecovery.DisabledBackColor = System.Drawing.Color.White
        Me.txtRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecovery.ForeColor = System.Drawing.Color.Black
        Me.txtRecovery.Location = New System.Drawing.Point(153, 88)
        Me.txtRecovery.MaxLength = 100
        Me.txtRecovery.Multiline = True
        Me.txtRecovery.Name = "txtRecovery"
        Me.txtRecovery.PreventEnterBeep = True
        Me.txtRecovery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecovery.Size = New System.Drawing.Size(261, 34)
        Me.txtRecovery.TabIndex = 442
        '
        'LabelX42
        '
        '
        '
        '
        Me.LabelX42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX42.Location = New System.Drawing.Point(432, 58)
        Me.LabelX42.Name = "LabelX42"
        Me.LabelX42.Size = New System.Drawing.Size(37, 23)
        Me.LabelX42.TabIndex = 430
        Me.LabelX42.Text = "Agua:"
        '
        'LabelX43
        '
        '
        '
        '
        Me.LabelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX43.Location = New System.Drawing.Point(432, 17)
        Me.LabelX43.Name = "LabelX43"
        Me.LabelX43.Size = New System.Drawing.Size(37, 23)
        Me.LabelX43.TabIndex = 429
        Me.LabelX43.Text = "NPO:"
        '
        'txtNPO
        '
        Me.txtNPO.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNPO.Border.Class = "TextBoxBorder"
        Me.txtNPO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNPO.DisabledBackColor = System.Drawing.Color.White
        Me.txtNPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPO.ForeColor = System.Drawing.Color.Black
        Me.txtNPO.Location = New System.Drawing.Point(536, 17)
        Me.txtNPO.MaxLength = 100
        Me.txtNPO.Multiline = True
        Me.txtNPO.Name = "txtNPO"
        Me.txtNPO.PreventEnterBeep = True
        Me.txtNPO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNPO.Size = New System.Drawing.Size(343, 34)
        Me.txtNPO.TabIndex = 445
        '
        'txtAgua
        '
        Me.txtAgua.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAgua.Border.Class = "TextBoxBorder"
        Me.txtAgua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAgua.DisabledBackColor = System.Drawing.Color.White
        Me.txtAgua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgua.ForeColor = System.Drawing.Color.Black
        Me.txtAgua.Location = New System.Drawing.Point(536, 57)
        Me.txtAgua.MaxLength = 100
        Me.txtAgua.Multiline = True
        Me.txtAgua.Name = "txtAgua"
        Me.txtAgua.PreventEnterBeep = True
        Me.txtAgua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAgua.Size = New System.Drawing.Size(343, 34)
        Me.txtAgua.TabIndex = 446
        '
        'LabelX44
        '
        '
        '
        '
        Me.LabelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX44.Location = New System.Drawing.Point(18, 169)
        Me.LabelX44.Name = "LabelX44"
        Me.LabelX44.Size = New System.Drawing.Size(130, 23)
        Me.LabelX44.TabIndex = 424
        Me.LabelX44.Text = "Pollo Desmenuzado:"
        '
        'LabelX45
        '
        '
        '
        '
        Me.LabelX45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX45.Location = New System.Drawing.Point(18, 129)
        Me.LabelX45.Name = "LabelX45"
        Me.LabelX45.Size = New System.Drawing.Size(94, 23)
        Me.LabelX45.TabIndex = 423
        Me.LabelX45.Text = "Pollo Licuado:"
        '
        'LabelX46
        '
        '
        '
        '
        Me.LabelX46.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX46.Location = New System.Drawing.Point(18, 88)
        Me.LabelX46.Name = "LabelX46"
        Me.LabelX46.Size = New System.Drawing.Size(94, 23)
        Me.LabelX46.TabIndex = 422
        Me.LabelX46.Text = "Recovery:"
        '
        'LabelX47
        '
        '
        '
        '
        Me.LabelX47.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX47.Location = New System.Drawing.Point(18, 46)
        Me.LabelX47.Name = "LabelX47"
        Me.LabelX47.Size = New System.Drawing.Size(94, 23)
        Me.LabelX47.TabIndex = 421
        Me.LabelX47.Text = "PVM Cantidad:"
        '
        'LabelX48
        '
        '
        '
        '
        Me.LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX48.Location = New System.Drawing.Point(18, 16)
        Me.LabelX48.Name = "LabelX48"
        Me.LabelX48.Size = New System.Drawing.Size(132, 23)
        Me.LabelX48.TabIndex = 420
        Me.LabelX48.Text = "Requerimiento(Kcal):"
        '
        'txtPVM
        '
        Me.txtPVM.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPVM.Border.Class = "TextBoxBorder"
        Me.txtPVM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPVM.DisabledBackColor = System.Drawing.Color.White
        Me.txtPVM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVM.ForeColor = System.Drawing.Color.Black
        Me.txtPVM.Location = New System.Drawing.Point(154, 47)
        Me.txtPVM.MaxLength = 100
        Me.txtPVM.Multiline = True
        Me.txtPVM.Name = "txtPVM"
        Me.txtPVM.PreventEnterBeep = True
        Me.txtPVM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPVM.Size = New System.Drawing.Size(260, 34)
        Me.txtPVM.TabIndex = 441
        '
        'txtPolloLic
        '
        Me.txtPolloLic.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPolloLic.Border.Class = "TextBoxBorder"
        Me.txtPolloLic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPolloLic.DisabledBackColor = System.Drawing.Color.White
        Me.txtPolloLic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolloLic.ForeColor = System.Drawing.Color.Black
        Me.txtPolloLic.Location = New System.Drawing.Point(154, 129)
        Me.txtPolloLic.MaxLength = 100
        Me.txtPolloLic.Multiline = True
        Me.txtPolloLic.Name = "txtPolloLic"
        Me.txtPolloLic.PreventEnterBeep = True
        Me.txtPolloLic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPolloLic.Size = New System.Drawing.Size(260, 34)
        Me.txtPolloLic.TabIndex = 443
        '
        'txtPolloDesm
        '
        Me.txtPolloDesm.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPolloDesm.Border.Class = "TextBoxBorder"
        Me.txtPolloDesm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPolloDesm.DisabledBackColor = System.Drawing.Color.White
        Me.txtPolloDesm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolloDesm.ForeColor = System.Drawing.Color.Black
        Me.txtPolloDesm.Location = New System.Drawing.Point(154, 169)
        Me.txtPolloDesm.MaxLength = 100
        Me.txtPolloDesm.Multiline = True
        Me.txtPolloDesm.Name = "txtPolloDesm"
        Me.txtPolloDesm.PreventEnterBeep = True
        Me.txtPolloDesm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPolloDesm.Size = New System.Drawing.Size(260, 34)
        Me.txtPolloDesm.TabIndex = 444
        '
        'txtHoraA
        '
        Me.txtHoraA.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraA.Border.Class = "TextBoxBorder"
        Me.txtHoraA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraA.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraA.ForeColor = System.Drawing.Color.Black
        Me.txtHoraA.Location = New System.Drawing.Point(432, 140)
        Me.txtHoraA.Name = "txtHoraA"
        Me.txtHoraA.PreventEnterBeep = True
        Me.txtHoraA.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraA.TabIndex = 413
        Me.txtHoraA.Visible = False
        '
        'SuperTabItem7
        '
        Me.SuperTabItem7.AttachedControl = Me.stcpAlimentacion
        Me.SuperTabItem7.GlobalItem = False
        Me.SuperTabItem7.Name = "SuperTabItem7"
        Me.SuperTabItem7.Text = "Alimentacion"
        '
        'stcpMonitoreo
        '
        Me.stcpMonitoreo.Controls.Add(Me.panelMonitoreo)
        Me.stcpMonitoreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpMonitoreo.Location = New System.Drawing.Point(0, 25)
        Me.stcpMonitoreo.Name = "stcpMonitoreo"
        Me.stcpMonitoreo.Size = New System.Drawing.Size(1178, 507)
        Me.stcpMonitoreo.TabIndex = 0
        Me.stcpMonitoreo.TabItem = Me.SuperTabItem6
        '
        'panelMonitoreo
        '
        Me.panelMonitoreo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelMonitoreo.Controls.Add(Me.gpMonitoreo)
        Me.panelMonitoreo.Controls.Add(Me.Panel3)
        Me.panelMonitoreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMonitoreo.Location = New System.Drawing.Point(0, 0)
        Me.panelMonitoreo.Name = "panelMonitoreo"
        Me.panelMonitoreo.Size = New System.Drawing.Size(1178, 507)
        Me.panelMonitoreo.TabIndex = 4
        '
        'gpMonitoreo
        '
        Me.gpMonitoreo.BackColor = System.Drawing.Color.White
        Me.gpMonitoreo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpMonitoreo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpMonitoreo.Controls.Add(Me.panelSeguimiento)
        Me.gpMonitoreo.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpMonitoreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpMonitoreo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpMonitoreo.Location = New System.Drawing.Point(0, 238)
        Me.gpMonitoreo.Name = "gpMonitoreo"
        Me.gpMonitoreo.Size = New System.Drawing.Size(1178, 269)
        '
        '
        '
        Me.gpMonitoreo.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpMonitoreo.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpMonitoreo.Style.BackColorGradientAngle = 90
        Me.gpMonitoreo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMonitoreo.Style.BorderBottomWidth = 1
        Me.gpMonitoreo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpMonitoreo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMonitoreo.Style.BorderLeftWidth = 1
        Me.gpMonitoreo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMonitoreo.Style.BorderRightWidth = 1
        Me.gpMonitoreo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpMonitoreo.Style.BorderTopWidth = 1
        Me.gpMonitoreo.Style.CornerDiameter = 4
        Me.gpMonitoreo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpMonitoreo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpMonitoreo.Style.TextColor = System.Drawing.Color.White
        Me.gpMonitoreo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpMonitoreo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpMonitoreo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpMonitoreo.TabIndex = 386
        Me.gpMonitoreo.Text = "MONITOREO"
        '
        'panelSeguimiento
        '
        Me.panelSeguimiento.BackColor = System.Drawing.Color.White
        Me.panelSeguimiento.Controls.Add(Me.JGMonitoreo)
        Me.panelSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.panelSeguimiento.Name = "panelSeguimiento"
        Me.panelSeguimiento.Size = New System.Drawing.Size(1172, 246)
        Me.panelSeguimiento.TabIndex = 0
        '
        'JGMonitoreo
        '
        Me.JGMonitoreo.BackColor = System.Drawing.Color.GhostWhite
        Me.JGMonitoreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGMonitoreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGMonitoreo.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGMonitoreo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGMonitoreo.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGMonitoreo.Location = New System.Drawing.Point(0, 0)
        Me.JGMonitoreo.Name = "JGMonitoreo"
        Me.JGMonitoreo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGMonitoreo.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGMonitoreo.Size = New System.Drawing.Size(1172, 246)
        Me.JGMonitoreo.TabIndex = 0
        Me.JGMonitoreo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnLimpiarM)
        Me.Panel3.Controls.Add(Me.dtpFechaM)
        Me.Panel3.Controls.Add(Me.btnAgregarM)
        Me.Panel3.Controls.Add(Me.txtTRC)
        Me.Panel3.Controls.Add(Me.txtFR)
        Me.Panel3.Controls.Add(Me.LabelX33)
        Me.Panel3.Controls.Add(Me.LabelX34)
        Me.Panel3.Controls.Add(Me.LabelX35)
        Me.Panel3.Controls.Add(Me.LabelX36)
        Me.Panel3.Controls.Add(Me.txtPSys)
        Me.Panel3.Controls.Add(Me.txtMED)
        Me.Panel3.Controls.Add(Me.txtPDys)
        Me.Panel3.Controls.Add(Me.LabelX37)
        Me.Panel3.Controls.Add(Me.LabelX38)
        Me.Panel3.Controls.Add(Me.LabelX39)
        Me.Panel3.Controls.Add(Me.LabelX40)
        Me.Panel3.Controls.Add(Me.LabelX41)
        Me.Panel3.Controls.Add(Me.txtFC)
        Me.Panel3.Controls.Add(Me.txtT)
        Me.Panel3.Controls.Add(Me.txtPeso)
        Me.Panel3.Controls.Add(Me.txtSPO2)
        Me.Panel3.Controls.Add(Me.txtHoraM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1178, 238)
        Me.Panel3.TabIndex = 236
        '
        'btnLimpiarM
        '
        Me.btnLimpiarM.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarM.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarM.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarM.FadeEffect = False
        Me.btnLimpiarM.FocusCuesEnabled = False
        Me.btnLimpiarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarM.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarM.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarM.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarM.Location = New System.Drawing.Point(729, 71)
        Me.btnLimpiarM.Name = "btnLimpiarM"
        Me.btnLimpiarM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarM.Size = New System.Drawing.Size(126, 42)
        Me.btnLimpiarM.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarM.TabIndex = 442
        Me.btnLimpiarM.Text = "LIMPIAR"
        '
        'dtpFechaM
        '
        Me.dtpFechaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaM.Location = New System.Drawing.Point(342, 170)
        Me.dtpFechaM.Name = "dtpFechaM"
        Me.dtpFechaM.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaM.TabIndex = 436
        Me.dtpFechaM.TabStop = False
        Me.dtpFechaM.Visible = False
        '
        'btnAgregarM
        '
        Me.btnAgregarM.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarM.BackColor = System.Drawing.Color.White
        Me.btnAgregarM.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarM.FadeEffect = False
        Me.btnAgregarM.FocusCuesEnabled = False
        Me.btnAgregarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarM.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarM.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarM.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarM.Location = New System.Drawing.Point(729, 24)
        Me.btnAgregarM.Name = "btnAgregarM"
        Me.btnAgregarM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarM.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarM.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarM.TabIndex = 435
        Me.btnAgregarM.Text = "AGREGAR"
        '
        'txtTRC
        '
        Me.txtTRC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTRC.Border.Class = "TextBoxBorder"
        Me.txtTRC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTRC.DisabledBackColor = System.Drawing.Color.White
        Me.txtTRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRC.ForeColor = System.Drawing.Color.Black
        Me.txtTRC.Location = New System.Drawing.Point(457, 112)
        Me.txtTRC.MaxLength = 100
        Me.txtTRC.Multiline = True
        Me.txtTRC.Name = "txtTRC"
        Me.txtTRC.PreventEnterBeep = True
        Me.txtTRC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTRC.Size = New System.Drawing.Size(220, 84)
        Me.txtTRC.TabIndex = 423
        '
        'txtFR
        '
        Me.txtFR.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFR.Border.Class = "TextBoxBorder"
        Me.txtFR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFR.DisabledBackColor = System.Drawing.Color.White
        Me.txtFR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFR.ForeColor = System.Drawing.Color.Black
        Me.txtFR.Location = New System.Drawing.Point(109, 89)
        Me.txtFR.MaxLength = 15
        Me.txtFR.Name = "txtFR"
        Me.txtFR.PreventEnterBeep = True
        Me.txtFR.Size = New System.Drawing.Size(208, 22)
        Me.txtFR.TabIndex = 417
        '
        'LabelX33
        '
        '
        '
        '
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX33.Location = New System.Drawing.Point(365, 111)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(51, 23)
        Me.LabelX33.TabIndex = 432
        Me.LabelX33.Text = "TRC:"
        '
        'LabelX34
        '
        '
        '
        '
        Me.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX34.Location = New System.Drawing.Point(365, 82)
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.Size = New System.Drawing.Size(37, 23)
        Me.LabelX34.TabIndex = 431
        Me.LabelX34.Text = "MED:"
        '
        'LabelX35
        '
        '
        '
        '
        Me.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX35.Location = New System.Drawing.Point(365, 50)
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.Size = New System.Drawing.Size(37, 23)
        Me.LabelX35.TabIndex = 430
        Me.LabelX35.Text = "PDys:"
        '
        'LabelX36
        '
        '
        '
        '
        Me.LabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX36.Location = New System.Drawing.Point(365, 22)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(37, 23)
        Me.LabelX36.TabIndex = 429
        Me.LabelX36.Text = "PSys:"
        '
        'txtPSys
        '
        Me.txtPSys.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPSys.Border.Class = "TextBoxBorder"
        Me.txtPSys.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPSys.DisabledBackColor = System.Drawing.Color.White
        Me.txtPSys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPSys.ForeColor = System.Drawing.Color.Black
        Me.txtPSys.Location = New System.Drawing.Point(457, 23)
        Me.txtPSys.MaxLength = 15
        Me.txtPSys.Name = "txtPSys"
        Me.txtPSys.PreventEnterBeep = True
        Me.txtPSys.Size = New System.Drawing.Size(220, 22)
        Me.txtPSys.TabIndex = 420
        '
        'txtMED
        '
        Me.txtMED.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMED.Border.Class = "TextBoxBorder"
        Me.txtMED.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMED.DisabledBackColor = System.Drawing.Color.White
        Me.txtMED.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMED.ForeColor = System.Drawing.Color.Black
        Me.txtMED.Location = New System.Drawing.Point(457, 82)
        Me.txtMED.MaxLength = 15
        Me.txtMED.Name = "txtMED"
        Me.txtMED.PreventEnterBeep = True
        Me.txtMED.Size = New System.Drawing.Size(220, 22)
        Me.txtMED.TabIndex = 422
        '
        'txtPDys
        '
        Me.txtPDys.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPDys.Border.Class = "TextBoxBorder"
        Me.txtPDys.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPDys.DisabledBackColor = System.Drawing.Color.White
        Me.txtPDys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDys.ForeColor = System.Drawing.Color.Black
        Me.txtPDys.Location = New System.Drawing.Point(457, 51)
        Me.txtPDys.MaxLength = 15
        Me.txtPDys.Multiline = True
        Me.txtPDys.Name = "txtPDys"
        Me.txtPDys.PreventEnterBeep = True
        Me.txtPDys.Size = New System.Drawing.Size(220, 24)
        Me.txtPDys.TabIndex = 421
        '
        'LabelX37
        '
        '
        '
        '
        Me.LabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX37.Location = New System.Drawing.Point(18, 152)
        Me.LabelX37.Name = "LabelX37"
        Me.LabelX37.Size = New System.Drawing.Size(51, 23)
        Me.LabelX37.TabIndex = 424
        Me.LabelX37.Text = "SPO2:"
        '
        'LabelX38
        '
        '
        '
        '
        Me.LabelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX38.Location = New System.Drawing.Point(18, 120)
        Me.LabelX38.Name = "LabelX38"
        Me.LabelX38.Size = New System.Drawing.Size(37, 23)
        Me.LabelX38.TabIndex = 423
        Me.LabelX38.Text = "Peso:"
        '
        'LabelX39
        '
        '
        '
        '
        Me.LabelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX39.Location = New System.Drawing.Point(18, 85)
        Me.LabelX39.Name = "LabelX39"
        Me.LabelX39.Size = New System.Drawing.Size(37, 23)
        Me.LabelX39.TabIndex = 422
        Me.LabelX39.Text = "FR:"
        '
        'LabelX40
        '
        '
        '
        '
        Me.LabelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX40.Location = New System.Drawing.Point(18, 55)
        Me.LabelX40.Name = "LabelX40"
        Me.LabelX40.Size = New System.Drawing.Size(37, 23)
        Me.LabelX40.TabIndex = 421
        Me.LabelX40.Text = "FC:"
        '
        'LabelX41
        '
        '
        '
        '
        Me.LabelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX41.Location = New System.Drawing.Point(18, 23)
        Me.LabelX41.Name = "LabelX41"
        Me.LabelX41.Size = New System.Drawing.Size(37, 23)
        Me.LabelX41.TabIndex = 420
        Me.LabelX41.Text = "T:"
        '
        'txtFC
        '
        Me.txtFC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFC.Border.Class = "TextBoxBorder"
        Me.txtFC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFC.DisabledBackColor = System.Drawing.Color.White
        Me.txtFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFC.ForeColor = System.Drawing.Color.Black
        Me.txtFC.Location = New System.Drawing.Point(110, 56)
        Me.txtFC.MaxLength = 15
        Me.txtFC.Name = "txtFC"
        Me.txtFC.PreventEnterBeep = True
        Me.txtFC.Size = New System.Drawing.Size(208, 22)
        Me.txtFC.TabIndex = 416
        '
        'txtT
        '
        Me.txtT.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtT.Border.Class = "TextBoxBorder"
        Me.txtT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtT.DisabledBackColor = System.Drawing.Color.White
        Me.txtT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT.ForeColor = System.Drawing.Color.Black
        Me.txtT.Location = New System.Drawing.Point(110, 24)
        Me.txtT.MaxLength = 15
        Me.txtT.Multiline = True
        Me.txtT.Name = "txtT"
        Me.txtT.PreventEnterBeep = True
        Me.txtT.Size = New System.Drawing.Size(208, 24)
        Me.txtT.TabIndex = 415
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPeso.Border.Class = "TextBoxBorder"
        Me.txtPeso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPeso.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.Black
        Me.txtPeso.Location = New System.Drawing.Point(110, 120)
        Me.txtPeso.MaxLength = 15
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.PreventEnterBeep = True
        Me.txtPeso.Size = New System.Drawing.Size(208, 22)
        Me.txtPeso.TabIndex = 418
        '
        'txtSPO2
        '
        Me.txtSPO2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSPO2.Border.Class = "TextBoxBorder"
        Me.txtSPO2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSPO2.DisabledBackColor = System.Drawing.Color.White
        Me.txtSPO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPO2.ForeColor = System.Drawing.Color.Black
        Me.txtSPO2.Location = New System.Drawing.Point(110, 152)
        Me.txtSPO2.MaxLength = 15
        Me.txtSPO2.Name = "txtSPO2"
        Me.txtSPO2.PreventEnterBeep = True
        Me.txtSPO2.Size = New System.Drawing.Size(208, 22)
        Me.txtSPO2.TabIndex = 419
        '
        'txtHoraM
        '
        Me.txtHoraM.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraM.Border.Class = "TextBoxBorder"
        Me.txtHoraM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraM.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraM.ForeColor = System.Drawing.Color.Black
        Me.txtHoraM.Location = New System.Drawing.Point(342, 142)
        Me.txtHoraM.Name = "txtHoraM"
        Me.txtHoraM.PreventEnterBeep = True
        Me.txtHoraM.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraM.TabIndex = 413
        Me.txtHoraM.Visible = False
        '
        'SuperTabItem6
        '
        Me.SuperTabItem6.AttachedControl = Me.stcpMonitoreo
        Me.SuperTabItem6.GlobalItem = False
        Me.SuperTabItem6.Name = "SuperTabItem6"
        Me.SuperTabItem6.Text = "Monitoreo"
        '
        'stcpSignosVitales
        '
        Me.stcpSignosVitales.Controls.Add(Me.panelSignosVitales)
        Me.stcpSignosVitales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpSignosVitales.Location = New System.Drawing.Point(0, 25)
        Me.stcpSignosVitales.Name = "stcpSignosVitales"
        Me.stcpSignosVitales.Size = New System.Drawing.Size(1178, 507)
        Me.stcpSignosVitales.TabIndex = 0
        Me.stcpSignosVitales.TabItem = Me.SuperTabItem4
        '
        'panelSignosVitales
        '
        Me.panelSignosVitales.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelSignosVitales.Controls.Add(Me.gpSignosVitales)
        Me.panelSignosVitales.Controls.Add(Me.Panel5)
        Me.panelSignosVitales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSignosVitales.Location = New System.Drawing.Point(0, 0)
        Me.panelSignosVitales.Name = "panelSignosVitales"
        Me.panelSignosVitales.Size = New System.Drawing.Size(1178, 507)
        Me.panelSignosVitales.TabIndex = 3
        '
        'gpSignosVitales
        '
        Me.gpSignosVitales.BackColor = System.Drawing.Color.White
        Me.gpSignosVitales.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpSignosVitales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpSignosVitales.Controls.Add(Me.Panel6)
        Me.gpSignosVitales.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpSignosVitales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpSignosVitales.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSignosVitales.Location = New System.Drawing.Point(0, 173)
        Me.gpSignosVitales.Name = "gpSignosVitales"
        Me.gpSignosVitales.Size = New System.Drawing.Size(1178, 334)
        '
        '
        '
        Me.gpSignosVitales.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSignosVitales.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpSignosVitales.Style.BackColorGradientAngle = 90
        Me.gpSignosVitales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSignosVitales.Style.BorderBottomWidth = 1
        Me.gpSignosVitales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpSignosVitales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSignosVitales.Style.BorderLeftWidth = 1
        Me.gpSignosVitales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSignosVitales.Style.BorderRightWidth = 1
        Me.gpSignosVitales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSignosVitales.Style.BorderTopWidth = 1
        Me.gpSignosVitales.Style.CornerDiameter = 4
        Me.gpSignosVitales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpSignosVitales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpSignosVitales.Style.TextColor = System.Drawing.Color.White
        Me.gpSignosVitales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpSignosVitales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpSignosVitales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpSignosVitales.TabIndex = 401
        Me.gpSignosVitales.Text = "SIGNOS  VITALES"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.JGSignosVitales)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1172, 311)
        Me.Panel6.TabIndex = 0
        '
        'JGSignosVitales
        '
        Me.JGSignosVitales.BackColor = System.Drawing.Color.GhostWhite
        Me.JGSignosVitales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGSignosVitales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGSignosVitales.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGSignosVitales.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.JGSignosVitales.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGSignosVitales.Location = New System.Drawing.Point(0, 0)
        Me.JGSignosVitales.Name = "JGSignosVitales"
        Me.JGSignosVitales.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGSignosVitales.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGSignosVitales.Size = New System.Drawing.Size(1172, 311)
        Me.JGSignosVitales.TabIndex = 0
        Me.JGSignosVitales.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.btnLimpiarSV)
        Me.Panel5.Controls.Add(Me.dtpFechaSV)
        Me.Panel5.Controls.Add(Me.txtHoraSV)
        Me.Panel5.Controls.Add(Me.btnAgregarSV)
        Me.Panel5.Controls.Add(Me.txtDefecacion)
        Me.Panel5.Controls.Add(Me.lbOtros)
        Me.Panel5.Controls.Add(Me.txtOtrosSV)
        Me.Panel5.Controls.Add(Me.lbDefecacion)
        Me.Panel5.Controls.Add(Me.txtDiarreas)
        Me.Panel5.Controls.Add(Me.txtVomitos)
        Me.Panel5.Controls.Add(Me.lbVomitos)
        Me.Panel5.Controls.Add(Me.lbDiarreas)
        Me.Panel5.Controls.Add(Me.txtInfartos)
        Me.Panel5.Controls.Add(Me.txtConvulsiones)
        Me.Panel5.Controls.Add(Me.lbMiccion)
        Me.Panel5.Controls.Add(Me.lbConvulsiones)
        Me.Panel5.Controls.Add(Me.txtMiccion)
        Me.Panel5.Controls.Add(Me.lbInfartos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1178, 173)
        Me.Panel5.TabIndex = 236
        '
        'btnLimpiarSV
        '
        Me.btnLimpiarSV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLimpiarSV.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarSV.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnLimpiarSV.FadeEffect = False
        Me.btnLimpiarSV.FocusCuesEnabled = False
        Me.btnLimpiarSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarSV.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.btnLimpiarSV.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnLimpiarSV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnLimpiarSV.Location = New System.Drawing.Point(702, 69)
        Me.btnLimpiarSV.Name = "btnLimpiarSV"
        Me.btnLimpiarSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLimpiarSV.Size = New System.Drawing.Size(162, 42)
        Me.btnLimpiarSV.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLimpiarSV.TabIndex = 441
        Me.btnLimpiarSV.Text = "LIMPIAR"
        '
        'dtpFechaSV
        '
        Me.dtpFechaSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSV.Location = New System.Drawing.Point(280, 105)
        Me.dtpFechaSV.Name = "dtpFechaSV"
        Me.dtpFechaSV.Size = New System.Drawing.Size(74, 22)
        Me.dtpFechaSV.TabIndex = 440
        Me.dtpFechaSV.TabStop = False
        Me.dtpFechaSV.Visible = False
        '
        'txtHoraSV
        '
        Me.txtHoraSV.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHoraSV.Border.Class = "TextBoxBorder"
        Me.txtHoraSV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraSV.DisabledBackColor = System.Drawing.Color.White
        Me.txtHoraSV.ForeColor = System.Drawing.Color.Black
        Me.txtHoraSV.Location = New System.Drawing.Point(280, 77)
        Me.txtHoraSV.Name = "txtHoraSV"
        Me.txtHoraSV.PreventEnterBeep = True
        Me.txtHoraSV.Size = New System.Drawing.Size(74, 22)
        Me.txtHoraSV.TabIndex = 439
        Me.txtHoraSV.Visible = False
        '
        'btnAgregarSV
        '
        Me.btnAgregarSV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarSV.BackColor = System.Drawing.Color.Black
        Me.btnAgregarSV.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAgregarSV.FadeEffect = False
        Me.btnAgregarSV.FocusCuesEnabled = False
        Me.btnAgregarSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSV.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.btnAgregarSV.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAgregarSV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAgregarSV.Location = New System.Drawing.Point(702, 21)
        Me.btnAgregarSV.Name = "btnAgregarSV"
        Me.btnAgregarSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAgregarSV.Size = New System.Drawing.Size(162, 42)
        Me.btnAgregarSV.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAgregarSV.TabIndex = 400
        Me.btnAgregarSV.Text = "AGREGAR"
        '
        'txtDefecacion
        '
        Me.txtDefecacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDefecacion.Border.Class = "TextBoxBorder"
        Me.txtDefecacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDefecacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDefecacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefecacion.ForeColor = System.Drawing.Color.Black
        Me.txtDefecacion.Location = New System.Drawing.Point(448, 56)
        Me.txtDefecacion.MaxLength = 5
        Me.txtDefecacion.Name = "txtDefecacion"
        Me.txtDefecacion.PreventEnterBeep = True
        Me.txtDefecacion.Size = New System.Drawing.Size(185, 22)
        Me.txtDefecacion.TabIndex = 261
        '
        'lbOtros
        '
        Me.lbOtros.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbOtros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbOtros.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbOtros.Location = New System.Drawing.Point(360, 88)
        Me.lbOtros.Name = "lbOtros"
        Me.lbOtros.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbOtros.Size = New System.Drawing.Size(65, 23)
        Me.lbOtros.TabIndex = 263
        Me.lbOtros.Text = "Otros"
        '
        'txtOtrosSV
        '
        Me.txtOtrosSV.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtOtrosSV.Border.Class = "TextBoxBorder"
        Me.txtOtrosSV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtOtrosSV.DisabledBackColor = System.Drawing.Color.White
        Me.txtOtrosSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosSV.ForeColor = System.Drawing.Color.Black
        Me.txtOtrosSV.Location = New System.Drawing.Point(448, 89)
        Me.txtOtrosSV.MaxLength = 100
        Me.txtOtrosSV.Multiline = True
        Me.txtOtrosSV.Name = "txtOtrosSV"
        Me.txtOtrosSV.PreventEnterBeep = True
        Me.txtOtrosSV.Size = New System.Drawing.Size(185, 74)
        Me.txtOtrosSV.TabIndex = 262
        '
        'lbDefecacion
        '
        Me.lbDefecacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDefecacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDefecacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDefecacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDefecacion.Location = New System.Drawing.Point(358, 57)
        Me.lbDefecacion.Name = "lbDefecacion"
        Me.lbDefecacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDefecacion.Size = New System.Drawing.Size(84, 23)
        Me.lbDefecacion.TabIndex = 264
        Me.lbDefecacion.Text = "Defecación:"
        '
        'txtDiarreas
        '
        Me.txtDiarreas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDiarreas.Border.Class = "TextBoxBorder"
        Me.txtDiarreas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDiarreas.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiarreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiarreas.ForeColor = System.Drawing.Color.Black
        Me.txtDiarreas.Location = New System.Drawing.Point(138, 50)
        Me.txtDiarreas.MaxLength = 5
        Me.txtDiarreas.Name = "txtDiarreas"
        Me.txtDiarreas.PreventEnterBeep = True
        Me.txtDiarreas.Size = New System.Drawing.Size(136, 22)
        Me.txtDiarreas.TabIndex = 252
        '
        'txtVomitos
        '
        Me.txtVomitos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtVomitos.Border.Class = "TextBoxBorder"
        Me.txtVomitos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVomitos.DisabledBackColor = System.Drawing.Color.White
        Me.txtVomitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVomitos.ForeColor = System.Drawing.Color.Black
        Me.txtVomitos.Location = New System.Drawing.Point(138, 21)
        Me.txtVomitos.MaxLength = 5
        Me.txtVomitos.Multiline = True
        Me.txtVomitos.Name = "txtVomitos"
        Me.txtVomitos.PreventEnterBeep = True
        Me.txtVomitos.Size = New System.Drawing.Size(136, 24)
        Me.txtVomitos.TabIndex = 251
        '
        'lbVomitos
        '
        Me.lbVomitos.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVomitos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVomitos.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVomitos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbVomitos.Location = New System.Drawing.Point(34, 22)
        Me.lbVomitos.Name = "lbVomitos"
        Me.lbVomitos.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbVomitos.Size = New System.Drawing.Size(81, 23)
        Me.lbVomitos.TabIndex = 259
        Me.lbVomitos.Text = "Vómitos:"
        '
        'lbDiarreas
        '
        Me.lbDiarreas.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDiarreas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDiarreas.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiarreas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDiarreas.Location = New System.Drawing.Point(34, 50)
        Me.lbDiarreas.Name = "lbDiarreas"
        Me.lbDiarreas.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDiarreas.Size = New System.Drawing.Size(81, 23)
        Me.lbDiarreas.TabIndex = 260
        Me.lbDiarreas.Text = "Diarreas:"
        '
        'txtInfartos
        '
        Me.txtInfartos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtInfartos.Border.Class = "TextBoxBorder"
        Me.txtInfartos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInfartos.DisabledBackColor = System.Drawing.Color.White
        Me.txtInfartos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfartos.ForeColor = System.Drawing.Color.Black
        Me.txtInfartos.Location = New System.Drawing.Point(138, 109)
        Me.txtInfartos.MaxLength = 5
        Me.txtInfartos.Name = "txtInfartos"
        Me.txtInfartos.PreventEnterBeep = True
        Me.txtInfartos.Size = New System.Drawing.Size(136, 22)
        Me.txtInfartos.TabIndex = 254
        '
        'txtConvulsiones
        '
        Me.txtConvulsiones.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtConvulsiones.Border.Class = "TextBoxBorder"
        Me.txtConvulsiones.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtConvulsiones.DisabledBackColor = System.Drawing.Color.White
        Me.txtConvulsiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConvulsiones.ForeColor = System.Drawing.Color.Black
        Me.txtConvulsiones.Location = New System.Drawing.Point(138, 78)
        Me.txtConvulsiones.MaxLength = 5
        Me.txtConvulsiones.Multiline = True
        Me.txtConvulsiones.Name = "txtConvulsiones"
        Me.txtConvulsiones.PreventEnterBeep = True
        Me.txtConvulsiones.Size = New System.Drawing.Size(136, 24)
        Me.txtConvulsiones.TabIndex = 253
        '
        'lbMiccion
        '
        Me.lbMiccion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMiccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMiccion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMiccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbMiccion.Location = New System.Drawing.Point(358, 24)
        Me.lbMiccion.Name = "lbMiccion"
        Me.lbMiccion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMiccion.Size = New System.Drawing.Size(65, 23)
        Me.lbMiccion.TabIndex = 257
        Me.lbMiccion.Text = "Micción:"
        '
        'lbConvulsiones
        '
        Me.lbConvulsiones.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbConvulsiones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbConvulsiones.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConvulsiones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbConvulsiones.Location = New System.Drawing.Point(34, 77)
        Me.lbConvulsiones.Name = "lbConvulsiones"
        Me.lbConvulsiones.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbConvulsiones.Size = New System.Drawing.Size(88, 23)
        Me.lbConvulsiones.TabIndex = 256
        Me.lbConvulsiones.Text = "Convulsiones:"
        '
        'txtMiccion
        '
        Me.txtMiccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMiccion.Border.Class = "TextBoxBorder"
        Me.txtMiccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMiccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtMiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiccion.ForeColor = System.Drawing.Color.Black
        Me.txtMiccion.Location = New System.Drawing.Point(448, 24)
        Me.txtMiccion.MaxLength = 5
        Me.txtMiccion.Name = "txtMiccion"
        Me.txtMiccion.PreventEnterBeep = True
        Me.txtMiccion.Size = New System.Drawing.Size(185, 22)
        Me.txtMiccion.TabIndex = 255
        '
        'lbInfartos
        '
        Me.lbInfartos.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbInfartos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbInfartos.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfartos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbInfartos.Location = New System.Drawing.Point(35, 108)
        Me.lbInfartos.Name = "lbInfartos"
        Me.lbInfartos.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbInfartos.Size = New System.Drawing.Size(67, 23)
        Me.lbInfartos.TabIndex = 258
        Me.lbInfartos.Text = "Infartos :"
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.stcpSignosVitales
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Signos Vitales"
        '
        'stcpDatosGenerales
        '
        Me.stcpDatosGenerales.Controls.Add(Me.panelDatosGenerales)
        Me.stcpDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcpDatosGenerales.Location = New System.Drawing.Point(0, 25)
        Me.stcpDatosGenerales.Name = "stcpDatosGenerales"
        Me.stcpDatosGenerales.Size = New System.Drawing.Size(1178, 507)
        Me.stcpDatosGenerales.TabIndex = 4
        Me.stcpDatosGenerales.TabItem = Me.SuperTabItem3
        '
        'panelDatosGenerales
        '
        Me.panelDatosGenerales.BackColor = System.Drawing.Color.LightSkyBlue
        Me.panelDatosGenerales.Controls.Add(Me.panelDatos)
        Me.panelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.panelDatosGenerales.Name = "panelDatosGenerales"
        Me.panelDatosGenerales.Size = New System.Drawing.Size(1178, 507)
        Me.panelDatosGenerales.TabIndex = 2
        '
        'panelDatos
        '
        Me.panelDatos.AutoScroll = True
        Me.panelDatos.BackColor = System.Drawing.Color.White
        Me.panelDatos.Controls.Add(Me.LabelX2)
        Me.panelDatos.Controls.Add(Me.txtId)
        Me.panelDatos.Controls.Add(Me.LabelX12)
        Me.panelDatos.Controls.Add(Me.cbTurno)
        Me.panelDatos.Controls.Add(Me.txtMotivoI)
        Me.panelDatos.Controls.Add(Me.txtTelefonoI)
        Me.panelDatos.Controls.Add(Me.txtEdadI)
        Me.panelDatos.Controls.Add(Me.txtSexoI)
        Me.panelDatos.Controls.Add(Me.txtEspecieI)
        Me.panelDatos.Controls.Add(Me.txtPacienteI)
        Me.panelDatos.Controls.Add(Me.txtPropietarioI)
        Me.panelDatos.Controls.Add(Me.LabelX17)
        Me.panelDatos.Controls.Add(Me.LabelX14)
        Me.panelDatos.Controls.Add(Me.LabelX11)
        Me.panelDatos.Controls.Add(Me.LabelX7)
        Me.panelDatos.Controls.Add(Me.LabelX8)
        Me.panelDatos.Controls.Add(Me.LabelX9)
        Me.panelDatos.Controls.Add(Me.LabelX10)
        Me.panelDatos.Controls.Add(Me.LabelX4)
        Me.panelDatos.Controls.Add(Me.lbIdFicha)
        Me.panelDatos.Controls.Add(Me.txtIdFicInter)
        Me.panelDatos.Controls.Add(Me.lbFechaI)
        Me.panelDatos.Controls.Add(Me.dtpFechaSeg)
        Me.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelDatos.Location = New System.Drawing.Point(0, 0)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1178, 507)
        Me.panelDatos.TabIndex = 235
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(21, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(96, 23)
        Me.LabelX2.TabIndex = 445
        Me.LabelX2.Text = "Id Seguimiento:"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtId.Border.Class = "TextBoxBorder"
        Me.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtId.DisabledBackColor = System.Drawing.Color.White
        Me.txtId.Enabled = False
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(122, 21)
        Me.txtId.Name = "txtId"
        Me.txtId.PreventEnterBeep = True
        Me.txtId.Size = New System.Drawing.Size(115, 22)
        Me.txtId.TabIndex = 444
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX12.Location = New System.Drawing.Point(21, 330)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(63, 23)
        Me.LabelX12.TabIndex = 443
        Me.LabelX12.Text = "Turno:"
        '
        'cbTurno
        '
        cbTurno_DesignTimeLayout.LayoutString = resources.GetString("cbTurno_DesignTimeLayout.LayoutString")
        Me.cbTurno.DesignTimeLayout = cbTurno_DesignTimeLayout
        Me.cbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurno.Location = New System.Drawing.Point(122, 329)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTurno.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTurno.SelectedIndex = -1
        Me.cbTurno.SelectedItem = Nothing
        Me.cbTurno.Size = New System.Drawing.Size(135, 22)
        Me.cbTurno.TabIndex = 442
        Me.cbTurno.Tag = "1"
        Me.cbTurno.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtMotivoI
        '
        Me.txtMotivoI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMotivoI.Border.Class = "TextBoxBorder"
        Me.txtMotivoI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMotivoI.DisabledBackColor = System.Drawing.Color.White
        Me.txtMotivoI.Enabled = False
        Me.txtMotivoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoI.ForeColor = System.Drawing.Color.Black
        Me.txtMotivoI.Location = New System.Drawing.Point(456, 53)
        Me.txtMotivoI.MaxLength = 400
        Me.txtMotivoI.Multiline = True
        Me.txtMotivoI.Name = "txtMotivoI"
        Me.txtMotivoI.PreventEnterBeep = True
        Me.txtMotivoI.Size = New System.Drawing.Size(666, 159)
        Me.txtMotivoI.TabIndex = 415
        '
        'txtTelefonoI
        '
        Me.txtTelefonoI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTelefonoI.Border.Class = "TextBoxBorder"
        Me.txtTelefonoI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelefonoI.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefonoI.Enabled = False
        Me.txtTelefonoI.ForeColor = System.Drawing.Color.Black
        Me.txtTelefonoI.Location = New System.Drawing.Point(122, 128)
        Me.txtTelefonoI.MaxLength = 25
        Me.txtTelefonoI.Name = "txtTelefonoI"
        Me.txtTelefonoI.PreventEnterBeep = True
        Me.txtTelefonoI.Size = New System.Drawing.Size(239, 22)
        Me.txtTelefonoI.TabIndex = 414
        '
        'txtEdadI
        '
        Me.txtEdadI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEdadI.Border.Class = "TextBoxBorder"
        Me.txtEdadI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEdadI.DisabledBackColor = System.Drawing.Color.White
        Me.txtEdadI.Enabled = False
        Me.txtEdadI.ForeColor = System.Drawing.Color.Black
        Me.txtEdadI.Location = New System.Drawing.Point(122, 195)
        Me.txtEdadI.MaxLength = 25
        Me.txtEdadI.Name = "txtEdadI"
        Me.txtEdadI.PreventEnterBeep = True
        Me.txtEdadI.Size = New System.Drawing.Size(239, 22)
        Me.txtEdadI.TabIndex = 413
        '
        'txtSexoI
        '
        Me.txtSexoI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSexoI.Border.Class = "TextBoxBorder"
        Me.txtSexoI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSexoI.DisabledBackColor = System.Drawing.Color.White
        Me.txtSexoI.Enabled = False
        Me.txtSexoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexoI.ForeColor = System.Drawing.Color.Black
        Me.txtSexoI.Location = New System.Drawing.Point(122, 228)
        Me.txtSexoI.Name = "txtSexoI"
        Me.txtSexoI.PreventEnterBeep = True
        Me.txtSexoI.Size = New System.Drawing.Size(239, 22)
        Me.txtSexoI.TabIndex = 412
        '
        'txtEspecieI
        '
        Me.txtEspecieI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEspecieI.Border.Class = "TextBoxBorder"
        Me.txtEspecieI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEspecieI.DisabledBackColor = System.Drawing.Color.White
        Me.txtEspecieI.Enabled = False
        Me.txtEspecieI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecieI.ForeColor = System.Drawing.Color.Black
        Me.txtEspecieI.Location = New System.Drawing.Point(122, 260)
        Me.txtEspecieI.Name = "txtEspecieI"
        Me.txtEspecieI.PreventEnterBeep = True
        Me.txtEspecieI.Size = New System.Drawing.Size(239, 22)
        Me.txtEspecieI.TabIndex = 411
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
        Me.txtPacienteI.Location = New System.Drawing.Point(122, 161)
        Me.txtPacienteI.Name = "txtPacienteI"
        Me.txtPacienteI.PreventEnterBeep = True
        Me.txtPacienteI.Size = New System.Drawing.Size(239, 22)
        Me.txtPacienteI.TabIndex = 410
        '
        'txtPropietarioI
        '
        Me.txtPropietarioI.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPropietarioI.Border.Class = "TextBoxBorder"
        Me.txtPropietarioI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPropietarioI.DisabledBackColor = System.Drawing.Color.White
        Me.txtPropietarioI.Enabled = False
        Me.txtPropietarioI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioI.ForeColor = System.Drawing.Color.Black
        Me.txtPropietarioI.Location = New System.Drawing.Point(122, 93)
        Me.txtPropietarioI.Name = "txtPropietarioI"
        Me.txtPropietarioI.PreventEnterBeep = True
        Me.txtPropietarioI.Size = New System.Drawing.Size(239, 22)
        Me.txtPropietarioI.TabIndex = 409
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX17.Location = New System.Drawing.Point(456, 21)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(214, 19)
        Me.LabelX17.TabIndex = 407
        Me.LabelX17.Text = "MOTIVO DE INTERNACIÓN:"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX14.Location = New System.Drawing.Point(21, 195)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(56, 23)
        Me.LabelX14.TabIndex = 384
        Me.LabelX14.Text = "Edad:"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX11.Location = New System.Drawing.Point(21, 128)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(74, 23)
        Me.LabelX11.TabIndex = 405
        Me.LabelX11.Text = "Teléfono:"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(21, 234)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX7.Size = New System.Drawing.Size(36, 16)
        Me.LabelX7.TabIndex = 403
        Me.LabelX7.Text = "Sexo:"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(21, 266)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX8.Size = New System.Drawing.Size(54, 16)
        Me.LabelX8.TabIndex = 401
        Me.LabelX8.Text = "Especie:"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(21, 166)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX9.Size = New System.Drawing.Size(60, 16)
        Me.LabelX9.TabIndex = 399
        Me.LabelX9.Text = "Paciente:"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(21, 97)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX10.Size = New System.Drawing.Size(78, 16)
        Me.LabelX10.TabIndex = 397
        Me.LabelX10.Text = "Propietario:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(246, 59)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 23)
        Me.LabelX4.TabIndex = 396
        Me.LabelX4.Text = "Ctrl+Enter"
        '
        'lbIdFicha
        '
        '
        '
        '
        Me.lbIdFicha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdFicha.Location = New System.Drawing.Point(21, 60)
        Me.lbIdFicha.Name = "lbIdFicha"
        Me.lbIdFicha.Size = New System.Drawing.Size(90, 23)
        Me.lbIdFicha.TabIndex = 343
        Me.lbIdFicha.Text = "Id Internación:"
        '
        'txtIdFicInter
        '
        Me.txtIdFicInter.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdFicInter.Border.Class = "TextBoxBorder"
        Me.txtIdFicInter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdFicInter.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdFicInter.ForeColor = System.Drawing.Color.Black
        Me.txtIdFicInter.Location = New System.Drawing.Point(122, 60)
        Me.txtIdFicInter.Name = "txtIdFicInter"
        Me.txtIdFicInter.PreventEnterBeep = True
        Me.txtIdFicInter.Size = New System.Drawing.Size(115, 22)
        Me.txtIdFicInter.TabIndex = 1
        '
        'lbFechaI
        '
        '
        '
        '
        Me.lbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaI.Location = New System.Drawing.Point(21, 295)
        Me.lbFechaI.Name = "lbFechaI"
        Me.lbFechaI.Size = New System.Drawing.Size(94, 23)
        Me.lbFechaI.TabIndex = 341
        Me.lbFechaI.Text = "Fecha Ingreso:"
        '
        'dtpFechaSeg
        '
        Me.dtpFechaSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSeg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSeg.Location = New System.Drawing.Point(122, 296)
        Me.dtpFechaSeg.Name = "dtpFechaSeg"
        Me.dtpFechaSeg.Size = New System.Drawing.Size(122, 22)
        Me.dtpFechaSeg.TabIndex = 340
        Me.dtpFechaSeg.TabStop = False
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.stcpDatosGenerales
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.TabFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem3.Text = "Datos Generales"
        '
        'gpBusqSeguimiento
        '
        Me.gpBusqSeguimiento.BackColor = System.Drawing.Color.Transparent
        Me.gpBusqSeguimiento.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqSeguimiento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqSeguimiento.Controls.Add(Me.panelBusqSeguimiento)
        Me.gpBusqSeguimiento.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpBusqSeguimiento.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.gpBusqSeguimiento.Name = "gpBusqSeguimiento"
        Me.gpBusqSeguimiento.Size = New System.Drawing.Size(930, 477)
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
        Me.panelBusqSeguimiento.Size = New System.Drawing.Size(924, 454)
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
        Me.JGBusqSeguimiento.Size = New System.Drawing.Size(924, 454)
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
        Me.btnFClinica.Location = New System.Drawing.Point(1096, 0)
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
        Me.btnReciboI.Location = New System.Drawing.Point(1016, 0)
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
        Me.btnSeguimiento.Location = New System.Drawing.Point(928, 0)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(88, 72)
        Me.btnSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSeguimiento.TabIndex = 20
        Me.btnSeguimiento.Text = "SEGUIMIENTO"
        Me.btnSeguimiento.TextColor = System.Drawing.Color.White
        '
        'F1_Fic_SegInternacion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 691)
        Me.Name = "F1_Fic_SegInternacion2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEGUIMIENTO DE  INTERNACIÓN"
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
        Me.gpFichaInternacion.ResumeLayout(False)
        CType(Me.stcFichaInternacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcFichaInternacion.ResumeLayout(False)
        Me.stcpExamenFisico.ResumeLayout(False)
        Me.panelExamenFisico.ResumeLayout(False)
        Me.gpExamenFisico.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.JGExamenFisico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbTurnoEF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGradoConciencia.ResumeLayout(False)
        Me.PanelDolor.ResumeLayout(False)
        Me.PanelDeshidratacion.ResumeLayout(False)
        Me.PanelMucosas.ResumeLayout(False)
        Me.stcpTratamiento.ResumeLayout(False)
        Me.PanelTratamiento.ResumeLayout(False)
        Me.gpTratamiento.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.JGTratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.stcpEstudiosComplem.ResumeLayout(False)
        Me.PanelEstudiosComplemen.ResumeLayout(False)
        Me.gpEstudiosComplem.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.JGEstudiosC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.stcpFluidoterapia.ResumeLayout(False)
        Me.panelFluidoterapia.ResumeLayout(False)
        Me.gpFluidoterapia.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.JGFluidoterapia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.cbTurnoF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcpAlimentacion.ResumeLayout(False)
        Me.panelAlimentacion.ResumeLayout(False)
        Me.gpAlimentacion.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.JGAlimentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.txtRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcpMonitoreo.ResumeLayout(False)
        Me.panelMonitoreo.ResumeLayout(False)
        Me.gpMonitoreo.ResumeLayout(False)
        Me.panelSeguimiento.ResumeLayout(False)
        CType(Me.JGMonitoreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.stcpSignosVitales.ResumeLayout(False)
        Me.panelSignosVitales.ResumeLayout(False)
        Me.gpSignosVitales.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.JGSignosVitales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.stcpDatosGenerales.ResumeLayout(False)
        Me.panelDatosGenerales.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.cbTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqSeguimiento.ResumeLayout(False)
        Me.panelBusqSeguimiento.ResumeLayout(False)
        CType(Me.JGBusqSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents gpFichaInternacion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpBusqSeguimiento As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqSeguimiento As Panel
    Friend WithEvents JGBusqSeguimiento As Janus.Windows.GridEX.GridEX
    Protected WithEvents btnFClinica As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnSeguimiento As DevComponents.DotNetBar.ButtonX
    Protected WithEvents btnReciboI As DevComponents.DotNetBar.ButtonX
    Friend WithEvents stcFichaInternacion As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents stcpDatosGenerales As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpTratamiento As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelTratamiento As Panel
    Friend WithEvents SuperTabItem10 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpEstudiosComplem As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEstudiosComplemen As Panel
    Friend WithEvents SuperTabItem9 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpFluidoterapia As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem8 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpAlimentacion As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem7 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpMonitoreo As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem6 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpSignosVitales As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents stcpExamenFisico As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents panelExamenFisico As Panel
    Friend WithEvents gpExamenFisico As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents JGExamenFisico As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFechaEF As DateTimePicker
    Friend WithEvents txtHoraEF As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAgregarEF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTurnoEF As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelGradoConciencia As Panel
    Friend WithEvents chbComa As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbEstable As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbSemicomatoso As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelDolor As Panel
    Friend WithEvents chbSevero As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbLeve As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbModerado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lbMucosas As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelDeshidratacion As Panel
    Friend WithEvents chb5_7 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chb0_5 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chb8_10 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lbDeshidratacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelMucosas As Panel
    Friend WithEvents chbCianoticas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbPalidas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbRosadas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chbIctericas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents lbDolor As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbGradoConciencia As DevComponents.DotNetBar.LabelX
    Friend WithEvents panelSignosVitales As Panel
    Friend WithEvents gpSignosVitales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents JGSignosVitales As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpFechaSV As DateTimePicker
    Friend WithEvents txtHoraSV As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAgregarSV As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDefecacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbOtros As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOtrosSV As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbDefecacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDiarreas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVomitos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbVomitos As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbDiarreas As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtInfartos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtConvulsiones As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbMiccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbConvulsiones As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMiccion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbInfartos As DevComponents.DotNetBar.LabelX
    Friend WithEvents panelMonitoreo As Panel
    Friend WithEvents gpMonitoreo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelSeguimiento As Panel
    Friend WithEvents JGMonitoreo As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpFechaM As DateTimePicker
    Friend WithEvents btnAgregarM As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTRC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPSys As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMED As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPDys As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX37 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX38 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX39 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX40 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPeso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSPO2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHoraM As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panelAlimentacion As Panel
    Friend WithEvents gpAlimentacion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents JGAlimentacion As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dtpFechaA As DateTimePicker
    Friend WithEvents btnAgregarA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtRecovery As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX42 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX43 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNPO As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAgua As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX44 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX45 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX46 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX47 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX48 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPVM As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPolloLic As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPolloDesm As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHoraA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panelFluidoterapia As Panel
    Friend WithEvents gpFluidoterapia As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents JGFluidoterapia As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dtpFechaF As DateTimePicker
    Friend WithEvents btnAgregarF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtHoraTermino As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX53 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX54 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX55 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX56 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHoraInicio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFluidos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCantidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHoraF As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX57 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTurnoF As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents panelDatosGenerales As Panel
    Friend WithEvents panelDatos As Panel
    Friend WithEvents txtMotivoI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTelefonoI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEdadI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSexoI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEspecieI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPacienteI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPropietarioI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdFicha As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdFicInter As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbFechaI As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaSeg As DateTimePicker
    Friend WithEvents gpEstudiosComplem As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents JGEstudiosC As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtEstudiosComplem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpFechaEC As DateTimePicker
    Friend WithEvents btnAgregarEC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHoraEC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpTratamiento As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents JGTratamiento As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel As Panel
    Friend WithEvents txtTratamiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpFechaT As DateTimePicker
    Friend WithEvents btnAgregarT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHoraT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTurno As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtObs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRequerimiento As DevComponents.Editors.IntegerInput
    Friend WithEvents btnLimpiarSV As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiarM As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiarA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiarF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiarEC As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiarT As DevComponents.DotNetBar.ButtonX
End Class
