namespace Vista.Configuracion
{
    partial class UCPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPerfil));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textOldClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textNewClave = new System.Windows.Forms.TextBox();
            this.textConfirmNewClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarClave = new System.Windows.Forms.Button();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pbxPerfil = new System.Windows.Forms.PictureBox();
            this.textFoto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnGuardarClave);
            this.panel1.Controls.Add(this.btnCargarFoto);
            this.panel1.Controls.Add(this.pbxPerfil);
            this.panel1.Controls.Add(this.textFoto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 795);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textUsuario);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textEmail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(224, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 256);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(28, 46);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(203, 22);
            this.textUsuario.TabIndex = 19;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(28, 108);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(203, 22);
            this.textNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombres";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(31, 172);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(203, 22);
            this.textEmail.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textOldClave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textNewClave);
            this.groupBox1.Controls.Add(this.textConfirmNewClave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(521, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 256);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Antigua contraseña";
            // 
            // textOldClave
            // 
            this.textOldClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOldClave.Location = new System.Drawing.Point(30, 50);
            this.textOldClave.Name = "textOldClave";
            this.textOldClave.PasswordChar = '•';
            this.textOldClave.Size = new System.Drawing.Size(203, 22);
            this.textOldClave.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Confirmar nueva contraseña";
            // 
            // textNewClave
            // 
            this.textNewClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewClave.Location = new System.Drawing.Point(30, 107);
            this.textNewClave.Name = "textNewClave";
            this.textNewClave.PasswordChar = '•';
            this.textNewClave.Size = new System.Drawing.Size(203, 22);
            this.textNewClave.TabIndex = 33;
            // 
            // textConfirmNewClave
            // 
            this.textConfirmNewClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmNewClave.Location = new System.Drawing.Point(30, 163);
            this.textConfirmNewClave.Name = "textConfirmNewClave";
            this.textConfirmNewClave.PasswordChar = '•';
            this.textConfirmNewClave.Size = new System.Drawing.Size(203, 22);
            this.textConfirmNewClave.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nueva contraseña";
            // 
            // btnGuardarClave
            // 
            this.btnGuardarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(132)))), ((int)(((byte)(246)))));
            this.btnGuardarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardarClave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(187)))));
            this.btnGuardarClave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(114)))), ((int)(((byte)(220)))));
            this.btnGuardarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClave.ForeColor = System.Drawing.Color.White;
            this.btnGuardarClave.Location = new System.Drawing.Point(24, 622);
            this.btnGuardarClave.Name = "btnGuardarClave";
            this.btnGuardarClave.Size = new System.Drawing.Size(180, 30);
            this.btnGuardarClave.TabIndex = 44;
            this.btnGuardarClave.Text = "Guardar";
            this.btnGuardarClave.UseVisualStyleBackColor = false;
            this.btnGuardarClave.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(172, 582);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(32, 23);
            this.btnCargarFoto.TabIndex = 43;
            this.btnCargarFoto.Text = "...";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pbxPerfil
            // 
            this.pbxPerfil.BackColor = System.Drawing.Color.White;
            this.pbxPerfil.Location = new System.Drawing.Point(24, 396);
            this.pbxPerfil.Name = "pbxPerfil";
            this.pbxPerfil.Size = new System.Drawing.Size(180, 180);
            this.pbxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPerfil.TabIndex = 42;
            this.pbxPerfil.TabStop = false;
            // 
            // textFoto
            // 
            this.textFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoto.Location = new System.Drawing.Point(24, 582);
            this.textFoto.Name = "textFoto";
            this.textFoto.Size = new System.Drawing.Size(142, 22);
            this.textFoto.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // UCPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCPerfil";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 40, 30);
            this.Size = new System.Drawing.Size(831, 855);
            this.Load += new System.EventHandler(this.UCPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textOldClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNewClave;
        private System.Windows.Forms.TextBox textConfirmNewClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarClave;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.PictureBox pbxPerfil;
        private System.Windows.Forms.TextBox textFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
