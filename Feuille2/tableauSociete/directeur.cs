using System;
using System.Collections.Generic;
using System.Text;

namespace tableauSociete
{
    public class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Salaire = salaire;
            this.Service = service;
            this.Societe = societe;
            nmbr++;
        }

        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age} , dalaire de la personne : {Salaire}, service de la personne : {Service}, societe de la personne : {Societe}";
        }

        public new void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}