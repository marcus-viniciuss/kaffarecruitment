using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidateCnpjDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (Valida.ValdacaoCNPJ.Cnpj(mskCNPJ.Text))

                MessageBox.Show("CNPJ Válido!");
            else
                MessageBox.Show("CNPJ Inválido!");

            mskCNPJ.Text = "";
        }
    }
}
