using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExibirVerificadorCpfCnpj()
        {
            FormValidadorCpfCnpj frm = new FormValidadorCpfCnpj();

            frm.ShowDialog();
        }

        private void ExibirCalculadoraSimples()
        {
            FormCalculadoraSimples frm = new FormCalculadoraSimples();

            frm.ShowDialog();
        }

        private void on_Click(object sender, EventArgs e)
        {
            if (sender == sairToolStripMenuItem)
                Close();
            else if (sender == verificadorCPFOuCNPJToolStripMenuItem)
                ExibirVerificadorCpfCnpj();
            else if (sender == calculadoraSimplesToolStripMenuItem)
                ExibirCalculadoraSimples();
            else
                MessageBox.Show("Opção não configurada!!!");
        }
    }
}
