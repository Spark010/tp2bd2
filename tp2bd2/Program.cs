using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2bd2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fonction Principale du projet
            //Boucle de controle principale
            bool est_en_fonction = true;
            Console.Beep();
            do
            {
                est_en_fonction = Menu_Console.MenuPrincipal(est_en_fonction);
            } while (est_en_fonction == true);
            Console.Clear();
        }
    }
}
