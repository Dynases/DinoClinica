<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizador
    Inherits System.Windows.Forms.Form

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
        Me.CrGeneral = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrGeneral
        '
        Me.CrGeneral.ActiveViewIndex = -1
        Me.CrGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrGeneral.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrGeneral.Location = New System.Drawing.Point(0, 0)
        Me.CrGeneral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CrGeneral.Name = "CrGeneral"
        Me.CrGeneral.Size = New System.Drawing.Size(600, 366)
        Me.CrGeneral.TabIndex = 1
        Me.CrGeneral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Visualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.CrGeneral)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Visualizador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrGeneral As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
