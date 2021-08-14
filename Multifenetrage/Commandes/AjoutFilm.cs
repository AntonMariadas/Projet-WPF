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
    public class AjoutFilm : ICommand
    {
        // Injection de dépendance par constructeur => je fais un setter avec le constructeur de la classe dont j'ai besoin
        GestionFilm gestionFilm;

        public AjoutFilm(GestionFilm GestionFilm)
        {
            gestionFilm = GestionFilm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Film film = new Film();
            film = (Film)parameter;
            gestionFilm.AjoutFilmEnBase(film);
        }
    }
}
