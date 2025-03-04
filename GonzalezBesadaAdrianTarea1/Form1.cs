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

            txtFicheroAGuardar.Clear();

            LeerFichero(ruta);
        }
        private void LeerFichero(string ruta)
        {
            using (StreamReader ficheroALeer = File.OpenText(ruta))
            {
                txtFicheroALeer.Text = ficheroALeer.ReadToEnd();
                ficheroALeer.Close();
            }

        }

        private OpenFileDialog SeleccionarArchivo(string filter)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = @":\";

                if(!string.IsNullOrEmpty(filter))
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
                    
                }
            }
        }
    }
}
