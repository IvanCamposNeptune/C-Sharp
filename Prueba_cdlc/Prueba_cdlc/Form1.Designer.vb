<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Id_administradorLabel As System.Windows.Forms.Label
        Dim Nombre_clienteLabel As System.Windows.Forms.Label
        Dim Correo_clienteLabel As System.Windows.Forms.Label
        Dim Equipo_clienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AdministradorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AdministradorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cdlc_pruebaDataSet = New Prueba_cdlc.cdlc_pruebaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdministradorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AdministradorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_administradorTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Equipo_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdministradorTableAdapter = New Prueba_cdlc.cdlc_pruebaDataSetTableAdapters.administradorTableAdapter()
        Me.TableAdapterManager = New Prueba_cdlc.cdlc_pruebaDataSetTableAdapters.TableAdapterManager()
        Id_administradorLabel = New System.Windows.Forms.Label()
        Nombre_clienteLabel = New System.Windows.Forms.Label()
        Correo_clienteLabel = New System.Windows.Forms.Label()
        Equipo_clienteLabel = New System.Windows.Forms.Label()
        CType(Me.AdministradorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdministradorBindingNavigator.SuspendLayout()
        CType(Me.AdministradorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cdlc_pruebaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministradorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_administradorLabel
        '
        Id_administradorLabel.AutoSize = True
        Id_administradorLabel.Location = New System.Drawing.Point(12, 79)
        Id_administradorLabel.Name = "Id_administradorLabel"
        Id_administradorLabel.Size = New System.Drawing.Size(83, 13)
        Id_administradorLabel.TabIndex = 2
        Id_administradorLabel.Text = "id administrador:"
        '
        'Nombre_clienteLabel
        '
        Nombre_clienteLabel.AutoSize = True
        Nombre_clienteLabel.Location = New System.Drawing.Point(12, 105)
        Nombre_clienteLabel.Name = "Nombre_clienteLabel"
        Nombre_clienteLabel.Size = New System.Drawing.Size(79, 13)
        Nombre_clienteLabel.TabIndex = 4
        Nombre_clienteLabel.Text = "nombre cliente:"
        '
        'Correo_clienteLabel
        '
        Correo_clienteLabel.AutoSize = True
        Correo_clienteLabel.Location = New System.Drawing.Point(12, 131)
        Correo_clienteLabel.Name = "Correo_clienteLabel"
        Correo_clienteLabel.Size = New System.Drawing.Size(74, 13)
        Correo_clienteLabel.TabIndex = 6
        Correo_clienteLabel.Text = "correo cliente:"
        '
        'Equipo_clienteLabel
        '
        Equipo_clienteLabel.AutoSize = True
        Equipo_clienteLabel.Location = New System.Drawing.Point(12, 157)
        Equipo_clienteLabel.Name = "Equipo_clienteLabel"
        Equipo_clienteLabel.Size = New System.Drawing.Size(76, 13)
        Equipo_clienteLabel.TabIndex = 8
        Equipo_clienteLabel.Text = "equipo cliente:"
        '
        'AdministradorBindingNavigator
        '
        Me.AdministradorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdministradorBindingNavigator.BindingSource = Me.AdministradorBindingSource
        Me.AdministradorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdministradorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdministradorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdministradorBindingNavigatorSaveItem})
        Me.AdministradorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdministradorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdministradorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdministradorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdministradorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdministradorBindingNavigator.Name = "AdministradorBindingNavigator"
        Me.AdministradorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdministradorBindingNavigator.Size = New System.Drawing.Size(859, 25)
        Me.AdministradorBindingNavigator.TabIndex = 0
        Me.AdministradorBindingNavigator.Text = "BindingNavigator1"
        Me.AdministradorBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'AdministradorBindingSource
        '
        Me.AdministradorBindingSource.DataMember = "administrador"
        Me.AdministradorBindingSource.DataSource = Me.Cdlc_pruebaDataSet
        '
        'Cdlc_pruebaDataSet
        '
        Me.Cdlc_pruebaDataSet.DataSetName = "cdlc_pruebaDataSet"
        Me.Cdlc_pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AdministradorBindingNavigatorSaveItem
        '
        Me.AdministradorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdministradorBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdministradorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdministradorBindingNavigatorSaveItem.Name = "AdministradorBindingNavigatorSaveItem"
        Me.AdministradorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdministradorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'AdministradorDataGridView
        '
        Me.AdministradorDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdministradorDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AdministradorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdministradorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AdministradorDataGridView.DataSource = Me.AdministradorBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdministradorDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.AdministradorDataGridView.Location = New System.Drawing.Point(394, 42)
        Me.AdministradorDataGridView.Name = "AdministradorDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdministradorDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AdministradorDataGridView.Size = New System.Drawing.Size(445, 207)
        Me.AdministradorDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_administrador"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_administrador"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "correo_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "correo_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "equipo_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "equipo_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Id_administradorTextBox
        '
        Me.Id_administradorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradorBindingSource, "id_administrador", True))
        Me.Id_administradorTextBox.Location = New System.Drawing.Point(101, 76)
        Me.Id_administradorTextBox.Name = "Id_administradorTextBox"
        Me.Id_administradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_administradorTextBox.TabIndex = 3
        '
        'Nombre_clienteTextBox
        '
        Me.Nombre_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradorBindingSource, "nombre_cliente", True))
        Me.Nombre_clienteTextBox.Location = New System.Drawing.Point(101, 102)
        Me.Nombre_clienteTextBox.Name = "Nombre_clienteTextBox"
        Me.Nombre_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_clienteTextBox.TabIndex = 5
        '
        'Correo_clienteTextBox
        '
        Me.Correo_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradorBindingSource, "correo_cliente", True))
        Me.Correo_clienteTextBox.Location = New System.Drawing.Point(101, 128)
        Me.Correo_clienteTextBox.Name = "Correo_clienteTextBox"
        Me.Correo_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_clienteTextBox.TabIndex = 7
        '
        'Equipo_clienteTextBox
        '
        Me.Equipo_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradorBindingSource, "equipo_cliente", True))
        Me.Equipo_clienteTextBox.Location = New System.Drawing.Point(101, 154)
        Me.Equipo_clienteTextBox.Name = "Equipo_clienteTextBox"
        Me.Equipo_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Equipo_clienteTextBox.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(25, 206)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(25, 247)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(126, 247)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(126, 206)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(274, 226)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 14
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "INGRESAR"
        '
        'AdministradorTableAdapter
        '
        Me.AdministradorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administradorTableAdapter = Me.AdministradorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Prueba_cdlc.cdlc_pruebaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 381)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Id_administradorLabel)
        Me.Controls.Add(Me.Id_administradorTextBox)
        Me.Controls.Add(Nombre_clienteLabel)
        Me.Controls.Add(Me.Nombre_clienteTextBox)
        Me.Controls.Add(Correo_clienteLabel)
        Me.Controls.Add(Me.Correo_clienteTextBox)
        Me.Controls.Add(Equipo_clienteLabel)
        Me.Controls.Add(Me.Equipo_clienteTextBox)
        Me.Controls.Add(Me.AdministradorDataGridView)
        Me.Controls.Add(Me.AdministradorBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Prueba_CDLC"
        CType(Me.AdministradorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdministradorBindingNavigator.ResumeLayout(False)
        Me.AdministradorBindingNavigator.PerformLayout()
        CType(Me.AdministradorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cdlc_pruebaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministradorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cdlc_pruebaDataSet As cdlc_pruebaDataSet
    Friend WithEvents AdministradorBindingSource As BindingSource
    Friend WithEvents AdministradorTableAdapter As cdlc_pruebaDataSetTableAdapters.administradorTableAdapter
    Friend WithEvents TableAdapterManager As cdlc_pruebaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdministradorBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AdministradorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AdministradorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_administradorTextBox As TextBox
    Friend WithEvents Nombre_clienteTextBox As TextBox
    Friend WithEvents Correo_clienteTextBox As TextBox
    Friend WithEvents Equipo_clienteTextBox As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Label1 As Label
End Class
