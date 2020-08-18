using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Modelos
{
    public class Financeiro
    {
        public Financeiro()
        {
            Codigo = 0;
            Vencimento = DateTime.Now;
            Emissao = DateTime.Today;

        }
        public int Lancamento { get; set; }

        public int Codigo { get; set; }
        public String Nome { get; set; }

        public DateTime Vencimento { get; set; }

        public String Pagamento { get; set; }
        public Decimal Valor { get; set; }
        public DateTime Emissao { get; set; }
        public String Tipo { get; set; }
    }
}
