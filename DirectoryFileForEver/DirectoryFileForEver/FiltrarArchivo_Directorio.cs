﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DirectoryFileForEver
{
    public partial class FiltrarArchivo_Directorio : Form
    {
        public string filtro { get; set; }
        public DateTime fecha;

        public FiltrarArchivo_Directorio()
        {
            InitializeComponent();
        }

        public FiltrarArchivo_Directorio(string filtrar)
        {
            InitializeComponent();
            filtro = filtrar;
            if (filtro.Equals("Todo"))
            {
                radioButtonTodo.Checked = true;
            }

            comprobarFiltro();
        }


        private void comprobarFiltro()
        {
            dateTimePicker1.Enabled = false;
            if (radioButtonArchivos.Checked)
            {
                filtro = radioButtonArchivos.Text;
            }
            else if (radioButtonDirectorios.Checked)
            {
                filtro = radioButtonDirectorios.Text;
            }
            else
            {
                filtro = radioButtonTodo.Text;
            }

            if (checkBoxDT.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void radioButtonTodo_CheckedChanged(object sender, EventArgs e)
        {
            comprobarFiltro();
        }

        private void radioButtonArchivos_CheckedChanged(object sender, EventArgs e)
        {
            comprobarFiltro();
        }

        private void radioButtonDirectorios_CheckedChanged(object sender, EventArgs e)
        {
            comprobarFiltro();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            fecha = dateTimePicker1.Value;

        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtro aplicado correctamente");
            this.Close();
        }

        private void checkBoxDT_CheckedChanged(object sender, EventArgs e)
        {
            comprobarFiltro();
        }
    }
}
