using Multifenetrage.Commandes;
using Multifenetrage.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Multifenetrage.ViewModel
{
    //Servira de context de Binding : DataContext
    public class GestionUtilisateur : IDisposable
    {
        // Pas besoin de static car ds la commande ajoutUtilisateur nous avons une instance de cette classe
        private MaVideothequeEntities db = new MaVideothequeEntities();

        // AjoutUtilisateur la methode créer dans le dossier Commandes 
        public AjoutUtilisateur AjoutUtilisateurVM { get; set; }

        public Utilisateur UtilisateurVM { get; set; }

        public ObservableCollection<Utilisateur> ListUtilisateurVM { get; set; } //Evite A/R en base de données en stockant dans une liste


        //constructor
        //ctr  +tab +tab
        public GestionUtilisateur()
        {
            if (ListUtilisateurVM == null)
            {
                // Je créé une liste que j'initialise à partir des utilisateurs de la BD
                // ObservableCollection définit à la base comme set, il attend une liste
                ListUtilisateurVM = new ObservableCollection<Utilisateur>(db.Utilisateur.ToList());
            }
            //j'instancie la propriete et je lui pass la classe en parametre
            AjoutUtilisateurVM = new AjoutUtilisateur(this);
            // puis on initialise les Champs
            UtilisateurVM = new Utilisateur()
            {
                Id = 0,
                Email = string.Empty,  // eviter string s = "";
                Login = string.Empty,
                Nom = string.Empty,
                Prenom = string.Empty,
                MotDePasse = string.Empty

            };
        }

        public void AjoutUtilisateurBase(Utilisateur utilisateur)
        {
            /**
             Pour accéder aux classes qui mappent les tables
             Utiliser le Conteneur d'Entité avec un Using

            using (DBvideothequeEntities db = new DBvideothequeEntities())
            {
                db.
                libérer la ressouce automatiquement
                On peut faire cette gestion via l'interface IDisposable qui gère automatiquement la ressousce (fermeture auto)
            }
            */

            db.Utilisateur.Add(utilisateur);
            int i = db.SaveChanges();
            string _msg = (i > 0) ? "Enregistré" : "Echec enregistrement";
            MessageBox.Show(_msg);
            if (i > 0)
            {
                ListUtilisateurVM.Add(utilisateur); // évite A/R BDD
            //    UtilisateurVM.Login = string.Empty;
            //    UtilisateurVM.Nom = string.Empty;
            //    UtilisateurVM.Prenom = string.Empty;

            }
            

        }

        public void SuppUtilisateur(Utilisateur utilisateur)
        {
            db.Utilisateur.Remove(utilisateur);
        }

        public void Dispose()
        {
            // gére automatiquement la fermeture de la connexion vers la BDD
            db.Dispose(); 
        }

    }
    
}
