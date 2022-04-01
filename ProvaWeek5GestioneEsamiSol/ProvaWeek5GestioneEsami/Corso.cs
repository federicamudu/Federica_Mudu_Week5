using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class Corso
    {
        public string NomeDelCorso { get; set; }
        public int CreditiCorso { get; set; }

        public Corso()
        {

        }
        public Corso(string nomeDelCorso, int creditiCorso)
        {
            NomeDelCorso = nomeDelCorso;
            CreditiCorso = creditiCorso;
        }
        public string GetInfoCorso()
        {
            return $"{NomeDelCorso} \tCFU: {CreditiCorso}";
        }

    }
}
