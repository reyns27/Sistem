using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormListaPacientes : Form
    {
        public FormListaPacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantPacientes frm = new FormMantPacientes();
            if (dataGridView1.SelectedRows.Count > 0)
            {               
                frm.TxtExpediente.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.TxtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.TxtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.TxtDireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.TxtTelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantPacientes frm = new FormMantPacientes();
            frm.ShowDialog();
        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(1, "2", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(2, "3", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(3, "4", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(4, "5", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(5, "6", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(6, "7", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(7, "8", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(8, "9", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(9, "10", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(10, "11", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(11, "12", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(12, "13", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(13, "14", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(14, "15", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(15, "16", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(16, "17", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(17, "18", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(18, "19", "Rafael", "Fernandez", "AV. Melgar", "56465");
            dataGridView1.Rows.Insert(19, "20", "Rafael", "Fernandez", "AV. Melgar", "56465");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMembresia frm = Owner as FormMembresia;
            //FormMembresia frm = new FormMembresia();

            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        
    }
}
