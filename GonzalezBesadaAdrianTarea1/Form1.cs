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

namespace GonzalezBesadaAdrianTarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _ficheroPredeterminado = "ficheroAGuardar.txt";

        string _ficheroAModificar = string.Empty;

        string _estructuraDirectorios1 = @"\CARPETA_MONTECASTELO\DAM\ACCESO_DATOS";

        List<string> _estructuraFicheros1 = new List<string>()
        {
            "FICHERO1.TXT",
            "FICHERO2.TXT"
        };

        string _estructuraDirectorios2 = @"\CARPETA_MONTECASTELO\DAM\PROYECTO";

        List<string> _estructuraFicheros2 = new List<string>()
        {
            "ENTREGA1.TXT",
            "ENTREGA FINAL.TXT"
        };

        // IO
        private void EscribirFichero(string ruta, string textoAGuardar, bool isSobreescribir)
        {
            StreamWriter ficheroAGuardar;

            if (isSobreescribir)
            {
                ficheroAGuardar = File.CreateText(ruta);
            }
            else
            {
                ficheroAGuardar = File.AppendText(ruta);
            }

            ficheroAGuardar.WriteLine(textoAGuardar);

            ficheroAGuardar.Close();


        }
        private void LeerFichero(string ruta)
        {
            if (File.Exists(ruta))
            {
                using (StreamReader ficheroALeer = File.OpenText(ruta))
                {
                    txtFicheroALeer.Text = ficheroALeer.ReadToEnd();
                    ficheroALeer.Close();
                }
            }
            else
            {
                MessageBox.Show("El fichero no existe");
            }
        }

        private OpenFileDialog SeleccionarArchivo(string filter)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = @":\";

                if (!string.IsNullOrEmpty(filter))
                {
                    openFile.Filter = filter;
                }

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    return openFile;
                }
            }

            return null;
        }

        private FolderBrowserDialog SeleccionarDirectorio()
        {
            using (FolderBrowserDialog directorio = new FolderBrowserDialog())
            {
                if (directorio.ShowDialog() == DialogResult.OK)
                {
                    return directorio;
                }
            }

            return null;
        }

        private void btnGuardarEnFichero_Click(object sender, EventArgs e)
        {
            string textoAGuardar = txtFicheroAGuardar.Text;

            EscribirFichero(_ficheroPredeterminado, textoAGuardar, false);
            txtFicheroAGuardar.Clear();

            LeerFichero(_ficheroPredeterminado);
        }

        private void btnLeerFichero_Click(object sender, EventArgs e)
        {
            LeerFichero(_ficheroPredeterminado);
        }

        private void btnFicheroAModificar_Click(object sender, EventArgs e)
        {
            string rutaFichero = string.Empty;

            OpenFileDialog openFile = SeleccionarArchivo("txt files (*.txt)|*.txt");

            if (openFile != null)
            {
                _ficheroAModificar = openFile.FileName;

                var ficheroStream = openFile.OpenFile();

                using (StreamReader fichero = new StreamReader(ficheroStream))
                {
                    txtFicheroAModificar.Text = fichero.ReadToEnd();
                }
            }

        }

        private void btnModificarFichero_Click(object sender, EventArgs e)
        {
            EscribirFichero(_ficheroAModificar, txtFicheroAModificar.Text, true);
        }

        private void btnCopiarArchivoA_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivoOrigen = SeleccionarArchivo("txt files (*.txt)|*.txt");

            if (archivoOrigen != null)
            {
                FolderBrowserDialog directorioDestino = SeleccionarDirectorio();

                if (directorioDestino != null)
                {

                    StreamReader ficheroOriginal = new StreamReader(archivoOrigen.OpenFile());

                    string nombreArchivoSinExtension = Path.GetFileNameWithoutExtension(archivoOrigen.FileName);
                    string extension = Path.GetExtension(archivoOrigen.FileName);
                    string nuevoNombre = nombreArchivoSinExtension + "_copia" + extension;

                    EscribirFichero(Path.Combine(directorioDestino.SelectedPath, nuevoNombre), ficheroOriginal.ReadToEnd(), true);

                    MessageBox.Show("Archivo copiado");
                }
            }
        }

        private void btnCargarEstructura_Click(object sender, EventArgs e)
        {
            bool existDDrive = false;
            bool existEDrive = false;

            if (Directory.Exists(@"D:\"))
                existDDrive = true;

            if (Directory.Exists(@"E:\"))
                existEDrive = true;

            if (existDDrive && existEDrive)
            {
                CrearEstructura("D:", _estructuraDirectorios1, _estructuraFicheros1);

                CrearEstructura("E:", _estructuraDirectorios2, _estructuraFicheros2);

                MessageBox.Show("Estructura creada");
            }
            else
            {
                string discoLocal = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
                discoLocal = discoLocal.Substring(0, 2);

                CrearEstructura(discoLocal, _estructuraDirectorios1, _estructuraFicheros1);
                CrearEstructura(discoLocal, _estructuraDirectorios2, _estructuraFicheros2);

                MessageBox.Show("Estructura creada");
            }
        }

        private void CrearEstructura(string disco, string directorios, List<string> ficheros)
        {
            string estructuraDirectorios = disco + directorios;

            if (!Directory.Exists(estructuraDirectorios))
            {
                Directory.CreateDirectory(estructuraDirectorios);

                foreach (string fichero in ficheros)
                {

                    EscribirFichero(Path.Combine(estructuraDirectorios, fichero), "", true);
                }
            }
        }
    }
}
