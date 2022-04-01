// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* domanda 1: c
 * domanda 2: Heap, Reference
 * domanda 3: a e b*/

using ProvaWeek5GestioneEsami;


List<CorsoDiLaurea> corsiDiLaurea = GestioneEsami.CaricaCorsiDiLaurea();
List<Corso> corsi = new List<Corso>();
List<Corso> corsoDaSostenere = new List<Corso>();
List<Studente> studenti = GestioneEsami.CaricaStudente();

Console.WriteLine("Inserisci il tuo nome:");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci il tuo cognome: ");
string cognome = Console.ReadLine();
int matricola;
do
{
    Console.WriteLine("Inserisci la tua matricola: ");
} while (!int.TryParse(Console.ReadLine(), out matricola) && matricola >= 1000);

Studente stud = GestioneEsami.IsAutenticato(nome, cognome, matricola);

if (stud != null)
{
    Console.WriteLine("\nBenvenuto Studente!");
    Console.WriteLine("\nEcco i tuoi dati: ");
    Console.WriteLine(stud.GetInfoStudente());
}
else
{
    Console.WriteLine("Non sei iscritto a nessun corso di laurea!");
}

do
{
    Menu();

    int scelta;
    do
    {
        Console.Write("Fai la tua scelta: ");

    } while (!int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta < 2);

    switch (scelta)
    {
        case 1:
            NomeCorsoLaurea nomeCorso = stud.Immatricolazione.CorsodiLaurea.NomeCorso;
            if (nomeCorso == NomeCorsoLaurea.Ingegneria)
            {
                corsi = GestioneEsami.corsiIngegneria;
                Console.WriteLine("\nCorsi disponibili: ");
                foreach (var item in corsi)
                {

                    Console.WriteLine(item.GetInfoCorso());
                }
                Corso corsoScelto = new Corso();
                Console.WriteLine("Quale esame vuoi sostenere?");
                var esameScelto = Console.ReadLine();
                Corso c = GestioneEsami.CercaEsamePerNome(esameScelto);
                if (c == null)
                {
                    Console.WriteLine("Nome esame non valido");
                }
                else
                {
                    corsoDaSostenere.Add(c);
                    Console.WriteLine("Corso prenotato");
                }
                //manca la parte di verifica (se i CFU del corso associato all’esame non superino i CFU massimi del Corso di laurea
                //e se non ha il flag RichiestaLaurea assegnato a vero.)
            }
            break;
        case 2:
            //Metodo EsamePassato(Input:Esame prenotato)
            //Impostare a true il valore di superato

            break;
        case 0:
            return;
    }


} while (true);


//void EsamePassato()
//{
//    Console.WriteLine("Quale esame vuoi verbalizzare?");
//    string esameDaVerbalizzare = Console.ReadLine();
//    foreach (var item in corsoDaSostenere)
//    {

//    }
//}

void Menu()
{
    Console.WriteLine("***Menù***");
    Console.WriteLine("1. Prenotare un esame");
    Console.WriteLine("2. Verbalizzare un esame");
    Console.WriteLine("0. Esci");
    Console.WriteLine("******");
}