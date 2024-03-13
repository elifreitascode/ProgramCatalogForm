using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsBD.DAL;
using WinFormsBD.Entities;

namespace WinFormsBD
{
    public partial class Form1 : Form
    {
        private int Desconectado = 0;
        private int Conectado = 1;
        public Form1()
        {
            InitializeComponent();
            button1.Tag = 0;
            button1.Text = "Conectar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAgendaLista lista = new CAgendaLista();   
            try
            {
                CConexaoDao.Conectar();
                //MessageBox.Show("Banco de dados conectado com sucesso");

                using (SqlCommand command = new SqlCommand()) 
                {
                    command.CommandText = "SELECT * FROM tb_agenda";
                    command.Connection = CConexaoDao.GetConnection();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CAgenda registro = new CAgenda();

                            registro.Codigo = Convert.ToInt32(reader["codigo"]);
                            registro.Nome = reader["nome"].ToString();
                            registro.Apelido = reader["apelido"].ToString();
                            registro.Nascimento = Convert.ToDateTime(reader["nascimento"]);
                            registro.Telefone = reader["telefone"].ToString();
                            registro.Email = reader["email"].ToString();

                            lista.Adicionar(registro);

                        }
                    }
                } ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CConexaoDao.Desconectar();
            }

            listBox1.Items.Clear();
            foreach (CAgenda item in lista.GetLista())
            {
                listBox1.Items.Add(item.ToString());
            }
            /*if ((int)button1.Tag == Desconectado)
            {
                CConexaoDao.Conectar();
                button1.Tag = Conectado;
                button1.Text = "Desconectar";
                
            }
            else
            {
                CConexaoDao.Desconectar();
                button1.Tag = Desconectado;
                button1.Text = "Conectar";
            }
            */
        }
    }
}
