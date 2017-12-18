namespace Vista.Navegacion
{
    partial class UCReportes
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
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(0, 129);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(160, 45);
            this.btnRutas.TabIndex = 21;
            this.btnRutas.Text = "    Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(0, 84);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(160, 45);
            this.btnEmpresa.TabIndex = 20;
            this.btnEmpresa.Text = "    Empresas";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnChoferes
            // 
            this.btnChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btnChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoferes.FlatAppearance.BorderSize = 0;
            this.btnChoferes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChoferes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoferes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoferes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnChoferes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoferes.Location = new System.Drawing.Point(0, 39);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(160, 45);
            this.btnChoferes.TabIndex = 18;
            this.btnChoferes.Text = "    Choferes";
            this.btnChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoferes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChoferes.UseVisualStyleBackColor = false;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.btnChoferes);
            this.panel1.Controls.Add(this.btnRutas);
            this.panel1.Controls.Add(this.btnEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 511);
            this.panel1.TabIndex = 29;
            // 
            // UCReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Name = "UCReportes";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 0, 30);
            this.Size = new System.Drawing.Size(180, 571);
            this.Load += new System.EventHandler(this.UCReportes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.Panel panel1;
    }
}
