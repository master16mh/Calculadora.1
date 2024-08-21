using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.FE_front_end_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Oper1; 
            int Oper2;
            int Resultado;
            Oper1 = Convert.ToInt32(txtOper1.Text);
            Oper2 = Convert.ToInt32(txtOper2.Text);

            Resultado = Oper1 + Oper2;

            txtResultado.Text = Resultado.ToString();
        }
    }
}
