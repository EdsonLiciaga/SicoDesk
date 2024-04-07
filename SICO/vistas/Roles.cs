using SICO.controladores;
using SICO.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICODESK.vistas
{
    public partial class Roles : Form
    {
        RolesControlador objRolesControlador = new RolesControlador();
        public Roles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objRolesControlador.GetList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            string tipoRol = txtTipoRol.Text;
            string descripcion = txtDescripcion.Text; 

            objRolesControlador.Update(id, tipoRol, descripcion);
            dataGridView1.DataSource = objRolesControlador.GetList();

            txtTipoRol.Clear();
            txtDescripcion.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipoRol = txtTipoRol.Text; 
            string descripcion = txtDescripcion.Text;

            objRolesControlador.Save(tipoRol, descripcion);
            dataGridView1.DataSource = objRolesControlador.GetList();

            txtTipoRol.Clear();
            txtDescripcion.Clear(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            roles objRoles = objRolesControlador.Search(id);

            txtTipoRol.Text = objRoles.tipo_rol; 
            txtDescripcion.Text = objRoles.descripcion;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTipoRol.Clear();
            txtDescripcion.Clear(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            objRolesControlador.Delete(id);
            dataGridView1.DataSource = objRolesControlador.GetList();
        }
    }
}
