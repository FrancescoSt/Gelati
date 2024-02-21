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

namespace stoppa.francesco._4I.Gelati
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gelati Gelati;
        Ingredienti Ingredienti;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Gelati g = new Gelati("Gelati.csv");
                dgGelati.ItemsSource = Gelati;
                Ingredienti i = new Ingredienti("Ingredienti.csv");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void dgGelati_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Gelati g = e.AddedItems[0] as Gelati;
            //StatusBar.Text = $"{g.Cognome}";

            List<Gelato> ContattiFiiltrati = new List<Gelato>();
            foreach (var item in Gelati)
            {
                if (item.idGelato == g.idGelato)
                {
                    ContattiFiiltrati.Add((Gelato)item);

                    dgIngredienti.ItemsSource = ContattiFiiltrati;

                }
            }
        }

        private void dgGelati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Gelato p = e.Row.DataContext as Gelato;
            if (p.idGelato == 1) // Check if the contact is empty
            {
                e.Row.Background = Brushes.Red;
                e.Row.Background = Brushes.White;

            }
        }
    }
    }
}
