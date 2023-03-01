using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Cep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            CEP_CorreioService(txtCep.Text);
        }

        private void CEP_CorreioService(String CEP)
        {
            CorreiosRef.AtendeClienteClient correios = new CorreiosRef.AtendeClienteClient();
            CorreiosRef.enderecoERP consulta = correios.consultaCEP(CEP);

            if (consulta != null)
            {
                txtRua.Text = consulta.end;
                txtBairro.Text = consulta.bairro;
                txtCidade.Text = consulta.cidade;
                txtEstado.Text = consulta.uf;

                txtNumero.Focus();

            }
            else
            {
                MessageBox.Show("Cep não encontrado!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCep_Leave_1(object sender, EventArgs e)
        {
            CEP_CorreioService(txtCep.Text);
        }
    }
}
