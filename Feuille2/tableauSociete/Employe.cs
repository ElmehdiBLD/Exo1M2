using System;
using System.Collections.Generic;
using System.Text;

namespace tableauSociete
{
    public class Employe : Personne
    {
        public double Salaire { get; set; }


        public Employe(string nom, string prenom, int age, double salaire) : base(nom, prenom, age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Salaire = salaire;
            nmbr++;
        }

        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age} , age de la personne : {Salaire}";
        }

        public new void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Employe operator ++(Employe personne)
        {
            personne.Age++;
            return personne;
        }

    }
}