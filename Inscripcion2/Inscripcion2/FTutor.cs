using CapaNegocio;
using Sistema_de_inscripcion;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using Inscripcion2;

namespace inscripcion
{
    public partial class FTutor : Form
    {

        public string valorparametro = "", mensaje = ""; 
        
            public FTutor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FTutor_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
        }

        private void FTutor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiaObjetos()
        {
            tbIdTutor.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbCedula.Clear();
            tbTelefono.Clear();
            tbDireccion.Clear();
            CbEstado.SelectedItem = 0;
        }

        public void HabilitaControles(bool valor)
        {
            tbIdTutor.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbCedula.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbDireccion.Enabled = valor;
            CbEstado.Enabled = valor;

            if (Program.nuevo)
                CbEstado.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FBusquedaTutor fBuscarTutor = new FBusquedaTutor();
            fBuscarTutor.ShowDialog();
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
            string vparametro = Program.vidTutor.ToString();
            CNTutor cnTutor = new CNTutor();
            DataTable dt = new DataTable();
            dt = cnTutor.ObtenerTutor(vparametro);

            foreach(DataRow row in dt.Rows)
            {
                tbIdTutor.Text = row["IdTutor"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellidos"].ToString();
                tbCedula.Text = row["Cedula"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                CbEstado.Text = row["Estado"].ToString();
            }
        }


        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbIdTutor.Focus();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
                 if (tbNombre.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar el nombre del Tutor");
                        tbNombre.Focus();
                    }
                    else
             if (tbApellido.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar el apellido del Tutor");
                        tbApellido.Focus();
                    }
                    else
            if (tbCedula.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar la cedula del Tutor");
                        tbCedula.Focus();
                    }
                    else
             if (tbTelefono.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar el telefono del Tutor");
                        tbTelefono.Focus();
                    }
                    else
            if (tbDireccion.Text == String.Empty)
                    {
                        MessageBox.Show("Debe indicar la direccion del Tutor");
                        tbDireccion.Focus();
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
                    mensaje = CNTutor.InsertarTutor(tbNombre.Text, tbApellido.Text, tbCedula.Text, tbTelefono.Text, tbDireccion.Text, CbEstado.Text);
                    MessageBox.Show("Los datos han sido insertados");
                }
                else
                {
                    mensaje = CNTutor.ActualizarTutor(Program.vidTutor,tbNombre.Text, tbApellido.Text, tbCedula.Text, tbTelefono.Text, tbDireccion.Text, CbEstado.Text);
                    MessageBox.Show("Los datos han sido actualizados");
                }
                
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
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


    }
}
