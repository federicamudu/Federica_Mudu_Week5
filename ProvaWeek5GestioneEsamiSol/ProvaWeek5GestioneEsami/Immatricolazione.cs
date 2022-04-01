using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class Immatricolazione
    {
        public static int numero = 1000;
        public int Matricola { get; }
        public DateTime DataInizio { get; set; } = DateTime.Today;
        public int CreditiAccumulati { get; set; }
        public CorsoDiLaurea CorsodiLaurea { get; set; } = new CorsoDiLaurea();
        public bool FuoriCorso { get { return ControlloFuoriCorso(); } }

        public Immatricolazione()
        {

        }
        public Immatricolazione(DateTime dataInizio, CorsoDiLaurea corsodiLaurea)
        {
            DataInizio = dataInizio;
            Matricola = numero++;
            CorsodiLaurea = corsodiLaurea;
        }
        public bool ControlloFuoriCorso()
        {
            bool fuoriCorso = true;
            var tempo = DateTime.Today - DataInizio;
            int giorni = tempo.Days;
            int anni = (int)(0.00273785 * giorni);
            if (anni < CorsodiLaurea.AnniDiCorso)
            {
                fuoriCorso = false;
            }
            return fuoriCorso;
        }
    }
}
