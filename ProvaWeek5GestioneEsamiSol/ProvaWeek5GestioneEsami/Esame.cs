using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class Esame
    {
        public Corso Corso { get; set; } = new Corso();
        public bool Superato { get; set; }

        public Esame()
        {

        }
        public Esame(Corso corso)
        {
            Corso = corso;
        }
        public string GetInfoEsame()
        {
            return $"Corso: {Corso.NomeDelCorso} \tCFU:{Corso.CreditiCorso} \tSuperato:{Superato}";
        }
    }
}
