using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Por favor selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Marjorie\Desktop\Ejercicio27Lista";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultado.Text = resultado;
            }
        }
    }
}
