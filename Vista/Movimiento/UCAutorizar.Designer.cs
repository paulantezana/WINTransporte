namespace Vista.Movimiento
{
    partial class UCAutorizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAutorizar));
            System.Windows.Forms.Label id_rutaLabel;
            System.Windows.Forms.Label id_empresaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label vijenteLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label id_vehiculoLabel;
            System.Windows.Forms.Label id_choferLabel;
            System.Windows.Forms.Label ayudanteLabel;
            System.Windows.Forms.Label descripcionLabel1;
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEliminarDetaller = new System.Windows.Forms.Button();
            this.btnCancelarDetalle = new System.Windows.Forms.Button();
            this.btnNuevoDetalle = new System.Windows.Forms.Button();
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.dBTransporte = new Vista.DBTransporte();
            this.autorizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorizacionesTableAdapter = new Vista.DBTransporteTableAdapters.AutorizacionesTableAdapter();
            this.tableAdapterManager = new Vista.DBTransporteTableAdapters.TableAdapterManager();
            this.autorizacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorizacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.id_rutaComboBox = new System.Windows.Forms.ComboBox();
            this.id_empresaComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vijenteTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasTableAdapter = new Vista.DBTransporteTableAdapters.RutasTableAdapter();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new Vista.DBTransporteTableAdapters.EmpresasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizacionDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorizacionDetallesTableAdapter = new Vista.DBTransporteTableAdapters.AutorizacionDetallesTableAdapter();
            this.autorizacionDetallesDataGridView = new System.Windows.Forms.DataGridView();
            this.id_vehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.id_choferComboBox = new System.Windows.Forms.ComboBox();
            this.ayudanteTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new Vista.DBTransporteTableAdapters.VehiculosTableAdapter();
            this.choferesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choferesTableAdapter = new Vista.DBTransporteTableAdapters.ChoferesTableAdapter();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_rutaLabel = new System.Windows.Forms.Label();
            id_empresaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            vijenteLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            id_vehiculoLabel = new System.Windows.Forms.Label();
            id_choferLabel = new System.Windows.Forms.Label();
            ayudanteLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingNavigator)).BeginInit();
            this.autorizacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionDetallesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).BeginInit();
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
            this.panel6.Size = new System.Drawing.Size(850, 638);
            this.panel6.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 638);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.autorizacionesDataGridView);
            this.panel3.Controls.Add(this.autorizacionesBindingNavigator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(550, 245);
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
            this.panel1.Size = new System.Drawing.Size(550, 74);
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
            this.btnImprimir.Location = new System.Drawing.Point(421, 25);
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
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorizar";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(550, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(300, 638);
            this.panel5.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnNuevo.Location = new System.Drawing.Point(30, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 30);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnEliminar.Location = new System.Drawing.Point(207, 25);
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
            this.btnCancelar.Location = new System.Drawing.Point(101, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 30);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(192, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Autorizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.autorizacionDetallesDataGridView);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 319);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(20);
            this.panel7.Size = new System.Drawing.Size(550, 319);
            this.panel7.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(descripcionLabel);
            this.panel2.Controls.Add(this.descripcionTextBox);
            this.panel2.Controls.Add(vijenteLabel);
            this.panel2.Controls.Add(this.vijenteTextBox);
            this.panel2.Controls.Add(fechaLabel);
            this.panel2.Controls.Add(this.fechaDateTimePicker);
            this.panel2.Controls.Add(id_empresaLabel);
            this.panel2.Controls.Add(this.id_empresaComboBox);
            this.panel2.Controls.Add(id_rutaLabel);
            this.panel2.Controls.Add(this.id_rutaComboBox);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 319);
            this.panel2.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(descripcionLabel1);
            this.panel8.Controls.Add(this.descripcionTextBox1);
            this.panel8.Controls.Add(ayudanteLabel);
            this.panel8.Controls.Add(this.ayudanteTextBox);
            this.panel8.Controls.Add(id_choferLabel);
            this.panel8.Controls.Add(this.id_choferComboBox);
            this.panel8.Controls.Add(id_vehiculoLabel);
            this.panel8.Controls.Add(this.id_vehiculoComboBox);
            this.panel8.Controls.Add(this.btnModificarDetalle);
            this.panel8.Controls.Add(this.btnEliminarDetaller);
            this.panel8.Controls.Add(this.btnCancelarDetalle);
            this.panel8.Controls.Add(this.btnNuevoDetalle);
            this.panel8.Controls.Add(this.btnGuardarDetalle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 319);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(299, 319);
            this.panel8.TabIndex = 29;
            // 
            // btnEliminarDetaller
            // 
            this.btnEliminarDetaller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDetaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDetaller.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnEliminarDetaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetaller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnEliminarDetaller.Location = new System.Drawing.Point(203, 19);
            this.btnEliminarDetaller.Name = "btnEliminarDetaller";
            this.btnEliminarDetaller.Size = new System.Drawing.Size(70, 30);
            this.btnEliminarDetaller.TabIndex = 30;
            this.btnEliminarDetaller.Text = "Eliminar";
            this.btnEliminarDetaller.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDetalle
            // 
            this.btnCancelarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnCancelarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnCancelarDetalle.Location = new System.Drawing.Point(101, 271);
            this.btnCancelarDetalle.Name = "btnCancelarDetalle";
            this.btnCancelarDetalle.Size = new System.Drawing.Size(85, 30);
            this.btnCancelarDetalle.TabIndex = 29;
            this.btnCancelarDetalle.Text = "Cancelar";
            this.btnCancelarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnNuevoDetalle
            // 
            this.btnNuevoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnNuevoDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnNuevoDetalle.Location = new System.Drawing.Point(26, 19);
            this.btnNuevoDetalle.Name = "btnNuevoDetalle";
            this.btnNuevoDetalle.Size = new System.Drawing.Size(70, 30);
            this.btnNuevoDetalle.TabIndex = 31;
            this.btnNuevoDetalle.Text = "Nuevo";
            this.btnNuevoDetalle.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.btnGuardarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(114)))), ((int)(((byte)(220)))));
            this.btnGuardarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDetalle.Location = new System.Drawing.Point(192, 271);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(85, 30);
            this.btnGuardarDetalle.TabIndex = 28;
            this.btnGuardarDetalle.Text = "Autorizar";
            this.btnGuardarDetalle.UseVisualStyleBackColor = false;
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.btnModificarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnModificarDetalle.Location = new System.Drawing.Point(116, 19);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(70, 30);
            this.btnModificarDetalle.TabIndex = 32;
            this.btnModificarDetalle.Text = "Modificar";
            this.btnModificarDetalle.UseVisualStyleBackColor = true;
            // 
            // dBTransporte
            // 
            this.dBTransporte.DataSetName = "DBTransporte";
            this.dBTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorizacionesBindingSource
            // 
            this.autorizacionesBindingSource.DataMember = "Autorizaciones";
            this.autorizacionesBindingSource.DataSource = this.dBTransporte;
            // 
            // autorizacionesTableAdapter
            // 
            this.autorizacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorizacionDetallesTableAdapter = this.autorizacionDetallesTableAdapter;
            this.tableAdapterManager.AutorizacionesTableAdapter = this.autorizacionesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = this.choferesTableAdapter;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.LicenciasTableAdapter = null;
            this.tableAdapterManager.PapeletasTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = this.rutasTableAdapter;
            this.tableAdapterManager.SancionesTableAdapter = null;
            this.tableAdapterManager.Tipo_empresasTableAdapter = null;
            this.tableAdapterManager.Tipo_vehiculosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vista.DBTransporteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = this.vehiculosTableAdapter;
            // 
            // autorizacionesBindingNavigator
            // 
            this.autorizacionesBindingNavigator.AddNewItem = null;
            this.autorizacionesBindingNavigator.BindingSource = this.autorizacionesBindingSource;
            this.autorizacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autorizacionesBindingNavigator.DeleteItem = null;
            this.autorizacionesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.autorizacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.autorizacionesBindingNavigator.Location = new System.Drawing.Point(20, 200);
            this.autorizacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autorizacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autorizacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autorizacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autorizacionesBindingNavigator.Name = "autorizacionesBindingNavigator";
            this.autorizacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autorizacionesBindingNavigator.Size = new System.Drawing.Size(510, 25);
            this.autorizacionesBindingNavigator.TabIndex = 16;
            this.autorizacionesBindingNavigator.Text = "bindingNavigator1";
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
            // autorizacionesDataGridView
            // 
            this.autorizacionesDataGridView.AllowUserToAddRows = false;
            this.autorizacionesDataGridView.AllowUserToDeleteRows = false;
            this.autorizacionesDataGridView.AllowUserToOrderColumns = true;
            this.autorizacionesDataGridView.AutoGenerateColumns = false;
            this.autorizacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorizacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.autorizacionesDataGridView.DataSource = this.autorizacionesBindingSource;
            this.autorizacionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorizacionesDataGridView.Location = new System.Drawing.Point(20, 20);
            this.autorizacionesDataGridView.Name = "autorizacionesDataGridView";
            this.autorizacionesDataGridView.ReadOnly = true;
            this.autorizacionesDataGridView.Size = new System.Drawing.Size(510, 180);
            this.autorizacionesDataGridView.TabIndex = 17;
            // 
            // id_rutaLabel
            // 
            id_rutaLabel.AutoSize = true;
            id_rutaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_rutaLabel.Location = new System.Drawing.Point(27, 74);
            id_rutaLabel.Name = "id_rutaLabel";
            id_rutaLabel.Size = new System.Drawing.Size(47, 16);
            id_rutaLabel.TabIndex = 27;
            id_rutaLabel.Text = "id ruta:";
            // 
            // id_rutaComboBox
            // 
            this.id_rutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autorizacionesBindingSource, "id_ruta", true));
            this.id_rutaComboBox.DataSource = this.rutasBindingSource;
            this.id_rutaComboBox.DisplayMember = "partida";
            this.id_rutaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_rutaComboBox.FormattingEnabled = true;
            this.id_rutaComboBox.Location = new System.Drawing.Point(117, 71);
            this.id_rutaComboBox.Name = "id_rutaComboBox";
            this.id_rutaComboBox.Size = new System.Drawing.Size(160, 24);
            this.id_rutaComboBox.TabIndex = 28;
            this.id_rutaComboBox.ValueMember = "id_ruta";
            // 
            // id_empresaLabel
            // 
            id_empresaLabel.AutoSize = true;
            id_empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_empresaLabel.Location = new System.Drawing.Point(30, 114);
            id_empresaLabel.Name = "id_empresaLabel";
            id_empresaLabel.Size = new System.Drawing.Size(79, 16);
            id_empresaLabel.TabIndex = 28;
            id_empresaLabel.Text = "id empresa:";
            // 
            // id_empresaComboBox
            // 
            this.id_empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autorizacionesBindingSource, "id_empresa", true));
            this.id_empresaComboBox.DataSource = this.empresasBindingSource;
            this.id_empresaComboBox.DisplayMember = "nombre";
            this.id_empresaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_empresaComboBox.FormattingEnabled = true;
            this.id_empresaComboBox.Location = new System.Drawing.Point(117, 106);
            this.id_empresaComboBox.Name = "id_empresaComboBox";
            this.id_empresaComboBox.Size = new System.Drawing.Size(160, 24);
            this.id_empresaComboBox.TabIndex = 29;
            this.id_empresaComboBox.ValueMember = "id_empresa";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(30, 145);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(44, 16);
            fechaLabel.TabIndex = 29;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.autorizacionesBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(117, 145);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(160, 22);
            this.fechaDateTimePicker.TabIndex = 30;
            // 
            // vijenteLabel
            // 
            vijenteLabel.AutoSize = true;
            vijenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vijenteLabel.Location = new System.Drawing.Point(30, 186);
            vijenteLabel.Name = "vijenteLabel";
            vijenteLabel.Size = new System.Drawing.Size(50, 16);
            vijenteLabel.TabIndex = 30;
            vijenteLabel.Text = "vijente:";
            // 
            // vijenteTextBox
            // 
            this.vijenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizacionesBindingSource, "vijente", true));
            this.vijenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vijenteTextBox.Location = new System.Drawing.Point(116, 180);
            this.vijenteTextBox.Name = "vijenteTextBox";
            this.vijenteTextBox.Size = new System.Drawing.Size(161, 22);
            this.vijenteTextBox.TabIndex = 31;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(30, 222);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(81, 16);
            descripcionLabel.TabIndex = 31;
            descripcionLabel.Text = "descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizacionesBindingSource, "descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(117, 219);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(160, 22);
            this.descripcionTextBox.TabIndex = 32;
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataMember = "rutas";
            this.rutasBindingSource.DataSource = this.dBTransporte;
            // 
            // rutasTableAdapter
            // 
            this.rutasTableAdapter.ClearBeforeFill = true;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "empresas";
            this.empresasBindingSource.DataSource = this.dBTransporte;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_autorizacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Autorizacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_ruta";
            this.dataGridViewTextBoxColumn2.DataSource = this.rutasBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "partida";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ruta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_ruta";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_empresa";
            this.dataGridViewTextBoxColumn3.DataSource = this.empresasBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_empresa";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vijente";
            this.dataGridViewTextBoxColumn5.HeaderText = "vijente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // autorizacionDetallesBindingSource
            // 
            this.autorizacionDetallesBindingSource.DataMember = "fk_autorizaciondetalles_autorizaciones";
            this.autorizacionDetallesBindingSource.DataSource = this.autorizacionesBindingSource;
            // 
            // autorizacionDetallesTableAdapter
            // 
            this.autorizacionDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // autorizacionDetallesDataGridView
            // 
            this.autorizacionDetallesDataGridView.AutoGenerateColumns = false;
            this.autorizacionDetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorizacionDetallesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.autorizacionDetallesDataGridView.DataSource = this.autorizacionDetallesBindingSource;
            this.autorizacionDetallesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorizacionDetallesDataGridView.Location = new System.Drawing.Point(20, 20);
            this.autorizacionDetallesDataGridView.Name = "autorizacionDetallesDataGridView";
            this.autorizacionDetallesDataGridView.Size = new System.Drawing.Size(510, 279);
            this.autorizacionDetallesDataGridView.TabIndex = 0;
            // 
            // id_vehiculoLabel
            // 
            id_vehiculoLabel.AutoSize = true;
            id_vehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vehiculoLabel.Location = new System.Drawing.Point(38, 71);
            id_vehiculoLabel.Name = "id_vehiculoLabel";
            id_vehiculoLabel.Size = new System.Drawing.Size(75, 16);
            id_vehiculoLabel.TabIndex = 32;
            id_vehiculoLabel.Text = "id vehiculo:";
            // 
            // id_vehiculoComboBox
            // 
            this.id_vehiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autorizacionDetallesBindingSource, "id_vehiculo", true));
            this.id_vehiculoComboBox.DataSource = this.vehiculosBindingSource;
            this.id_vehiculoComboBox.DisplayMember = "placa";
            this.id_vehiculoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_vehiculoComboBox.FormattingEnabled = true;
            this.id_vehiculoComboBox.Location = new System.Drawing.Point(123, 68);
            this.id_vehiculoComboBox.Name = "id_vehiculoComboBox";
            this.id_vehiculoComboBox.Size = new System.Drawing.Size(150, 24);
            this.id_vehiculoComboBox.TabIndex = 33;
            this.id_vehiculoComboBox.ValueMember = "id_vehiculo";
            // 
            // id_choferLabel
            // 
            id_choferLabel.AutoSize = true;
            id_choferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_choferLabel.Location = new System.Drawing.Point(42, 111);
            id_choferLabel.Name = "id_choferLabel";
            id_choferLabel.Size = new System.Drawing.Size(62, 16);
            id_choferLabel.TabIndex = 33;
            id_choferLabel.Text = "id chofer:";
            // 
            // id_choferComboBox
            // 
            this.id_choferComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autorizacionDetallesBindingSource, "id_chofer", true));
            this.id_choferComboBox.DataSource = this.choferesBindingSource;
            this.id_choferComboBox.DisplayMember = "nombres";
            this.id_choferComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_choferComboBox.FormattingEnabled = true;
            this.id_choferComboBox.Location = new System.Drawing.Point(123, 108);
            this.id_choferComboBox.Name = "id_choferComboBox";
            this.id_choferComboBox.Size = new System.Drawing.Size(150, 24);
            this.id_choferComboBox.TabIndex = 34;
            this.id_choferComboBox.ValueMember = "id_chofer";
            // 
            // ayudanteLabel
            // 
            ayudanteLabel.AutoSize = true;
            ayudanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ayudanteLabel.Location = new System.Drawing.Point(38, 153);
            ayudanteLabel.Name = "ayudanteLabel";
            ayudanteLabel.Size = new System.Drawing.Size(67, 16);
            ayudanteLabel.TabIndex = 34;
            ayudanteLabel.Text = "ayudante:";
            // 
            // ayudanteTextBox
            // 
            this.ayudanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizacionDetallesBindingSource, "ayudante", true));
            this.ayudanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudanteTextBox.Location = new System.Drawing.Point(124, 150);
            this.ayudanteTextBox.Name = "ayudanteTextBox";
            this.ayudanteTextBox.Size = new System.Drawing.Size(149, 22);
            this.ayudanteTextBox.TabIndex = 35;
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel1.Location = new System.Drawing.Point(30, 194);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(81, 16);
            descripcionLabel1.TabIndex = 35;
            descripcionLabel1.Text = "descripcion:";
            // 
            // descripcionTextBox1
            // 
            this.descripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorizacionDetallesBindingSource, "descripcion", true));
            this.descripcionTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox1.Location = new System.Drawing.Point(124, 191);
            this.descripcionTextBox1.Name = "descripcionTextBox1";
            this.descripcionTextBox1.Size = new System.Drawing.Size(149, 22);
            this.descripcionTextBox1.TabIndex = 36;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "vehiculos";
            this.vehiculosBindingSource.DataSource = this.dBTransporte;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_autorizaciondetalle";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_autorizaciondetalle";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_autorizacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_autorizacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_vehiculo";
            this.dataGridViewTextBoxColumn9.DataSource = this.vehiculosBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "placa";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_vehiculo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "id_vehiculo";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_chofer";
            this.dataGridViewTextBoxColumn10.DataSource = this.choferesBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "nombres";
            this.dataGridViewTextBoxColumn10.HeaderText = "id_chofer";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "id_chofer";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ayudante";
            this.dataGridViewTextBoxColumn11.HeaderText = "ayudante";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn12.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // UCAutorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "UCAutorizar";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 40, 30);
            this.Size = new System.Drawing.Size(890, 698);
            this.Load += new System.EventHandler(this.UCAutorizar_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesBindingNavigator)).EndInit();
            this.autorizacionesBindingNavigator.ResumeLayout(false);
            this.autorizacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizacionDetallesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnEliminarDetaller;
        private System.Windows.Forms.Button btnCancelarDetalle;
        private System.Windows.Forms.Button btnNuevoDetalle;
        private System.Windows.Forms.Button btnGuardarDetalle;
        private DBTransporte dBTransporte;
        private System.Windows.Forms.BindingSource autorizacionesBindingSource;
        private DBTransporteTableAdapters.AutorizacionesTableAdapter autorizacionesTableAdapter;
        private DBTransporteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autorizacionesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView autorizacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox vijenteTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox id_empresaComboBox;
        private System.Windows.Forms.ComboBox id_rutaComboBox;
        private DBTransporteTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private DBTransporteTableAdapters.RutasTableAdapter rutasTableAdapter;
        private System.Windows.Forms.DataGridView autorizacionDetallesDataGridView;
        private System.Windows.Forms.BindingSource autorizacionDetallesBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox1;
        private System.Windows.Forms.TextBox ayudanteTextBox;
        private System.Windows.Forms.ComboBox id_choferComboBox;
        private System.Windows.Forms.ComboBox id_vehiculoComboBox;
        private DBTransporteTableAdapters.AutorizacionDetallesTableAdapter autorizacionDetallesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource choferesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DBTransporteTableAdapters.ChoferesTableAdapter choferesTableAdapter;
        private DBTransporteTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
    }
}
