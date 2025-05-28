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
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void Most_Click(object sender, EventArgs e)
        {
            listaautos.DataSource = acc.MostrarAutos();
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            if (acc.ExportarExcel())
            {
                MessageBox.Show("Exportando con exito...");
                listaautos.DataSource = null;

            }
            else
            {
                MessageBox.Show("Fallo el exportado...");
            }
        }


        private void Imp_Click(object sender, EventArgs e)
        {
            if (acc.Importar())
            {
                MessageBox.Show("Importando...");
                listaautos.DataSource = null;


            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            int ID2 = Convert.ToInt32(id.Text);
            int anio2 = Convert.ToInt32(anio.Text);
            double precio2 = Convert.ToDouble(precio.Text);

            if (acc.Agregar(ID2, marca.Text, modelo.Text, anio2, color.Text, precio2, estado.Text))
            {
                MessageBox.Show("Agregado con éxito");
                listaautos.DataSource = null;

            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void Elim_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id.Text);
            if (acc.Eliminar(ID))
            {
                MessageBox.Show("Eliminado con éxito");
                listaautos.DataSource = null;
                // Refrescar el DataGridView
            }
            else
            {
                MessageBox.Show("No se encontró el auto con ese ID");
            }
        }

        private void Act_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id.Text);
            int Anio = Convert.ToInt32(anio.Text);
            double Precio = Convert.ToDouble(precio.Text);


            if (acc.Actualizar(ID, marca.Text, modelo.Text, Anio, color.Text, Precio, estado.Text))
            {
                MessageBox.Show("Actualizado con exito");
                listaautos.DataSource = null;


            }
            else
            {
                MessageBox.Show("fallo en actualizar");
            }
        }

        private void limp_Click(object sender, EventArgs e)
        {
            id.Text = "";
            marca.Text = "";
            modelo.Text = "";
            anio.Text = "";
            color.Text = "";
            precio.Text = "";
            estado.Text = "";

        }

        private void elem_Click(object sender, EventArgs e)
        {
            listaautos.DataSource = acc.TotalElementos();

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            acc.TotalSuma();
            
        }
    }
}
