using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryFileForEver
{
    public partial class pantallaAgregar : Form
    {
        DirectoryInfo datos;

        public pantallaAgregar(DirectoryInfo datos)
        {
            this.datos = datos;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Equals(""))
            {
                if (radioButton1.Checked)//directorio
                {
                    Directory.CreateDirectory(textBox2.Text + "\\" + textBox1.Text);
                }
                else //file
                {
                    File.Create(textBox2.Text + "\\" + textBox1.Text);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede crear un Fichero/Directorio vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pantallaAgregar_Load(object sender, EventArgs e)
        {
            textBox2.Text = datos.FullName;
        }
    }
}
