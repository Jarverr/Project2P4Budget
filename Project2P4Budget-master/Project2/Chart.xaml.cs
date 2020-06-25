using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Project2
{
    /// <summary>
    /// Logika interakcji dla klasy Chart.xaml
    /// </summary>
    public partial class Chart : Window
    {
        public Chart()
        {
            InitializeComponent();
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
            Dictionary<string,decimal> date = LoadFromDB();
            DrawingChart(date);
        }
        private void DrawingChart(Dictionary<string,decimal> date)
        {
            var maxHeight = ChartPlace.MaxHeight;  //gdy nie ustawie recznie heighta to daje 0 :C
            decimal actualHeight;
            decimal height=0;
            Decimal.TryParse(ChartPlace.Height.ToString(), out actualHeight);
            foreach (var item in date)
            {
                if (height < item.Value)
                    height = item.Value;
            }

            if (date["Children"] != 0)
                RectChildren.Height = (double)(actualHeight * date["Children"] / date["Total"]);
            else
                RectChildren.Height = 0;

            if (date["Cloathes"] != 0)
                RectCloathes.Height = (double)(actualHeight * date["Cloathes"] / date["Total"]);
            else
                RectCloathes.Height = 0;

            if (date["Loans"] != 0)
                RectDebts.Height = (double)(actualHeight * date["Loans"] / date["Total"]);
            else
                RectDebts.Height = 0;

            if (date["Diffrent"] != 0)
                RectDiffrent.Height = (double)(actualHeight * date["Diffrent"] / date["Total"]);
            else
                RectDiffrent.Height = 0;

            if (date["Entertaiment"] != 0)
                RectEntertaiment.Height = (double)(actualHeight * date["Entertaiment"] / date["Total"]);
            else
                RectEntertaiment.Height = 0;

            if (date["Flat"] != 0)
                RectFlat.Height = (double)(actualHeight * date["Flat"] / date["Total"]);
            else
                RectFlat.Height = 0;

            if (date["Food"] != 0)
                RectFood.Height = (double)(actualHeight * date["Food"] / date["Total"]);
            else
                RectFood.Height = 0;

            if (date["Health"] != 0)
                RectHealth.Height = (double)(actualHeight * date["Health"] / date["Total"]);
            else
                RectHealth.Height = 0;

            if (date["Hygiene"] != 0)
                RectHygiene.Height = (double)(actualHeight * date["Hygiene"] / date["Total"]);
            else
                RectHygiene.Height = 0;

            if (date["Profit"] != 0)
                RectProfit.Height = (double)(actualHeight * date["Profit"] / date["Total"]);
            else
                RectProfit.Height = 0;

            if (date["Savings"] != 0)
                RectSavings.Height = (double)(actualHeight * date["Savings"] / date["Total"]);
            else
                RectSavings.Height = 0;

            if (date["Telecomunication"] != 0)
                RectTelecomunication.Height = (double)(actualHeight * date["Telecomunication"] / date["Total"]);
            else
                RectTelecomunication.Height = 0;

            if (date["Transport"] != 0)
                RectTransport.Height = (double)(actualHeight * date["Transport"] / date["Total"]);
            else
                RectTransport.Height = 0;
            //RectChildren.Width = WidthForRect.Width.Value;
            //RectCloathes.Width = WidthForRect.Width.Value;
            //RectDebts.Width= WidthForRect.Width.Value;
            //RectDiffrent.Width= WidthForRect.Width.Value;
            //RectEntertaiment.Width= WidthForRect.Width.Value;
            //RectFlat.Width= WidthForRect.Width.Value;
            //RectFood.Width= WidthForRect.Width.Value;
            //RectHealth.Width= WidthForRect.Width.Value;
            //RectHygiene.Width= WidthForRect.Width.Value;
            //RectProfit.Width= WidthForRect.Width.Value;
            //RectSavings.Width= WidthForRect.Width.Value;
            //RectTelecomunication.Width= WidthForRect.Width.Value;
            //RectTransport.Width= WidthForRect.Width.Value;
            RectChildren.Width = (WindowName.Width-10-130/*Legend.Width*/) / 13;
            RectCloathes.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectDebts.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectDiffrent.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectEntertaiment.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectFlat.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectFood.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectHealth.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectHygiene.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectProfit.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectSavings.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectTelecomunication.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectTransport.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
        }

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

        private Dictionary<string,decimal> LoadFromDB()
        {
            using (var DateFromDataBase = new BudgetContext())
            {
                decimal total=0;
                decimal num=0;
                Dictionary<string, decimal> toReturn = new Dictionary<string, decimal>();
                ObservableCollection<Budget> budgetToObserver = new ObservableCollection<Budget>();
                foreach (var item in DateFromDataBase.Budżet.ToList<Budget>())
                {

                    if (item.Rok == Convert.ToInt32(Year.SelectedValue) && item.Miesiąc - 1 == Month.SelectedIndex)
                    {

                        var buildingSavings = new BudowanieOszczednosci(item.BudowanieOszczednosci.FunduszAwaryjny, item.BudowanieOszczednosci.FunduszWydatkówNieregularnych, item.BudowanieOszczednosci.PoduszkaFinansowa, item.BudowanieOszczednosci.KontoEmerytalne, item.BudowanieOszczednosci.NadpłataDlugow, item.BudowanieOszczednosci.FunduszWakacyjny, item.BudowanieOszczednosci.FunduszPrezentySwiateczne, item.BudowanieOszczednosci.Inne);
                        num = buildingSavings.FunduszAwaryjny + buildingSavings.FunduszPrezentySwiateczne + buildingSavings.FunduszWakacyjny + buildingSavings.FunduszWydatkówNieregularnych + buildingSavings.Inne + buildingSavings.KontoEmerytalne + buildingSavings.NadpłataDlugow + buildingSavings.PoduszkaFinansowa;
                        total = num;
                        toReturn.Add("Savings", num);

                        var loans = new Dlugi(item.Dlugi.KredytHipoteczny, item.Dlugi.KredytKonsumpcyjny, item.Dlugi.PozyczkaOsobista, item.Dlugi.Inne);
                        num = loans.Inne + loans.KredytHipoteczny + loans.KredytKonsumpcyjny + loans.PozyczkaOsobista;
                        total += num;
                        toReturn.Add("Loans", num);

                        var children = new Dzieci(item.Dzieci.ArtykulySzkolne, item.Dzieci.DodatkoweZajecia, item.Dzieci.WplatyNaSzkole, item.Dzieci.ZabawkiGry, item.Dzieci.OpiekaNadDziecmi, item.Dzieci.Inne);
                        num = children.ArtykulySzkolne + children.DodatkoweZajecia + children.WplatyNaSzkole + children.ZabawkiGry + children.OpiekaNadDziecmi + children.Inne;
                        total += num;
                        toReturn.Add("Children", num);

                        var hygiene = new Higiena(item.Higiena.Kosmetyki, item.Higiena.SrodkiCzystosci, item.Higiena.Fryzjer, item.Higiena.Kosmetyczka, item.Higiena.Inne);
                        num = hygiene.Kosmetyczka + hygiene.Kosmetyki + hygiene.SrodkiCzystosci + hygiene.Fryzjer + hygiene.Inne;
                        total += num;
                        toReturn.Add("Hygiene", num);

                        var diff = new InneWydatki(item.InneWydatki.Dobroczynnosc, item.InneWydatki.Prezenty, item.InneWydatki.RTVAGD, item.InneWydatki.Oprogramowanie, item.InneWydatki.EdukacjaSzkolenia, item.InneWydatki.Uslugi, item.InneWydatki.Podatki, item.InneWydatki.Inne);
                        num = diff.Dobroczynnosc + diff.Inne + diff.Podatki + diff.RTVAGD + diff.Oprogramowanie + diff.EdukacjaSzkolenia + diff.Uslugi + diff.Podatki;
                        total += num;
                        toReturn.Add("Diffrent", num);

                        var food = new Jedzenie(item.Jedzenie.JedzenieDom, item.Jedzenie.JedzenieMiasto, item.Jedzenie.JedzeniePraca, item.Jedzenie.Alkohol, item.Jedzenie.Inne);
                        num = food.JedzenieDom + food.JedzenieMiasto + food.JedzeniePraca + food.Alkohol + food.Inne;
                        total += num;
                        toReturn.Add("Food", num);

                        var flat = new Mieszkanie(item.Mieszkanie.Czynsz, item.Mieszkanie.WodaKanalizacja, item.Mieszkanie.Prad, item.Mieszkanie.Gaz, item.Mieszkanie.Ogrzewanie, item.Mieszkanie.Smieci, item.Mieszkanie.KonserwacjeNaprawy, item.Mieszkanie.Wyposazenie, item.Mieszkanie.UbezpieczenieNieruchomosci, item.Mieszkanie.Inne);
                        num = flat.Czynsz + flat.WodaKanalizacja + flat.WodaKanalizacja + flat.Prad + flat.Gaz + flat.Ogrzewanie + flat.Smieci + flat.KonserwacjeNaprawy + flat.Wyposazenie + flat.UbezpieczenieNieruchomosci + flat.Inne;
                        total += num;
                        toReturn.Add("Flat", num);

                        var profit = new Przychody(item.Przychody.Wynagrodzenie, item.Przychody.WynagrodzeniePartnera, item.Przychody.Premia, item.Przychody.PrzychodyZPremiiBankowych, item.Przychody.OdsetkiBankowe, item.Przychody.SprzedazAllegro, item.Przychody.Inne);
                        num = profit.Wynagrodzenie + profit.WynagrodzeniePartnera + profit.Premia + profit.PrzychodyZPremiiBankowych + profit.OdsetkiBankowe + profit.SprzedazAllegro + profit.Inne;
                        total += num;
                        toReturn.Add("Profit", num);

                        var entertaiment = new Rozrywka(item.Rozrywka.SilowniaBasen, item.Rozrywka.KinoTeatr, item.Rozrywka.Koncerty, item.Rozrywka.Czasopisma, item.Rozrywka.Ksiazki, item.Rozrywka.Hobby, item.Rozrywka.Hotel, item.Rozrywka.Inne);
                        num = entertaiment.SilowniaBasen + entertaiment.KinoTeatr + entertaiment.Koncerty + entertaiment.Czasopisma + entertaiment.Ksiazki + entertaiment.Inne + entertaiment.Hobby + entertaiment.Hotel;
                        total += num;
                        toReturn.Add("Entertaiment", num);

                        var telecomunication = new Telekomunikacja(item.Telekomunikacja.Telefon1, item.Telekomunikacja.Telefon2, item.Telekomunikacja.Tv, item.Telekomunikacja.Internet, item.Telekomunikacja.Inne);
                        num = telecomunication.Telefon1 + telecomunication.Telefon2 + telecomunication.Tv + telecomunication.Inne + telecomunication.Internet;
                        total += num;
                        toReturn.Add("Telecomunication", num);

                        var transport = new Transport(item.Transport.PaliwoSamochod, item.Transport.PrzegladNaprawa, item.Transport.Wyposazenie, item.Transport.DodatkoweUbezp, item.Transport.BiletyKomunikacjiMiejskiej, item.Transport.BiletyPKPPKS, item.Transport.Taxi, item.Transport.Inne);
                        num = transport.Inne + transport.PaliwoSamochod + transport.PrzegladNaprawa + transport.Wyposazenie + transport.DodatkoweUbezp + transport.BiletyKomunikacjiMiejskiej + transport.BiletyPKPPKS + transport.Taxi;
                        total += num;
                        toReturn.Add("Transport", num);

                        var clothes = new Ubrania(item.Ubrania.ZwykleUbrania, item.Ubrania.SportoweUbrania, item.Ubrania.Buty, item.Ubrania.Dodatki, item.Ubrania.Inne);
                        num = clothes.SportoweUbrania + clothes.ZwykleUbrania + clothes.Buty + clothes.Dodatki + clothes.Inne;
                        total += num;
                        toReturn.Add("Cloathes", num);

                        var helath = new Zdrowie(item.Zdrowie.Lekarz, item.Zdrowie.Badania, item.Zdrowie.Lekarstwa, item.Zdrowie.Inne);
                        num = helath.Lekarstwa + helath.Lekarz + helath.Badania + helath.Inne;
                        total += num;
                        toReturn.Add("Health", num);


                        var budget = new Budget(food, profit, transport, flat, telecomunication, helath, clothes, hygiene, children, entertaiment, loans, diff, buildingSavings);
                        toReturn.Add("Total", total);
                        budgetToObserver.Add(budget);
                        DataContext = budgetToObserver;
                        return toReturn;
                    }
                }
                return toReturn;

            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //załadowanie wartości z bazy danych
            Dictionary<string, decimal> date = LoadFromDB();
            if (date.Count!=0)
            {
                DrawingChart(date);
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            RectChildren.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectCloathes.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectDebts.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectDiffrent.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectEntertaiment.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectFlat.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectFood.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectHealth.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectHygiene.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectProfit.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectSavings.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectTelecomunication.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;
            RectTransport.Width = (WindowName.Width - 10 - 130/*Legend.Width*/) / 13;

        }
    }
}
