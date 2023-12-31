﻿using System;
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
    public partial class FConsutarUsuario : Form
    { 
        
        public int visuplidor = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNUsuario cNUsuario = new CNUsuario();

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

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FConsutarUsuario_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidUsuario = 0;
            MostrarDatos();
            tbBuscar.Focus();

        }

        public FConsutarUsuario()
        {
            InitializeComponent();
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
        {
           if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }
            MostrarDatos(); //Se llama al método MostrarDatos
            tbBuscar.Focus(); //Se le pasa el cursos al textbox

        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if(DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index;
        }

        private void FConsutarUsuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }
        
        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNUsuario.ObtenerUsuario(valorparametro) != null)
            {
                DGVDatos.DataSource = cNUsuario.ObtenerUsuario(valorparametro);
                DGVDatos.Columns[0].Width = 150; //IdTutor
                DGVDatos.Columns[1].Width = 179; //Nombre
                DGVDatos.Columns[2].Width = 150; //Apellido
                DGVDatos.Columns[3].Width = 100; //Telefono
                DGVDatos.Columns[4].Width = 150; //Estado
            }
            else
                MessageBox.Show("No se retorno ningun valor!");
                DGVDatos.Refresh();
            LCantTutor.Text = Convert.ToString(DGVDatos.RowCount - 1);
            if(DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun dato que mostrar!");
            }

        }

    }
}
