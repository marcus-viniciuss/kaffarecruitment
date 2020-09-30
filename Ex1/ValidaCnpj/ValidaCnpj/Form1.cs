using System;
using System.Windows.Forms;

namespace ValidaCnpj
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

        private void mskCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}