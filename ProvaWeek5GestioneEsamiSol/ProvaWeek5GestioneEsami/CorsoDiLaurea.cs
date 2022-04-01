using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class CorsoDiLaurea
    {
        public NomeCorsoLaurea NomeCorso { get; set; }
        public int AnniDiCorso { get; set; }
        public int CreditiTotali { get { return CalcoloCreditiTotali(); } }
        public List<Corso> Corsi { get; set; } = new List<Corso>();

        public CorsoDiLaurea()
        {

        }
        public CorsoDiLaurea(NomeCorsoLaurea nomeCorso)
        {
            NomeCorso = nomeCorso;
        }
        public CorsoDiLaurea(NomeCorsoLaurea nomeCorso, int anni, List<Corso> corsi)
        {
            NomeCorso = nomeCorso;
            AnniDiCorso = anni;
            Corsi = corsi;
        }

        public int CalcoloCreditiTotali()
        {
            int creditiTotali = 0;
            foreach (var item in Corsi)
            {
                creditiTotali += item.CreditiCorso;
            }
            return creditiTotali;
        }
        public void StampaInfoCorsi()
        {

            Console.WriteLine($"Nome Corso di Laurea: {NomeCorso}\n" +
                $"Anni di corso: {AnniDiCorso}\n" +
                $"CFU Totali: {CreditiTotali}\n" +
                $"Corsi che devono essere sostenuti per il conseguimento del titolo: ");
            foreach (var item in Corsi)
            {
                Console.WriteLine($"\n{item.GetInfoCorso()}");
            }
            Console.WriteLine("***************************");
        }
        public string GetInfoCDL()
        {
            return $"{NomeCorso}";

        }
    }
    public enum NomeCorsoLaurea
    {
        Matematica = 1,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }
}
