
namespace TDS_DS_Library
{
    public abstract class CDocument
    {
        private string numero;
        private string digitoVerificadorCalculado;

        public CDocument() { }

        public CDocument(string nr)
        {
            numero = nr;
            Calcular();
        }

        public string Numero
        {
            get => numero;
            set => numero = value;
        }

        public abstract void Calcular();
        public abstract string GetDigitoVerificadorOriginal();
        public abstract string GetQuemEuSou();
        public abstract bool GetEhValido();

        public int GetModulo11(int soma)
        {
            int resto = soma % 11;

            return resto <= 1 ? 0 : 11 - resto; ;
        }

        internal void SetDigitoVerificadorCalculado(string dvCalc)
        {
            digitoVerificadorCalculado = dvCalc;
        }

        internal string GetDigitoVerificadorCalculado()
        {
            return digitoVerificadorCalculado;
        }
    }

    public class TCPF : CDocument
    {
        public TCPF() { }

        public TCPF(string nr) : base(nr)
        {
        }

        private int GetRound1()
        {
            int soma = 0;

            soma += 10 * int.Parse(Numero.Substring(0, 1));
            soma += 9 * int.Parse(Numero.Substring(1, 1));
            soma += 8 * int.Parse(Numero.Substring(2, 1));
            soma += 7 * int.Parse(Numero.Substring(3, 1));
            soma += 6 * int.Parse(Numero.Substring(4, 1));
            soma += 5 * int.Parse(Numero.Substring(5, 1));
            soma += 4 * int.Parse(Numero.Substring(6, 1));
            soma += 3 * int.Parse(Numero.Substring(7, 1));
            soma += 2 * int.Parse(Numero.Substring(8, 1));

            return soma;
        }

        private int GetRound2(int digito)
        {
            int soma = 0;

            soma += 11 * int.Parse(Numero.Substring(0, 1));
            soma += 10 * int.Parse(Numero.Substring(1, 1));
            soma += 9 * int.Parse(Numero.Substring(2, 1));
            soma += 8 * int.Parse(Numero.Substring(3, 1));
            soma += 7 * int.Parse(Numero.Substring(4, 1));
            soma += 6 * int.Parse(Numero.Substring(5, 1));
            soma += 5 * int.Parse(Numero.Substring(6, 1));
            soma += 4 * int.Parse(Numero.Substring(7, 1));
            soma += 3 * int.Parse(Numero.Substring(8, 1));
            soma += 2 * digito;

            return soma;
        }

        public override void Calcular()
        {
            int dv1 = GetModulo11(GetRound1());
            int dv2 = GetModulo11(GetRound2(dv1));

            SetDigitoVerificadorCalculado($"{dv1}{dv2}");
        }

        public override bool GetEhValido()
        {
            return GetDigitoVerificadorOriginal() == GetDigitoVerificadorCalculado();
        }

        public override string GetDigitoVerificadorOriginal()
        {
            return Numero.Substring(9, 2);
        }

        public override string GetQuemEuSou()
        {
            return "Eu sou CPF!";
        }
    }

    public class TCNPJ : CDocument
    {
        public TCNPJ() { }

        public TCNPJ(string nr) : base(nr)
        {
        }

        private int GetRound1()
        {
            int soma = 0;

            soma += 5 * int.Parse(Numero.Substring(0, 1));
            soma += 4 * int.Parse(Numero.Substring(1, 1));
            soma += 3 * int.Parse(Numero.Substring(2, 1));
            soma += 2 * int.Parse(Numero.Substring(3, 1));
            soma += 9 * int.Parse(Numero.Substring(4, 1));
            soma += 8 * int.Parse(Numero.Substring(5, 1));
            soma += 7 * int.Parse(Numero.Substring(6, 1));
            soma += 6 * int.Parse(Numero.Substring(7, 1));
            soma += 5 * int.Parse(Numero.Substring(8, 1));
            soma += 4 * int.Parse(Numero.Substring(9, 1));
            soma += 3 * int.Parse(Numero.Substring(10, 1));
            soma += 2 * int.Parse(Numero.Substring(11, 1));

            return soma;
        }

        private int GetRound2(int digito)
        {
            int soma = 0;

            soma += 6 * int.Parse(Numero.Substring(0, 1));
            soma += 5 * int.Parse(Numero.Substring(1, 1));
            soma += 4 * int.Parse(Numero.Substring(2, 1));
            soma += 3 * int.Parse(Numero.Substring(3, 1));
            soma += 2 * int.Parse(Numero.Substring(4, 1));
            soma += 9 * int.Parse(Numero.Substring(5, 1));
            soma += 8 * int.Parse(Numero.Substring(6, 1));
            soma += 7 * int.Parse(Numero.Substring(7, 1));
            soma += 6 * int.Parse(Numero.Substring(8, 1));
            soma += 5 * int.Parse(Numero.Substring(9, 1));
            soma += 4 * int.Parse(Numero.Substring(10, 1));
            soma += 3 * int.Parse(Numero.Substring(11, 1));
            soma += 2 * digito;

            return soma;
        }

        public override void Calcular()
        {
            int dv1 = GetModulo11(GetRound1());
            int dv2 = GetModulo11(GetRound2(dv1));

            SetDigitoVerificadorCalculado($"{dv1}{dv2}");
        }

        public override bool GetEhValido()
        {
            return GetDigitoVerificadorOriginal() == GetDigitoVerificadorCalculado();
        }

        public override string GetDigitoVerificadorOriginal()
        {
            return Numero.Substring(12, 2);
        }

        public override string GetQuemEuSou()
        {
            return "Eu sou CNPJ!";
        }
    }

}
