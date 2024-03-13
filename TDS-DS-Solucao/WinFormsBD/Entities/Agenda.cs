using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBD.Entities
{
    public class CAgenda
    {
        private int codigo;
        private string nome;
        private string apelido;
        private DateTime nascimento;
        private string telefone;
        private string email;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return codigo.ToString() + "|"+
                nome + "|" +
                apelido + "|" +
                nascimento.ToString("dd/MM/yyyy") + "|" +
                telefone + "|" +
                email;
        }
    }

    public class CAgendaLista
    {
        private List<CAgenda> lista = new List<CAgenda>();

        public void Adicionar(CAgenda item)
        {
            lista.Add(item);
        }

        public List<CAgenda> GetLista()
        {
            return lista;
        }

    }
}
