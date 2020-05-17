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

namespace Project2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var createDB = new BudgetContext())
            {
                var budget = new Budget( 2021, 1);
                var debts = new Dlugi(1, 0, 0, 0, 0, budget);
                budget.Dlugi = debts;
                var children = new Dzieci(1, 0, 0, 0, 0, 0, 0, budget);
                budget.Dzieci = children;
                var hygiene = new Higiena(1, 0, 0, 0, 0, 0, budget);
                budget.Higiena = hygiene;
                var difExpenses = new InneWydatki(1, 0, 0, 0, 0, 0, 0, 0, 0, budget);
                budget.InneWydatki = difExpenses;
                var food = new Jedzenie(1, 0, 0, 0, 0, 0, budget);
                budget.Jedzenie = food;
                var house = new Mieszkanie(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, budget);
                budget.Mieszkanie = house;
                var revenues = new Przychody(1, 0, 0, 0, 0, 0, 0, 0, budget);
                budget.Przychody = revenues;
                var entertaiment = new Rozrywka(1, 0, 0, 0, 0, 0, 0, 0, budget);
                budget.Rozrywka = entertaiment;
                var telecommunication = new Telekomunikacja(1, 0, 0, 0, 0, 0, budget);
                budget.Telekomunikacja = telecommunication;
                var transport = new Transport(1, 0, 0, 0, 0, 0, 0, 0, 0, budget);
                budget.Transport = transport;
                var clothes = new Ubrania(1, 0, 0, 0, 0, 0, budget);
                budget.Ubrania = clothes;
                var health =new Zdrowie(1, 0, 0, 0, 0, budget);
                budget.Zdrowie = health;
                createDB.SaveChanges();
            }
        }
    }
}
