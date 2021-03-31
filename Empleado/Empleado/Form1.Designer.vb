<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnif = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.cmdinsertar = New System.Windows.Forms.Button()
        Me.cmdactualizar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.ExamenDataSet = New Empleado.examenDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New Empleado.examenDataSetTableAdapters.empleadoTableAdapter()
        Me.ExamenDataSet1 = New Empleado.examenDataSet1()
        Me.EmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter1 = New Empleado.examenDataSet1TableAdapters.empleadoTableAdapter()
        Me.dgvista = New System.Windows.Forms.DataGridView()
        Me.nif_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamenDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamenDataSet2 = New Empleado.examenDataSet2()
        Me.Practica01DataSet = New Empleado.practica01DataSet()
        Me.Practica01DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Practica001DataSet = New Empleado.practica001DataSet()
        Me.Practica001DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Practica01DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Practica01DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Practica001DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Practica001DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nif:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ciudad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad:"
        '
        'txtnif
        '
        Me.txtnif.Location = New System.Drawing.Point(125, 27)
        Me.txtnif.Name = "txtnif"
        Me.txtnif.Size = New System.Drawing.Size(100, 20)
        Me.txtnif.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(125, 60)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 6
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(125, 95)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 7
        '
        'txtciudad
        '
        Me.txtciudad.Location = New System.Drawing.Point(125, 131)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(100, 20)
        Me.txtciudad.TabIndex = 8
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(125, 166)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 20)
        Me.txtedad.TabIndex = 9
        '
        'cmdinsertar
        '
        Me.cmdinsertar.Location = New System.Drawing.Point(43, 238)
        Me.cmdinsertar.Name = "cmdinsertar"
        Me.cmdinsertar.Size = New System.Drawing.Size(75, 23)
        Me.cmdinsertar.TabIndex = 10
        Me.cmdinsertar.Text = "Insertar"
        Me.cmdinsertar.UseVisualStyleBackColor = True
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Location = New System.Drawing.Point(138, 238)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(75, 23)
        Me.cmdactualizar.TabIndex = 11
        Me.cmdactualizar.Text = "Actualizar"
        Me.cmdactualizar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(236, 238)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdeliminar.TabIndex = 12
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Location = New System.Drawing.Point(333, 238)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 13
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(430, 238)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 14
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'ExamenDataSet
        '
        Me.ExamenDataSet.DataSetName = "examenDataSet"
        Me.ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.ExamenDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'ExamenDataSet1
        '
        Me.ExamenDataSet1.DataSetName = "examenDataSet1"
        Me.ExamenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource1
        '
        Me.EmpleadoBindingSource1.DataMember = "empleado"
        Me.EmpleadoBindingSource1.DataSource = Me.ExamenDataSet1
        '
        'EmpleadoTableAdapter1
        '
        Me.EmpleadoTableAdapter1.ClearBeforeFill = True
        '
        'dgvista
        '
        Me.dgvista.AllowUserToAddRows = False
        Me.dgvista.AllowUserToDeleteRows = False
        Me.dgvista.AutoGenerateColumns = False
        Me.dgvista.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nif_empleado, Me.nombre, Me.direccion, Me.ciudad, Me.edad})
        Me.dgvista.DataSource = Me.Practica001DataSetBindingSource
        Me.dgvista.Location = New System.Drawing.Point(12, 270)
        Me.dgvista.Name = "dgvista"
        Me.dgvista.ReadOnly = True
        Me.dgvista.Size = New System.Drawing.Size(547, 160)
        Me.dgvista.TabIndex = 15
        '
        'nif_empleado
        '
        Me.nif_empleado.DataPropertyName = "nif_empleado"
        Me.nif_empleado.HeaderText = "Nif"
        Me.nif_empleado.Name = "nif_empleado"
        Me.nif_empleado.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'ciudad
        '
        Me.ciudad.DataPropertyName = "ciudad"
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.ReadOnly = True
        '
        'edad
        '
        Me.edad.DataPropertyName = "edad"
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        '
        'ExamenDataSet2BindingSource
        '
        Me.ExamenDataSet2BindingSource.DataSource = Me.ExamenDataSet2
        Me.ExamenDataSet2BindingSource.Position = 0
        '
        'ExamenDataSet2
        '
        Me.ExamenDataSet2.DataSetName = "examenDataSet2"
        Me.ExamenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Practica01DataSet
        '
        Me.Practica01DataSet.DataSetName = "practica01DataSet"
        Me.Practica01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Practica01DataSetBindingSource
        '
        Me.Practica01DataSetBindingSource.DataSource = Me.Practica01DataSet
        Me.Practica01DataSetBindingSource.Position = 0
        '
        'Practica001DataSet
        '
        Me.Practica001DataSet.DataSetName = "practica001DataSet"
        Me.Practica001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Practica001DataSetBindingSource
        '
        Me.Practica001DataSetBindingSource.DataSource = Me.Practica001DataSet
        Me.Practica001DataSetBindingSource.Position = 0
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.dgvista)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdactualizar)
        Me.Controls.Add(Me.cmdinsertar)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtnif)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Practica01DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Practica01DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Practica001DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Practica001DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnif As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents cmdinsertar As Button
    Friend WithEvents cmdactualizar As Button
    Friend WithEvents cmdeliminar As Button
    Friend WithEvents cmdlimpiar As Button
    Friend WithEvents cmdsalir As Button
    Friend WithEvents ExamenDataSet As examenDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As examenDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents ExamenDataSet1 As examenDataSet1
    Friend WithEvents EmpleadoBindingSource1 As BindingSource
    Friend WithEvents EmpleadoTableAdapter1 As examenDataSet1TableAdapters.empleadoTableAdapter
    Friend WithEvents dgvista As DataGridView
    Friend WithEvents nif_empleado As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents ExamenDataSet2BindingSource As BindingSource
    Friend WithEvents ExamenDataSet2 As examenDataSet2
    Friend WithEvents Practica01DataSetBindingSource As BindingSource
    Friend WithEvents Practica01DataSet As practica01DataSet
    Friend WithEvents Practica001DataSetBindingSource As BindingSource
    Friend WithEvents Practica001DataSet As practica001DataSet
End Class
