using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendezAgendaContactos
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            lstContactosEditar.Items.Clear();
            if (frmAgregar.Indice == 0)
            {
                MessageBox.Show("No Hay Contactos Cargados","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                for (int i = 0; i < frmAgregar.Indice; i++)
                {
                    lstContactosEditar.Items.Add(frmAgregar.vecContactos[i].Nombre);
                }
            }
        }

        private void mskNuevoNumero_Click(object sender, EventArgs e)
        {
            mskNuevoNumero.Select(0, 0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int i = lstContactosEditar.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("Seleccione un Contacto Para Editar.");
                return;
            }

            string nuevoNombre = txtNuevoNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nuevoNombre) && nuevoNombre != frmAgregar.vecContactos[i].Nombre)
            {
                frmAgregar.vecContactos[i].Nombre = nuevoNombre;
                lstContactosEditar.Items[i] = nuevoNombre;
            }

            string nuevoNumero = mskNuevoNumero.Text.Trim();
            if (!string.IsNullOrEmpty(nuevoNumero) && nuevoNumero != frmAgregar.vecContactos[i].Numero)
            {
                frmAgregar.vecContactos[i].Numero = nuevoNumero;
            }

            string nuevaCategoria = lstNuevaCategoria.Text.Trim();
            if (!string.IsNullOrEmpty(nuevaCategoria) && nuevaCategoria != frmAgregar.vecContactos[i].Categoria)
            {
                frmAgregar.vecContactos[i].Categoria = nuevaCategoria;
            }
            MessageBox.Show("Contacto Actualizado Correctamente","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
