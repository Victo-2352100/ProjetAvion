using Bibliotheque;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Avion viou = new Avion(12, 6);

            Avion viou = new Avion(TestCreationHabitacle());

            while (true)
            {
                Console.Clear();
                Console.WriteLine(viou.ToString());
                Passager JeannePasDarc = new Passager("Jeanne");
                if (Console.ReadLine() == "a")
                    viou.DebarquerPassager();
                else
                    viou.AjouterPassager(JeannePasDarc);
            }
        }
        static Habitacle TestCreationHabitacle()
        {   
            //creation de la rangee
            int tailleHab = 8;
            Rangee[] rangees = new Rangee[7];
     
            // création des 2 sections pour la rangée
            Section[] ra1 = new Section[2];
            ra1[0] = new Section(new Siege[2], false);
            ra1[1] = new Section(new Siege[3], true);

            //remplissage
           
            for (int i = 1; i < rangees.Length - 1; i++)
            {
                rangees[i] = new Rangee(4, tailleHab);
            }
            rangees[0] = new Rangee(ra1, tailleHab);

            rangees[6] = new Rangee(6, tailleHab);

            return new Habitacle(rangees, tailleHab);
        }
    }
}