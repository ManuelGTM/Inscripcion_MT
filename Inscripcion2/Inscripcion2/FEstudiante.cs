using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Inscripcion2
{
    public partial class FEstudiante : Form
    {
        public string valorparametro = "", mensaje = "";
        public FEstudiante()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FEstudiante_FormClosing(object sender, FormClosingEventArgs e)
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

        public void LimpiaObjetos()
        {
            tbIdEstudiante.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbIdTutor.Clear();
            tbSexo.Clear();
            tbFechaNacimiento.Clear();
            tbDireccion.Clear();
            CbEstado.SelectedItem = 0;
        }

        public void HabilitaControles(bool valor)
        {
            tbIdEstudiante.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbIdTutor.Enabled = valor;
            tbSexo.Enabled = valor;
            tbFechaNacimiento.Enabled = valor;
            tbDireccion.Enabled = valor;
            CbEstado.Enabled = valor;

            if (Program.nuevo)
                CbEstado.SelectedIndex = 0;
        }

        private void FEstudiante_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
           HabilitaBotones();

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

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (!tbIdTutor.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbIdEstudiante.Focus();

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vidTutor.ToString();
            CNEstudiante cnEstudiante = new CNEstudiante();
            DataTable dt = new DataTable();
            dt = cnEstudiante.ObtenerEstudiante(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbIdEstudiante.Text = row["IdEstudiante"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbIdTutor.Text = row["IdTutor"].ToString();
                tbSexo.Text = row["Sexo"].ToString();
                tbFechaNacimiento.Text = row["FechaNacimiento"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                CbEstado.Text = row["Estado"].ToString();
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

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Estudiante");
                tbNombre.Focus();
            }
            else
            if (tbApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido del Estudiante");
                tbApellido.Focus();
            }
            else
           if (tbIdTutor.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Id del Estudiante");
                tbIdTutor.Focus();
            }
            else 
            if (tbSexo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el sexo del Estudiante");
                tbSexo.Focus();
            }
            else
            if (tbFechaNacimiento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la fecha de nacimiento del Estudiante");
                tbFechaNacimiento.Focus();
            }
            else
           if (tbDireccion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la direccion del Estudiante");
                tbDireccion.Focus();
            }
            else
            if (CbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el estado del Estudiante");
                CbEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    
                   try
                    {
                      int Tutor = Convert.ToInt32(tbIdTutor.Text.ToString());
                      mensaje = CNEstudiante.InsertarEstudiante(tbNombre.Text, tbApellido.Text, Tutor, tbSexo.Text,tbFechaNacimiento.Text, tbDireccion.Text, CbEstado.Text);
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
                      int Tutor = Convert.ToInt32(tbIdTutor.Text.ToString());
                      mensaje = CNEstudiante.ActualizarEstudiante(Program.vidEstudiante, tbNombre.Text, tbApellido.Text, Tutor, tbSexo.Text, tbFechaNacimiento.Text, tbDireccion.Text, CbEstado.Text);
                      MessageBox.Show("Los datos han sido actualizados");
                    }catch(Exception)
                    {
                        MessageBox.Show("Error:");
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
