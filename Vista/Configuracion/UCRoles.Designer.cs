namespace Vista.Configuracion
{
    partial class UCRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRoles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoRol = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarRol = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardarRol = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelarRol = new System.Windows.Forms.ToolStripButton();
            this.rolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTransporte = new Vista.DBTransporte();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rolesBindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolesTableAdapter = new Vista.DBTransporteTableAdapters.RolesTableAdapter();
            this.tableAdapterManager = new Vista.DBTransporteTableAdapters.TableAdapterManager();
            this.rolTableAdapter = new Vista.DBTransporteTableAdapters.RolTableAdapter();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).BeginInit();
            this.rolesBindingNavigator.SuspendLayout();
            this.panelHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(435, 30);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(300, 503);
            this.panel5.TabIndex = 12;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.toolStrip1);
            this.panel8.Controls.Add(this.rolDataGridView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 60);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(15);
            this.panel8.Size = new System.Drawing.Size(299, 383);
            this.panel8.TabIndex = 30;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoRol,
            this.tsbEliminarRol,
            this.tsbGuardarRol,
            this.tsbCancelarRol});
            this.toolStrip1.Location = new System.Drawing.Point(15, 235);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(269, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevoRol
            // 
            this.tsbNuevoRol.AutoSize = false;
            this.tsbNuevoRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoRol.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoRol.Image")));
            this.tsbNuevoRol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevoRol.Name = "tsbNuevoRol";
            this.tsbNuevoRol.RightToLeftAutoMirrorImage = true;
            this.tsbNuevoRol.Size = new System.Drawing.Size(45, 32);
            this.tsbNuevoRol.Text = "Agregar nuevo";
            this.tsbNuevoRol.Click += new System.EventHandler(this.tsbNuevoRol_Click);
            // 
            // tsbEliminarRol
            // 
            this.tsbEliminarRol.AutoSize = false;
            this.tsbEliminarRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminarRol.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarRol.Image")));
            this.tsbEliminarRol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEliminarRol.Name = "tsbEliminarRol";
            this.tsbEliminarRol.RightToLeftAutoMirrorImage = true;
            this.tsbEliminarRol.Size = new System.Drawing.Size(45, 32);
            this.tsbEliminarRol.Text = "Eliminar";
            this.tsbEliminarRol.Click += new System.EventHandler(this.tsbEliminarRol_Click);
            // 
            // tsbGuardarRol
            // 
            this.tsbGuardarRol.AutoSize = false;
            this.tsbGuardarRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardarRol.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardarRol.Image")));
            this.tsbGuardarRol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardarRol.Name = "tsbGuardarRol";
            this.tsbGuardarRol.Size = new System.Drawing.Size(45, 32);
            this.tsbGuardarRol.Text = "Guardar datos";
            this.tsbGuardarRol.Click += new System.EventHandler(this.tsbGuardarRol_Click);
            // 
            // tsbCancelarRol
            // 
            this.tsbCancelarRol.AutoSize = false;
            this.tsbCancelarRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelarRol.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelarRol.Image")));
            this.tsbCancelarRol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelarRol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarRol.Name = "tsbCancelarRol";
            this.tsbCancelarRol.Size = new System.Drawing.Size(45, 32);
            this.tsbCancelarRol.Text = "Cancelar";
            this.tsbCancelarRol.Click += new System.EventHandler(this.tsbCancelarRol_Click);
            // 
            // rolDataGridView
            // 
            this.rolDataGridView.AllowUserToAddRows = false;
            this.rolDataGridView.AutoGenerateColumns = false;
            this.rolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rolDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rolDataGridView.ColumnHeadersHeight = 33;
            this.rolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rolDataGridView.DataSource = this.rolBindingSource;
            this.rolDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rolDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rolDataGridView.Location = new System.Drawing.Point(15, 15);
            this.rolDataGridView.Name = "rolDataGridView";
            this.rolDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rolDataGridView.RowTemplate.Height = 27;
            this.rolDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rolDataGridView.Size = new System.Drawing.Size(269, 220);
            this.rolDataGridView.TabIndex = 1;
            this.rolDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Rol";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Rol";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rol";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.dBTransporte;
            // 
            // dBTransporte
            // 
            this.dBTransporte.DataSetName = "DBTransporte";
            this.dBTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 443);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 60);
            this.panel7.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 60);
            this.panel6.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Perfiles de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rol";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelMainContainer);
            this.panel4.Controls.Add(this.panelHeaderContainer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 503);
            this.panel4.TabIndex = 13;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.AutoScroll = true;
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.panelMain);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 60);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelMainContainer.Size = new System.Drawing.Size(435, 443);
            this.panelMainContainer.TabIndex = 6;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.rolesDataGridView);
            this.panelMain.Controls.Add(this.rolesBindingNavigator);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(15);
            this.panelMain.Size = new System.Drawing.Size(415, 423);
            this.panelMain.TabIndex = 15;
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rolesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.rolesDataGridView.AutoGenerateColumns = false;
            this.rolesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.rolesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.rolesDataGridView.ColumnHeadersHeight = 33;
            this.rolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3});
            this.rolesDataGridView.DataSource = this.rolesBindingSource;
            this.rolesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rolesDataGridView.Location = new System.Drawing.Point(15, 15);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rolesDataGridView.RowTemplate.Height = 27;
            this.rolesDataGridView.Size = new System.Drawing.Size(385, 358);
            this.rolesDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Roles";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Roles";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Rol";
            this.dataGridViewTextBoxColumn2.DataSource = this.rolBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Rol";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_Rol";
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            this.rolBindingSource1.DataSource = this.dBTransporte;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Applicacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Applicacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Consultar";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Consultar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Editar";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Editar";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Eliminar";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.dBTransporte;
            // 
            // rolesBindingNavigator
            // 
            this.rolesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rolesBindingNavigator.AutoSize = false;
            this.rolesBindingNavigator.BackColor = System.Drawing.Color.White;
            this.rolesBindingNavigator.BindingSource = this.rolesBindingSource;
            this.rolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rolesBindingNavigator.DeleteItem = null;
            this.rolesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rolesBindingNavigatorSaveItem,
            this.rolesBindingNavigatorCancelItem});
            this.rolesBindingNavigator.Location = new System.Drawing.Point(15, 373);
            this.rolesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rolesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rolesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rolesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rolesBindingNavigator.Name = "rolesBindingNavigator";
            this.rolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rolesBindingNavigator.Size = new System.Drawing.Size(385, 35);
            this.rolesBindingNavigator.TabIndex = 14;
            this.rolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AutoSize = false;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(42, 32);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.AutoSize = false;
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoSize = false;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(45, 32);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // rolesBindingNavigatorSaveItem
            // 
            this.rolesBindingNavigatorSaveItem.AutoSize = false;
            this.rolesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesBindingNavigatorSaveItem.Image")));
            this.rolesBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rolesBindingNavigatorSaveItem.Name = "rolesBindingNavigatorSaveItem";
            this.rolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(45, 32);
            this.rolesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.rolesBindingNavigatorSaveItem_Click);
            // 
            // rolesBindingNavigatorCancelItem
            // 
            this.rolesBindingNavigatorCancelItem.AutoSize = false;
            this.rolesBindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolesBindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesBindingNavigatorCancelItem.Image")));
            this.rolesBindingNavigatorCancelItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rolesBindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rolesBindingNavigatorCancelItem.Name = "rolesBindingNavigatorCancelItem";
            this.rolesBindingNavigatorCancelItem.Size = new System.Drawing.Size(45, 32);
            this.rolesBindingNavigatorCancelItem.Text = "Cancelar";
            this.rolesBindingNavigatorCancelItem.Click += new System.EventHandler(this.rolesBindingNavigatorCancelItem_Click);
            // 
            // panelHeaderContainer
            // 
            this.panelHeaderContainer.BackColor = System.Drawing.Color.White;
            this.panelHeaderContainer.Controls.Add(this.label1);
            this.panelHeaderContainer.Controls.Add(this.label2);
            this.panelHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderContainer.Name = "panelHeaderContainer";
            this.panelHeaderContainer.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelHeaderContainer.Size = new System.Drawing.Size(435, 60);
            this.panelHeaderContainer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido a la administracion de los permisos de acceso al sistema";
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorizacionDetallesTableAdapter = null;
            this.tableAdapterManager.AutorizacionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.LicenciasTableAdapter = null;
            this.tableAdapterManager.PapeletasTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.SancionesTableAdapter = null;
            this.tableAdapterManager.Tipo_empresasTableAdapter = null;
            this.tableAdapterManager.Tipo_vehiculosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vista.DBTransporteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // UCRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "UCRoles";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 40, 30);
            this.Size = new System.Drawing.Size(775, 563);
            this.Load += new System.EventHandler(this.UCRoles_Load);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTransporte)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelMainContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).EndInit();
            this.rolesBindingNavigator.ResumeLayout(false);
            this.rolesBindingNavigator.PerformLayout();
            this.panelHeaderContainer.ResumeLayout(false);
            this.panelHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeaderContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DBTransporte dBTransporte;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DBTransporteTableAdapters.RolesTableAdapter rolesTableAdapter;
        private DBTransporteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rolesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rolesDataGridView;
        private System.Windows.Forms.ToolStripButton rolesBindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevoRol;
        private System.Windows.Forms.ToolStripButton tsbEliminarRol;
        private System.Windows.Forms.ToolStripButton tsbGuardarRol;
        private System.Windows.Forms.ToolStripButton tsbCancelarRol;
        private System.Windows.Forms.DataGridView rolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private DBTransporteTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    }
}
