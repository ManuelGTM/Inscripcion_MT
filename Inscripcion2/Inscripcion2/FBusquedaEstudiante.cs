using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Inscripcion2
{
    public partial class FBusquedaEstudiante : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        
        CNEstudiante cNEstudiante = new CNEstudiante();

        public FBusquedaEstudiante()
        {
            InitializeComponent();
        }

        private void FBusquedaEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FBusquedaEstudiante_Load_1(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidEstudiante = 0;
            MostrarDatos();
            tbBuscar.Focus();
                
        }

        private void FBusquedaEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario! \n Seguro que desea hacerlo?",
                               "Mensaje de SIGEMP",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
                //valosparametro = tbBuscar.Text.Trim();
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if(DGVDatos.CurrentRow != null)
            {
                Program.modificar = true;
                Program.vidEstudiante = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if(indice > 0)
            {
                indice = indice - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if(indice < this.DGVDatos.RowCount-1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if(indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!(e.RowIndex > -1))
            {
                return;
            }
            BAceptar_Click(sender, e);
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNEstudiante.ObtenerEstudiante(valorparametro) != null)
            {
                DGVDatos.DataSource = cNEstudiante.ObtenerEstudiante(valorparametro);
                DGVDatos.Columns[0].Width = 80; //IdEstudiante
                DGVDatos.Columns[1].Width = 200;//Nombre
                DGVDatos.Columns[2].Width = 200;//Apellido
                DGVDatos.Columns[3].Width = 80;//IdTutor
                DGVDatos.Columns[4].Width = 200;//Sexo
                DGVDatos.Columns[5].Width = 200;//FechaNacimiento
                DGVDatos.Columns[6].Width = 225;//Direccion
                DGVDatos.Columns[7].Width = 90;//Direccion
            }
            else
                MessageBox.Show("No se retorno ningun valor!");
                DGVDatos.Refresh();
        }
    
    
    
    }
}
