using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public List<Esame> Esami { get; set; } = new List<Esame>();
        public bool RichiestaDiLaurea { get; set; } 


        public Studente()
        {

        }
        public Studente(string nome, string cognome, int annoDiNascita, Immatricolazione immatricolazione)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            Immatricolazione = immatricolazione;
        }
        public int CalcoloCrediti()
        {

            foreach (var item in Esami)
                if (item.Superato)
                {
                    Immatricolazione.CreditiAccumulati += item.Corso.CreditiCorso;
                }

            return Immatricolazione.CreditiAccumulati;
        }
        public bool VerificaRichiestaLaurea()
        {
            bool richiestaLaurea = false;

            if (Immatricolazione.CreditiAccumulati == Immatricolazione.CorsodiLaurea.CreditiTotali)
            {
                richiestaLaurea = true;
            }
            return richiestaLaurea;
        }

        public string GetInfoStudente()
        {
            return $"Nome:{Nome} \n" +
                $"Cognome:{Cognome} \n" +
                $"Matricola:{Immatricolazione.Matricola} \n" +
                $"DataInizio:{Immatricolazione.DataInizio.ToShortDateString()} \n" +
                $"Corso di Laurea:{Immatricolazione.CorsodiLaurea.GetInfoCDL()} \n" +
                $"CFU accumulati:{Immatricolazione.CreditiAccumulati} \n" +
                $"Status FuoriCorso:{Immatricolazione.FuoriCorso}\n" +
                $"Status Richiesta Laurea: {RichiestaDiLaurea}";
        }
    }
}
