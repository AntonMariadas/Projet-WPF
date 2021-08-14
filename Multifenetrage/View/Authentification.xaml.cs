using Multifenetrage.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Multifenetrage.View
{
    /// <summary>
    /// Logique d'interaction pour Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        int nbEssai = 3;

        public static string login;
        
        public Authentification()
        {
            InitializeComponent();
        }

        /*
        * Pour que cette classe puisse annoncer un changement sur champ
        * On a besoin de 2 Choses:
        * Un evenement qui va s'activer lorsque l'utilisateur se connecte : Event
        * C'est un moyen pour transporter l'information : Delegate
        * Pour annoncer le changement
        * Un delegate c'est un pointeur sur une fonctioon : Cette fonction recoit en parametre 
        * l'information qu'il faut notifier
        */

        //1 Etape
        public delegate void DInfoConnexion(string info);

        //On crée un déclencheur sur la base de ce delegate 
        public event DInfoConnexion NotifierUneConnexion;







        // Button Ok Click
        // j'ai omis de l'ecrire 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // On verifie le mot de passe et le userName


            //-- Traitement 

            
            // Retourner à la fenetre principale Avec un Resultat Ok  si l' authenfication reussi
            //
            if (chkWin.IsChecked == true)
            {
                //MessageBox.Show("Authentification Windows");
                // utiliser une fonctionnalité windows  pour verifier l'authenfication
                // c'est une DLL externe

                bool ok = WindowsAccessHelper.IsValidateCredentials(txbLogin.Text, pwdMDP.Password,"" );

                
                //string _result = (ok) ? "Compte Valide" : "Compte non Valide";
                //MessageBox.Show(_result);
                
                
                if (ok)
                {
                    this.DialogResult = true;
                    /*
                     * On doit logger l'action de l'utilisateur cad tracer ses actions 
                     * tracer a 2 niveaux 
                     * => JournalWindows sur les évenements
                         -

                     * => En Base

                     */

                    string _msg = $"{txbLogin.Text} s'est connecté le {DateTime.Now} à partir du compte " +
                                  $"{Environment.UserName} depuis le PC : {Environment.MachineName}";

                    MessageBox.Show(_msg);

                    MessageBox.Show(EncryptHelper.Base64Encode(_msg));

                    string _mesEnc = EncryptHelper.Base64Encode(_msg);

                    // Sauvegarder en base et dans le journal de Windows
                    // l'onglet daans le journal dans les applications 

                    var _log = new EventLog("Application");
                    _log.Source = "Application";
                    _log.WriteEntry(_mesEnc,EventLogEntryType.Information,1500);

                    // 2eme Etape pour l'affichage du Bienvenu
                    MainWindow.user = txbLogin.Text;

                    //2Etape pour le declenchement de l'evenement
                    //DeclencherEvenement(txbLogin.Text); Autre Methode
                    if(NotifierUneConnexion != null)
                    {
                        NotifierUneConnexion(txbLogin.Text);
                    }

                }
                else
                {
                    if (nbEssai == 1)

                    {
                        this.DialogResult = false;
                    }
                    else
                    {
                        nbEssai--;
                        MessageBox.Show($"Il vous reste : {nbEssai} Essai(s)");
                        // Permet de reinitialiser les Champs 
                        txbLogin.Text = "";
                        pwdMDP.Password = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Authentification en Bases de de Donnees");
                //bool _ok = VerifUserEnBase();
                //if (_ok)
                //    this.DialogResult = true;
                //else
                //    this.DialogResult = false;
            }
        }

        //private void DeclencherEvenement(string text)
        //{
        //    if(NotifierUneConnexion != null)
        //    {
        //        NotifierUneConnexion(text);
        //    }
        //}

        public string MajLabel()
        {
            return txbLogin.Text;
        }


        private void Button_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // Retourner à la fenetre principale Avec un Resultat false  si l' authenfication n'est pas reussi
            this.DialogResult = false;
        }
    }
}
