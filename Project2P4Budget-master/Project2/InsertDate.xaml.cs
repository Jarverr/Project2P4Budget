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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Project2
{
    /// <summary>
    /// Logika interakcji dla klasy InsertDate.xaml
    /// </summary>
    public partial class InsertDate : Window
    {
        private Budget budget;
        public InsertDate()
        {
            InitializeComponent();
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
            budget = new Budget();
            budget.BudowanieOszczednosci = new BudowanieOszczednosci();
            budget.Dlugi = new Dlugi();
            budget.Dzieci = new Dzieci();
            budget.Higiena = new Higiena();
            budget.InneWydatki = new InneWydatki();
            budget.Jedzenie = new Jedzenie();
            budget.Mieszkanie = new Mieszkanie();
            budget.Przychody = new Przychody();
            budget.Rozrywka = new Rozrywka();
            budget.Telekomunikacja = new Telekomunikacja();
            budget.Transport = new Transport();
            budget.Ubrania = new Ubrania();
            budget.Zdrowie = new Zdrowie();

            DataContext = budget;
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
        private void CheckAll_Checked(object sender, RoutedEventArgs e)
        {
            if (CBDlugi == null)
                return;

            CBDlugi.IsChecked = true;
            CBDzieci.IsChecked = true;
            CBHigiena.IsChecked = true;
            CBInne.IsChecked = true;
            CBJedzenie.IsChecked = true;
            CBMieszkanie.IsChecked = true;
            CBPrzychody.IsChecked = true;
            CBRozrywka.IsChecked = true;
            CBTelekomunikacja.IsChecked = true;
            CBTransport.IsChecked = true;
            CBUbranie.IsChecked = true;
            CBZdrowie.IsChecked = true;
            CBSavings.IsChecked = true;
        }
        private void DisplayInfo_Checked(object sender, RoutedEventArgs e)
        {
            if (CBSavings == null || CBInne == null)
                return;
            if (CBDlugi.IsChecked == false)
            {
                GroupDebts.Visibility = Visibility.Collapsed;
                GroupDebtsValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupDebts.Visibility = Visibility.Visible;
                GroupDebtsValues.Visibility = Visibility.Visible;
            }
            if (CBDzieci.IsChecked == false)
            {
                GroupChildren.Visibility = Visibility.Collapsed;
                GroupChildrenValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupChildren.Visibility = Visibility.Visible;
                GroupChildrenValues.Visibility = Visibility.Visible;
            }
            if (CBHigiena.IsChecked == false)
            {
                GroupHygiene.Visibility = Visibility.Collapsed;
                GroupHygieneValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupHygiene.Visibility = Visibility.Visible;
                GroupHygieneValues.Visibility = Visibility.Visible;
            }
            if (CBInne.IsChecked == false)
            {
                GroupDiff.Visibility = Visibility.Collapsed;
                GroupDiffValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupDiff.Visibility = Visibility.Visible;
                GroupDiffValues.Visibility = Visibility.Visible;
            }
            if (CBJedzenie.IsChecked == false)
            {
                GroupFood.Visibility = Visibility.Collapsed;
                GroupFoodValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupFood.Visibility = Visibility.Visible;
                GroupFoodValues.Visibility = Visibility.Visible;
            }
            if (CBMieszkanie.IsChecked == false)
            {
                GroupFlat.Visibility = Visibility.Collapsed;
                GroupFlatValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupFlat.Visibility = Visibility.Visible;
                GroupFlatValues.Visibility = Visibility.Visible;
            }
            if (CBPrzychody.IsChecked == false)
            {
                GroupProfit.Visibility = Visibility.Collapsed;
                GroupProfitValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupProfit.Visibility = Visibility.Visible;
                GroupProfitValues.Visibility = Visibility.Visible;
            }
            if (CBRozrywka.IsChecked == false)
            {
                GroupEntertaiment.Visibility = Visibility.Collapsed;
                GroupEntertaimentValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupEntertaiment.Visibility = Visibility.Visible;
                GroupEntertaimentValues.Visibility = Visibility.Visible;
            }
            if (CBTelekomunikacja.IsChecked == false)
            {
                GroupTelecomunication.Visibility = Visibility.Collapsed;
                GroupTelecomunicationValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupTelecomunication.Visibility = Visibility.Visible;
                GroupTelecomunicationValues.Visibility = Visibility.Visible;
            }
            if (CBTransport.IsChecked == false)
            {
                GroupTransport.Visibility = Visibility.Collapsed;
                GroupTransportValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupTransport.Visibility = Visibility.Visible;
                GroupTransportValues.Visibility = Visibility.Visible;
            }
            if (CBUbranie.IsChecked == false)
            {
                GroupCloathesValues.Visibility = Visibility.Collapsed;
                GroupClothes.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupCloathesValues.Visibility = Visibility.Visible;
                GroupClothes.Visibility = Visibility.Visible;
            }
            if (CBZdrowie.IsChecked == false)
            {
                GroupHelath.Visibility = Visibility.Collapsed;
                GroupHelathValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupHelath.Visibility = Visibility.Visible;
                GroupHelathValues.Visibility = Visibility.Visible;
            }
            if (CBSavings.IsChecked == false)
            {
                GroupSavings.Visibility = Visibility.Collapsed;
                GroupSavingsValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupSavings.Visibility = Visibility.Visible;
                GroupSavingsValues.Visibility = Visibility.Visible;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            
            ///Paroswanie texboxow
            /*
            Decimal[] number = new Decimal[10];
            //Przychody
            Decimal.TryParse(TextBoxReward.Text, out number[0]);
            Decimal.TryParse(TextBoxRewardPartner.Text, out number[1]);
            Decimal.TryParse(TextBoxBonus.Text, out number[2]);
            Decimal.TryParse(TextBoxBankBonus.Text, out number[3]);
            Decimal.TryParse(TextBoxInterestBank.Text, out number[4]);
            Decimal.TryParse(TextBoxAllegro.Text, out number[5]);
            Decimal.TryParse(TextBoxDiffrentReward.Text, out number[6]);
            var profit = new Przychody(number[0],number[1],number[2],number[3],number[4],number[5],number[6]);
            //jedzenie
            Decimal.TryParse(TextBoxFoodHouse.Text, out number[0]);
            Decimal.TryParse(TextBoxFoodCity.Text, out number[1]);
            Decimal.TryParse(TextBoxFoodWork.Text, out number[2]);
            Decimal.TryParse(TextBoxAlcohol.Text, out number[3]);
            Decimal.TryParse(TextBoxDiffrentFood.Text, out number[4]);
            var food = new Jedzenie(number[0], number[1], number[2], number[3], number[4]);
            //mieszkanie
            Decimal.TryParse(TextBoxRent.Text, out number[0]);
            Decimal.TryParse(TextBoxWater.Text, out number[1]);
            Decimal.TryParse(TextBoxPower.Text, out number[2]);
            Decimal.TryParse(TextBoxGas.Text, out number[3]);
            Decimal.TryParse(TextBoxHeating.Text, out number[4]);
            Decimal.TryParse(TextBoxRubish.Text, out number[5]);
            Decimal.TryParse(TextBoxReparing.Text, out number[6]);
            Decimal.TryParse(TextBoxEquipment.Text, out number[7]);
            Decimal.TryParse(TextBoxInsurance.Text, out number[8]);
            Decimal.TryParse(TextBoxDiffrentFlat.Text, out number[9]);
            var flat = new Mieszkanie(number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7], number[8], number[9]);
            //transport
            Decimal.TryParse(TextBoxFuelCar.Text, out number[0]);
            Decimal.TryParse(TextBoxReparingCar.Text, out number[1]);
            Decimal.TryParse(TextBoxAdditionalEquipmentCar.Text, out number[2]);
            Decimal.TryParse(TextBoxInsuranceCar.Text, out number[3]);
            Decimal.TryParse(TextBoxTicketPublicTransport.Text, out number[4]);
            Decimal.TryParse(TextBoxPKSPKP.Text, out number[5]);
            Decimal.TryParse(TextBoxTaxi.Text, out number[6]);
            Decimal.TryParse(TextBoxDiffrentTransport.Text, out number[7]);
            var transport = new Transport(number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7]);
            //Telekomunikacja
            Decimal.TryParse(TextBoxPhone1.Text, out number[0]);
            Decimal.TryParse(TextBoxPhone2.Text, out number[1]);
            Decimal.TryParse(TextBoxTV.Text, out number[2]);
            Decimal.TryParse(TextBoxInternet.Text, out number[3]);
            Decimal.TryParse(TextBoxTelecomunication.Text, out number[4]);
            var telecomunication = new Telekomunikacja(number[0], number[1], number[2], number[3], number[4]);
            //OpiekaZdrowotna
            Decimal.TryParse(TextBoxDoc.Text, out number[0]);
            Decimal.TryParse(TextBoxSurvey.Text, out number[1]);
            Decimal.TryParse(TextBoxMedicine.Text, out number[2]);
            Decimal.TryParse(TextBoxDiffrentHealth.Text, out number[3]);
            var helath = new Zdrowie(number[0], number[1], number[2], number[3]);
            //Ubranie
            Decimal.TryParse(TextBoxNormalClothes.Text, out number[0]);
            Decimal.TryParse(TextBoxSportClothes.Text, out number[1]);
            Decimal.TryParse(TextBoxShoes.Text, out number[2]);
            Decimal.TryParse(TextBoxExtensions.Text, out number[3]);
            Decimal.TryParse(TextBoxDiffrentClothes.Text, out number[4]);
            var cloathes = new Ubrania(number[0], number[1], number[2], number[3], number[4]);
            //Higiena
            Decimal.TryParse(TextBoxCosmetics.Text, out number[0]);
            Decimal.TryParse(TextBoxCleaningSupplies.Text, out number[1]);
            Decimal.TryParse(TextBoxHairdresser.Text, out number[2]);
            Decimal.TryParse(TextBoxBeuatician.Text, out number[3]);
            Decimal.TryParse(TextBoxDiffrentHygiene.Text, out number[4]);
            var hygiene = new Higiena(number[0], number[1], number[2], number[3], number[4]);
            //Dzieci
            Decimal.TryParse(TextBoxSchoolArtical.Text, out number[0]);
            Decimal.TryParse(TextBoxExtraLessons.Text, out number[1]);
            Decimal.TryParse(TextBoxSchoolTaxes.Text, out number[2]);
            Decimal.TryParse(TextBoxJoys.Text, out number[3]);
            Decimal.TryParse(TextBoxChildcare.Text, out number[4]);
            Decimal.TryParse(TextBoxDiffrentChildren.Text, out number[5]);
            var children = new Dzieci(number[0], number[1], number[2], number[3], number[4],number[5]);
            //Rozrywka
            Decimal.TryParse(TextBoxGym.Text, out number[0]);
            Decimal.TryParse(TextBoxCinema.Text, out number[1]);
            Decimal.TryParse(TextBoxConcerts.Text, out number[2]);
            Decimal.TryParse(TextBoxNewspapers.Text, out number[3]);
            Decimal.TryParse(TextBoxBooks.Text, out number[4]);
            Decimal.TryParse(TextBoxHobbies.Text, out number[5]);
            Decimal.TryParse(TextBoxHotels.Text, out number[6]);
            Decimal.TryParse(TextBoxDiffrentEntertainment.Text, out number[7]);
            var entertaiment = new Rozrywka(number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7]);
            //Inne
            Decimal.TryParse(TextBoxCharity.Text, out number[0]);
            Decimal.TryParse(TextBoxPresent.Text, out number[1]);
            Decimal.TryParse(TextBoxRTV.Text, out number[2]);
            Decimal.TryParse(TextBoxSoftware.Text, out number[3]);
            Decimal.TryParse(TextBoxEducation.Text, out number[4]);
            Decimal.TryParse(TextBoxServices.Text, out number[5]);
            Decimal.TryParse(TextBoxTaxes.Text, out number[6]);
            Decimal.TryParse(TextBoxDiffrentTaxes.Text, out number[7]);
            var Diffrent= new InneWydatki(number[0], number[1], number[2], number[3], number[4], number[5],number[6],number[7]);
            //długi
            Decimal.TryParse(TextBoxMortage.Text, out number[0]);
            Decimal.TryParse(TextBoxConsumerLoan.Text, out number[1]);
            Decimal.TryParse(TextBoxIndividualLoan.Text, out number[2]);
            Decimal.TryParse(TextBoxDiffrentLoans.Text, out number[3]);
            var loans = new Dlugi(number[0], number[1], number[2], number[3]);
            //budowanie oszczednosci
            Decimal.TryParse(TextBoxEmergencyFund.Text, out number[0]);
            Decimal.TryParse(TextBoxIrregularExpenditure.Text, out number[1]);
            Decimal.TryParse(TextBoxFinancialCushion.Text, out number[2]);
            Decimal.TryParse(TextBoxRetirmentAccount.Text, out number[3]);
            Decimal.TryParse(TextBoxOverpaymentDebts.Text, out number[4]);
            Decimal.TryParse(TextBoxSummerHoliday.Text, out number[5]);
            Decimal.TryParse(TextBoxChristmas.Text, out number[6]);
            Decimal.TryParse(TextBoxDiffrentSavings.Text, out number[7]);
            var savings = new BudowanieOszczednosci(number[0], number[1], number[2], number[3], number[4], number[5], number[6], number[7]);
            */
            
            using (var DateFromDataBase = new BudgetContext())
            {
                int idToInsert=Month.SelectedIndex;
                foreach (var item in DateFromDataBase.Budżet)
                {
                    if (item.Rok == Convert.ToInt32(Year.SelectedValue) && item.Miesiąc - 1 == Month.SelectedIndex)
                    {
                        idToInsert = item.Id;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.PrzychodyDDD)
                {
                    if (item.IdPrzychody==idToInsert)
                    {
                        item.Wynagrodzenie += budget.Przychody.Wynagrodzenie;
                        item.WynagrodzeniePartnera += budget.Przychody.WynagrodzeniePartnera;
                        item.SprzedazAllegro += budget.Przychody.SprzedazAllegro;
                        item.PrzychodyZPremiiBankowych += budget.Przychody.PrzychodyZPremiiBankowych;
                        item.Premia += budget.Przychody.Premia;
                        item.OdsetkiBankowe += budget.Przychody.OdsetkiBankowe;
                        item.Inne += budget.Przychody.Inne;

                        //item.Wynagrodzenie += profit.Wynagrodzenie;
                        //item.WynagrodzeniePartnera += profit.WynagrodzeniePartnera;
                        //item.SprzedazAllegro += profit.SprzedazAllegro;
                        //item.PrzychodyZPremiiBankowych += profit.PrzychodyZPremiiBankowych;
                        //item.Premia += profit.Premia;
                        //item.OdsetkiBankowe += profit.OdsetkiBankowe;
                        //item.Inne += profit.Inne;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.BudowanieOszczednoscis)
                {
                    if (item.IdBudowaniaOszczednosci==idToInsert)
                    {
                        item.FunduszAwaryjny += budget.BudowanieOszczednosci.FunduszAwaryjny;
                        item.FunduszPrezentySwiateczne += budget.BudowanieOszczednosci.FunduszPrezentySwiateczne;
                        item.FunduszWakacyjny += budget.BudowanieOszczednosci.FunduszWakacyjny;
                        item.FunduszWydatkówNieregularnych += budget.BudowanieOszczednosci.FunduszWydatkówNieregularnych;
                        item.Inne += budget.BudowanieOszczednosci.Inne;
                        item.KontoEmerytalne += budget.BudowanieOszczednosci.KontoEmerytalne;
                        item.NadpłataDlugow += budget.BudowanieOszczednosci.NadpłataDlugow;
                        item.PoduszkaFinansowa += budget.BudowanieOszczednosci.PoduszkaFinansowa;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Długiiii)
                {
                    if (item.IdDlugi==idToInsert)
                    {
                        item.Inne += budget.Dlugi.Inne;
                        item.KredytHipoteczny += budget.Dlugi.KredytHipoteczny;
                        item.KredytKonsumpcyjny += budget.Dlugi.KredytKonsumpcyjny;
                        item.PozyczkaOsobista += budget.Dlugi.PozyczkaOsobista;
                        break;
                    }

                }
                foreach (var item in DateFromDataBase.Dzieciaki)
                {
                    if (item.IdDzieci==idToInsert)
                    {
                        item.ArtykulySzkolne += budget.Dzieci.ArtykulySzkolne;
                        item.DodatkoweZajecia += budget.Dzieci.DodatkoweZajecia;
                        item.Inne += budget.Dzieci.Inne;
                        item.OpiekaNadDziecmi += budget.Dzieci.OpiekaNadDziecmi;
                        item.WplatyNaSzkole += budget.Dzieci.WplatyNaSzkole;
                        item.ZabawkiGry += budget.Dzieci.ZabawkiGry;
                        break;
                    }
                }

                foreach (var item in DateFromDataBase.Higieny)
                {
                    if (item.IdHigiena==idToInsert)
                    {
                        item.Fryzjer += budget.Higiena.Fryzjer;
                        item.Inne += budget.Higiena.Inne;
                        item.Kosmetyczka += budget.Higiena.Kosmetyczka;
                        item.Kosmetyki += budget.Higiena.Kosmetyki;
                        item.SrodkiCzystosci += budget.Higiena.SrodkiCzystosci;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.InneWydatków)
                {
                    if (item.IdInneWydatki==idToInsert)
                    {
                        item.Dobroczynnosc += budget.InneWydatki.Dobroczynnosc;
                        item.EdukacjaSzkolenia += budget.InneWydatki.EdukacjaSzkolenia;
                        item.Inne += budget.InneWydatki.Inne;
                        item.Oprogramowanie += budget.InneWydatki.Oprogramowanie;
                        item.Podatki += budget.InneWydatki.Podatki;
                        item.Prezenty += budget.InneWydatki.Prezenty;
                        item.RTVAGD += budget.InneWydatki.RTVAGD;
                        item.Uslugi += budget.InneWydatki.Uslugi;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Jedzenia)
                {
                    if (item.IdJedzenie==idToInsert)
                    {
                        item.Alkohol += budget.Jedzenie.Alkohol;
                        item.Inne += budget.Jedzenie.Inne;
                        item.JedzenieDom += budget.Jedzenie.JedzenieDom;
                        item.JedzenieMiasto += budget.Jedzenie.JedzenieMiasto;
                        item.JedzeniePraca += budget.Jedzenie.JedzeniePraca;
                        break;
                    }

                }
                foreach (var item in DateFromDataBase.Mieszkania)
                {
                    if (item.IdMieszkania==idToInsert)
                    {
                        item.Czynsz += budget.Mieszkanie.Czynsz;
                        item.Gaz += budget.Mieszkanie.Gaz;
                        item.Inne += budget.Mieszkanie.Inne;
                        item.KonserwacjeNaprawy += budget.Mieszkanie.KonserwacjeNaprawy;
                        item.Ogrzewanie += budget.Mieszkanie.Ogrzewanie;
                        item.Prad += budget.Mieszkanie.Prad;
                        item.Smieci += budget.Mieszkanie.Smieci;
                        item.UbezpieczenieNieruchomosci += budget.Mieszkanie.UbezpieczenieNieruchomosci;
                        item.WodaKanalizacja += budget.Mieszkanie.WodaKanalizacja;
                        item.Wyposazenie += budget.Mieszkanie.Wyposazenie;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Rozrywki)
                {
                    if (item.IdRozrywka == idToInsert)
                    {
                        item.Czasopisma += budget.Rozrywka.Czasopisma;
                        item.Hobby += budget.Rozrywka.Hobby;
                        item.Hotel += budget.Rozrywka.Hotel;
                        item.Inne += budget.Rozrywka.Inne;
                        item.KinoTeatr += budget.Rozrywka.KinoTeatr;
                        item.Koncerty += budget.Rozrywka.Koncerty;
                        item.Ksiazki += budget.Rozrywka.Ksiazki;
                        item.SilowniaBasen += budget.Rozrywka.SilowniaBasen;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Telekomunikacje)
                {
                    if (item.IdTelekomunikacja==idToInsert)
                    {
                        item.Inne += budget.Telekomunikacja.Inne;
                        item.Internet += budget.Telekomunikacja.Internet;
                        item.Telefon1 += budget.Telekomunikacja.Telefon1;
                        item.Telefon2 += budget.Telekomunikacja.Telefon2;
                        item.Tv += budget.Telekomunikacja.Tv;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Transporty)
                {
                    if (item.IdTransport==idToInsert)
                    {
                        item.BiletyKomunikacjiMiejskiej += budget.Transport.BiletyKomunikacjiMiejskiej;
                        item.BiletyPKPPKS += budget.Transport.BiletyPKPPKS;
                        item.DodatkoweUbezp += budget.Transport.DodatkoweUbezp;
                        item.Inne += budget.Transport.Inne;
                        item.PaliwoSamochod += budget.Transport.PaliwoSamochod;
                        item.PrzegladNaprawa += budget.Transport.PrzegladNaprawa;
                        item.Taxi += budget.Transport.Taxi;
                        item.Wyposazenie += budget.Transport.Wyposazenie;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Ubranki)
                {
                    if (idToInsert==item.IdUbrania)
                    {
                        item.Buty += budget.Ubrania.Buty;
                        item.Dodatki += budget.Ubrania.Dodatki;
                        item.Inne += budget.Ubrania.Inne;
                        item.SportoweUbrania += budget.Ubrania.SportoweUbrania;
                        item.ZwykleUbrania += budget.Ubrania.ZwykleUbrania;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Zdrowia)
                {
                    if (idToInsert==item.IdZdrowie)
                    {
                        item.Badania += budget.Zdrowie.Badania;
                        item.Inne += budget.Zdrowie.Inne;
                        item.Lekarstwa += budget.Zdrowie.Lekarstwa;
                        item.Lekarz += budget.Zdrowie.Lekarz;
                        break;
                    }
                }
                DateFromDataBase.SaveChanges();

            }
            budget.Przychody.Inne = 0;
            budget.Przychody.OdsetkiBankowe = 0;
            budget.Przychody.Premia = 0;
            budget.Przychody.PrzychodyZPremiiBankowych = 0;
            budget.Przychody.SprzedazAllegro = 0;
            budget.Przychody.Wynagrodzenie= 0;
            budget.Przychody.WynagrodzeniePartnera= 0;
            budget.BudowanieOszczednosci.FunduszAwaryjny = 0;
            budget.BudowanieOszczednosci.FunduszPrezentySwiateczne = 0;
            budget.BudowanieOszczednosci.FunduszWakacyjny = 0;
            budget.BudowanieOszczednosci.FunduszWydatkówNieregularnych = 0;
            budget.BudowanieOszczednosci.Inne= 0;
            budget.BudowanieOszczednosci.KontoEmerytalne= 0;
            budget.BudowanieOszczednosci.NadpłataDlugow = 0;
            budget.BudowanieOszczednosci.PoduszkaFinansowa= 0;
            budget.Dlugi.Inne= 0;
            budget.Dlugi.KredytHipoteczny = 0;
            budget.Dlugi.KredytKonsumpcyjny= 0;
            budget.Dlugi.PozyczkaOsobista= 0;
            budget.Dzieci.ArtykulySzkolne= 0;
            budget.Dzieci.DodatkoweZajecia = 0;
            budget.Dzieci.Inne = 0;
            budget.Dzieci.OpiekaNadDziecmi = 0;
            budget.Dzieci.WplatyNaSzkole = 0;
            budget.Dzieci.ZabawkiGry = 0;
            budget.Higiena.Fryzjer = 0;
            budget.Higiena.Inne = 0;
            budget.Higiena.Kosmetyczka= 0;
            budget.Higiena.Kosmetyki = 0;
            budget.Higiena.SrodkiCzystosci= 0;
            budget.InneWydatki.Dobroczynnosc= 0;
            budget.InneWydatki.EdukacjaSzkolenia = 0;
            budget.InneWydatki.Inne = 0;
            budget.InneWydatki.Oprogramowanie= 0;
            budget.InneWydatki.Podatki = 0;
            budget.InneWydatki.Prezenty = 0;
            budget.InneWydatki.RTVAGD = 0;
            budget.InneWydatki.Uslugi= 0;
            budget.Jedzenie.Alkohol= 0;
            budget.Jedzenie.Inne= 0;
            budget.Jedzenie.JedzenieDom = 0;
            budget.Jedzenie.JedzenieMiasto = 0;
            budget.Jedzenie.JedzeniePraca = 0;
            budget.Mieszkanie.Czynsz = 0;
            budget.Mieszkanie.Gaz= 0;
            budget.Mieszkanie.Inne = 0;
            budget.Mieszkanie.KonserwacjeNaprawy = 0;
            budget.Mieszkanie.Ogrzewanie = 0;
            budget.Mieszkanie.Prad = 0;
            budget.Mieszkanie.Smieci = 0;
            budget.Mieszkanie.UbezpieczenieNieruchomosci= 0;
            budget.Mieszkanie.WodaKanalizacja = 0;
            budget.Mieszkanie.Wyposazenie = 0;
            budget.Przychody.Inne = 0;
            budget.Przychody.OdsetkiBankowe = 0;
            budget.Przychody.Premia = 0;
            budget.Przychody.PrzychodyZPremiiBankowych = 0;
            budget.Przychody.SprzedazAllegro = 0;
            budget.Przychody.Wynagrodzenie = 0;
            budget.Przychody.WynagrodzeniePartnera = 0;
            budget.Rozrywka.Czasopisma = 0;
            budget.Rozrywka.Hobby = 0;
            budget.Rozrywka.Hotel = 0;
            budget.Rozrywka.Inne= 0;
            budget.Rozrywka.KinoTeatr= 0;
            budget.Rozrywka.Koncerty = 0;
            budget.Rozrywka.Ksiazki= 0;
            budget.Rozrywka.SilowniaBasen  = 0;
            budget.Telekomunikacja.Inne = 0;
            budget.Telekomunikacja.Internet= 0;
            budget.Telekomunikacja.Telefon1 = 0;
            budget.Telekomunikacja.Telefon2 = 0;
            budget.Telekomunikacja.Tv = 0;
            budget.Transport.BiletyKomunikacjiMiejskiej = 0;
            budget.Transport.BiletyPKPPKS= 0;
            budget.Transport.DodatkoweUbezp= 0;
            budget.Transport.Inne = 0;
            budget.Transport.PaliwoSamochod = 0;
            budget.Transport.PrzegladNaprawa = 0;
            budget.Transport.Taxi= 0;
            budget.Transport.Wyposazenie= 0;
            budget.Ubrania.Buty= 0;
            budget.Ubrania.Dodatki = 0;
            budget.Ubrania.Inne = 0;
            budget.Ubrania.SportoweUbrania = 0;
            budget.Ubrania.ZwykleUbrania = 0;
            budget.Zdrowie.Badania = 0;
            budget.Zdrowie.Inne = 0;
            budget.Zdrowie.Lekarstwa = 0;
            budget.Zdrowie.Lekarz = 0;

            foreach (StackPanel item in GroupOfTextBoxes.Children)
            {
                foreach (Control item2 in item.Children)
                {
                    if (item2.GetType()==typeof(TextBox))
                    {
                        ((TextBox)item2).Text = string.Empty;
                    }
                }
            }

            TBInfoAboutAddingToDB.Visibility = Visibility.Visible;
            timer.Tick -= dispacherTimer_Ticked;
            timer.Tick += dispacherTimer_Ticked;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
            timer2.Tick -= dispachterTimerChangeTextBox;
            timer2.Tick += dispachterTimerChangeTextBox;
            timer2.Interval = new TimeSpan(0, 0, 1);
            timer2.Start();
            
            
        }

        private void dispachterTimerChangeTextBox(object sender, EventArgs e)
        {
            counter++;
            if (counter%2==1)
            {
                TBInfoAboutAddingToDB.FontSize = 18D;
            }
            else
                TBInfoAboutAddingToDB.FontSize = 15D;
            if (counter==5)
            {
                timer2.Stop();
            }
        }

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        int counter=0;

        private void dispacherTimer_Ticked(object sender, EventArgs e)
        {
            TBInfoAboutAddingToDB.Visibility = Visibility.Hidden;

            timer.Stop();
        }
    }
}
