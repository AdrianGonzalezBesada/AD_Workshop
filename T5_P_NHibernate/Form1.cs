using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T5_P_NHibernate.Services;

namespace T5_P_NHibernate
{
    public partial class Form1 : Form
    {
        private InstitutoService _institutoService = new InstitutoService();
        private AsignaturaService _asignaturaService = new AsignaturaService();
        private EstudianteService _estudianteService = new EstudianteService();

        public Form1()
        {
            InitializeComponent();
            Configurations.NHibernateUtil.Start();
        }







    }
}
