using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Article
    {
        protected string designation;
        protected int prix;

        public void acheter()
        {

        }
    }

    class Livre : Article
    {
        protected string isbn;
        protected int nbPages;
    }

    class Disque : Article
    {
        protected string label;
    }

    class Video : Article
    {
        protected int duree;

        public void afficher()
        {

        }
    }

    class Poche : Livre
    {
        private string categorie;
    }

    class Broche : Livre
    {
    }
}