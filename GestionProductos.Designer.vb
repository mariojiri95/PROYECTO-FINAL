<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PRODUCTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTODataSet = New PROYECTO_FINAL.PROYECTODataSet()
        Me.pageAnadir = New System.Windows.Forms.TabPage()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkFavorito = New System.Windows.Forms.CheckBox()
        Me.comboSubcategoria = New System.Windows.Forms.ComboBox()
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.txtPrecioCoste = New System.Windows.Forms.TextBox()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtImpuesto2 = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtMargen = New System.Windows.Forms.TextBox()
        Me.txtBeneficio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreMostrar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PRODUCTO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTO1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOTableAdapter = New PROYECTO_FINAL.PROYECTODataSetTableAdapters.PRODUCTOTableAdapter()
        Me.TableAdapterManager = New PROYECTO_FINAL.PROYECTODataSetTableAdapters.TableAdapterManager()
        Me.txtImpuesto2Mod = New System.Windows.Forms.TextBox()
        Me.txtImpuestoMod = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageAnadir.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PRODUCTO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTO1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 668)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SALIR"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.pageAnadir)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1573, 616)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PRODUCTODataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1565, 590)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCADOR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PRODUCTODataGridView
        '
        Me.PRODUCTODataGridView.AutoGenerateColumns = False
        Me.PRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PRODUCTODataGridView.DataSource = Me.PRODUCTOBindingSource
        Me.PRODUCTODataGridView.Location = New System.Drawing.Point(6, 6)
        Me.PRODUCTODataGridView.Name = "PRODUCTODataGridView"
        Me.PRODUCTODataGridView.Size = New System.Drawing.Size(1376, 578)
        Me.PRODUCTODataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_PRODUCTO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_PRODUCTO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NOMBRE_A_MOSTRAR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NOMBRE_A_MOSTRAR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UNIDAD_DE_MEDIDA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UNIDAD_DE_MEDIDA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SUBTIPO"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SUBTIPO"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PRECIO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRECIO_COSTE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PRECIO_COSTE"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MARGEN"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MARGEN"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "BENEFICIO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "BENEFICIO"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IMPUESTO"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IMPUESTO"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IMPUESTO2"
        Me.DataGridViewTextBoxColumn17.HeaderText = "IMPUESTO2"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "EXISTENCIAS"
        Me.DataGridViewTextBoxColumn18.HeaderText = "EXISTENCIAS"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FAVORITO"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FAVORITO"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PRECIO_FINAL"
        Me.DataGridViewTextBoxColumn21.HeaderText = "PRECIO_FINAL"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "IMAGEN"
        Me.DataGridViewTextBoxColumn22.HeaderText = "IMAGEN"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'PRODUCTOBindingSource
        '
        Me.PRODUCTOBindingSource.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource.DataSource = Me.PROYECTODataSet
        '
        'PROYECTODataSet
        '
        Me.PROYECTODataSet.DataSetName = "PROYECTODataSet"
        Me.PROYECTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pageAnadir
        '
        Me.pageAnadir.Controls.Add(Me.txtPrecioFinal)
        Me.pageAnadir.Controls.Add(Me.Label16)
        Me.pageAnadir.Controls.Add(Me.chkFavorito)
        Me.pageAnadir.Controls.Add(Me.comboSubcategoria)
        Me.pageAnadir.Controls.Add(Me.comboCategoria)
        Me.pageAnadir.Controls.Add(Me.btnLimpiar)
        Me.pageAnadir.Controls.Add(Me.btnAnadir)
        Me.pageAnadir.Controls.Add(Me.txtPrecioCoste)
        Me.pageAnadir.Controls.Add(Me.txtImagen)
        Me.pageAnadir.Controls.Add(Me.Label15)
        Me.pageAnadir.Controls.Add(Me.Label14)
        Me.pageAnadir.Controls.Add(Me.txtExistencias)
        Me.pageAnadir.Controls.Add(Me.Label13)
        Me.pageAnadir.Controls.Add(Me.txtImpuesto2)
        Me.pageAnadir.Controls.Add(Me.txtImpuesto)
        Me.pageAnadir.Controls.Add(Me.txtMargen)
        Me.pageAnadir.Controls.Add(Me.txtBeneficio)
        Me.pageAnadir.Controls.Add(Me.Label12)
        Me.pageAnadir.Controls.Add(Me.Label11)
        Me.pageAnadir.Controls.Add(Me.Label10)
        Me.pageAnadir.Controls.Add(Me.Label9)
        Me.pageAnadir.Controls.Add(Me.Label8)
        Me.pageAnadir.Controls.Add(Me.Label7)
        Me.pageAnadir.Controls.Add(Me.Label6)
        Me.pageAnadir.Controls.Add(Me.Label5)
        Me.pageAnadir.Controls.Add(Me.txtUnidad)
        Me.pageAnadir.Controls.Add(Me.Label2)
        Me.pageAnadir.Controls.Add(Me.txtNombreMostrar)
        Me.pageAnadir.Controls.Add(Me.Label3)
        Me.pageAnadir.Controls.Add(Me.Label4)
        Me.pageAnadir.Controls.Add(Me.txtPrecio)
        Me.pageAnadir.Controls.Add(Me.txtNombre)
        Me.pageAnadir.Location = New System.Drawing.Point(4, 22)
        Me.pageAnadir.Name = "pageAnadir"
        Me.pageAnadir.Padding = New System.Windows.Forms.Padding(3)
        Me.pageAnadir.Size = New System.Drawing.Size(1565, 590)
        Me.pageAnadir.TabIndex = 2
        Me.pageAnadir.Text = "AÑADIR"
        Me.pageAnadir.UseVisualStyleBackColor = True
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(240, 497)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioFinal.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(45, 497)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 20)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Precio final:"
        '
        'chkFavorito
        '
        Me.chkFavorito.AutoSize = True
        Me.chkFavorito.Location = New System.Drawing.Point(715, 373)
        Me.chkFavorito.Name = "chkFavorito"
        Me.chkFavorito.Size = New System.Drawing.Size(15, 14)
        Me.chkFavorito.TabIndex = 38
        Me.chkFavorito.UseVisualStyleBackColor = True
        '
        'comboSubcategoria
        '
        Me.comboSubcategoria.FormattingEnabled = True
        Me.comboSubcategoria.Location = New System.Drawing.Point(240, 305)
        Me.comboSubcategoria.Name = "comboSubcategoria"
        Me.comboSubcategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboSubcategoria.TabIndex = 37
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Items.AddRange(New Object() {"REFRESCOS", "ALCOHOL", "COPAS", "CAFÉS", "TAPAS", "PLATOS", "POSTRES"})
        Me.comboCategoria.Location = New System.Drawing.Point(240, 240)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboCategoria.TabIndex = 36
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(943, 472)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(110, 45)
        Me.btnLimpiar.TabIndex = 35
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Location = New System.Drawing.Point(943, 346)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(110, 110)
        Me.btnAnadir.TabIndex = 34
        Me.btnAnadir.Text = "AÑADIR"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'txtPrecioCoste
        '
        Me.txtPrecioCoste.Location = New System.Drawing.Point(240, 435)
        Me.txtPrecioCoste.Name = "txtPrecioCoste"
        Me.txtPrecioCoste.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioCoste.TabIndex = 33
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(715, 435)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(100, 20)
        Me.txtImagen.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(520, 435)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Imagen:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(520, 370)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Favorito:"
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(715, 305)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.ReadOnly = True
        Me.txtExistencias.Size = New System.Drawing.Size(100, 20)
        Me.txtExistencias.TabIndex = 28
        Me.txtExistencias.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(520, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Existencias:"
        '
        'txtImpuesto2
        '
        Me.txtImpuesto2.Location = New System.Drawing.Point(715, 240)
        Me.txtImpuesto2.Name = "txtImpuesto2"
        Me.txtImpuesto2.ReadOnly = True
        Me.txtImpuesto2.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto2.TabIndex = 26
        Me.txtImpuesto2.Text = "0"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(715, 175)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 25
        Me.txtImpuesto.Text = "0"
        '
        'txtMargen
        '
        Me.txtMargen.Location = New System.Drawing.Point(715, 110)
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.ReadOnly = True
        Me.txtMargen.Size = New System.Drawing.Size(100, 20)
        Me.txtMargen.TabIndex = 24
        Me.txtMargen.Text = "0"
        Me.txtMargen.WordWrap = False
        '
        'txtBeneficio
        '
        Me.txtBeneficio.Location = New System.Drawing.Point(715, 45)
        Me.txtBeneficio.Name = "txtBeneficio"
        Me.txtBeneficio.ReadOnly = True
        Me.txtBeneficio.Size = New System.Drawing.Size(100, 20)
        Me.txtBeneficio.TabIndex = 23
        Me.txtBeneficio.Text = "0"
        Me.txtBeneficio.WordWrap = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(520, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Impuesto 2:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(520, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Impuesto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(520, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Beneficio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Margen de beneficio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio de coste:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Subcategoría:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Unidad de medida:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(240, 175)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre a mostrar:"
        '
        'txtNombreMostrar
        '
        Me.txtNombreMostrar.Location = New System.Drawing.Point(240, 110)
        Me.txtNombreMostrar.Name = "txtNombreMostrar"
        Me.txtNombreMostrar.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreMostrar.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Categoría:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(240, 370)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(240, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.txtImpuesto2Mod)
        Me.TabPage3.Controls.Add(Me.txtImpuestoMod)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1565, 590)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "ACCIONES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.BackgroundImage = Global.PROYECTO_FINAL.My.Resources.Resources.reload_webpage_icon_icons_com_53905
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(16, 660)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 55)
        Me.Button3.TabIndex = 4
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PRODUCTO1BindingSource
        '
        Me.PRODUCTO1BindingSource.DataSource = Me.PROYECTODataSet
        Me.PRODUCTO1BindingSource.Position = 0
        '
        'PRODUCTO1BindingSource1
        '
        Me.PRODUCTO1BindingSource1.DataSource = Me.PROYECTODataSet
        Me.PRODUCTO1BindingSource1.Position = 0
        '
        'PRODUCTOTableAdapter
        '
        Me.PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PEDIDOTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOTableAdapter = Me.PRODUCTOTableAdapter
        Me.TableAdapterManager.TIENE_PROD_PEDTableAdapter = Nothing
        Me.TableAdapterManager.TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROYECTO_FINAL.PROYECTODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtImpuesto2Mod
        '
        Me.txtImpuesto2Mod.Location = New System.Drawing.Point(276, 124)
        Me.txtImpuesto2Mod.Name = "txtImpuesto2Mod"
        Me.txtImpuesto2Mod.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto2Mod.TabIndex = 30
        '
        'txtImpuestoMod
        '
        Me.txtImpuestoMod.Location = New System.Drawing.Point(276, 78)
        Me.txtImpuestoMod.Name = "txtImpuestoMod"
        Me.txtImpuestoMod.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuestoMod.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(41, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 20)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Impuesto 2:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(41, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Impuesto:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(427, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 66)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "GestionProductos"
        Me.Text = "GESTION PRODUCTOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PRODUCTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageAnadir.ResumeLayout(False)
        Me.pageAnadir.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PRODUCTO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTO1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pageAnadir As TabPage
    Friend WithEvents PROYECTODataSet As PROYECTODataSet
    Friend WithEvents PRODUCTOBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreMostrar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecioCoste As TextBox
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtImpuesto2 As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtMargen As TextBox
    Friend WithEvents txtBeneficio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents comboSubcategoria As ComboBox
    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents chkFavorito As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTO1BindingSource As BindingSource
    Friend WithEvents PRODUCTO1BindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTOTableAdapter As PROYECTODataSetTableAdapters.PRODUCTOTableAdapter
    Friend WithEvents TableAdapterManager As PROYECTODataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtPrecioFinal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PRODUCTODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtImpuesto2Mod As TextBox
    Friend WithEvents txtImpuestoMod As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button2 As Button
End Class
