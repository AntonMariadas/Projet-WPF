using Multifenetrage.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multifenetrage
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 1 etape
        public static string user;

        public MainWindow()
        {
            InitializeComponent();
            //demander une Authentification 
            Authentifier();
        }
       

      


        private void Authentifier()
        {
            //Rendre la fenetre invisible

            this.Hide();

            //Afficher la 2eme sous forme de boite de dialogue
            Authentification authentification = new Authentification();
            // Permet d'avoir un affichage modale : 
            //impossible a la fenetre en dessous avant d'avoir la fenbetre au dessus


            // Etape 3 de l'evenement Delegate
            // se souscrire a un événement 
            authentification.NotifierUneConnexion += Connected;




            if (authentification.ShowDialog() == true)
            {
                MessageBox.Show("Authenfication OK");
                //lbUser.Content =$"Bienvenue : {user}";

                //On appelle une methode dazns l'autre classe qui retourne un string 
                // Elle reutilise l'Objet qui est instancié à la ligne 39.
                //lbUser1.Content = $"Bienvenue : {authentification.MajLabel()}";

                this.Show();
            }
            else
            {
                MessageBox.Show("Authenfication  PAS OK");
                this.Close();
            }
        }

        private void Connected(string info)
        {
            //lbUser2.Content = $"Bienvenue Délégate {info}";
        }

        private void FinApplication(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Fermeture de fichiers  ou contenu ouvertes -- eventuellement
            MessageBox.Show("Fermeture de l'application en cours...");

        }

        private void GestionUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            frmPrincipale.Navigate(new UserAdmin());
        }

        private void GestionFilm_click(object sender, RoutedEventArgs e)
        {
            frmPrincipale.Navigate(new Film());

        }

        private void GestionEmprunt_click(object sender, RoutedEventArgs e)
        {
            frmPrincipale.Navigate(new Emprunt());

        }

    }
}
