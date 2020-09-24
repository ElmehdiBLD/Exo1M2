using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace tableauSociete

{
    public class Program
    {
            public static void Main(string[] args)
            {
                var emp1 = new Employe("albert", "luc", 22, 2600);
                var emp2 = new Employe("albert", "killyan", 34, 500);
                var emp3 = new Employe("albert", "paul", 64, 2200);
                var emp4 = new Employe("albert", "titouan", 14, 4600);
                var emp5 = new Employe("albert", "luc", 64, 3100);
                var chef1 = new Chef("monique", "kevin", 54, 3200, "acceuil");
                var chef2 = new Chef("mireille", "tristan", 74, 2900, "DINSI");
                var dir1 = new Directeur("lea", "anne", 12, 2800, "ELITE", "auchan");

                dir1.Afficher();
                chef2.Afficher();
                emp3.Afficher();

                Personne[] personnesArray = new Personne[8];
                personnesArray[0] = emp1;
                personnesArray[1] = emp2;
                personnesArray[2] = emp3;
                personnesArray[3] = emp4;
                personnesArray[4] = emp5;
                personnesArray[5] = chef1;
                personnesArray[6] = chef2;
                personnesArray[7] = dir1;

                for (int i = 0; i < personnesArray.Length; i++) { personnesArray[i].Afficher(); }

                emp1++;
                emp2.Salaire = 1600;
                chef1.Service = "DRH";


                for (int i = 0; i < personnesArray.Length; i++) { personnesArray[i].Afficher(); }

            }
        }
    }