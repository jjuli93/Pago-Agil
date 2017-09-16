using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Login;

using PagoAgilFrba.AbmRol;
using PagoAgilFrba.AbmCliente;
using PagoAgilFrba.AbmEmpresa;

namespace PagoAgilFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmABMRol());
            //Application.Run(new FrmABMCliente());
            Application.Run(new FrmABMEmpresa());
        }
    }
}
