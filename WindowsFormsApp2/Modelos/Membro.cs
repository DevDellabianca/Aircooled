using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Modelos
{
    public class Membro
    {
        public Membro()
        {
            Codigo = 0;
            Adesao = DateTime.Now;
            Nascimento = DateTime.Now;

        }

        public int Codigo { get; set; }
        public DateTime Adesao { get; set; }
        public String Nome { get; set; }
        public String Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public String Cpf { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Profissao { get; set; }
        public String Apelido { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Estado { get; set; }

        public Decimal Valor { get; set; }
        public String Dia_Venc { get; set; }

    }
}
