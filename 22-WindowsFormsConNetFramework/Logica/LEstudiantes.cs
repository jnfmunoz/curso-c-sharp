using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Logica
{
    public class LEstudiantes : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        //private Librarys librarys;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            image = (PictureBox)objetos[0];
            
            //librarys = new Librarys();
        }

        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El campo id es requerido";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            } 
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El campo email es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El campo nombre es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El campo apellido es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                        else
                        {
                            if (textBoxEvent.ComprobarFormatoEmail(listTextBox[1].Text))
                            {
                                BeginTransactionAsync();
                                try
                                {
                                    var imageArray = uploadImage.ImageToByte(image.Image);

                                    _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                                        .Value(e => e.nombre, listTextBox[1].Text)
                                        .Value(e => e.apellido, listTextBox[2].Text)
                                        .Value(e => e.email, listTextBox[3].Text)
                                        .Value(e => e.image, imageArray)
                                        .Insert();

                                    //using( var db = new Conexion() ){

                                    //    db.Insert(new Estudiante()
                                    //    {
                                    //        nid = listTextBox[0].Text,
                                    //        nombre = listTextBox[1].Text,
                                    //        apellido = listTextBox[2].Text,
                                    //        email = listTextBox[3].Text,

                                    //    });
                                    //}

                                }
                                catch (Exception)
                                {
                                    throw;
                                }                                                               

                            }
                            else
                            {
                                listLabel[1].Text = "Email no válido";
                                listLabel[1].ForeColor = Color.Red;
                                listTextBox[1].Focus();
                            }
                        }

                    }
                }
            }
        }

    }
}
