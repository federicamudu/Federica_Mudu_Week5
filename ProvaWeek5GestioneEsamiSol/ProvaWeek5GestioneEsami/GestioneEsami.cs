using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek5GestioneEsami
{
    internal class GestioneEsami
    {
        public static List<Corso> corsiMatematica = new List<Corso>();
        public static List<Corso> corsiFisica = new List<Corso>();
        public static List<Corso> corsiInformatica = new List<Corso>();
        public static List<Corso> corsiIngegneria = new List<Corso>();
        public static List<Corso> corsiLettere = new List<Corso>();

        public static List<CorsoDiLaurea> corsiDiLaurea = new List<CorsoDiLaurea>();
        public static List<Studente> studente = new List<Studente>();

        public static List<Corso> CaricaCorsiMatematica()
        {
            Corso corso1 = new Corso("Analisi 1", 9);
            Corso corso2 = new Corso("Geometria", 6);
            Corso corso3 = new Corso("Fisica 1", 7);

            corsiMatematica.Add(corso1);
            corsiMatematica.Add(corso2);
            corsiMatematica.Add(corso3);

            return corsiMatematica;
        }
        public static List<Corso> CaricaCorsiFisica()
        {
            Corso corso1 = new Corso("Fisica 1", 7);
            Corso corso2 = new Corso("Fisica 2", 12);

            corsiFisica.Add(corso1);
            corsiFisica.Add(corso2);

            return corsiFisica;
        }
        public static List<Corso> CaricaCorsiInformatica()
        {
            Corso corso1 = new Corso("Informatica", 12);
            Corso corso2 = new Corso("Calcolatori", 10);
            corsiInformatica.Add(corso1);
            corsiInformatica.Add(corso2);

            return corsiInformatica;
        }
        public static List<Corso> CaricaCorsiIngegneria()
        {
            Corso corso1 = new Corso("Analisi 1", 9);
            Corso corso2 = new Corso("Geometria", 6);
            Corso corso3 = new Corso("Informatica", 12);

            corsiIngegneria.Add(corso1);
            corsiIngegneria.Add(corso2);
            corsiIngegneria.Add(corso3);

            return corsiIngegneria;
        }
        public static List<Corso> CaricaCorsiLettere()
        {
            Corso corso1 = new Corso("Letteratura Italiana", 12);
            Corso corso2 = new Corso("Storia", 14);
            Corso corso3 = new Corso("Filosofia", 12);

            corsiLettere.Add(corso1);
            corsiLettere.Add(corso2);
            corsiLettere.Add(corso3);

            return corsiLettere;
        }
        public static List<CorsoDiLaurea> CaricaCorsiDiLaurea()
        {
            CorsoDiLaurea cdl1 = new CorsoDiLaurea(NomeCorsoLaurea.Matematica, 3, CaricaCorsiMatematica());
            CorsoDiLaurea cdl2 = new CorsoDiLaurea(NomeCorsoLaurea.Fisica, 2, CaricaCorsiFisica());
            CorsoDiLaurea cdl3 = new CorsoDiLaurea(NomeCorsoLaurea.Informatica, 4, CaricaCorsiInformatica());
            CorsoDiLaurea cdl4 = new CorsoDiLaurea(NomeCorsoLaurea.Ingegneria, 3, CaricaCorsiIngegneria());
            CorsoDiLaurea cdl5 = new CorsoDiLaurea(NomeCorsoLaurea.Lettere, 5, CaricaCorsiLettere());          

            corsiDiLaurea.Add(cdl1);
            corsiDiLaurea.Add(cdl2);
            corsiDiLaurea.Add(cdl3);
            corsiDiLaurea.Add(cdl4);
            corsiDiLaurea.Add(cdl5);

            return corsiDiLaurea;
        }
        public static List<Studente> CaricaStudente()
        {
            CorsoDiLaurea corsoDiLaurea = new CorsoDiLaurea(NomeCorsoLaurea.Ingegneria);
            Immatricolazione immatricolazione = new Immatricolazione(new DateTime(2012, 10, 01), corsoDiLaurea);
            Studente s1 = new Studente("Federica", "Mudu", 1993, immatricolazione);
            studente.Add(s1);
            return studente;
        }
        public static Studente IsAutenticato(string nome, string cognome, int matricola)
        {
            foreach (var item in studente)
            {
                if (item.Nome == nome && item.Cognome == cognome && item.Immatricolazione.Matricola == matricola)
                {
                    item.GetInfoStudente();
                    return item;
                }
            }
            return null;
        }
        public static Corso CercaEsamePerNome(string nome)
        {
            
            foreach (var item in corsiIngegneria)
            {
                if(item.NomeDelCorso == nome)
                {
                    return item;
                }

            }
            return null;
        }


    }
}
