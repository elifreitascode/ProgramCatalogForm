using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsBD.DAL;
using WinFormsBD.Entities;

namespace WinFormsBD
{
    public partial class Form1 : Form
    {
        //private int Desconectado = 0;
        //private int Conectado = 1;
        public Form1()
        {
            InitializeComponent();
            //button1.Tag = 0;
            //button1.Text = "Conectar";
        }

        private CAgendaLista ObterAgendaLista()
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
                            registro.Telefone = reader["telefones"].ToString();
                            registro.Email = reader["email"].ToString();

                            lista.Adicionar(registro);

                        }
                    }
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CConexaoDao.Desconectar();
            }

            return lista;

        }

        private  void InserirAgenda(CAgenda registro)
        {
            try
            {
                CConexaoDao.Conectar();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = CConexaoDao.GetConnection();
                    command.CommandText = "insert into tb_agenda (nome, apelido, nascimento, telefones, email) " +
                        "values (@p01, @p02, @p03, @p04, @p05)";

                    command.Parameters.AddWithValue("@p01", registro.Nome);
                    command.Parameters.AddWithValue("@p02", registro.Apelido);
                    command.Parameters.AddWithValue("@p03", registro.Nascimento);
                    command.Parameters.AddWithValue("@p04", registro.Telefone);
                    command.Parameters.AddWithValue("@p05", registro.Email);

                    command.ExecuteNonQuery();
                    


                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                CConexaoDao.Desconectar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            try
            {
                CAgendaLista lista = ObterAgendaLista();

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Código", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Apelido", typeof(string));
                dataTable.Columns.Add("Data de nascimento", typeof(DateTime));
                dataTable.Columns.Add("Telefones", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));

                foreach(CAgenda registro in lista.GetLista())
                {
                    dataTable.Rows.Add(registro.Codigo, 
                        registro.Nome, 
                        registro.Apelido,
                        registro.Nascimento, 
                        registro.Telefone, 
                        registro.Email);
                }

                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CConexaoDao.Desconectar();
            }

            //listBox1.Items.Clear();
            //foreach (CAgenda item in lista.GetLista())
            //{
                //listBox1.Items.Add(item.ToString());
            //}
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
                dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2())
            {
                form.ShowDialog();

                if (form.Confirmou)
                    InserirAgenda(form.Registro);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form3 form = new Form3())
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                form.Registro.Codigo = r
                form.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Form4 form = new Form4())
            {
                form.ShowDialog();
            }
        }
    }
}
