using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Inscripcion2
{
    public partial class FUsuario : Form
    {
        public string valorparametro = "", mensaje = ""; 

        public FUsuario()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
             LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbIdUsuario.Focus();

        }

        private void FUsuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FUsuario_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        public void LimpiaObjetos()
        {
            tbIdUsuario.Clear();
            tbUsuario.Clear();
            tbClave.Clear();
            tbNivel.Clear();
            CbEstado.SelectedItem = 0;
        }

        public void HabilitaControles(bool valor)
        {
            tbIdUsuario.ReadOnly = true;
            tbUsuario.Enabled = valor;
            tbClave.Enabled = valor;
            tbNivel.Enabled = valor;
            CbEstado.Enabled = valor;

            if (Program.nuevo)
                CbEstado.SelectedIndex = 0;
        }
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = true;
                BBuscar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                HabilitaControles(true);
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = false;
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();

        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!tbIdUsuario.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento();
            //fBuscarDepto.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos();
                BEditar_Click(sender, e);
            }
            else
            {
                LimpiaObjetos();
                BBuscar.Focus();
            }

        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vidUsuario.ToString();
            CNUsuario cnUsuario = new CNUsuario();
            DataTable dt = new DataTable();
            dt = cnUsuario.ObtenerUsuario(vparametro);

            foreach(DataRow row in dt.Rows)
            {
                tbIdUsuario.Text = row["IdUsuario"].ToString();
                tbUsuario.Text = row["Usuario"].ToString();
                tbClave.Text = row["Clave"].ToString();
                tbNivel.Text = row["Nivel"].ToString();
                CbEstado.Text = row["Estado"].ToString();
            }
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar el nombre del Usuario");
                        tbUsuario.Focus();
                    }
                    else
             if (tbClave.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar la clave del Usuario");
                        tbClave.Focus();
                    }
                    else
            if (tbNivel.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar el nivel del Usuario");
                        tbNivel.Focus();
                    }
                    else
            if (CbEstado.Text == String.Empty)
                    {
                        MessageBox.Show("Debe seleccionar el estado del Tutor");
                        CbEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    try
                    {
                      int Nivel = Convert.ToInt32(tbNivel.Text.ToString());
                      mensaje = CNUsuario.InsertarUsuario(tbUsuario.Text, tbClave.Text, Nivel, CbEstado.Text);
                      MessageBox.Show("Los datos han sido insertados");
                    }catch(Exception)
                    {
                        MessageBox.Show("Error:");
                    }
                }
                else
                {
                    try
                    {
                      int Nivel = Convert.ToInt32(tbNivel.Text.ToString());
                      mensaje = CNUsuario.ActualizarUsuario(Program.vidUsuario, tbUsuario.Text, tbClave.Text, Nivel, CbEstado.Text);
                      MessageBox.Show("Los datos han sido Actualizados");
                    }catch (Exception)
                    {
                        MessageBox.Show("Error");
                    }
                }
                
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }

        }
    }
}
