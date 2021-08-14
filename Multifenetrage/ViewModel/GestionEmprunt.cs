using Multifenetrage.Commandes;
using Multifenetrage.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Multifenetrage.ViewModel
{
    public class GestionEmprunt : IDisposable
    {
        public MaVideothequeEntities db = new MaVideothequeEntities();
        
        public ObservableCollection<Film> ListeFilms { get; set; }
        public ObservableCollection<Utilisateur> ListeUtilisateurs { get; set; }

        public Utilisateur UtilisateurSelectionne { get; set; }

        public Emprunt Emprunt { get; set; }

        public AjoutEmprunt AjoutEmprunt { get; set; }

        public ObservableCollection<Emprunt> ListeEmprunts { get; set; }

        /**
        Affichage des films selectionnés via ComboBox dans une ListBox
        --------------------------------------------------------------
        1. On récupère dans le XAML->ComboBox->SelectedValue (filmSelectionne).
        2. On ajoute les film selectionnés dans une LIST (ListeDesFilmsSelectionnes) :
            => A chaque fois que je séléctionne un film, j'utilise le SETTER de la propriété filmSelectionné.
                => Je vais donc ajouter la nouvelle valeur à la List a chaque fois que j'utilise le Setter.
                    + Vérifier que le film n'est pas déjà dans la List (ListeDesFilmsSelectionnes)
        */

        private Film filmSelectionne;
        
        public Film FilmSelectionne
        {
            get { return filmSelectionne; }
            set 
            {
                filmSelectionne = value;
                VerificationEtAjoutDansListeDesFilmsSelectionnes(filmSelectionne);
            }
        }

        public Film FilmARetirer
        {
            get { return filmSelectionne; }
            set
            {
                filmSelectionne = value;
                if (filmSelectionne != null)
                {
                    if (filmSelectionne.Id != 0)
                        ListeDesFilmsSelectionnes.Remove(filmSelectionne);
                }
            }
        }

        public ObservableCollection<Film> ListeDesFilmsSelectionnes { get; set; }

        private void VerificationEtAjoutDansListeDesFilmsSelectionnes(Film film)
        {
            if (film.Id != 0)
            {
                Film g = ListeDesFilmsSelectionnes.FirstOrDefault(x => x.Id == film.Id);
                if (g == null)
                    ListeDesFilmsSelectionnes.Add(film);
            }
        }


        public GestionEmprunt()
        {
            if (ListeFilms == null)
                ListeFilms = new ObservableCollection<Film>(db.Film.ToList());

            if (ListeUtilisateurs == null)
                ListeUtilisateurs = new ObservableCollection<Utilisateur>(db.Utilisateur.ToList());

            if (ListeDesFilmsSelectionnes == null)
                ListeDesFilmsSelectionnes = new ObservableCollection<Film>();

            Emprunt = new Emprunt()
            {
                Id = 0,
                IdUtilisateur = 0,
                IdFilm = 0,
                DateEmprunt = null,
                DateRetour = null,
                Statut = string.Empty,
            };

            FilmSelectionne = new Film();

            AjoutEmprunt = new AjoutEmprunt(this);

            if (ListeEmprunts == null)
            ListeEmprunts = new ObservableCollection<Emprunt>(db.Emprunt.ToList());
        }
        
        public void AjoutEmpruntEnBase(Emprunt emprunt)
        {
            Emprunt.IdUtilisateur = UtilisateurSelectionne.Id;
            Emprunt.IdFilm = filmSelectionne.Id;
            string _etat = Emprunt.Statut.Substring(37);
            Emprunt.Statut = _etat;

            db.Emprunt.Add(emprunt);
            int _i = db.SaveChanges();
            if (_i > 0)
                MessageBox.Show("Emprunt enregistré en base");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
