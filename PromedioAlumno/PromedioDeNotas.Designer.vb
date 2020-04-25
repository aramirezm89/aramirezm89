<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PromedioDeNotas
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblNota3 = New System.Windows.Forms.Label()
        Me.TxtPromedio = New System.Windows.Forms.TextBox()
        Me.LblNota2 = New System.Windows.Forms.Label()
        Me.TxtNota3 = New System.Windows.Forms.TextBox()
        Me.TxtNota2 = New System.Windows.Forms.TextBox()
        Me.TxtNota1 = New System.Windows.Forms.TextBox()
        Me.LblNota1 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnPromedio = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbModulo = New System.Windows.Forms.ComboBox()
        Me.ModulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntoNETDataSet = New PromedioAlumno.PuntoNETDataSet()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.ModulosTableAdapter = New PromedioAlumno.PuntoNETDataSetTableAdapters.modulosTableAdapter()
        Me.TableAdapterManager = New PromedioAlumno.PuntoNETDataSet1TableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenedorMosulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlumnosTableAdapter1 = New PromedioAlumno.PuntoNETDataSet1TableAdapters.alumnosTableAdapter()
        Me.PuntoNETDataSet2 = New PromedioAlumno.PuntoNETDataSet2()
        Me.PuntoNETDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosTableAdapter1 = New PromedioAlumno.PuntoNETDataSet2TableAdapters.modulosTableAdapter()
        Me.ModulosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoNETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PuntoNETDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoNETDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(662, 29)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(87, 34)
        Me.BtnCerrar.TabIndex = 13
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblNota3)
        Me.GroupBox1.Controls.Add(Me.TxtPromedio)
        Me.GroupBox1.Controls.Add(Me.LblNota2)
        Me.GroupBox1.Controls.Add(Me.TxtNota3)
        Me.GroupBox1.Controls.Add(Me.TxtNota2)
        Me.GroupBox1.Controls.Add(Me.TxtNota1)
        Me.GroupBox1.Controls.Add(Me.LblNota1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnPromedio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 266)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notas"
        '
        'LblNota3
        '
        Me.LblNota3.AutoSize = True
        Me.LblNota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNota3.Location = New System.Drawing.Point(62, 207)
        Me.LblNota3.Name = "LblNota3"
        Me.LblNota3.Size = New System.Drawing.Size(64, 25)
        Me.LblNota3.TabIndex = 21
        Me.LblNota3.Text = "Nota3"
        '
        'TxtPromedio
        '
        Me.TxtPromedio.Enabled = False
        Me.TxtPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPromedio.Location = New System.Drawing.Point(533, 34)
        Me.TxtPromedio.Multiline = True
        Me.TxtPromedio.Name = "TxtPromedio"
        Me.TxtPromedio.Size = New System.Drawing.Size(100, 48)
        Me.TxtPromedio.TabIndex = 20
        '
        'LblNota2
        '
        Me.LblNota2.AutoSize = True
        Me.LblNota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNota2.Location = New System.Drawing.Point(62, 136)
        Me.LblNota2.Name = "LblNota2"
        Me.LblNota2.Size = New System.Drawing.Size(64, 25)
        Me.LblNota2.TabIndex = 19
        Me.LblNota2.Text = "Nota2"
        '
        'TxtNota3
        '
        Me.TxtNota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota3.Location = New System.Drawing.Point(163, 205)
        Me.TxtNota3.MaxLength = 3
        Me.TxtNota3.Name = "TxtNota3"
        Me.TxtNota3.Size = New System.Drawing.Size(66, 27)
        Me.TxtNota3.TabIndex = 18
        '
        'TxtNota2
        '
        Me.TxtNota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota2.Location = New System.Drawing.Point(166, 136)
        Me.TxtNota2.MaxLength = 3
        Me.TxtNota2.Name = "TxtNota2"
        Me.TxtNota2.Size = New System.Drawing.Size(61, 27)
        Me.TxtNota2.TabIndex = 17
        '
        'TxtNota1
        '
        Me.TxtNota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota1.Location = New System.Drawing.Point(166, 53)
        Me.TxtNota1.MaxLength = 3
        Me.TxtNota1.Name = "TxtNota1"
        Me.TxtNota1.Size = New System.Drawing.Size(63, 27)
        Me.TxtNota1.TabIndex = 16
        '
        'LblNota1
        '
        Me.LblNota1.AutoSize = True
        Me.LblNota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNota1.Location = New System.Drawing.Point(62, 53)
        Me.LblNota1.Name = "LblNota1"
        Me.LblNota1.Size = New System.Drawing.Size(64, 25)
        Me.LblNota1.TabIndex = 15
        Me.LblNota1.Text = "Nota1"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(388, 158)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(124, 33)
        Me.BtnLimpiar.TabIndex = 14
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnPromedio
        '
        Me.BtnPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPromedio.Location = New System.Drawing.Point(388, 41)
        Me.BtnPromedio.Name = "BtnPromedio"
        Me.BtnPromedio.Size = New System.Drawing.Size(124, 37)
        Me.BtnPromedio.TabIndex = 13
        Me.BtnPromedio.Text = "Promedio"
        Me.BtnPromedio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbModulo)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.LblNombre)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(54, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 179)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Alumno"
        '
        'CmbModulo
        '
        Me.CmbModulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbModulo.DataSource = Me.ModulosBindingSource3
        Me.CmbModulo.FormattingEnabled = True
        Me.CmbModulo.Location = New System.Drawing.Point(159, 136)
        Me.CmbModulo.MaxLength = 35
        Me.CmbModulo.Name = "CmbModulo"
        Me.CmbModulo.Size = New System.Drawing.Size(530, 33)
        Me.CmbModulo.TabIndex = 7
        Me.CmbModulo.ValueMember = "nombre_modulo"
        '
        'ModulosBindingSource
        '
        Me.ModulosBindingSource.DataMember = "modulos"
        Me.ModulosBindingSource.DataSource = Me.PuntoNETDataSet
        '
        'PuntoNETDataSet
        '
        Me.PuntoNETDataSet.DataSetName = "PuntoNETDataSet"
        Me.PuntoNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(163, 88)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(320, 30)
        Me.TxtTelefono.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Modulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Telefono"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(161, 35)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(479, 30)
        Me.TxtNombre.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(41, 35)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 25)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'ModulosTableAdapter
        '
        Me.ModulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PromedioAlumno.PuntoNETDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenedorMosulosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 26)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenedorMosulosToolStripMenuItem
        '
        Me.MantenedorMosulosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MantenedorMosulosToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MantenedorMosulosToolStripMenuItem.Name = "MantenedorMosulosToolStripMenuItem"
        Me.MantenedorMosulosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.MantenedorMosulosToolStripMenuItem.Text = "Mantenedor Modulo"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'AlumnosTableAdapter1
        '
        Me.AlumnosTableAdapter1.ClearBeforeFill = True
        '
        'PuntoNETDataSet2
        '
        Me.PuntoNETDataSet2.DataSetName = "PuntoNETDataSet2"
        Me.PuntoNETDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuntoNETDataSet2BindingSource
        '
        Me.PuntoNETDataSet2BindingSource.DataSource = Me.PuntoNETDataSet2
        Me.PuntoNETDataSet2BindingSource.Position = 0
        '
        'ModulosBindingSource1
        '
        Me.ModulosBindingSource1.DataMember = "modulos"
        Me.ModulosBindingSource1.DataSource = Me.PuntoNETDataSet2BindingSource
        '
        'ModulosTableAdapter1
        '
        Me.ModulosTableAdapter1.ClearBeforeFill = True
        '
        'ModulosBindingSource2
        '
        Me.ModulosBindingSource2.DataMember = "modulos"
        Me.ModulosBindingSource2.DataSource = Me.PuntoNETDataSet2BindingSource
        '
        'ModulosBindingSource3
        '
        Me.ModulosBindingSource3.DataMember = "modulos"
        Me.ModulosBindingSource3.DataSource = Me.PuntoNETDataSet2BindingSource
        '
        'PromedioDeNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(816, 580)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PromedioDeNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promedio Alumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ModulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoNETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PuntoNETDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoNETDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblNota3 As Label
    Friend WithEvents TxtPromedio As TextBox
    Friend WithEvents LblNota2 As Label
    Friend WithEvents TxtNota3 As TextBox
    Friend WithEvents TxtNota2 As TextBox
    Friend WithEvents TxtNota1 As TextBox
    Friend WithEvents LblNota1 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnPromedio As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbModulo As ComboBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PuntoNETDataSet As PuntoNETDataSet
    Friend WithEvents ModulosBindingSource As BindingSource
    Friend WithEvents ModulosTableAdapter As PuntoNETDataSetTableAdapters.modulosTableAdapter
    Friend WithEvents TableAdapterManager As PuntoNETDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenedorMosulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AlumnosTableAdapter1 As PuntoNETDataSet1TableAdapters.alumnosTableAdapter
    Friend WithEvents PuntoNETDataSet2BindingSource As BindingSource
    Friend WithEvents PuntoNETDataSet2 As PuntoNETDataSet2
    Friend WithEvents ModulosBindingSource1 As BindingSource
    Friend WithEvents ModulosTableAdapter1 As PuntoNETDataSet2TableAdapters.modulosTableAdapter
    Friend WithEvents ModulosBindingSource2 As BindingSource
    Friend WithEvents ModulosBindingSource3 As BindingSource
End Class
