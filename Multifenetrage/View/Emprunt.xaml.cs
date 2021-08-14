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
    /// Logique d'interaction pour Emprunt.xaml
    /// </summary>
    public partial class Emprunt : Page
    {
        GestionEmprunt gestionEmprunt = new GestionEmprunt();

        public Emprunt()
        {
            InitializeComponent();
            DataContext = gestionEmprunt;
        }
    }
}
