using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryFileForEver
{
    public partial class leerJSON : Form
    {
        public leerJSON()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Fichero JSON (*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaJson.Text = openFile.FileName;
            }
        }
    }
}
