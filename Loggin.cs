using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordinario
{
    public partial class Loggin : Form
    {
        Usuarios casa = new Usuarios();
        public Loggin()
        {
            InitializeComponent();
        }

        private void Usua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ing_Click(object sender, EventArgs e)
        {
            string user = Usua.Text;
            string Password = Contra.Text;

            var lista = casa.ObtenerUsuario();
            var valida = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contrasenia == Password);
            if (valida != null)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Ora");
            }
        }
    }
}
