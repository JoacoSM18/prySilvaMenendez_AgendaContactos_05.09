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
    public partial class frmBorrar : Form
    {
        public frmBorrar()
        {
            InitializeComponent();
        }

        private void frmBorrar_Load(object sender, EventArgs e)
        {
            lstContactosBorrar.Items.Clear();
            if (frmAgregar.Indice == 0)
            {
                MessageBox.Show("No Hay Contactos Cargados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                for (int i = 0; i < frmAgregar.Indice; i++)
                {
                    lstContactosBorrar.Items.Add(frmAgregar.vecContactos[i].Nombre);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = lstContactosBorrar.SelectedIndex;

            if (i < 0)
            {
                MessageBox.Show("Por Favor, Seleccione un Contacto para Eliminar.");
                return;
            }

            DialogResult Resultado = MessageBox.Show
            (
                "¿Seguro que Desea Borrar Este Contacto?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (Resultado == DialogResult.Yes)
            {
                for (int j = i; j < frmAgregar.Indice - 1; j++)
                {
                    frmAgregar.vecContactos[j] = frmAgregar.vecContactos[j + 1];
                }
                frmAgregar.Indice--;
                lstContactosBorrar.Items.RemoveAt(i); 
                MessageBox.Show("Contacto Eliminado Correctamente","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
