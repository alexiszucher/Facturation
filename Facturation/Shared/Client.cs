using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    class Client
    {
        private string nom;
        private string prenom;
        private int age;

        public Client(string nom, string prenom, int age) 
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public int getAge()
        {
            return this.age;
        }
    }
}
