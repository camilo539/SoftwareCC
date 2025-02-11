using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario UsuarioActual;

        public Inicio(Usuario objusuario)
        {

            UsuarioActual = objusuario;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Iblusuario.Text = UsuarioActual.NombreCompleto;
        }

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
