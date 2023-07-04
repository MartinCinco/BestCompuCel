using BestCompuCel.Properties;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AvisoLegal form = new AvisoLegal();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            string rutaInstalacion = System.Reflection.Assembly.GetEntryAssembly().Location;
            string textoRecortado = rutaInstalacion.Substring(0, rutaInstalacion.Length - 16);
            string aviso = textoRecortado + "Properties\\AvisoLegal.txt";
            string fileContent = File.ReadAllText(aviso);
            lbAviso.Text = fileContent;
        }
    }
}
