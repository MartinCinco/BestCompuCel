using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BestCompuCel.Formularios
{
    public partial class AvisoLegal : Form
    {
        public AvisoLegal()
        {
            InitializeComponent();
        }

        private void AvisoLegal_FormClosing(object sender, FormClosingEventArgs e)
        {

            string rutaInstalacion = System.Reflection.Assembly.GetEntryAssembly().Location;
            string textoRecortado = rutaInstalacion.Substring(0, rutaInstalacion.Length - 16);
            string aviso = textoRecortado + "Properties\\AvisoLegal.txt";
            

            string filePath = aviso; // Ruta y nombre de archivo seleccionados
            string content = textBox1.Text; // Contenido del TextBox

            File.WriteAllText(filePath, content);
        }
    }
}
