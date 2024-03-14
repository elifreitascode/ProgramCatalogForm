using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsBD.Entities;

namespace WinFormsBD
{
    public partial class Form2 : Form
    {
        private bool confirmou = false;
        private CAgenda registro = null;

        public Form2()
        {
            InitializeComponent();
            maskedTextBox1.Text = DateTime.Today.ToString("dd/MM/yyyy");    
        }


        public bool Confirmou { get => confirmou;}
        public CAgenda Registro { get => registro; set => registro = value; }
        private DateTime GetNascimentoAsDateTime()
        {
            int dia = Convert.ToInt32(maskedTextBox1.Text.Substring(0,2));
            int mes = Convert.ToInt32(maskedTextBox1.Text.Substring(3, 2));
            int ano = Convert.ToInt32(maskedTextBox1.Text.Substring(6, 4));

            return new DateTime(ano, mes, dia);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro = new CAgenda()
            {
                Codigo = -1,
                Nome = textBox3.Text,
                Apelido = textBox5.Text,
                Nascimento = GetNascimentoAsDateTime(),
                Telefone = textBox2.Text,
                Email = textBox6.Text
            };

            confirmou = true;
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
