namespace Vista.Navegacion
{
    partial class UCMovimientos
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
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnRegularizarSancion = new System.Windows.Forms.Button();
            this.btnSancionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnAutorizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutorizar.FlatAppearance.BorderSize = 0;
            this.btnAutorizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAutorizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnAutorizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutorizar.Location = new System.Drawing.Point(3, 142);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(157, 45);
            this.btnAutorizar.TabIndex = 21;
            this.btnAutorizar.Text = "    Autorizar";
            this.btnAutorizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnRegularizarSancion
            // 
            this.btnRegularizarSancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnRegularizarSancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegularizarSancion.FlatAppearance.BorderSize = 0;
            this.btnRegularizarSancion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegularizarSancion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRegularizarSancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegularizarSancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegularizarSancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnRegularizarSancion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegularizarSancion.Location = new System.Drawing.Point(3, 97);
            this.btnRegularizarSancion.Name = "btnRegularizarSancion";
            this.btnRegularizarSancion.Size = new System.Drawing.Size(157, 45);
            this.btnRegularizarSancion.TabIndex = 20;
            this.btnRegularizarSancion.Text = "    Regularizar Sancion";
            this.btnRegularizarSancion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegularizarSancion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegularizarSancion.UseVisualStyleBackColor = false;
            this.btnRegularizarSancion.Click += new System.EventHandler(this.btnRegularizarSancion_Click);
            // 
            // btnSancionar
            // 
            this.btnSancionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnSancionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSancionar.FlatAppearance.BorderSize = 0;
            this.btnSancionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSancionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSancionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSancionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSancionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnSancionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSancionar.Location = new System.Drawing.Point(3, 52);
            this.btnSancionar.Name = "btnSancionar";
            this.btnSancionar.Size = new System.Drawing.Size(157, 45);
            this.btnSancionar.TabIndex = 18;
            this.btnSancionar.Text = "    Sancionar";
            this.btnSancionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSancionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSancionar.UseVisualStyleBackColor = false;
            this.btnSancionar.Click += new System.EventHandler(this.btnSancionar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.btnSancionar);
            this.panel1.Controls.Add(this.btnAutorizar);
            this.panel1.Controls.Add(this.btnRegularizarSancion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 521);
            this.panel1.TabIndex = 30;
            // 
            // UCMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Name = "UCMovimientos";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 0, 30);
            this.Size = new System.Drawing.Size(180, 581);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnRegularizarSancion;
        private System.Windows.Forms.Button btnSancionar;
        private System.Windows.Forms.Panel panel1;
    }
}
