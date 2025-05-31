using Logica;
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
        private LEstudiantes estudiante = new LEstudiantes();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.CargarImagen(pictureBoxImage);

        }
    }
}
