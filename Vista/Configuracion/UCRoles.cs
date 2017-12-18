using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Componentes;

namespace Vista.Configuracion
{
    public partial class UCRoles : UserControl
    {
        private int itemRol;
        private int currentRolId;

        public UCRoles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rolesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            estado(false);
            MessageBox.Show("El registro se guardó exitosamente ", "Guardar Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UCRoles_Load(object sender, EventArgs e)
        {
            rolTableAdapter.Fill(dBTransporte.Rol);
            cargarRegistros();
            estado(false);
            estadoRol(false);
        }

        private void cargarRegistros()
        {
            try
            {
                currentRolId = Convert.ToInt32(rolDataGridView.Rows[itemRol].Cells[0].Value.ToString());
                this.rolesTableAdapter.BuscarRoles(this.dBTransporte.Roles, currentRolId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            estado(true);
        }

        private void estado(bool state)
        {
            rolesBindingNavigatorCancelItem.Enabled = state;

            bindingNavigatorDeleteItem.Enabled = !state;
            bindingNavigatorMoveLastItem.Enabled = !state;
            bindingNavigatorMoveFirstItem.Enabled = !state;
            bindingNavigatorMoveNextItem.Enabled = !state;
            bindingNavigatorMovePreviousItem.Enabled = !state;
            bindingNavigatorAddNewItem.Enabled = !state;
            bindingNavigatorPositionItem.Enabled = !state;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;
            rolesBindingSource.RemoveAt(rolesBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void rolesBindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.rolesBindingSource.CancelEdit();
            estado(false);
        }

        private void tsbNuevoRol_Click(object sender, EventArgs e)
        {
            rolBindingSource.AddNew();
            estadoRol(true);
        }

        private void estadoRol(bool state)
        {
            tsbCancelarRol.Enabled = state;
            tsbNuevoRol.Enabled = !state;
            tsbNuevoRol.Enabled = !state;
        }

        private void tsbEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.No) return;
                rolBindingSource.RemoveAt(rolBindingSource.Position);
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbGuardarRol_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rolBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            estadoRol(false);
        }

        private void tsbCancelarRol_Click(object sender, EventArgs e)
        {
            this.rolBindingSource.CancelEdit();
            estadoRol(false);
        }

        private void rolDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            itemRol = rolDataGridView.CurrentRow.Index;
            cargarRegistros();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.leftLine(panel5);
        }
    }
}
