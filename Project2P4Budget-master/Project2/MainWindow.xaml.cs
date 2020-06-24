using System;
using System.ComponentModel;
using System.Windows;

namespace Project2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Check check = null;
        
        public MainWindow()
        {
            InitializeComponent();
            TitleOfProgram.Content += DateTime.Now.Year.ToString();

            if (DateTime.Now.Hour>19)
            {
                WelcomeLabel.Content += "Dobry wieczór!  :) Dobrze Cię widzieć, fajnie że jesteś - uśmiechnij się! Proszę.";
            }
            else
               WelcomeLabel.Content += "Dzięń dobry!  :) Dobrze Cię widzieć, fajnie że jesteś - uśmiechnij się! Proszę.";

        }
        /// <summary>
        /// Tworzenie BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += creatingDBBackgroundWorker_doWork;
            backgroundWorker.ProgressChanged += backgroundWorkerDBCreating_Progress;
            backgroundWorker.RunWorkerCompleted += backgroundWorkerCreated_End;
            backgroundWorker.WorkerReportsProgress = true;
            GoToDataButton.IsEnabled = false;
            GoToModyfDateButton.IsEnabled = false;
            CrateButton.IsEnabled = false;
            backgroundWorker.RunWorkerAsync();
          
        }

        private void backgroundWorkerCreated_End(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBarCreation.Value = 0;
            GoToDataButton.IsEnabled = true;
            GoToModyfDateButton.IsEnabled = true;
            CrateButton.IsEnabled = true;
        }

        private void backgroundWorkerDBCreating_Progress(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarCreation.Value += e.ProgressPercentage;
        }

        private void creatingDBBackgroundWorker_doWork(object sender, DoWorkEventArgs e)
        {

            var worker = (BackgroundWorker)sender;
            using (var createDB = new BudgetContext())
            {
                if (!createDB.Database.Exists())
                {

                    int year = DateTime.Now.Year;
                    Budget[] budget = new Budget[12];
                    for (int j = 0; j < 10; j++)
                    {
                        if (j >= 1)
                        {
                            year += 1;
                        }
                        for (int i = 0; i < budget.Length; i++)
                        {
                            budget[i] = new Budget(year, i + 1);
                            var debts = new Dlugi(0, 0, 0, 0, budget[i]);
                            budget[i].Dlugi = debts;
                            var children = new Dzieci(0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].Dzieci = children;
                            var hygiene = new Higiena(0, 0, 0, 0, 0, budget[i]);
                            budget[i].Higiena = hygiene;
                            var difExpenses = new InneWydatki(0, 0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].InneWydatki = difExpenses;
                            var food = new Jedzenie(0, 0, 0, 0, 0, budget[i]);
                            budget[i].Jedzenie = food;
                            var house = new Mieszkanie(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].Mieszkanie = house;
                            var revenues = new Przychody(0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].Przychody = revenues;
                            var entertaiment = new Rozrywka(0, 0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].Rozrywka = entertaiment;
                            var telecommunication = new Telekomunikacja(0, 0, 0, 0, 0, budget[i]);
                            budget[i].Telekomunikacja = telecommunication;
                            var transport = new Transport(0, 0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].Transport = transport;
                            var clothes = new Ubrania(0, 0, 0, 0, 0, budget[i]);
                            budget[i].Ubrania = clothes;
                            var health = new Zdrowie(0, 0, 0, 0, budget[i]);
                            budget[i].Zdrowie = health;
                            var buildingSavings = new BudowanieOszczednosci(0, 0, 0, 0, 0, 0, 0, 0, budget[i]);
                            budget[i].BudowanieOszczednosci = buildingSavings;
                            createDB.Budżet.Add(budget[i]);
                            createDB.BudowanieOszczednoscis.Add(buildingSavings);
                            createDB.Dzieciaki.Add(children);
                            createDB.Długiiii.Add(debts);
                            createDB.InneWydatków.Add(difExpenses);
                            createDB.Higieny.Add(hygiene);
                            createDB.Jedzenia.Add(food);
                            createDB.Mieszkania.Add(house);
                            createDB.PrzychodyDDD.Add(revenues);
                            createDB.Rozrywki.Add(entertaiment);
                            createDB.Telekomunikacje.Add(telecommunication);
                            createDB.Transporty.Add(transport);
                            createDB.Ubranki.Add(clothes);
                            createDB.Zdrowia.Add(health);
                            worker.ReportProgress(1);

                        }
                    }
                    MessageBox.Show("Baza danych została utworzona :)", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Information);


                    createDB.SaveChanges();
                    return;
                }
                else
                {
                    MessageBox.Show("Baza danych jest już utworzona :)", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /// <summary>
        /// Przejscie do innych funkcjonalności
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //https://www.altcontroldelete.pl/artykuly/implementacja-backgroundworker-w-wpf/
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //progres bar do naprawy
            using(var db= new BudgetContext())
            {
                if (db.Database.Exists())
                {
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.DoWork += backgroundWorker_DoWork;
                    worker.ProgressChanged += backgroundWorker_ProgressChanged;
                    worker.RunWorkerCompleted += backgroundWorker_TaskCompleted;
                    worker.WorkerReportsProgress = true;
                    GoToDataButton.IsEnabled = false;
                    GoToModyfDateButton.IsEnabled = false;
                    CrateButton.IsEnabled = false;
                    //var check = new Check();
                    //check.Show();
                    //this.Close();
                    worker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Zanim przejdziesz do przeglądu bazy danych, utwórz ją :)","Mały problem",MessageBoxButton.OK,MessageBoxImage.Information);
                }
      
            }

        }

        private void backgroundWorker_TaskCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            check.Show();
            this.Close();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarCreation.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            //https://stackoverflow.com/questions/2329978/the-calling-thread-must-be-sta-because-many-ui-components-require-this
            Application.Current.Dispatcher.Invoke((Action)delegate //problem z wątkami SDA
            {
                check = new Check();
                worker.ReportProgress(90);
                worker.ReportProgress(100);
            });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var db = new BudgetContext())
            {
                if (db.Database.Exists())
                {
                    InsertDate insert = new InsertDate();
                    insert.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Zanim przejdziesz do przeglądu bazy danych, utwórz ją :)", "Mały problem", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }

           
        }
    }
}
