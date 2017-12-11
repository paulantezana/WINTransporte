﻿using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                errorProvider1.SetError(textUsuario, "El campo usuario esta vacía");
                textUsuario.Focus();
                return;
            }
            errorProvider1.Clear();
            if (textPassword.Text == "")
            {
                errorProvider1.SetError(textPassword, "El campo contraseña esta vacía");
                textPassword.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioController usuarioController = new UsuarioController();
            if (!usuarioController.loginUsuario(textUsuario.Text, textPassword.Text))
            {
                MessageBox.Show("El nombre de usuario o contraseña incorrecta", "Login");
                return;
            }

            FormHome formHome = new FormHome(UsuarioController.usuario);
            formHome.Show();
            this.Hide();
        }
    }
}
