using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAtv12
{
    public class Aluno
    {    
        public string Nome { get; set; }
        public string Snome /*sobrenome*/ { get; set; }
        public int Codigo { get; set; }
        public DateTime DataNasc { get; set; }

        public DateTime Data;

        public int Idade()
        {
            var c = DateTime.Now;
            Data = c;
            var i = Convert.ToInt32(Data.Year - DataNasc.Year);
            return i;
        }

        public string nomeCompleto()
        {
            return "" + Nome + " " + Snome + "";
        }

        public int validarNome()
        {
            int i = 0;
            string n = Nome;
            string s = Snome;

            if (n.Contains(" Ç") || n.Contains(" ç") || s.Contains(" Ç") || s.Contains(" ç"))
            {
                Console.WriteLine("Este nome não pode ser registrado. Contém a letra no início 'Ç' que é inválido ");
                i = +1;
            }
            if (n.Contains("@") || s.Contains("@"))
            {
                Console.WriteLine("Este caracter não podeser utilizado. O caracter '@' é inválido");
                i = +2;
            }
            return i;
        }

        public string ValidacaoErro(int i)
        {
            string m;
            if (validarNome() == 1)
            {
                m = "ERROR POR 'Ç'";
                return m;
            }
            else if (validarNome() == 2)
            {
                m = "ERROR POR '@'";
                return m;
            }

            return " ";
        }
    }
}
