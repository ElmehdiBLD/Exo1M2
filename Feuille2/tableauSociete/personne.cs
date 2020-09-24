using System;
using System.Collections.Generic;
using System.Text;

namespace tableauSociete
{
    public class Personne : IDisposable
    {
        protected static int nmbr = 0;
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected int Age { get; set; }


        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            nmbr++;
        }

        public void Afficher(Personne personne)
        {
            Console.WriteLine($"Nom: {personne.Nom}");
            Console.WriteLine($"Prénom: {personne.Prenom}");
            Console.WriteLine($"Age: {personne.Age}");
            Console.WriteLine("");
        }

        public void Combien()
        {
            Console.WriteLine($"nmbr personne créer : {nmbr}");
        }

        public void Dispose()
        {
            nmbr--;
        }




        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age}";
        }

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne operator ++(Personne personne)
        {
            personne.Age++;
            return personne;
        }




    }
}