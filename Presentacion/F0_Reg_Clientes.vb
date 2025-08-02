Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.Controls
Partial Class F0_Reg_Clientes
    'Inherits Modelo.Modelo0
#Region "VARIABLES LOCALES"
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public Limpiar As Boolean = False  'Bandera para indicar si limpiar todos los datos o mantener datos ya registrados
#End Region
#Region "EVENTOS"
    Private Sub F0_Reg_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
        'TxtNombreUsu.Text = L_Usuario

    End Sub
    Private Sub JGBPropietario_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub
    Private Sub JDGClientes_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JDGClientes.EditingCell, JGBPropietario.EditingCell
        e.Cancel = True
    End Sub
    Private Sub btnAgregarMascota_Click(sender As Object, e As EventArgs) Handles btnAgregarMascota.Click
        Dim frm As New F1_Reg_Pacientes
        frm._Iniciar = 1
        frm._IdCliente = IIf(txtId.Text <> String.Empty, txtId.Text, 0)
        'frm._modulo = FP_Configuracion
        frm.ShowDialog()
        frm._Iniciar = 0
        'Actualiza 
        _prIniciarTodo()
    End Sub
    'Emergencia
    Private Sub btnEmergencia_Click(sender As Object, e As EventArgs) Handles btnEmergencia.Click
        Dim tFichaAtencion As DataTable = L_fnMostrarFichaAtencion()
        Dim frm As New F_Reg_Emergencia
        Dim dt As DataTable = L_fnFichaAtencionMaxPrioridadEmergencia()
        Dim _prioridad As Integer = dt.Rows(0).Item("fapriori")
        If _prioridad > 0 Then
            _prioridad = _prioridad
            tFichaAtencion.Rows.Add(Convert.ToInt32(JGMascotasAtencion.GetValue("pbid")), 3, 0, _prioridad, _fnObtenerNumiConsultorio(JGMascotasAtencion.GetValue("Consultorio")))
        Else
            tFichaAtencion.Rows.Add(Convert.ToInt32(JGMascotasAtencion.GetValue("pbid")), 3, 0, -1, _fnObtenerNumiConsultorio(JGMascotasAtencion.GetValue("Consultorio")))
        End If
        frm._Tabla = tFichaAtencion
        frm.ShowDialog()
        Dim mensaje = IIf(frm._resultado, "El paciente " + JGMascotasAtencion.GetValue("pbid").ToString() + " paso a fichas de atencion ".ToUpper + " Grabado con Exito.", "La paciente no paso a Ficha de Atención".ToUpper)
        Dim imagen As Bitmap = New Bitmap(IIf(frm._resultado, My.Resources.checked, My.Resources.cancel), 50, 50)
        ToastNotification.Show(Me, mensaje.ToUpper, imagen, 2000, eToastGlowColor.Green, eToastPosition.TopCenter)
        _prCargarPaciente(JGBPropietario.GetValue("caid"))
    End Sub
    'Asignar Ficha
    Private Sub btnAsignarFicha_Click(sender As Object, e As EventArgs) Handles btnAsignarFicha.Click
#Region "Declaraciones"
        Dim img As New Bitmap(My.Resources.checked)
        btnAsignarFicha.Image = img
        Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        'Guarda la atencion de ficha clinica
        Dim tFichaAtencion As DataTable = L_fnMostrarFichaAtencion()
        Dim bandera As Boolean = False
#End Region
        _prInterpretarDatosFichaAtencion(tFichaAtencion, bandera)
        If (bandera = False) Then
            ToastNotification.Show(Me, "Seleccione consultorio y una sola opción en la lista de pacientes".ToUpper, img2, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Return
        End If
        If tFichaAtencion.Rows.Count = 0 Then
            ToastNotification.Show(Me, "Seleccione consultorio y el check de un paciente".ToUpper, img2, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Return
        Else
            If bandera Then
                Dim _faId As String = "" 'Codigo de ficha
                Dim resultado As Boolean = False
                resultado = L_fnGrabarFichaAtencion(_faId, tFichaAtencion)
                Dim mensaje = IIf(resultado, "El paciente paso a fichas de atencion y fue".ToUpper + " Grabado con Exito.", "La paciente no pudo ser insertado".ToUpper)
                Dim imagen As Bitmap = New Bitmap(IIf(resultado, My.Resources.checked, My.Resources.cancel), 50, 50)
                ToastNotification.Show(Me, mensaje.ToUpper, imagen, 3000, eToastGlowColor.Green, eToastPosition.TopCenter)
                'Carga las mascotas en estado Sin atencion
                _prCargarPaciente(JGBPropietario.GetValue("caid"))
                '***Cargar la ventana de Ficha de Atención***'
                F_Fic_FichaAtencion._prCargarFichaAtencion()
                btnAsignarFicha.Enabled = False
            End If
        End If
    End Sub

    ''*****Ingresa en un datatable los datos del paciente y valida que solo se realice  1 seleccion de check en la grilla
    Sub _prInterpretarDatosFichaAtencion(ByRef dt As DataTable, ByRef bandera As Boolean)
        Dim tFicha As DataTable = L_fnFichaAtencionMaxPrioridad()
        Dim tMascota As DataTable = CType(JGMascotasAtencion.DataSource, DataTable)
        Dim contador As Integer = 0
        Dim faPriori As Integer = tFicha.Rows(0).Item("faPriori")
        For Each fila As DataRow In tMascota.Rows
            If fila.Item("Consulta") = True And fila.Item("ReConsulta") = False And fila.Item("Consultorio") <> String.Empty Then
                faPriori = faPriori + 1
                dt.Rows.Add(Convert.ToInt32(fila.Item("pbid")), 1, 0, faPriori, _fnObtenerNumiConsultorio(fila.Item("Consultorio")))
            End If
            If fila.Item("Consulta") = False And fila.Item("ReConsulta") = True And fila.Item("Consultorio") <> String.Empty Then
                faPriori = faPriori + 1
                dt.Rows.Add(Convert.ToInt32(fila.Item("pbid")), 2, 0, faPriori, _fnObtenerNumiConsultorio(fila.Item("Consultorio")))
            End If
            If fila.Item("Consulta") = False And fila.Item("ReConsulta") = False And fila.Item("Consultorio") = String.Empty Then
                contador = contador + 1
            End If
            If fila.Item("Consulta") = True And fila.Item("ReConsulta") = False And fila.Item("Consultorio") = String.Empty Then
                contador = contador + 1
            End If
            If fila.Item("Consulta") = False And fila.Item("ReConsulta") = True And fila.Item("Consultorio") = String.Empty Then
                contador = contador + 1
            End If


        Next
        bandera = True
        If tMascota.Rows.Count <> dt.Rows.Count + contador Then
            bandera = False
        End If
    End Sub
    Public Function _fnObtenerNumiConsultorio(name As String) As Integer
        Dim dt As New DataTable
        dt = L_fnMostrarConsultorio()

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim data As String = dt.Rows(i).Item("ccNro")
            If (data.Equals(name)) Then
                Return dt.Rows(i).Item("ccId")
            End If
        Next
        Return -1
    End Function
    Private Sub JGBPropietario_SelectionChanged(sender As Object, e As EventArgs) Handles JGBPropietario.SelectionChanged
        'Verifica si existe filas en JDG
        If (JGBPropietario.RowCount >= 0 And JGBPropietario.Row >= 0) Then
            'Carga la grilla de Mascotas atencion
            _prCargarPacienteSeleccion(JGBPropietario.GetValue("caid"))
            btnAsignarFicha.Enabled = True
        End If
    End Sub
    'Seleccion de propietarios
    Private Sub JDGClientes_SelectionChanged(sender As Object, e As EventArgs) Handles JDGClientes.SelectionChanged
        If (JDGClientes.RowCount >= 0 And JDGClientes.Row >= 0) Then
            _prMostrarRegistro(JDGClientes.Row)
        End If
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JDGClientes.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JDGClientes.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JDGClientes.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JDGClientes.RowCount > 0 Then
            _MPos = JDGClientes.RowCount - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    '***************SELECCION EL CHECK DE LA GRILLA MASCOTAS
    Private Sub JGMascotasAtencion_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGMascotasAtencion.EditingCell
        If (e.Column.Index = JGMascotasAtencion.RootTable.Columns("Consulta").Index Or e.Column.Index = JGMascotasAtencion.RootTable.Columns("ReConsulta").Index Or e.Column.Index = JGMascotasAtencion.RootTable.Columns("Consultorio").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Public Sub _prIniciarTodo()
        'Asignar permiso
        _prCargarComboConsultorios(cbConsultorio)
        _PMInhabilitar()
        _PMAsignarPermisos()
        _prCargarClientes()
        _prCargarPropietarios()
        _PMOInhabilitar()

    End Sub

    Private Sub _prCargarComboConsultorios(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMostrarConsultorio()

        With mCombo
            .DropDownList.Columns.Clear()
            '.DropDownList.Columns.Add("ccId").Width = 60
            '.DropDownList.Columns("ccId").Caption = "ID"
            .DropDownList.Columns.Add("ccNro").Width = 120
            .DropDownList.Columns("ccNro").Caption = "Doctor"
            .ValueMember = "ccNro"
            .DisplayMember = "ccNro"
            .DataSource = dt
            .Refresh()

        End With

    End Sub
    ''*****CARGA EL DATAGRID DEL CLIENTE*****''
    Private Sub _prCargarClientes()
        Dim dt As New DataTable
        dt = L_fnMostrarClientes()

        JDGClientes.DataSource = dt
        JDGClientes.RetrieveStructure()
        JDGClientes.AlternatingColors = True

        With JDGClientes.RootTable.Columns("caid")
            .Width = 80
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True

        End With
        With JDGClientes.RootTable.Columns("caci")
            .Width = 90
            .Caption = "CI"
            .Visible = True

        End With
        With JDGClientes.RootTable.Columns("canomb")
            .Width = 150
            .Visible = True
            .Caption = "Nombre"
        End With
        With JDGClientes.RootTable.Columns("caapell")
            .Width = 150
            .Caption = "Apellidos"
            .Visible = True
        End With

        With JDGClientes.RootTable.Columns("cadir")
            .Width = 150
            .Caption = "Dirección"
            .Visible = False
        End With
        With JDGClientes.RootTable.Columns("catelf")
            .Width = 90
            .Caption = "Teléfono"
            .Visible = True
        End With
        With JDGClientes.RootTable.Columns("camail")
            .Width = 150
            .Visible = False
            .Caption = "Email"
        End With
        With JDGClientes.RootTable.Columns("cafecha")
            .Width = 90
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Fecha"
        End With
        With JDGClientes.RootTable.Columns("cafechanac")
            .Width = 90
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Fecha Nac"
        End With
        With JDGClientes.RootTable.Columns("cahora")
            .Width = 90
            .Visible = False

        End With
        With JDGClientes.RootTable.Columns("causuario")
            .Width = 90
            .Visible = False
            .Caption = "Usuario"
        End With
        With JDGClientes
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .RootTable.Columns(0).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
        'If (dt.Rows.Count <= 0) Then
        '    _prCargarDetalleVenta(-1)
        'End If
    End Sub
    ''*****CARGA EL DATAGRID DEL PROPIETARIO*****''
    Private Sub _prCargarPropietarios()
        Dim dt As New DataTable
        dt = L_fnMostrarClientesSiDebeOno()

        JGBPropietario.DataSource = dt
        JGBPropietario.RetrieveStructure()
        JGBPropietario.AlternatingColors = True

        With JGBPropietario.RootTable.Columns("caid")
            .Width = 90
            .Caption = "Id"
            .Visible = True

        End With
        With JGBPropietario.RootTable.Columns("caci")
            .Width = 90
            .Caption = "CI"
            .Visible = True

        End With
        With JGBPropietario.RootTable.Columns("canomb")
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "Nombre"
        End With
        With JGBPropietario.RootTable.Columns("caapell")
            .Width = 250
            .Caption = "Apellidos"
            .Visible = True
        End With

        With JGBPropietario.RootTable.Columns("cadir")
            .Width = 250
            .Caption = "Dirección"
            .Visible = True
        End With
        With JGBPropietario.RootTable.Columns("catelf")
            .Width = 90
            .Caption = "Teléfono"
            .Visible = True
        End With
        'With JGBPropietario.RootTable.Columns("camail")
        '    .Width = 150
        '    .Visible = False
        '    .Caption = "Mail"
        'End With
        'With JGBPropietario.RootTable.Columns("cafecha")
        '    .Width = 90
        '    .Visible = True
        '    .Caption = "Fecha"
        'End With
        'With JGBPropietario.RootTable.Columns("cahora")
        '    .Width = 90
        '    .Visible = False

        'End With
        'With JGBPropietario.RootTable.Columns("causuario")
        '    .Width = 90
        '    .Visible = False
        '    .Caption = "Usuario"

        'End With
        With JGBPropietario.RootTable.Columns("Monto")
            .Width = 90
            .Caption = "Monto"
            .Visible = False
        End With
        With JGBPropietario.RootTable.Columns("Pagos")
            .Width = 90
            .Caption = "Pagos"
            .Visible = False
        End With
        With JGBPropietario.RootTable.Columns("Saldo")
            .Width = 90
            .Caption = "Saldo"
            .Visible = False
        End With
        With JGBPropietario.RootTable.Columns("Debe")
            .Width = 90
            .Caption = "Debe?"
            .Visible = True
        End With
        With JGBPropietario
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .RootTable.Columns(0).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
        If (dt.Rows.Count <= 0) Then
            _prCargarPaciente(-1)
        End If
    End Sub
    ''*****MUESTRA EL PROPIETARIO EN LOS TEXTBOX*****''
    Public Sub _prMostrarRegistro(_N As Integer)
        JDGClientes.Row = _N
        With JDGClientes
            'caid, caci, canomb, caapell, cadir, catelf, camail, cafecha, cahora, causuario, caest
            txtId.Text = .GetValue("caid")
            txtCI.Text = .GetValue("caci")
            txtNombreC.Text = .GetValue("canomb")
            txtApellidosC.Text = .GetValue("caapell")
            txtDireccionC.Text = .GetValue("cadir")
            txtTelfC.Text = .GetValue("catelf")
            txtMail.Text = .GetValue("camail")
            dtpFIngresoC.Value = .GetValue("cafecha")
            tbFechaNac.Value = .GetValue("cafechanac")
            _prCargarPaciente(Convert.ToInt32(txtId.Text))
            'Muestra el bubblebar(que usuario registró el cliente)
            lbFecha.Text = CType(.GetValue("cafecha"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("cahora").ToString
            lbUsuario.Text = .GetValue("causuario").ToString
            'Muestra la cantidad de propietarios
            LblPaginacion.Text = Str(JDGClientes.Row + 1) + "/" + JDGClientes.RowCount.ToString
        End With
    End Sub
    ''*****CARGA EL DATAGRID DEL PACIENTE SEGUN UN CODIGO DE CLIENTE*****''
    Private Sub _prCargarPaciente(_id As Integer)
        Dim _tabla As DataTable = L_fnMostrarPaciente(_id)
        JGrM_Buscador.DataSource = _tabla
        JGrM_Buscador.RetrieveStructure()
        JGrM_Buscador.AlternatingColors = True
        With JGrM_Buscador.RootTable.Columns("pbid")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pb_caid")
            .Width = 70
            .Caption = "Id_Cliente"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("cacliente")
            .Width = 140
            .Caption = "Cliente"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("pbnomb")
            .Width = 120
            .Caption = "Nombre"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbespec")
            .Width = 110
            .Caption = "pbespec"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("Especie")
            .Width = 110
            .Caption = "Especie"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbfnac")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "F. Nacimiento"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbraza")
            .Width = 100
            .Caption = "pbraza"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("Raza")
            .Width = 120
            .Caption = "Raza"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbsex")
            .Width = 82
            .Caption = "Sexo"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbcolor")
            .Width = 100
            .Caption = "Color"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbester")
            .Width = 90
            .Caption = "Esterilizado"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbdest")
            .Width = 100
            .Caption = "Descripción Estado"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbseñas")
            .Width = 100
            .Caption = "Señas"
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbfingr")
            .Width = 95
            .Caption = "F. Ingreso"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGrM_Buscador.RootTable.Columns("pbest")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("pbhora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("pbusuario")
            .Width = 100
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGrM_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .RootTable.Columns(0).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prCargarPacienteSeleccion(_id As Integer)
        Dim _tabla As DataTable = L_fnMostrarPacientesSeleccion(_id)


        '------------------borrar despues -------------------------------------
        For i = _tabla.Rows.Count - 1 To 0 Step -1
            If i > 0 Then
                _tabla.Rows.RemoveAt(i)
            Else
                _tabla.Rows(i).Item("pbnomb") = _tabla.Rows(i).Item("cacliente")
            End If

        Next
        '----------------------------------------------------------------------
        JGMascotasAtencion.DataSource = _tabla
        JGMascotasAtencion.RetrieveStructure()
        JGMascotasAtencion.AlternatingColors = True
        With JGMascotasAtencion.RootTable.Columns("pbid")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("pb_caid")
            .Width = 70
            .Caption = "Id_Cliente"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("cacliente")
            .Width = 150
            .Caption = "Cliente"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("pbnomb")
            .Width = 300
            .Caption = "Nombre"
            .Visible = True
        End With
        With JGMascotasAtencion.RootTable.Columns("Especie")
            .Width = 120
            .Caption = "Especie"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("Raza")
            .Width = 180
            .Caption = "Raza"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("pbsex")
            .Width = 130
            .Caption = "Sexo"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("pbest")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGMascotasAtencion.RootTable.Columns("Consulta")
            .Width = 100
            .Caption = "Consulta"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGMascotasAtencion.RootTable.Columns("ReConsulta")
            .Width = 120
            .Caption = "Reconsulta"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGMascotasAtencion.RootTable.Columns("Consultorio")

            .Caption = "Doctor"
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbConsultorio.DropDownList
            '.DefaultValue = cbConsultorio.ValueMember
            .Width = 150
            .Visible = True
        End With
        With JGMascotasAtencion
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .RootTable.Columns(0).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarClientes()
        _prCargarPropietarios()
        If JGBPropietario.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(_MPos)
        Else
            _PMOLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
#End Region
#Region "METODOS SOBRECARGADOS"
    Public Overrides Function _PMOGetTablaBuscador() As DataTable
        Dim dtBuscador As DataTable = L_fnMostrarClientesSiDebeOno()
        Return dtBuscador
    End Function
    ''*****GRABAR EL REGISTRO DEL CLIENTE*****''
    Public Overrides Function _PMOGrabarRegistro() As Boolean

        Dim res As Boolean = L_fnGrabarClientes(txtId.Text, txtCI.Text, txtNombreC.Text.Trim(), txtApellidosC.Text, txtDireccionC.Text, txtTelfC.Text, txtMail.Text, dtpFIngresoC.Value.ToString("yyyy/MM/dd"), tbFechaNac.Value.ToString("yyyy/MM/dd"))

        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

            ToastNotification.Show(Me, "Id del Cliente ".ToUpper + txtId.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            'If (MessageBox.Show("¿Desea registrar un paciente? ", "Registro de pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            '    Dim frm As New F1_Reg_Pacientes
            '    frm._IdCliente = txtId.Text
            '    frm._Iniciar = 1

            '    frm.ShowDialog()
            '    frm.txtNMascota.Focus()
            '    frm._Iniciar = 0
            'End If
            L_fnGrabarPaciente("", txtId.Text, txtNombreC.Text + " " + txtApellidosC.Text, 1, dtpFIngresoC.Value.ToString("yyyy/MM/dd"), 1, "MACHO", "TRANSPARENTE", "SI", "", "", dtpFIngresoC.Value.ToString("yyyy/MM/dd"))
            _prCargarClientes()
            _prMostrarRegistro(0)
            _PMOLimpiar()
            _prCargarPropietarios()
            txtCI.Focus()
            Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El cliente no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    Public Overrides Function _PMOModificarRegistro() As Boolean

        Dim res As Boolean = L_fnModificarClientes(txtId.Text, txtCI.Text, txtNombreC.Text.Trim(), txtApellidosC.Text, txtDireccionC.Text, txtTelfC.Text, txtMail.Text, dtpFIngresoC.Value.ToString("yyyy/MM/dd"), tbFechaNac.Value.ToString("yyyy/MM/dd"))

        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

            ToastNotification.Show(Me, "Id del Cliente ".ToUpper + txtId.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            'If (MessageBox.Show("¿Desea modificar un paciente? ", "Registro de pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            '    Dim frm As New F1_Reg_Pacientes
            '    frm._IdCliente = txtId.Text
            '    frm._Iniciar = 2
            '    frm.Focus()
            '    frm.superTabControl1.SelectedTabIndex = 1
            '    modificarPac = True
            '    _caidcli = txtId.Text
            '    frm.ShowDialog()
            '    frm._Iniciar = 0
            'End If
            'Actualiza los registros
            _prIniciarTodo()
            txtCI.Focus()
            Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El cliente no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    ''*****ELIMINAR EL REGISTRO*****''
    Public Overrides Sub _PMOEliminarRegistro()
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        If L_fnExistePaciente(txtId.Text) Then
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim mensajeError As String = ""
                Dim res As Boolean = L_fnEliminarClientes(txtId.Text, mensajeError)
                If res Then
                    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                    ToastNotification.Show(Me, "Código del cliente ".ToUpper + txtId.Text + " eliminado con Exito.".ToUpper,
                                              img, 2000,
                                              eToastGlowColor.Green,
                                              eToastPosition.TopCenter)
                    _prFiltrar()
                Else
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                End If
            End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "No se puede eliminar debido a que tiene mascotas registradas, primero elimine las mascotas correspondientes".ToUpper, img, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtCI.Text = String.Empty Then
            txtCI.BackColor = Color.Red
            MEP.SetError(txtCI, "ingrese el carnet de identidad!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el C.I. del Cliente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtCI.BackColor = Color.White
            MEP.SetError(txtCI, "")
        End If

        If txtNombreC.Text = String.Empty Then
            txtNombreC.BackColor = Color.Red
            MEP.SetError(txtNombreC, "Ingrese el nombre!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el nombre del cliente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtNombreC.BackColor = Color.White
            MEP.SetError(txtNombreC, "")
        End If
        If txtApellidosC.Text = String.Empty Then
            txtApellidosC.BackColor = Color.Red
            MEP.SetError(txtApellidosC, "Ingrese el apellido!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el apellido del cliente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtApellidosC.BackColor = Color.White
            MEP.SetError(txtApellidosC, "")
        End If

        If txtTelfC.Text = String.Empty Then
            txtTelfC.BackColor = Color.Red
            MEP.SetError(txtTelfC, "Ingrese un telefono!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el telefono del cliente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtTelfC.BackColor = Color.White
            MEP.SetError(txtTelfC, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides _
    Function _PMOGetListEstructuraBuscador() As List(Of Modelo.Celda)
        Dim listEstCeldas As New List(Of Modelo.Celda)
        listEstCeldas.Add(New Modelo.Celda("caid", True, "ID", 70))
        listEstCeldas.Add(New Modelo.Celda("caci", True, "CI", 70))
        listEstCeldas.Add(New Modelo.Celda("canomb", True, "NOMBRE", 200))
        'listEstCeldas.Add(New Modelos.Celda("paape", True, "APELLIDO", 200))
        'listEstCeldas.Add(New Modelos.Celda("padirec", True, "DIRECCION", 200))
        'listEstCeldas.Add(New Modelos.Celda("patelef1", True, "TELEFONO", 100))
        'listEstCeldas.Add(New Modelos.Celda("patelef2", True, "CELULAR", 100))
        'listEstCeldas.Add(New Modelos.Celda("paemail", True, "E-MAIL", 100))
        'listEstCeldas.Add(New Modelos.Celda("patipo", False))
        'listEstCeldas.Add(New Modelos.Celda("tipodesc", True, "TIPO", 70))
        'listEstCeldas.Add(New Modelos.Celda("paobs", True, "OBSERVACION", 70))
        'listEstCeldas.Add(New Modelos.Celda("pafnac", True, "FEC. NACIMIENTO", 80))
        'listEstCeldas.Add(New Modelos.Celda("pafing", True, "FEC. INGRESO", 80))
        'listEstCeldas.Add(New Modelos.Celda("pafret", True, "FEC. RETIRO", 80))
        'listEstCeldas.Add(New Modelos.Celda("paest", False))
        'listEstCeldas.Add(New Modelos.Celda("paest2", True, "ESTADO", 80))
        'listEstCeldas.Add(New Modelos.Celda("pasal", True, "SALARIO", 80, "0.00"))
        'listEstCeldas.Add(New Modelos.Celda("paeciv", False))
        'listEstCeldas.Add(New Modelos.Celda("pafot", False))
        'listEstCeldas.Add(New Modelos.Celda("civildesc", True, "EST. CIVIL", 120))
        'listEstCeldas.Add(New Modelos.Celda("pasuc", False))
        'listEstCeldas.Add(New Modelos.Celda("cadesc", True, "SUCURSAL", 120))
        'listEstCeldas.Add(New Modelos.Celda("pafijo", False))
        'listEstCeldas.Add(New Modelos.Celda("pafijo2", True, "FIJO", 80))
        'listEstCeldas.Add(New Modelos.Celda("pafsal", True, "SALIDA", 80))
        'listEstCeldas.Add(New Modelos.Celda("pareloj", False))
        'listEstCeldas.Add(New Modelos.Celda("pareloj2", True, "RELOJ", 80))
        'listEstCeldas.Add(New Modelos.Celda("paemp", False))
        'listEstCeldas.Add(New Modelos.Celda("paemp2", True, "EMPRESA", 120))
        'listEstCeldas.Add(New Modelos.Celda("palat", False))
        'listEstCeldas.Add(New Modelos.Celda("palon", False))
        'listEstCeldas.Add(New Modelos.Celda("paesp", True, "PAREJA", 120))
        'listEstCeldas.Add(New Modelos.Celda("pahijos", True, "HIJOS", 120))
        'listEstCeldas.Add(New Modelos.Celda("pamseg", True, "MATRI. SEGURO", 120))
        'listEstCeldas.Add(New Modelos.Celda("patsan", True, "TIPO SANGRE", 120))
        'listEstCeldas.Add(New Modelos.Celda("papsalud", True, "PROBLEM. SALUD", 120))
        'listEstCeldas.Add(New Modelos.Celda("pafact", False))
        'listEstCeldas.Add(New Modelos.Celda("pahact", False))
        'listEstCeldas.Add(New Modelos.Celda("pauact", False))
        Return listEstCeldas
    End Function

    Public Overrides Sub _PMONuevo()
        _PMOHabilitar()
        '_PMOLimpiar()
        '_prhabilitar()
        btnAgregarMascota.Enabled = False
        txtCI.Focus()
        _prCargarPaciente(-1)
        JDGClientes.Enabled = False

    End Sub
    Public Overrides Sub _PMOModificar()
        _PMOHabilitar()
        '_prhabilitar()
    End Sub
    Public Overrides Sub _PMOLimpiar()
        txtId.Clear()
        txtCI.ResetText()
        txtNombreC.Clear()
        txtApellidosC.Clear()
        txtDireccionC.Clear()
        txtTelfC.Clear()
        txtMail.Clear()
        dtpFIngresoC.Value = DateTime.Today()
        tbFechaNac.Value = DateTime.Today()
    End Sub
    Public Overrides Sub _PMOInhabilitar()
        txtId.ReadOnly = True
        txtCI.IsInputReadOnly = True
        txtNombreC.ReadOnly = True
        txtApellidosC.ReadOnly = True
        txtDireccionC.ReadOnly = True
        txtTelfC.ReadOnly = True
        txtMail.ReadOnly = True
        dtpFIngresoC.Enabled = False
        btnAgregarMascota.Enabled = False
        tbFechaNac.Enabled = False

    End Sub
    Public Overrides Sub _PMOHabilitar()
        txtId.ReadOnly = False
        txtCI.IsInputReadOnly = False
        txtNombreC.ReadOnly = False
        txtApellidosC.ReadOnly = False
        txtDireccionC.ReadOnly = False
        txtTelfC.ReadOnly = False
        txtMail.ReadOnly = False
        dtpFIngresoC.Enabled = True
        btnAgregarMascota.Enabled = True
        tbFechaNac.Enabled = True
    End Sub
    Public Overrides Sub _PMOSalir()
        _PMOInhabilitar()
        'prInhabiliitar()
        _prFiltrar()
        JDGClientes.Enabled = True
    End Sub

    Private Sub F0_Reg_Clientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnClientes)
    End Sub
    Function CalcularDiferenciaEnAnios(fecha1 As DateTime, fecha2 As DateTime) As Integer
        ' Asegúrate de que fecha2 sea posterior a fecha1
        If fecha1 > fecha2 Then
            Dim temp As DateTime = fecha1
            fecha1 = fecha2
            fecha2 = temp
        End If

        ' Calcula la diferencia en años
        Dim diferencia As Integer = fecha2.Year - fecha1.Year

        ' Ajusta si la fecha2 aún no ha llegado a la fecha1 en el año en curso
        If (fecha1.Month > fecha2.Month) OrElse (fecha1.Month = fecha2.Month AndAlso fecha1.Day > fecha2.Day) Then
            diferencia -= 1
        End If

        Return diferencia
    End Function
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles tbFechaNac.ValueChanged
        Dim edad As Integer = CalcularDiferenciaEnAnios(tbFechaNac.Value, Date.Now)
        tbEdad.Value = edad
    End Sub



#End Region
End Class