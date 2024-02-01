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
    public partial class pantallaModificar : Form
    {
        DirectoryInfo datos;
        DirectoriosFicheros direc;

        public pantallaModificar(DirectoryInfo datos, DirectoriosFicheros direc)
        {
            this.datos = datos;
            this.direc = direc;
            InitializeComponent();
        }

        private void pantallaModificar_Load(object sender, EventArgs e)
        {
            textBox2.Text = direc.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Equals(""))
            {
                if (direc.Tipo.Equals("Directorio"))
                {
                    Directory.Move(direc.FullName, datos.FullName + "\\" + textBox1.Text);
                }
                else
                {

                    if (direc.Tipo.Equals(""))
                    {
                        File.Move(direc.FullName, datos.FullName + "\\" + textBox1.Text);
                        File.Delete(direc.FullName);
                    }
                    else
                    {
                        File.Move(direc.FullName, datos.FullName + "\\" + textBox1.Text + direc.Tipo);
                        File.Delete(direc.FullName);
                    }
                }
                this.Close();
            }
             else
            {
                MessageBox.Show("No se puede crear un Fichero/Directorio vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
