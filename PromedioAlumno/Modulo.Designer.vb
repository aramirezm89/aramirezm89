<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modulo
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim LblCodigoModulo As System.Windows.Forms.Label
        Dim LblNombreModulo As System.Windows.Forms.Label
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntoNETDataSet1 = New PromedioAlumno.PuntoNETDataSet1()
        Me.ModulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigomoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombremoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntoNETDataSet2 = New PromedioAlumno.PuntoNETDataSet2()
        Me.ModulosTableAdapter = New PromedioAlumno.PuntoNETDataSet1TableAdapters.modulosTableAdapter()
        Me.TableAdapterManager = New PromedioAlumno.PuntoNETDataSet1TableAdapters.TableAdapterManager()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New PromedioAlumno.PuntoNETDataSet1TableAdapters.alumnosTableAdapter()
        Me.AlumnosTableAdapter1 = New PromedioAlumno.PuntoNETDataSet1TableAdapters.alumnosTableAdapter()
        Me.PuntoNETDataSet11 = New PromedioAlumno.PuntoNETDataSet1()
        Me.ModulosTableAdapter1 = New PromedioAlumno.PuntoNETDataSet2TableAdapters.modulosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.TxtCodigoModulo = New System.Windows.Forms.TextBox()
        Me.TxtNombreModulo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PromedioAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        LblCodigoModulo = New System.Windows.Forms.Label()
        LblNombreModulo = New System.Windows.Forms.Label()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoNETDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoNETDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoNETDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCodigoModulo
        '
        LblCodigoModulo.AutoSize = True
        LblCodigoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblCodigoModulo.Location = New System.Drawing.Point(91, 68)
        LblCodigoModulo.Name = "LblCodigoModulo"
        LblCodigoModulo.Size = New System.Drawing.Size(165, 25)
        LblCodigoModulo.TabIndex = 9
        LblCodigoModulo.Text = "Codigo Modulo:"
        '
        'LblNombreModulo
        '
        LblNombreModulo.AutoSize = True
        LblNombreModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblNombreModulo.Location = New System.Drawing.Point(91, 118)
        LblNombreModulo.Name = "LblNombreModulo"
        LblNombreModulo.Size = New System.Drawing.Size(171, 25)
        LblNombreModulo.TabIndex = 11
        LblNombreModulo.Text = "Nombre Modulo:"
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "modulos"
        Me.ModulosBindingSource.DataSource = Me.PuntoNETDataSet1
        '
        'PuntoNETDataSet1
        '
        Me.PuntoNETDataSet1.DataSetName = "PuntoNETDataSet1"
        Me.PuntoNETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosDataGridView
        '
        Me.ModulosDataGridView.AllowUserToAddRows = False
        Me.ModulosDataGridView.AllowUserToDeleteRows = False
        Me.ModulosDataGridView.AllowUserToResizeColumns = False
        Me.ModulosDataGridView.AllowUserToResizeRows = False
        Me.ModulosDataGridView.AutoGenerateColumns = False
        Me.ModulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigomoduloDataGridViewTextBoxColumn, Me.NombremoduloDataGridViewTextBoxColumn})
        Me.ModulosDataGridView.DataSource = Me.ModulosBindingSource1
        Me.ModulosDataGridView.Location = New System.Drawing.Point(85, 429)
        Me.ModulosDataGridView.Name = "ModulosDataGridView"
        Me.ModulosDataGridView.RowHeadersWidth = 51
        Me.ModulosDataGridView.RowTemplate.Height = 24
        Me.ModulosDataGridView.Size = New System.Drawing.Size(411, 176)
        Me.ModulosDataGridView.TabIndex = 5
        '
        'CodigomoduloDataGridViewTextBoxColumn
        '
        Me.CodigomoduloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigomoduloDataGridViewTextBoxColumn.DataPropertyName = "codigo_modulo"
        Me.CodigomoduloDataGridViewTextBoxColumn.HeaderText = "codigo_modulo"
        Me.CodigomoduloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigomoduloDataGridViewTextBoxColumn.Name = "CodigomoduloDataGridViewTextBoxColumn"
        Me.CodigomoduloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigomoduloDataGridViewTextBoxColumn.Width = 133
        '
        'NombremoduloDataGridViewTextBoxColumn
        '
        Me.NombremoduloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombremoduloDataGridViewTextBoxColumn.DataPropertyName = "nombre_modulo"
        Me.NombremoduloDataGridViewTextBoxColumn.HeaderText = "nombre_modulo"
        Me.NombremoduloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombremoduloDataGridViewTextBoxColumn.Name = "NombremoduloDataGridViewTextBoxColumn"
        Me.NombremoduloDataGridViewTextBoxColumn.Width = 139
        '
        'ModulosBindingSource1
        '
        Me.ModulosBindingSource1.DataMember = "modulos"
        Me.ModulosBindingSource1.DataSource = Me.PuntoNETDataSet2
        '
        'PuntoNETDataSet2
        '
        Me.PuntoNETDataSet2.DataSetName = "PuntoNETDataSet2"
        Me.PuntoNETDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.modulosTableAdapter = Me.ModulosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PromedioAlumno.PuntoNETDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.PuntoNETDataSet1
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'AlumnosTableAdapter1
        '
        Me.AlumnosTableAdapter1.ClearBeforeFill = True
        '
        'PuntoNETDataSet11
        '
        Me.PuntoNETDataSet11.DataSetName = "PuntoNETDataSet1"
        Me.PuntoNETDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModulosTableAdapter1
        '
        Me.ModulosTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnInsert)
        Me.GroupBox1.Controls.Add(LblCodigoModulo)
        Me.GroupBox1.Controls.Add(Me.TxtCodigoModulo)
        Me.GroupBox1.Controls.Add(LblNombreModulo)
        Me.GroupBox1.Controls.Add(Me.TxtNombreModulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 317)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresa Datos"
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(96, 269)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(105, 33)
        Me.BtnModificar.TabIndex = 16
        Me.BtnModificar.Text = "M&odificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(259, 269)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(105, 33)
        Me.BtnBuscar.TabIndex = 15
        Me.BtnBuscar.Text = "B&uscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(259, 186)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(105, 33)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "E&liminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.Location = New System.Drawing.Point(96, 186)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(105, 33)
        Me.BtnInsert.TabIndex = 13
        Me.BtnInsert.Text = "I&ngresar Registro"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'TxtCodigoModulo
        '
        Me.TxtCodigoModulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModulosBindingSource, "codigo_modulo", True))
        Me.TxtCodigoModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoModulo.Location = New System.Drawing.Point(302, 68)
        Me.TxtCodigoModulo.Name = "TxtCodigoModulo"
        Me.TxtCodigoModulo.Size = New System.Drawing.Size(222, 30)
        Me.TxtCodigoModulo.TabIndex = 10
        '
        'TxtNombreModulo
        '
        Me.TxtNombreModulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModulosBindingSource, "nombre_modulo", True))
        Me.TxtNombreModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreModulo.Location = New System.Drawing.Point(302, 113)
        Me.TxtNombreModulo.Name = "TxtNombreModulo"
        Me.TxtNombreModulo.Size = New System.Drawing.Size(222, 30)
        Me.TxtNombreModulo.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PromedioAlumnoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PromedioAlumnoToolStripMenuItem
        '
        Me.PromedioAlumnoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PromedioAlumnoToolStripMenuItem.Name = "PromedioAlumnoToolStripMenuItem"
        Me.PromedioAlumnoToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.PromedioAlumnoToolStripMenuItem.Text = "Promedio Alumno"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnModificar, Me.ToolStripBtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(629, 27)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnGuardar
        '
        Me.ToolStripBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnGuardar.Image = Global.PromedioAlumno.My.Resources.Resources.salvar
        Me.ToolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnGuardar.Name = "ToolStripBtnGuardar"
        Me.ToolStripBtnGuardar.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnGuardar.Text = "Guardar Registro"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnBuscar.Image = Global.PromedioAlumno.My.Resources.Resources.buscar
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnBuscar.Text = "Buscar Registro"
        '
        'ToolStripBtnModificar
        '
        Me.ToolStripBtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnModificar.Image = Global.PromedioAlumno.My.Resources.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782
        Me.ToolStripBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnModificar.Name = "ToolStripBtnModificar"
        Me.ToolStripBtnModificar.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnModificar.Text = "Modificar registro"
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnEliminar.Image = Global.PromedioAlumno.My.Resources.Resources.compartimiento
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripBtnEliminar.Text = "Eliminar Registro"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(510, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(87, 34)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Modulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 617)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ModulosDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Modulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo"
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoNETDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoNETDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoNETDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PuntoNETDataSet1 As PuntoNETDataSet1
    Friend WithEvents ModulosBindingSource As BindingSource
    Friend WithEvents ModulosTableAdapter As PuntoNETDataSet1TableAdapters.modulosTableAdapter
    Friend WithEvents TableAdapterManager As PuntoNETDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As PuntoNETDataSet1TableAdapters.alumnosTableAdapter
    Friend WithEvents ModulosDataGridView As DataGridView
    Friend WithEvents AlumnosTableAdapter1 As PuntoNETDataSet1TableAdapters.alumnosTableAdapter
    Friend WithEvents PuntoNETDataSet11 As PuntoNETDataSet1
    Friend WithEvents PuntoNETDataSet2 As PuntoNETDataSet2
    Friend WithEvents ModulosBindingSource1 As BindingSource
    Friend WithEvents ModulosTableAdapter1 As PuntoNETDataSet2TableAdapters.modulosTableAdapter
    Friend WithEvents CodigomoduloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombremoduloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents TxtCodigoModulo As TextBox
    Friend WithEvents TxtNombreModulo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PromedioAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnModificar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents BtnCerrar As Button
End Class
