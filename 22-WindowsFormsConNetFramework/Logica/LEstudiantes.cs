﻿using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Bitmap _imagBitmap;
        private DataGridView _dataGridView;
        //private Librarys librarys;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            image = (PictureBox)objetos[0];
            _imagBitmap = (Bitmap)objetos[1];
            _dataGridView = (DataGridView)objetos[2];
            Restablecer();

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
                                var user = _Estudiante.Where(u => u.email.Equals(listLabel[1].Text)).ToList();
                                if (user.Count.Equals(0))
                                {
                                    Save();
                                }
                                else
                                {
                                    listLabel[1].Text = "Email ya está registrado!";
                                    listLabel[1].ForeColor = Color.Red;
                                    listTextBox[1].Focus();
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

        private void Save()
        {
            BeginTransactionAsync();
            try
            {
                var imageArray = uploadImage.ImageToByte(image.Image);

                //using( var db = new Conexion() ){

                //    db.Insert(new Estudiante()
                //    {
                //        nid = listTextBox[0].Text,
                //        nombre = listTextBox[1].Text,
                //        apellido = listTextBox[2].Text,
                //        email = listTextBox[3].Text,

                //    });
                //}

                _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                    .Value(e => e.nombre, listTextBox[2].Text)
                    .Value(e => e.apellido, listTextBox[3].Text)
                    .Value(e => e.email, listTextBox[1].Text)
                    .Value(e => e.image, imageArray)
                    .Insert();

                //int data = Convert.ToInt16("k");

                CommitTransaction();
                Restablecer();

            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }

        private int _reg_por_pagina = 2, _num_pagina = 1;

        private void BuscarEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;

            if (campo.Equals(""))
            {
                query = _Estudiante.ToList();
            }
            else
            {

            }


        }

        private void Restablecer()
        {
            image.Image = _imagBitmap;
            listLabel[0].Text = "N° id";
            listLabel[1].Text = "Email";
            listLabel[2].Text = "Nombre";
            listLabel[3].Text = "Apellido";

            listLabel[0].ForeColor = Color.SteelBlue;
            listLabel[1].ForeColor = Color.SteelBlue;
            listLabel[2].ForeColor = Color.SteelBlue;
            listLabel[3].ForeColor = Color.SteelBlue;

            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";

        }

    }
}
