
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text

Imports System.Reflection
Imports System.Runtime.InteropServices
Public Class F1_Con_Librerias
#Region "Variables Globales"
    Dim precio As DataTable
    Dim Bin As New MemoryStream
    Public _nameButton As String
    Public _modulo As SideNavItem
    Public _tab As SuperTabItem
#End Region
#Region "EVENTOS"
    Private Sub F1_Con_Librerias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub
    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
    '    _prhabilitar()
    '    btnModificar.Enabled = False
    'End Sub
    Private Sub JGLibrerias_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGLibrerias.EditingCell
        If (_fnAccesible()) Then
            'Deshabilitar la columna de Productos y solo habilitar la de los precios
            If (e.Column.Index = JGLibrerias.RootTable.Columns("lbdesc").Index) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub JGLibrerias_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGLibrerias.CellEdited
        If (_fnAccesible()) Then
            JGLibrerias.SetValue("estado", 2)
        End If
    End Sub
    Private Sub cbCategoria_ValueChanged(sender As Object, e As EventArgs) Handles cbCategoria.ValueChanged
        _prCargarTablaLibrerias()
    End Sub
    Private Sub cbPrograma_ValueChanged(sender As Object, e As EventArgs) Handles cbPrograma.ValueChanged
        _prCargarComboLibreriaCategoriaPrograma(cbCategoria)
    End Sub
    Private Sub btnAgregarLib_Click(sender As Object, e As EventArgs) Handles btnAgregarLib.Click
        If (txtDescripcion.Text.Length > 0) Then
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            'a.yccod1 ,a.yccod2 ,a.yccod3  ,a.ycdes3,1 as estado,Cast(null as image) as img   from TY0031 as a
            CType(JGLibrerias.DataSource, DataTable).Rows.Add(Str(cbPrograma.Value), Str(cbCategoria.Value), _fnSiguienteNumi() + 1, txtDescripcion.Text, 0, Bin.ToArray())
            txtDescripcion.Clear()
            txtDescripcion.Focus()
        End If
    End Sub

#End Region
#Region "MEtodos Privados"
    Private Sub _IniciarTodo()
        _prCargarComboLibreria(cbPrograma)
        btnNuevo.Visible = False
        _prInhabiliitar()
        _PMAsignarPermisos()
        '_prAsignarPermisos()
        Me.Text = "LIBRERIAS"
    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnGeneralProgramas()
        'pro.paid,pro.padesc1
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("paid").Width = 70
            .DropDownList.Columns("paid").Caption = "COD"
            .DropDownList.Columns.Add("padesc1").Width = 200
            .DropDownList.Columns("padesc1").Caption = "DESCRIPCION"
            .ValueMember = "paid"
            .DisplayMember = "padesc1"
            .DataSource = dt
            .Refresh()
        End With
        If (CType(cbPrograma.DataSource, DataTable).Rows.Count > 0) Then
            cbPrograma.SelectedIndex = 0
        End If
    End Sub
    Private Sub _prCargarComboLibreriaCategoriaPrograma(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        If (cbPrograma.SelectedIndex < 0) Then
            Return
        End If
        dt = L_fnGeneralProgramasCategorias(cbPrograma.Value)

        'lib.lbidgrup,pro.padesc2
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("paidgrup").Width = 70
            .DropDownList.Columns("paidgrup").Caption = "COD"
            .DropDownList.Columns.Add("padesc2").Width = 200
            .DropDownList.Columns("padesc2").Caption = "DESCRIPCION"
            .ValueMember = "paidgrup"
            .DisplayMember = "padesc2"
            .DataSource = dt
            .Refresh()
        End With
        If (CType(cbCategoria.DataSource, DataTable).Rows.Count > 0) Then
            cbCategoria.SelectedIndex = 0
        End If
        _prCargarTablaLibrerias()
    End Sub
    Private Sub _prInhabiliitar()
        lbDescripcion.Visible = False
        txtDescripcion.Visible = False
        btnAgregarLib.Visible = False
        Panel2.Visible = False
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        If (CType(JGLibrerias.DataSource, DataTable).Rows.Count > 0) Then
            JGLibrerias.RootTable.Columns("img").Visible = False
        End If
    End Sub
    Private Sub _prhabilitar()
        lbDescripcion.Visible = True
        txtDescripcion.Visible = True
        btnAgregarLib.Visible = True
        btnGrabar.Enabled = True
        txtDescripcion.Clear()
        Panel2.Visible = True
    End Sub
    Private Function _fnBytesArchivo(img As Bitmap, ancho As Integer, alto As Integer) As Object
        Bin = New MemoryStream()
        Dim img2 As New Bitmap(img, ancho, alto)
        img2.Save(Bin, System.Drawing.Imaging.ImageFormat.Png)
        Return Bin.ToArray()
    End Function
    Public Sub _prCargarIconDelete(ByRef dt As DataTable)
        Bin = New MemoryStream()
        Dim img2 As New Bitmap(My.Resources.delete, 28, 28)
        img2.Save(Bin, System.Drawing.Imaging.ImageFormat.Png)

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            dt.Rows(i).Item("img") = Bin.ToArray()
        Next
    End Sub
    Private Sub _prCargarTablaLibrerias()
        Dim dt As New DataTable
        If (cbPrograma.SelectedIndex < 0 And cbCategoria.SelectedIndex < 0) Then
            Return
        End If
        dt = L_fnGeneralDetalleLibrerias(cbPrograma.Value, cbCategoria.Value)
        _prCargarIconDelete(dt)
        JGLibrerias.DataSource = dt
        JGLibrerias.RetrieveStructure()
        JGLibrerias.AlternatingColors = True
        'dar formato a las columnas
        With JGLibrerias.RootTable.Columns("lbidprog")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False

        End With
        With JGLibrerias.RootTable.Columns("lbidgrup")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False

        End With

        With JGLibrerias.RootTable.Columns("lbidlib")
            .Width = 90
            .Visible = True
            .Caption = "CODIGO"
        End With

        With JGLibrerias.RootTable.Columns("lbdesc")
            .Caption = "DESCRIPCION"
            .Width = 200
            .Visible = True
            .MaxLength = 40

        End With
        With JGLibrerias.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        If (_fnAccesible()) Then
            With JGLibrerias.RootTable.Columns("img")
                .Width = 80
                .Caption = "Eliminar".ToUpper
                .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
                .Visible = True
            End With
        Else
            With JGLibrerias.RootTable.Columns("img")
                .Width = 80
                .Caption = "Eliminar".ToUpper
                .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
                .Visible = False
            End With
        End If
        With JGLibrerias
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .RecordNavigator = True
            .RecordNavigatorText = "LIBRERIAS"
            .RowHeaders = InheritableBoolean.True
            'diseño de la grilla
            JGLibrerias.VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Public Function _fnAccesible()
        Return btnGrabar.Enabled = True
    End Function
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGLibrerias.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("lbidlib=MAX(lbidlib)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("lbidlib")
        End If
        Return 1
    End Function
    Public Function _prValidarCategoria() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()

        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Sub GuardarRegistro()
        Dim grabar As Boolean = L_fnGrabarLibreriasPrograma("", CType(JGLibrerias.DataSource, DataTable))
        If (grabar) Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "categoria Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prInhabiliitar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La categoria no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
    End Sub
#End Region
#Region "Metodos SObrecargados"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        GuardarRegistro()
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        GuardarRegistro()
    End Function
    ''*****ELIMINAR EL REGISTRO*****''
    Public Overrides Sub _PMOEliminarRegistro()
        GuardarRegistro()
    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabiliitar()
    End Sub
    Public Overrides Sub _PMOModificar()
        _prhabilitar()
    End Sub

    Private Sub F1_Con_Librerias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnLibrerias)
    End Sub

#End Region
End Class