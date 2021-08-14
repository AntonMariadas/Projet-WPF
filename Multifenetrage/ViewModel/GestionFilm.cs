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

namespace Multifenetrage.ViewModel
{
    public class GestionFilm : IDisposable
    {
        private MaVideothequeEntities db = new MaVideothequeEntities();

        public Film Film { get; set; }
        public AjoutFilm AjoutFilmVM { get; set; }
        public ObservableCollection<Film> ListeFilms { get; set; }
        private PAYS pays;
        public PAYS PaysSelectionneVM 
        {
            get { return pays; }
            set 
            { 
                pays = value;
                if (pays.Id != 0)
                    ListePaysSelectionnes.Add(pays);
            }
        }

        public PAYS PaysARetirerVM { get { return pays; } set { pays = value;
            if (pays != null)
                ListePaysSelectionnes.Remove(pays);
            } }

        // Binding du ComboBox
        public ObservableCollection<Genre> ListeGenreVM { get; set; }
        public ObservableCollection<PAYS> ListePaysVM { get; set; }



        // La modification d'une propriété déclenche son setter (ici pour GenreSelectionneVM)
        // A ce moment on veut ajouter la nouvelle valeur à la liste
        // Pour cela on a besoin de modifier la SYNTAXE de la propriété
        private Genre genre;

        public Genre GenreSelectionneVM
        {
            get { return genre; }
            set 
            {
                genre = value;
                //if (genre.Id != 0)
                //   ListeGenresSelectionnes.Add(genre);
                AjouterGenreDansListeSelectionne(genre);
            }
        }

        public Genre GenreARetirerVM
        {
            get { return genre; }
            set
            {
                genre = value;
                if (genre != null)
                {
                    if (genre.Id != 0)
                        ListeGenresSelectionnes.Remove(genre);
                }
                
            }
                
        }

        // On crée une liste de genres selectionnés
        public ObservableCollection<Genre> ListeGenresSelectionnes { set; get; }

        private void AjouterGenreDansListeSelectionne(Genre genre)
        {
            // Vérifier si le genre n'est pas déjà dans la liste
            if (genre.Id != 0)
            {
                Genre g = ListeGenresSelectionnes.FirstOrDefault(x => x.Id == genre.Id);
                if (g == null)  // si on ne trouve rien, dans ce cas il s'agit bien d'un nouveau genre
                    ListeGenresSelectionnes.Add(genre);  // on peut l'insérer à la liste
            }
        }


        public ObservableCollection<PAYS> ListePaysSelectionnes { set; get; }

        private void AjouterPaysDansListeSelectionne(PAYS pays)
        {
            if (pays.Id != 0)
            {
                PAYS p = ListePaysSelectionnes.FirstOrDefault(x => x.Id == pays.Id); ;
                if (p == null)
                {
                    ListePaysSelectionnes.Add(pays);
                }
            }
        }



        public GestionFilm()
        {
            Film = new Film()
            {
                Id = 0,
                Titre = string.Empty,
                Summary = string.Empty,
                Duree = 0,
                ActeurP = string.Empty,
                AutresActeurs = string.Empty,
                affiche = string.Empty,
            };
            AjoutFilmVM = new AjoutFilm(this);

            if (ListeFilms == null)
                ListeFilms = new ObservableCollection<Film>(db.Film.ToList());

            if (ListeGenreVM == null)
                ListeGenreVM = new ObservableCollection<Genre>(db.Genre.ToList());

            if (ListePaysVM == null)
                ListePaysVM = new ObservableCollection<PAYS>(db.PAYS.ToList());

            if (ListeGenresSelectionnes == null)
                ListeGenresSelectionnes = new ObservableCollection<Genre>();

            if (ListePaysSelectionnes == null)
                ListePaysSelectionnes = new ObservableCollection<PAYS>();

            GenreSelectionneVM = new Genre();

            GenreARetirerVM = new Genre();

            PaysSelectionneVM = new PAYS();

            PaysARetirerVM = new PAYS();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void AjoutFilmEnBase(Film film)
        {
            List<FilmGenre> filmGenre = new List<FilmGenre>();
            List<FilmPays> filmPays = new List<FilmPays>();
            film.FilmGenre = filmGenre; // on initialise la liste de liaison FilmGenre
            film.FilmPays = filmPays;  // on initialise la lise FilmPays
            db.Film.Add(film);
            db.SaveChanges();
            
            foreach (var item in ListeGenresSelectionnes)
            {
                film.FilmGenre.Add(new FilmGenre { IdGenre = item.Id, IdFilm = film.Id }); // On remplit la table de liaison FilmGenre
            }

            foreach (var item in ListePaysSelectionnes)
            {
                film.FilmPays.Add(new FilmPays { IdPays = item.Id, IdFilm = film.Id });
            }

            db.SaveChanges();
        }

    }
}
