using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_TourOperador
{
    public partial class MVP_CATALOGO_EXCURSIONES : Form
    {
        public MVP_CATALOGO_EXCURSIONES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?","Supreme Safari ?" , MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?", "Santo Domingo City Tour?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?", "Dolphin Explorer?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?", "Samana Cayo Levantado?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?", "Saona Island?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas realizar una reserva para esta excursion?", "Diving Adventure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MVP_REGISTRO Registro = new MVP_REGISTRO();
                Registro.ShowDialog();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Por Favor, Continue Explorando las Excursiones disponibles", "Esta Bien");

            }
        }
    }
}
