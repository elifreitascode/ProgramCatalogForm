using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TDS_DS_Library;

namespace WinForms
{
    public partial class FormValidadorCpfCnpj : Form
    {
        public FormValidadorCpfCnpj()
        {
            InitializeComponent();
        }

        private CDocument InstanciarDocument()
        {
            if (textBox1.Text.Length == 11)
                return new TCPF(textBox1.Text);

            else if (textBox1.Text.Length == 14)
                return new TCPF(textBox1.Text);

            else
                throw new Exception("Documento inválido...");
        }


        private void on_Click(object sender, EventArgs e)
        {
            CDocument doc = InstanciarDocument();

            labelTypeDocument.Text = doc.GetQuemEuSou();
           
        }
    }
}
