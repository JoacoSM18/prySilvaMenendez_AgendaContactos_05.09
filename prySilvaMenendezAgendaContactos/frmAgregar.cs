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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        int Indice = 0;
        struct Contacto
        {
            public string Nombre;
            public string Numero;
            public string Categoria;
        }
        Contacto[] vecContactos = new Contacto [100];
        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || mskNumero.Text == "" || lstCategoria.Text == "")
            {
                MessageBox.Show("Datos Incompleto, Por Favor Complete Todos Los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                vecContactos[Indice].Nombre = txtNombre.Text;
                vecContactos[Indice].Numero = mskNumero.Text;
                vecContactos[Indice].Categoria = lstCategoria.Text;
                MessageBox.Show("Contacto Agregado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                mskNumero.Text = "";
                lstCategoria.SelectedIndex = -1;
            }
        }

        private void mskNumero_Click(object sender, EventArgs e)
        {
            mskNumero.Select(0, 0);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
