using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_WindowsFormsConNetFramework
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante;
        //private Librarys librarys;

        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNid);
            listTextBox.Add(textBoxEmail);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);

            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelEmail);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelPaginas);

            Object[] objetos = {
                pictureBoxImage,
                Properties.Resources.logo,
                dataGridViewEstudiantes,
                numericUpDown1
            };

            estudiante = new LEstudiantes(listTextBox, listLabel, objetos);
            //librarys = new Librarys();

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadImage.CargarImagen(pictureBoxImage);

        }

        private void TextBoxNid_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "N° id";
            }
        }

        private void TextBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.NumberKeyPress(e);
        }
        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.TextKeyPress(e);
        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.TextKeyPress(e);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar(); 
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            estudiante.BuscarEstudiante(textBoxBuscar.Text);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            estudiante.Paginador("Ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiante.RegistroPaginas();
        }
    }
}
