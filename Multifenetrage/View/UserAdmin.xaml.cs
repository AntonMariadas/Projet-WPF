using Multifenetrage.Helper;
using Multifenetrage.ViewModel;
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

namespace Multifenetrage.View
{
    /// <summary>
    /// Logique d'interaction pour UserAdmin.xaml
    /// </summary>
    public partial class UserAdmin : Page
    {
        // Creer une variable de classe globale  pour l'utiliser partout dans le code

        private GestionUtilisateur gestionUtilisateur = new GestionUtilisateur();

        public UserAdmin()
        {
            InitializeComponent();
            // On lui fait comprendre que le dataContext c'est le context de Binding
            this.DataContext = gestionUtilisateur;
            btnAjoutUtilisateur.IsEnabled = false;

        }

        // Pour verifier Si les deux mdp sont identiques 
        private void VerifyPassword_Click(object sender, RoutedEventArgs e)
        {
            if (pwdPass1.Password.Equals(pwdPass2.Password))
            {
                // Crypter le mdp avant de le stocker en base
                string _passwordCrypte = EncryptHelper.Base64Encode(pwdPass1.Password);

                //Alors on met a jour le champ mot de passe dans VM
                //Si on n'avait pas l'objet gestionUtilisateur
                // on aurait pu utiliser une notification
                gestionUtilisateur.UtilisateurVM.MotDePasse = _passwordCrypte;
                MessageBox.Show("C pareil");

                // Tant que les deux mdp ne sont pas identiques le btn doit etre desactivé
                btnAjoutUtilisateur.IsEnabled = true;
                // l'activation de ce meme btn est gérée par le canExecute!
                // donc il faudra concilier les 2 ...

            }
            else
            {
                btnAjoutUtilisateur.IsEnabled = false;
            }
            
        }
    }
}
