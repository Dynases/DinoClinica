<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim cbSector_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim cbConcepto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbSector = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbSector = New DevComponents.DotNetBar.LabelX()
        Me.txtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbObservacion = New DevComponents.DotNetBar.LabelX()
        Me.cbConcepto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbConcepto = New DevComponents.DotNetBar.LabelX()
        Me.lbFechaMov = New DevComponents.DotNetBar.LabelX()
        Me.txtIdMovimiento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdMovimiento = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cbSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(800, 164)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        Me.GroupPanel1.TabIndex = 36
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dtpFMovimiento)
        Me.Panel2.Controls.Add(Me.cbSector)
        Me.Panel2.Controls.Add(Me.lbSector)
        Me.Panel2.Controls.Add(Me.txtObservacion)
        Me.Panel2.Controls.Add(Me.lbObservacion)
        Me.Panel2.Controls.Add(Me.cbConcepto)
        Me.Panel2.Controls.Add(Me.lbConcepto)
        Me.Panel2.Controls.Add(Me.lbFechaMov)
        Me.Panel2.Controls.Add(Me.txtIdMovimiento)
        Me.Panel2.Controls.Add(Me.lbIdMovimiento)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 141)
        Me.Panel2.TabIndex = 0
        '
        'dtpFMovimiento
        '
        Me.dtpFMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFMovimiento.Location = New System.Drawing.Point(126, 46)
        Me.dtpFMovimiento.Name = "dtpFMovimiento"
        Me.dtpFMovimiento.Size = New System.Drawing.Size(122, 22)
        Me.dtpFMovimiento.TabIndex = 237
        Me.dtpFMovimiento.TabStop = False
        '
        'cbSector
        '
        cbSector_DesignTimeLayout.LayoutString = resources.GetString("cbSector_DesignTimeLayout.LayoutString")
        Me.cbSector.DesignTimeLayout = cbSector_DesignTimeLayout
        Me.cbSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSector.Location = New System.Drawing.Point(126, 103)
        Me.cbSector.Name = "cbSector"
        Me.cbSector.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbSector.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbSector.SelectedIndex = -1
        Me.cbSector.SelectedItem = Nothing
        Me.cbSector.Size = New System.Drawing.Size(176, 22)
        Me.cbSector.TabIndex = 4
        Me.cbSector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbSector
        '
        Me.lbSector.AutoSize = True
        Me.lbSector.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSector.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSector.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbSector.Location = New System.Drawing.Point(23, 108)
        Me.lbSector.Name = "lbSector"
        Me.lbSector.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSector.Size = New System.Drawing.Size(47, 16)
        Me.lbSector.TabIndex = 234
        Me.lbSector.Text = "Sector:"
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
        Me.txtObservacion.Location = New System.Drawing.Point(426, 18)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PreventEnterBeep = True
        Me.txtObservacion.Size = New System.Drawing.Size(211, 62)
        Me.txtObservacion.TabIndex = 3
        '
        'lbObservacion
        '
        Me.lbObservacion.AutoSize = True
        Me.lbObservacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbObservacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbObservacion.Location = New System.Drawing.Point(336, 18)
        Me.lbObservacion.Name = "lbObservacion"
        Me.lbObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbObservacion.Size = New System.Drawing.Size(84, 16)
        Me.lbObservacion.TabIndex = 231
        Me.lbObservacion.Text = "Observacion:"
        '
        'cbConcepto
        '
        cbConcepto_DesignTimeLayout.LayoutString = resources.GetString("cbConcepto_DesignTimeLayout.LayoutString")
        Me.cbConcepto.DesignTimeLayout = cbConcepto_DesignTimeLayout
        Me.cbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConcepto.Location = New System.Drawing.Point(126, 74)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbConcepto.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbConcepto.SelectedIndex = -1
        Me.cbConcepto.SelectedItem = Nothing
        Me.cbConcepto.Size = New System.Drawing.Size(176, 22)
        Me.cbConcepto.TabIndex = 2
        Me.cbConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbConcepto
        '
        Me.lbConcepto.AutoSize = True
        Me.lbConcepto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbConcepto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbConcepto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbConcepto.Location = New System.Drawing.Point(22, 79)
        Me.lbConcepto.Name = "lbConcepto"
        Me.lbConcepto.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbConcepto.Size = New System.Drawing.Size(65, 16)
        Me.lbConcepto.TabIndex = 229
        Me.lbConcepto.Text = "Concepto:"
        '
        'lbFechaMov
        '
        Me.lbFechaMov.AutoSize = True
        Me.lbFechaMov.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaMov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaMov.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaMov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaMov.Location = New System.Drawing.Point(23, 48)
        Me.lbFechaMov.Name = "lbFechaMov"
        Me.lbFechaMov.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaMov.Size = New System.Drawing.Size(44, 16)
        Me.lbFechaMov.TabIndex = 227
        Me.lbFechaMov.Text = "Fecha:"
        '
        'txtIdMovimiento
        '
        Me.txtIdMovimiento.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.txtIdMovimiento.Border.Class = "TextBoxBorder"
        Me.txtIdMovimiento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdMovimiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdMovimiento.Enabled = False
        Me.txtIdMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovimiento.ForeColor = System.Drawing.Color.Black
        Me.txtIdMovimiento.Location = New System.Drawing.Point(126, 16)
        Me.txtIdMovimiento.Name = "txtIdMovimiento"
        Me.txtIdMovimiento.PreventEnterBeep = True
        Me.txtIdMovimiento.Size = New System.Drawing.Size(80, 22)
        Me.txtIdMovimiento.TabIndex = 0
        '
        'lbIdMovimiento
        '
        Me.lbIdMovimiento.AutoSize = True
        Me.lbIdMovimiento.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdMovimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdMovimiento.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdMovimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdMovimiento.Location = New System.Drawing.Point(22, 18)
        Me.lbIdMovimiento.Name = "lbIdMovimiento"
        Me.lbIdMovimiento.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdMovimiento.Size = New System.Drawing.Size(98, 16)
        Me.lbIdMovimiento.TabIndex = 225
        Me.lbIdMovimiento.Text = "Id Movimiento:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFMovimiento As DateTimePicker
    Friend WithEvents cbSector As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Private WithEvents lbSector As DevComponents.DotNetBar.LabelX
    Private WithEvents txtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents lbObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbConcepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Private WithEvents lbConcepto As DevComponents.DotNetBar.LabelX
    Private WithEvents lbFechaMov As DevComponents.DotNetBar.LabelX
    Private WithEvents txtIdMovimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents lbIdMovimiento As DevComponents.DotNetBar.LabelX
End Class
