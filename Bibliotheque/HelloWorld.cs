using System;

namespace Bibliotheque
{
    public class HelloWorld
    {
        public HelloWorld(string prenom)
        {
            this.Prenom = prenom;
        }

        public string Prenom { get; set; }

        public string Bonjour
        {
            get { return $"Bonjour {this.Prenom}, il est {DateTime.Now:dd/MM/yyyy H:mm:ss zzz}"; }
        }
    }
}