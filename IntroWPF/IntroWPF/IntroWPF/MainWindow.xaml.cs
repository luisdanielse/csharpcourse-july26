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

namespace IntroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Game> games = new List<Game>();
            games.Add(new Game() {Team1 = "Yankees", Team2 ="Red Sox", Score1 = 3, Score2=3, Inning = 6 });
            games.Add(new Game() { Team1 = "Dodgers", Team2 = "Rays", Score1 = 3, Score2 = 3, Inning = 7 });
            games.Add(new Game() { Team1 = "Padres", Team2 = "Cubs", Score1 = 3, Score2 = 3, Inning = 8 });
            MLBScores.ItemsSource = games;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Game selectedGame = MLBScores.SelectedItem as Game;
            string information = "Selected game: " + selectedGame.Team1 + " VS " + selectedGame.Team2;
            information = information + ".  The game is the inning: " + selectedGame.Inning;
            MessageBox.Show(information);
        }
    }

    public class Game
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Team1 { get; set; }
        public string Team2 { get; set; }

        public int Inning { get; set; }
    }
}
