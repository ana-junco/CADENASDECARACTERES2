using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADENASDECARACTERES2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int conteo = 0, i = 0;
            string palabras = txtCadena.Text;
            while (palabras[i] == ' ')
                i++;
            if (palabras[i] == '.')
                conteo--;
            while (palabras[i] != ' ')
            {
             
                    if (palabras[i] == ' ')
                {
                    conteo++;
                    while (palabras[i] == ' ') i++;
                    if (palabras[i] == '.') conteo++;
                }
                else
                {
                    i++;
                }
            }
            conteo++;
            Console.WriteLine($"{0}", conteo);
            this.txtRes.Text = conteo.ToString();
        }
    }
}
