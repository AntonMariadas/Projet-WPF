using Multifenetrage.Model;
using Multifenetrage.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Multifenetrage.Commandes
{
    public class AjoutUtilisateur : ICommand
    {
        private GestionUtilisateur gestionUtilisateur;

        public AjoutUtilisateur(GestionUtilisateur gestionUtilisateur)
        {
            this.gestionUtilisateur = gestionUtilisateur;
        }

        // Les methodes de l'interface d ICommand
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //Enregistrer dans la base 
            Utilisateur utilisateur = new Utilisateur();
            utilisateur = (Utilisateur)parameter;
            gestionUtilisateur.AjoutUtilisateurBase(utilisateur);
            
        }
    }
}
