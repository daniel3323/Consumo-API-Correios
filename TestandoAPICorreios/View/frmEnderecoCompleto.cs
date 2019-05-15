using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestandoAPICorreios.Controller;

namespace TestandoAPICorreios
{
    public partial class Form1 : Form
    {
        ControllerEndereço controllerEndereço = new ControllerEndereço();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtCEP.Text != "")
            {
                txtLogradoudo.Text = controllerEndereço.GetEndereçoCompleto(txtCEP.Text).Logradouro;
                txtBairro.Text = controllerEndereço.GetEndereçoCompleto(txtCEP.Text).Bairro;
                txtCidade.Text = controllerEndereço.GetEndereçoCompleto(txtCEP.Text).Localidade;
                txtUF.Text = controllerEndereço.GetEndereçoCompleto(txtCEP.Text).UF;
                lblIndicePopulacional.Text = controllerEndereço.GetEndereçoCompleto(txtCEP.Text).IndicePopulacional.ToString();

                lblJson.Text = controllerEndereço.GetJsonEndereco(txtCEP.Text);
            }            
        }
    }
}
