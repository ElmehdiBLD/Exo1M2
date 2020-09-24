using System;
using System.Collections.Generic;
using System.Text;

namespace tableauSociete
{
    public class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Salaire = salaire;
            this.Service = service;
            nmbr++;
        }

        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age} , age de la personne : {Salaire}, age de la personne : {Service}";
        }

        public new void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

    }
}