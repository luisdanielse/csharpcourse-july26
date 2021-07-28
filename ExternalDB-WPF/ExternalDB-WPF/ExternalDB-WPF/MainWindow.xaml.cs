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

namespace ExternalDB_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = "Server=tcp:danielssql234.database.windows.net,1433;Initial Catalog=DBTest;Persist Security Info=False;User ID=testuser;Password=TestPa55w.rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            dataContext = new DataClasses1DataContext(connectionString);
            ShowZoo();
            ShowAnimals();
        }

        private void ShowZoo()
        {
            var zoos = from zoo in dataContext.Zoos select zoo;
            ZooList.DisplayMemberPath = "Location";
            ZooList.SelectedValuePath = "Id";
            ZooList.ItemsSource = zoos;
        }

        private void ShowAnimals()
        {
            var animals = from animal in dataContext.Animals select animal;
            AnimalList.DisplayMemberPath = "Name";
            AnimalList.SelectedValuePath = "Id";
            AnimalList.ItemsSource = animals;
        }

        private void ZooList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int IdOfZoo = Int32.Parse(ZooList.SelectedValue.ToString());

            var animalsInZoo = from animal in dataContext.Animals
                               join animalzoo in dataContext.AnimalZoos on animal.Id equals animalzoo.AnimalId
                               join zoo in dataContext.Zoos on animalzoo.ZooId equals zoo.Id
                               where zoo.Id == IdOfZoo
                               select animal;

            AnimalsInZoo.DisplayMemberPath = "Name";
            AnimalsInZoo.SelectedValuePath = "Id";
            AnimalsInZoo.ItemsSource = animalsInZoo;


        }
    }
}
