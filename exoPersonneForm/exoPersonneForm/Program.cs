using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exoPersonneForm
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Personne(string nom, string prenom, DateTime dateDeNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
        }
    }
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}
