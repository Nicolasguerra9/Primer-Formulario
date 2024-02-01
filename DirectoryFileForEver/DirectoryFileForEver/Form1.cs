using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DirectoryFileForEver
{
    public partial class Form1 : Form
    {
        DirectoryInfo directorioSeleccionado;
        BindingList<DirectoriosFicheros> Directorio = new BindingList<DirectoriosFicheros>();
        BindingList<DirectoriosFicheros> ListaDirectorio = new BindingList<DirectoriosFicheros>();
        BindingList<DirectoriosFicheros> ListaFichero = new BindingList<DirectoriosFicheros>();
        BindingList<DirectoriosFicheros> Datos = new BindingList<DirectoriosFicheros>();


        public Form1()
        {
            InitializeComponent();
        }
        

        public void update()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Directorio;
        }
        public void updateListaDirectorio()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaDirectorio;
        }
        public void updateListaFichero()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaFichero;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                textBoxRutaFiles.Text = folder.SelectedPath;
                directorioSeleccionado = new DirectoryInfo(textBoxRutaFiles.Text);
                obtenerDirectorios();
                obtenerFicheros();
                update(); 
            }



        }


        public void obtenerFicheros (){
            
            foreach (FileInfo fichero in directorioSeleccionado.GetFiles())
            {
                DirectoriosFicheros dirFich = new DirectoriosFicheros();
                dirFich.Name = Path.GetFileNameWithoutExtension(fichero.FullName);
                dirFich.Tipo = fichero.Extension;
                dirFich.creationDate = fichero.CreationTime;
                dirFich.ultimaModificacion = fichero.LastAccessTime;
                dirFich.FullName = fichero.FullName;

                Directorio.Add(dirFich);
                ListaFichero.Add(dirFich);

            }
        }

        public void obtenerDirectorios()
        {
            Directorio.Clear();
            ListaDirectorio.Clear();
            ListaFichero.Clear();
            foreach (DirectoryInfo fichero in directorioSeleccionado.GetDirectories())
            {
                DirectoriosFicheros dirFich = new DirectoriosFicheros();
                dirFich.Name = fichero.Name;
                dirFich.Tipo = "Directorio";
                dirFich.creationDate = fichero.CreationTime;
                dirFich.ultimaModificacion = fichero.LastAccessTime;
                dirFich.FullName = fichero.FullName;


                Directorio.Add(dirFich);
                ListaDirectorio.Add(dirFich);

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            pantallaAgregar f = new pantallaAgregar(directorioSeleccionado);
            f.ShowDialog();
            update();
            obtenerDirectorios();
            obtenerFicheros();
            ordenarTodo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoriosFicheros directoriosficheros = (DirectoriosFicheros)dataGridView1.CurrentRow.DataBoundItem;
            pantallaModificar f = new pantallaModificar(directorioSeleccionado, directoriosficheros);
            f.ShowDialog();
            update();
            obtenerDirectorios();
            obtenerFicheros();
            ordenarTodo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Ficheros JSON (*.json) | *.json";

            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaFiles.Text = openFile.FileName;

                JArray jarrayDirFich = JArray.Parse(File.ReadAllText(textBoxRutaFiles.Text, Encoding.UTF8));

                Datos = jarrayDirFich.ToObject<BindingList<DirectoriosFicheros>>();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Datos;
            }






           /* OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "Fichero JSON (*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaFiles.Text = openFile.FileName;
                JArray jarrayJson = JArray.Parse(File.ReadAllText(textBoxRutaFiles.Text, Encoding.Default));
                Datos = jarrayJson.ToObject<BindingList<DirectoriosFicheros>>();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Datos;

            }*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // escribirJSON f = new escribirJSON();
            //f.ShowDialog();

            JArray jarrayDirFich = (JArray)JToken.FromObject(Datos);

            File.WriteAllText(@"..\..\JSON\dirFich.json", jarrayDirFich.ToString());

        }

        private void textBoxRutaFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ordenarTodo();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ordenarTodo();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ordenarTodo();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ordenarTodo();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ordenarTodo();
        }

        public void ordenarTodo()
        {
            if (radioButton6.Checked)
            {
                if (radioButton1.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderBy(x => x.Name).ToList());

                }
                else if (radioButton2.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderBy(x => x.creationDate).ToList());

                }
                else if (radioButton3.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderBy(x => x.Tipo).ToList());

                }
            }else if (radioButton5.Checked)
            {
                if (radioButton1.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderByDescending(x => x.Name).ToList());

                }
                else if (radioButton2.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderByDescending(x => x.creationDate).ToList());

                }
                else if (radioButton3.Checked)
                {
                    Directorio = new BindingList<DirectoriosFicheros>(Directorio.OrderByDescending(x => x.Tipo).ToList());

                }
            }
            update();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DirectoriosFicheros directoriosficheros = (DirectoriosFicheros)dataGridView1.CurrentRow.DataBoundItem;
            if (directoriosficheros.Tipo.Equals("Directorio"))
            {
                Directory.Delete(directoriosficheros.FullName);
            }
            else
            {
                    File.Delete(directoriosficheros.FullName);
            }
            
            obtenerDirectorios();
            obtenerFicheros();
            ordenarTodo();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            
            
            /*
            filteredList.Clear();
            if (checkBoxFiles.Checked == true)
            {
                //filteredList = new BindingList<DirFich>(DirectoriosFicheros.FindAll(q => q.Tipo.Equals("Fichero")));
                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    if (dirfich.Tipo.Equals("Fichero"))
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;
            }
            if (checkBoxDirectories.Checked == true)
            {
                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    if (dirfich.Tipo.Equals("Directorio"))
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;
            }
            if (checkBoxCreationDate.Checked == true)
            {
                dateTimePickerCreationDateFilter.Enabled = true;

                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    int result = DateTime.Compare(dirfich.DataCreacion, dateTimePickerCreationDateFilter.Value);
                    if (result <= 0)
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;
            }
            if (checkBoxName.Checked == true)
            {
                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    if (dirfich.Nombre.Contains(textBoxNameFilter.Text))
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;
            }
            if (checkBoxSize.Checked == true)
            {
                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    if (dirfich.Tamanyo <= numericUpDownSizeFilter.Value)
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;
            }
            if (checkBoxExtension.Checked == true)
            {
                foreach (DirFich dirfich in DirectoriosFicheros)
                {
                    if (dirfich.Extension.Equals(comboBoxExtensionFilter.SelectedItem.ToString()))
                    {
                        filteredList.Add(dirfich);
                    }
                }
                dataGridViewFilesAndDirectories.DataSource = filteredList;
                filtered = true;

            }*/

            
             if (radioButtonTodo.Checked)
             {
                 Directorio.Clear();
                 obtenerDirectorios();
                 obtenerFicheros();
                 ordenarTodo();
             }
             else if (radioButtonFicheros.Checked)
             {
                 Directorio.Clear();
                 obtenerFicheros();
                 ordenarTodo();
             }
             else if (radioButtonDirectorios.Checked)
             {
                 Directorio.Clear();
                 obtenerDirectorios();
                 ordenarTodo();
             }

             if (checkBoxNombre.Checked)
             {
                 BindingList<DirectoriosFicheros> elementsList = new BindingList<DirectoriosFicheros>();


                     if (textBoxName.Text.Equals(""))
                     {

                         foreach (DirectoriosFicheros el in Directorio)
                         {
                             if (el.Name.Contains(textBoxName.Text))
                             {

                                 elementsList.Add(el);

                             }
                         }

                         if (elementsList.Count > 0)
                         {
                             dataGridView1.DataSource = null;
                             dataGridView1.DataSource = elementsList;
                         }
                         else
                         {
                             MessageBox.Show("No hay ningún directorio/archivo con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                 }
        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {
            textBoxName.Enabled = checkBoxNombre.Checked;
        }

        private void checkBoxCreationDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerCreationDate.Enabled = checkBoxCreationDate.Checked;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonDirectorios_CheckedChanged(object sender, EventArgs e)
        {
            Directorio.Clear();
            ListaDirectorio.Clear();
            ListaFichero.Clear();
            update();
            obtenerDirectorios();
        }

        private void radioButtonFicheros_CheckedChanged(object sender, EventArgs e)
        {
            Directorio.Clear();
            ListaDirectorio.Clear();
            ListaFichero.Clear();
            update();
            obtenerFicheros();
        }

        private void radioButtonTodo_CheckedChanged(object sender, EventArgs e)
        {
            Directorio.Clear();
            ListaDirectorio.Clear();
            ListaFichero.Clear();
            update();
            obtenerDirectorios();
            obtenerFicheros();
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
