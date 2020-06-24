using Project2.ViewsModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Project2
{
    /// <summary>
    /// Logika interakcji dla klasy Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        public Check()
        {
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += backgroundWorker_DoWork;
            ////worker.ProgressChanged += backgroundWorker_ProgressChanged;
            //worker.RunWorkerCompleted += backgroundWorker_TaskCompleted;
            //worker.WorkerReportsProgress = true;


            //worker.RunWorkerAsync();
            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += timer_Tick;
            //timer.Start();
            InitializeComponent();

        }
        //private void backgroundWorker_TaskCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    ProgressBarCreation.Value = e.ProgressPercentage;
        //}

        //private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    var worker = (BackgroundWorker)sender;
        //    Application.Current.Dispatcher.Invoke((Action)delegate //problem z wątkami SDA
        //    {
        //        InitializeComponent();
        //    });
        //    worker.ReportProgress(90);
        //    worker.ReportProgress(100);
        //}
        ////view test






        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    Clock.Text = DateTime.Now.ToLongTimeString();
        //}

        private void CheckView_Clicked(object sender, RoutedEventArgs e)
        {
            var Check = new Check();
            Check.Show();
            
            //WIDOKI
            //DataContext = new CheckingDateModel()
            //{
            //    Year = (int)Year.SelectedValue,
            //    Month = (int)Month.Tag
            //};
        }

        private void ModyfyView_Clicked(object sender, RoutedEventArgs e)
        {
            var Modyfy = new InsertDate();
            Modyfy.Show();
            //WIDOKI
            //DataContext = new ModyfingDateModel();
        }
        
        private void ChartView_Clicked(object sender, RoutedEventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            //WIDOKI
            //DataContext = new ChartsModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ustawienie comboboxa year
            DateTime localDate = DateTime.Now;

            Year.SelectedValue = localDate.Year;
            //ustwienie comboboxa MOnth
            for (int i = 0 + 1; i < Month.Items.Count + 1; i++)
            {
                if (i == localDate.Month)
                {
                    Month.SelectedValue = i;
                }
            }

            //załadowanie wartości z bazy danych
            LoadFromDB();


        }

        //zaladowanie wartości z BD
        private void LoadFromDB()
        {
            using (var DateFromDataBase = new BudgetContext())
            {
                ObservableCollection<Budget> budgetToObserver = new ObservableCollection<Budget>();
                foreach (var item in DateFromDataBase.Budżet.ToList<Budget>())
                {

                    if (item.Rok == Convert.ToInt32(Year.SelectedValue) && item.Miesiąc - 1 == Month.SelectedIndex)
                    {

                        var buildingSavings = new BudowanieOszczednosci(item.BudowanieOszczednosci.FunduszAwaryjny, item.BudowanieOszczednosci.FunduszWydatkówNieregularnych, item.BudowanieOszczednosci.PoduszkaFinansowa, item.BudowanieOszczednosci.KontoEmerytalne, item.BudowanieOszczednosci.NadpłataDlugow, item.BudowanieOszczednosci.FunduszWakacyjny, item.BudowanieOszczednosci.FunduszPrezentySwiateczne, item.BudowanieOszczednosci.Inne);
                        var loans = new Dlugi(item.Dlugi.KredytHipoteczny, item.Dlugi.KredytKonsumpcyjny, item.Dlugi.PozyczkaOsobista, item.Dlugi.Inne);
                        var children = new Dzieci(item.Dzieci.ArtykulySzkolne, item.Dzieci.DodatkoweZajecia, item.Dzieci.WplatyNaSzkole, item.Dzieci.ZabawkiGry, item.Dzieci.OpiekaNadDziecmi, item.Dzieci.Inne);
                        var hygiene = new Higiena(item.Higiena.Kosmetyki, item.Higiena.SrodkiCzystosci, item.Higiena.Fryzjer, item.Higiena.Kosmetyczka, item.Higiena.Inne);
                        var diff = new InneWydatki(item.InneWydatki.Dobroczynnosc, item.InneWydatki.Prezenty, item.InneWydatki.RTVAGD, item.InneWydatki.Oprogramowanie, item.InneWydatki.EdukacjaSzkolenia, item.InneWydatki.Uslugi, item.InneWydatki.Podatki, item.InneWydatki.Inne);
                        var food = new Jedzenie(item.Jedzenie.JedzenieDom, item.Jedzenie.JedzenieMiasto, item.Jedzenie.JedzeniePraca, item.Jedzenie.Alkohol, item.Jedzenie.Inne);
                        var flat = new Mieszkanie(item.Mieszkanie.Czynsz, item.Mieszkanie.WodaKanalizacja, item.Mieszkanie.Prad, item.Mieszkanie.Gaz, item.Mieszkanie.Ogrzewanie, item.Mieszkanie.Smieci, item.Mieszkanie.KonserwacjeNaprawy, item.Mieszkanie.Wyposazenie, item.Mieszkanie.UbezpieczenieNieruchomosci, item.Mieszkanie.Inne);
                        var profit = new Przychody(item.Przychody.Wynagrodzenie, item.Przychody.WynagrodzeniePartnera, item.Przychody.Premia, item.Przychody.PrzychodyZPremiiBankowych, item.Przychody.OdsetkiBankowe, item.Przychody.SprzedazAllegro, item.Przychody.Inne);
                        var entertaiment = new Rozrywka(item.Rozrywka.SilowniaBasen, item.Rozrywka.KinoTeatr, item.Rozrywka.Koncerty, item.Rozrywka.Czasopisma, item.Rozrywka.Ksiazki, item.Rozrywka.Hobby, item.Rozrywka.Hotel, item.Rozrywka.Inne);
                        var telecomunication = new Telekomunikacja(item.Telekomunikacja.Telefon1, item.Telekomunikacja.Telefon2, item.Telekomunikacja.Tv, item.Telekomunikacja.Internet, item.Telekomunikacja.Inne);
                        var transport = new Transport(item.Transport.PaliwoSamochod, item.Transport.PrzegladNaprawa, item.Transport.Wyposazenie, item.Transport.DodatkoweUbezp, item.Transport.BiletyKomunikacjiMiejskiej, item.Transport.BiletyPKPPKS, item.Transport.Taxi, item.Transport.Inne);
                        var clothes = new Ubrania(item.Ubrania.ZwykleUbrania, item.Ubrania.SportoweUbrania, item.Ubrania.Buty, item.Ubrania.Dodatki, item.Ubrania.Inne);
                        var helath = new Zdrowie(item.Zdrowie.Lekarz, item.Zdrowie.Badania, item.Zdrowie.Lekarstwa, item.Zdrowie.Inne);
                        var budget = new Budget(food, profit, transport, flat, telecomunication, helath, clothes, hygiene, children, entertaiment, loans, diff, buildingSavings);
                        budgetToObserver.Add(budget);
                        DataContext = budgetToObserver;
                        return; 
                    }
                }


            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //załadowanie wartości z bazy danych
            LoadFromDB();
        }

        //private void CheckAll_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (CBDlugi ==null)
        //        return;
            
        //    CBDlugi.IsChecked = true;
        //    CBDzieci.IsChecked = true;
        //    CBHigiena.IsChecked = true;
        //    CBInne.IsChecked = true;
        //    CBJedzenie.IsChecked = true;
        //    CBMieszkanie.IsChecked = true;
        //    CBPrzychody.IsChecked = true;
        //    CBRozrywka.IsChecked = true;
        //    CBTelekomunikacja.IsChecked = true;
        //    CBTransport.IsChecked = true;
        //    CBUbranie.IsChecked = true;
        //    CBZdrowie.IsChecked = true;
        //    CBSavings.IsChecked = true;
        //}

 
        //private void DisplayInfo_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (CBSavings == null || CBInne==null)
        //        return;
        //    if (CBDlugi.IsChecked==false)
        //    {
        //        GroupDebts.Visibility = Visibility.Collapsed;
        //        GroupDebtsValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupDebts.Visibility = Visibility.Visible;
        //        GroupDebtsValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBDzieci.IsChecked == false)
        //    {
        //        GroupChildren.Visibility = Visibility.Collapsed;
        //        GroupChildrenValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupChildren.Visibility = Visibility.Visible;
        //        GroupChildrenValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBHigiena.IsChecked == false)
        //    {
        //        GroupHygiene.Visibility = Visibility.Collapsed;
        //        GroupHygieneValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupHygiene.Visibility = Visibility.Visible;
        //        GroupHygieneValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBInne.IsChecked == false)
        //    {
        //        GroupDiffrent.Visibility = Visibility.Collapsed;
        //        GroupDiffrentValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupDiffrent.Visibility = Visibility.Visible;
        //        GroupDiffrentValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBJedzenie.IsChecked == false)
        //    {
        //        GroupFood.Visibility = Visibility.Collapsed;
        //        GroupFoodValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupFood.Visibility = Visibility.Visible;
        //        GroupFoodValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBMieszkanie.IsChecked == false)
        //    {
        //        GroupFlat.Visibility = Visibility.Collapsed;
        //        GroupFlatValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupFlat.Visibility = Visibility.Visible;
        //        GroupFlatValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBPrzychody.IsChecked == false)
        //    {
        //        GroupProfit.Visibility = Visibility.Collapsed;
        //        GroupProfitValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupProfit.Visibility = Visibility.Visible;
        //        GroupProfitValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBRozrywka.IsChecked == false)
        //    {
        //        GroupEntertaiment.Visibility = Visibility.Collapsed;
        //        GroupEntertaimentValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupEntertaiment.Visibility = Visibility.Visible;
        //        GroupEntertaimentValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBTelekomunikacja.IsChecked == false)
        //    {
        //        GroupTelecomunication.Visibility = Visibility.Collapsed;
        //        GroupTelecomunicationValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupTelecomunication.Visibility = Visibility.Visible;
        //        GroupTelecomunicationValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBTransport.IsChecked == false)
        //    {
        //        GroupTransport.Visibility = Visibility.Collapsed;
        //        GroupTransportValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupTransport.Visibility = Visibility.Visible;
        //        GroupTransportValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBUbranie.IsChecked == false)
        //    {
        //        GroupCloathesValues.Visibility = Visibility.Collapsed;
        //        GroupClothes.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupCloathesValues.Visibility = Visibility.Visible;
        //        GroupClothes.Visibility = Visibility.Visible;
        //    }
        //    if (CBZdrowie.IsChecked == false)
        //    {
        //        GroupHelath.Visibility = Visibility.Collapsed;
        //        GroupHelathValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupHelath.Visibility = Visibility.Visible;
        //        GroupHelathValues.Visibility = Visibility.Visible;
        //    }
        //    if (CBSavings.IsChecked==false)
        //    {
        //        GroupSavings.Visibility = Visibility.Collapsed;
        //        GroupSavingsValues.Visibility = Visibility.Collapsed;
        //        CBAll.IsChecked = false;
        //    }
        //    else
        //    {
        //        GroupSavings.Visibility = Visibility.Visible;
        //        GroupSavingsValues.Visibility = Visibility.Visible;
        //    }

        //}

        private void Image_TouchMove(object sender, TouchEventArgs e)
        {
            LoadFromDB();
        }
    }
}
