using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1BastidasReinaKen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //S= (2x5!) + (2^2x 4!) + (2^3x 3!) + (2^4x2!) + (2^5 x 1!)
            int number = int.Parse(this.txtInicial.Text);
            int s = int.Parse(this.txtFinal.Text);
            double cad = Examen.Formula.Formu(number, s);
            this.txtResultado.Text = cad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.txtLimit.Text);
            long cad = Facto.Factori.Serie(number);
            this.txtResulFacto.Text = cad.ToString();
        }
    }
}
