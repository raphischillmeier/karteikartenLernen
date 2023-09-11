using System;

namespace KarteiKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Karteikarten One = new Karteikarten();
            One.NameKK = "Längster Fluss";
            One.Frage = "Welcher Fluss ist der längste Fluss der Welt?";
            One.Antwort = "Der Nil";

            Karteikarten Two = new Karteikarten();
            Two.NameKK = "Gürteltiere";
            Two.Frage = "Was sind Gürteltiere?";
            Two.Antwort = "Kugelsicher";

            Karteikarten Three = new Karteikarten();
            Three.NameKK = "Nationalflaggen";
            Three.Frage = "Welche Nationalflagge hat die meisten Farben auf der Welt?";
            Three.Antwort = "Die Belize";

            Karteikarten Four = new Karteikarten();
            Four.NameKK = "Tweets";
            Four.Frage = "Wie viele Tweets werden pro Sekunde durchschnittlich verschickt?";
            Four.Antwort = "9310";

            Karteikarten Five = new Karteikarten();
            Five.NameKK = "Währung";
            Five.Frage = "Wie viel der weltweiten Währung ist digital?";
            Five.Antwort = "92%";

            One.AskQuestion();
            Two.AskQuestion();
            Three.AskQuestion();
            Four.AskQuestion();
            Five.AskQuestion();

            newKK();
        }

        static void newKK()
        {
            string j_n;
            Console.WriteLine("Möchtest du eine neue Karteikarte erstellen?");
            j_n = Console.ReadLine();

            while (j_n.Equals("Ja", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Wie soll die neue Karteikarte heißen?");
                string nameKK = Console.ReadLine();
                Console.WriteLine("Was ist die Frage der neuen Karteikarte?");
                string frage = Console.ReadLine();
                Console.WriteLine("Wie ist die Antwort der neuen Karteikarte?");
                string antwort = Console.ReadLine();

                Karteikarten newCard = new Karteikarten();
                newCard.NameKK = nameKK;
                newCard.Frage = frage;
                newCard.Antwort = antwort;
                newCard.AskQuestion();

                Console.WriteLine("Möchtest du eine weitere Karteikarte erstellen?");
                j_n = Console.ReadLine();
            }

            Console.WriteLine("Programm wird beendet");
        }
    }

    public class Karteikarten
    {
        public string NameKK { get; set; }
        public string Frage { get; set; }
        public string Antwort { get; set; }

        public void AskQuestion()
        {
            string answer = "Nix";
            int ver = 3;

            Console.WriteLine("Das ist die Karteikarte " + NameKK);

            while (ver > 0)
            {
                Console.WriteLine("Die Frage lautet: " + Frage + " Wie lautet die Antwort?");
                answer = Console.ReadLine();
                if (answer == Antwort)
                {
                    Console.WriteLine("Diese Antwort ist richtig!");
                    break;
                }
                else
                {
                    ver--;
                    Console.WriteLine("Diese Antwort ist falsch. Du hast noch " + ver + " Versuche.");
                    if (ver == 0)
                    {
                        Console.WriteLine("Du hast leider alle Versuche aufgebraucht.");
                    }
                }
            }
        }
    }
}

