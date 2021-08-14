using Multifenetrage.Model;
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
    /// Logique d'interaction pour Film.xaml
    /// </summary>
    public partial class Film : Page
    {
        GestionFilm gestionFilm = new GestionFilm();

        public Film()
        {
            InitializeComponent();
            DataContext = gestionFilm;
        }

        
    }
}
