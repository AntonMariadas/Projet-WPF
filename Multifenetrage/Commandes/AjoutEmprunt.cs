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
    public class AjoutEmprunt : ICommand
    {
        private GestionEmprunt gestionEmprunt;

        public AjoutEmprunt(GestionEmprunt gestionEmprunt)
        {
            this.gestionEmprunt = gestionEmprunt;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Emprunt emprunt = new Emprunt();
            emprunt = (Emprunt)parameter;
            gestionEmprunt.AjoutEmpruntEnBase(emprunt);
        }
    }
}
