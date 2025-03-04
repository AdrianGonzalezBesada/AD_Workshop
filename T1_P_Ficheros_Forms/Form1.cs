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

namespace T1_P_Ficheros_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string rutaFichero = "log.txt";

        private void btnInerstarTexto_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;

            // Crea o sobreescribe el fichero en caso de existir
            //fichero = File.CreateText("log.txt");

            // Continua escribiendo o crea el fichero en caso de no existir
            fichero = File.AppendText("log.txt");

            fichero.WriteLine(txtInsertarTexto.Text);
            fichero.Close();
            txtInsertarTexto.Clear();
        }

        private void btnMostrarTexto_Click(object sender, EventArgs e)
        {
            StreamReader fichero;

            fichero = File.OpenText(rutaFichero);
            txtMostrarTexto.Text = fichero.ReadToEnd();
            fichero.Close();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            string contenidoFichero = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaFichero = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        contenidoFichero = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(contenidoFichero, "Fichero: " + rutaFichero, MessageBoxButtons.OK);

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {

            string directorio = @"alumnos";

            if (!existFile(directorio))
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("El fichero no existe, desea crearlo?", "ATENCION", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    Directory.CreateDirectory(directorio);
                }

            }

            if (existFile(directorio))
            {
                string nombreCompleto = $"{txtNombreAlumno.Text} {txtApellidoAlumno.Text}";

                using (StreamWriter fichero = new StreamWriter(directorio + @"\alumnos.txt", true))
                {
                    fichero.WriteLine(nombreCompleto);
                }
                txtNombreAlumnoCompleto.Text = nombreCompleto;

            }

        }

        public bool existFile(string path)
        {
            return Directory.Exists(path);
        }

        private void btnComprobarDirectorio_Click(object sender, EventArgs e)
        {
            string directorioAComprobar = txtDirecotorioAComprobar.Text;
            DirectoryInfo directorio = new DirectoryInfo(directorioAComprobar);

            if (!directorio.Exists)
            {
                directorio.Create();
            }
            else
            {
                // Toggle para la demostración
                directorio.Delete();
            }


        }

        private void btnMoverDirectorio_Click(object sender, EventArgs e)
        {
            if (txtDirecotorioAComprobar.Text != "")
            {
                string origen = txtDirecotorioAComprobar.Text;
                DirectoryInfo directorioOrigen = new DirectoryInfo(origen);

                if (directorioOrigen.Exists)
                {
                    string destino = txtMoverDirectorio.Text;
                    if (destino != "")
                    {
                        destino = $"{destino}\\{directorioOrigen.Name}";
                    }
                    else
                    {
                        destino = directorioOrigen.Name;
                    }

                    Directory.Move(directorioOrigen.FullName, destino);

                    //var files = Directory.EnumerateFiles("");
                }
            }


        }

        private void btnMostrarArchivos_Click(object sender, EventArgs e)
        {
            string[] archivosEnDirectorio = Directory.GetFiles(".");

            foreach(string archivo in archivosEnDirectorio)
            {
                txtArchivosEnDirectorio.Text += Path.GetFileName(archivo) + "\n";
            }
        }
    }
}
