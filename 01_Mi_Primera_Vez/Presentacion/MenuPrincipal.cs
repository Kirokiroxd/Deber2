using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Método para cargar el formulario de Personal
        private void btnPerosnal_Click(object sender, EventArgs e)
        {
            // Verificar si el control ya está cargado
            if (PanelGeneral.Controls.OfType<CUPersonal>().FirstOrDefault() == null)
            {
                CUPersonal frmPrueba = new CUPersonal();
                PanelGeneral.Controls.Clear();
                frmPrueba.Dock = DockStyle.Fill;
                PanelGeneral.Controls.Add(frmPrueba);
            }
        }

        // Método para cargar el formulario de Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Si el control de Usuarios no está cargado, lo creamos e insertamos
            if (PanelGeneral.Controls.OfType<CUPersonal>().FirstOrDefault() == null)
            {
                CUPersonal frmUsuarios = new CUPersonal();
                PanelGeneral.Controls.Clear();
                frmUsuarios.Dock = DockStyle.Fill;
                PanelGeneral.Controls.Add(frmUsuarios);
            }
        }
    }

}
