namespace Vista.Movimiento
{
    partial class UCSancionar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSancionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label id_choferLabel;
            System.Windows.Forms.Label id_papeletaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label moraLabel;
            System.Windows.Forms.Label fechaLabel;
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dBTransporte = new Vista.DBTransporte();
            this.sancionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sancionesTableAdapter = new Vista.DBTransporteTableAdapters.SancionesTableAdapter();
            this.tableAdapterManager = new Vista.DBTransporteTableAdapters.TableAdapterManager();
            this.sancionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sancionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sancionesDataGridView = new System.Windows.Forms.DataGridView();
            this.id_choferComboBox = new System.Windows.Forms.ComboBox();
            this.id_papeletaComboBox = new System.Windows.Forms.ComboBox();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.moraTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.choferesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choferesTableAdapter = new Vista.DBTransporteTableAdapters.ChoferesTableAdapter();
            this.papeletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papeletasTableAdapter = new Vista.DBTransporteTableAdapters.PapeletasTableAdapter();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_choferLabel = new System.Windows.Forms.Label();
            id_papeletaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            moraLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesBindingNavigator)).BeginInit();
            this.sancionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papeletasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1013, 502);
            this.panel6.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(713, 502);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.sancionesDataGridView);
            this.panel3.Controls.Add(this.sancionesBindingNavigator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(713, 378);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 74);
            this.panel1.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(584, 25);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(109, 35);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "   Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenidos a la administracion del transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sanciones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(713, 50);
            this.panel2.TabIndex = 1;
            // 
            // textBuscar
            // 
            this.textBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(20, 12);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(673, 26);
            this.textBuscar.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pagadoCheckBox);
            this.panel5.Controls.Add(fechaLabel);
            this.panel5.Controls.Add(this.fechaDateTimePicker);
            this.panel5.Controls.Add(moraLabel);
            this.panel5.Controls.Add(this.moraTextBox);
            this.panel5.Controls.Add(montoLabel);
            this.panel5.Controls.Add(this.montoTextBox);
            this.panel5.Controls.Add(id_papeletaLabel);
            this.panel5.Controls.Add(this.id_papeletaComboBox);
            this.panel5.Controls.Add(id_choferLabel);
            this.panel5.Controls.Add(this.id_choferComboBox);
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(713, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(300, 502);
            this.panel5.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnNuevo.Location = new System.Drawing.Point(27, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 30);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnEliminar.Location = new System.Drawing.Point(204, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 30);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnCancelar.Location = new System.Drawing.Point(98, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 30);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(114)))), ((int)(((byte)(220)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(189, 452);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Sancionar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dBTransporte
            // 
            this.dBTransporte.DataSetName = "DBTransporte";
            this.dBTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sancionesBindingSource
            // 
            this.sancionesBindingSource.DataMember = "Sanciones";
            this.sancionesBindingSource.DataSource = this.dBTransporte;
            // 
            // sancionesTableAdapter
            // 
            this.sancionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorizacionDetallesTableAdapter = null;
            this.tableAdapterManager.AutorizacionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = this.choferesTableAdapter;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.LicenciasTableAdapter = null;
            this.tableAdapterManager.PapeletasTableAdapter = this.papeletasTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.SancionesTableAdapter = this.sancionesTableAdapter;
            this.tableAdapterManager.Tipo_empresasTableAdapter = null;
            this.tableAdapterManager.Tipo_vehiculosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vista.DBTransporteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // sancionesBindingNavigator
            // 
            this.sancionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sancionesBindingNavigator.BindingSource = this.sancionesBindingSource;
            this.sancionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sancionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sancionesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sancionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sancionesBindingNavigatorSaveItem});
            this.sancionesBindingNavigator.Location = new System.Drawing.Point(20, 353);
            this.sancionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sancionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sancionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sancionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sancionesBindingNavigator.Name = "sancionesBindingNavigator";
            this.sancionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sancionesBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.sancionesBindingNavigator.TabIndex = 16;
            this.sancionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // sancionesBindingNavigatorSaveItem
            // 
            this.sancionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sancionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sancionesBindingNavigatorSaveItem.Image")));
            this.sancionesBindingNavigatorSaveItem.Name = "sancionesBindingNavigatorSaveItem";
            this.sancionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sancionesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.sancionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.sancionesBindingNavigatorSaveItem_Click);
            // 
            // sancionesDataGridView
            // 
            this.sancionesDataGridView.AllowUserToAddRows = false;
            this.sancionesDataGridView.AllowUserToDeleteRows = false;
            this.sancionesDataGridView.AllowUserToOrderColumns = true;
            this.sancionesDataGridView.AutoGenerateColumns = false;
            this.sancionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sancionesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sancionesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sancionesDataGridView.ColumnHeadersHeight = 33;
            this.sancionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sancionesDataGridView.DataSource = this.sancionesBindingSource;
            this.sancionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sancionesDataGridView.Location = new System.Drawing.Point(20, 0);
            this.sancionesDataGridView.Name = "sancionesDataGridView";
            this.sancionesDataGridView.ReadOnly = true;
            this.sancionesDataGridView.RowTemplate.Height = 27;
            this.sancionesDataGridView.Size = new System.Drawing.Size(673, 353);
            this.sancionesDataGridView.TabIndex = 17;
            // 
            // id_choferLabel
            // 
            id_choferLabel.AutoSize = true;
            id_choferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_choferLabel.Location = new System.Drawing.Point(24, 74);
            id_choferLabel.Name = "id_choferLabel";
            id_choferLabel.Size = new System.Drawing.Size(50, 16);
            id_choferLabel.TabIndex = 27;
            id_choferLabel.Text = "Chofer:";
            // 
            // id_choferComboBox
            // 
            this.id_choferComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sancionesBindingSource, "id_chofer", true));
            this.id_choferComboBox.DataSource = this.choferesBindingSource;
            this.id_choferComboBox.DisplayMember = "nombres";
            this.id_choferComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_choferComboBox.FormattingEnabled = true;
            this.id_choferComboBox.Location = new System.Drawing.Point(27, 90);
            this.id_choferComboBox.Name = "id_choferComboBox";
            this.id_choferComboBox.Size = new System.Drawing.Size(247, 24);
            this.id_choferComboBox.TabIndex = 28;
            this.id_choferComboBox.ValueMember = "id_chofer";
            // 
            // id_papeletaLabel
            // 
            id_papeletaLabel.AutoSize = true;
            id_papeletaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_papeletaLabel.Location = new System.Drawing.Point(27, 130);
            id_papeletaLabel.Name = "id_papeletaLabel";
            id_papeletaLabel.Size = new System.Drawing.Size(66, 16);
            id_papeletaLabel.TabIndex = 28;
            id_papeletaLabel.Text = "Papeleta:";
            // 
            // id_papeletaComboBox
            // 
            this.id_papeletaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sancionesBindingSource, "id_papeleta", true));
            this.id_papeletaComboBox.DataSource = this.papeletasBindingSource;
            this.id_papeletaComboBox.DisplayMember = "nombre";
            this.id_papeletaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_papeletaComboBox.FormattingEnabled = true;
            this.id_papeletaComboBox.Location = new System.Drawing.Point(30, 146);
            this.id_papeletaComboBox.Name = "id_papeletaComboBox";
            this.id_papeletaComboBox.Size = new System.Drawing.Size(244, 24);
            this.id_papeletaComboBox.TabIndex = 29;
            this.id_papeletaComboBox.ValueMember = "id_papeleta";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoLabel.Location = new System.Drawing.Point(27, 184);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(48, 16);
            montoLabel.TabIndex = 29;
            montoLabel.Text = "Monto:";
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sancionesBindingSource, "monto", true));
            this.montoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTextBox.Location = new System.Drawing.Point(30, 200);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(244, 22);
            this.montoTextBox.TabIndex = 30;
            // 
            // moraLabel
            // 
            moraLabel.AutoSize = true;
            moraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moraLabel.Location = new System.Drawing.Point(27, 280);
            moraLabel.Name = "moraLabel";
            moraLabel.Size = new System.Drawing.Size(42, 16);
            moraLabel.TabIndex = 31;
            moraLabel.Text = "Mora:";
            // 
            // moraTextBox
            // 
            this.moraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sancionesBindingSource, "mora", true));
            this.moraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moraTextBox.Location = new System.Drawing.Point(30, 296);
            this.moraTextBox.Name = "moraTextBox";
            this.moraTextBox.Size = new System.Drawing.Size(244, 22);
            this.moraTextBox.TabIndex = 32;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(27, 333);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(49, 16);
            fechaLabel.TabIndex = 32;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sancionesBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(27, 349);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(247, 22);
            this.fechaDateTimePicker.TabIndex = 33;
            // 
            // choferesBindingSource
            // 
            this.choferesBindingSource.DataMember = "choferes";
            this.choferesBindingSource.DataSource = this.dBTransporte;
            // 
            // choferesTableAdapter
            // 
            this.choferesTableAdapter.ClearBeforeFill = true;
            // 
            // papeletasBindingSource
            // 
            this.papeletasBindingSource.DataMember = "papeletas";
            this.papeletasBindingSource.DataSource = this.dBTransporte;
            // 
            // papeletasTableAdapter
            // 
            this.papeletasTableAdapter.ClearBeforeFill = true;
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sancionesBindingSource, "pagado", true));
            this.pagadoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagadoCheckBox.Location = new System.Drawing.Point(30, 239);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pagadoCheckBox.TabIndex = 34;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sancion";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_sancion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_chofer";
            this.dataGridViewTextBoxColumn2.DataSource = this.choferesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chofer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_chofer";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_papeleta";
            this.dataGridViewTextBoxColumn3.DataSource = this.papeletasBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Papeleta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_papeleta";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn4.HeaderText = "monto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "pagado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "pagado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mora";
            this.dataGridViewTextBoxColumn5.HeaderText = "mora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UCSancionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "UCSancionar";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 40, 30);
            this.Size = new System.Drawing.Size(1053, 562);
            this.Load += new System.EventHandler(this.UCSancionar_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesBindingNavigator)).EndInit();
            this.sancionesBindingNavigator.ResumeLayout(false);
            this.sancionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sancionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papeletasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private DBTransporte dBTransporte;
        private System.Windows.Forms.BindingSource sancionesBindingSource;
        private DBTransporteTableAdapters.SancionesTableAdapter sancionesTableAdapter;
        private DBTransporteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sancionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sancionesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sancionesDataGridView;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox moraTextBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.ComboBox id_papeletaComboBox;
        private System.Windows.Forms.BindingSource papeletasBindingSource;
        private System.Windows.Forms.ComboBox id_choferComboBox;
        private System.Windows.Forms.BindingSource choferesBindingSource;
        private DBTransporteTableAdapters.ChoferesTableAdapter choferesTableAdapter;
        private DBTransporteTableAdapters.PapeletasTableAdapter papeletasTableAdapter;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
