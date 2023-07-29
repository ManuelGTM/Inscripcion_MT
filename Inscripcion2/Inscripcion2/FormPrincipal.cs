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
using inscripcion;
using Inscripcion2;

namespace Sistema_de_inscripcion
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUsuario FMantUsuario = new FUsuario();
            FMantUsuario.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {

           FTutor fMantTutor = new FTutor();
           fMantTutor.ShowDialog();
        }

        private void porPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porEmpleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            statusStrip1.Items[1].Text = "Fecha/Hora: "+DateTime.Now.ToString();


        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void inscripcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void utilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEstudiante fMantEstudiante = new FEstudiante();
            fMantEstudiante.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void periodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void procesoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosGeneralesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FConsultaTutor fCTutor = new FConsultaTutor();
            fCTutor.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConsultaEstudiante fCEstudiante = new FConsultaEstudiante();
            fCEstudiante.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FConsutarUsuario fCUsuario = new FConsutarUsuario();
            fCUsuario.ShowDialog();

        }
    }
}
