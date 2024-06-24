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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Animal> animals = new List<Animal>();
        public MainPage()
        {
            InitializeComponent();
            LstView.ItemsSource = animals;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == null) return;
            animals.Add(new Animal(Name.Text));
            LstView.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = LstView.SelectedItem as Animal;
            if (a != null)
            {
                animals.Remove(a);
                LstView.Items.Refresh();
            }
        }
    }
}
