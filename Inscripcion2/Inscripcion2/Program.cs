using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Sistema_de_inscripcion;

namespace Inscripcion2
{
    public static class Program
    {
        public static int vidEstudiante = 0;
        public static int vidEmpleado = 0;
        public static int vidTutor = 0;
        public static bool nuevo = false;
        public static bool modificar = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMenu());
        }
    }
}
