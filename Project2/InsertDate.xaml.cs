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
                        item.Wynagrodzenie += profit.Wynagrodzenie;
                        item.WynagrodzeniePartnera += profit.WynagrodzeniePartnera;
                        item.SprzedazAllegro += profit.SprzedazAllegro;
                        item.PrzychodyZPremiiBankowych += profit.PrzychodyZPremiiBankowych;
                        item.Premia += profit.Premia;
                        item.OdsetkiBankowe += profit.OdsetkiBankowe;
                        item.Inne += profit.Inne;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.BudowanieOszczednoscis)
                {
                    if (item.IdBudowaniaOszczednosci==idToInsert)
                    {
                        item.FunduszAwaryjny += savings.FunduszAwaryjny;
                        item.FunduszPrezentySwiateczne += savings.FunduszPrezentySwiateczne;
                        item.FunduszWakacyjny += savings.FunduszWakacyjny;
                        item.FunduszWydatkówNieregularnych += savings.FunduszWydatkówNieregularnych;
                        item.Inne += savings.Inne;
                        item.KontoEmerytalne += savings.KontoEmerytalne;
                        item.NadpłataDlugow += savings.NadpłataDlugow;
                        item.PoduszkaFinansowa += savings.PoduszkaFinansowa;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Długiiii)
                {
                    if (item.IdDlugi==idToInsert)
                    {
                        item.Inne += loans.Inne;
                        item.KredytHipoteczny += loans.KredytHipoteczny;
                        item.KredytKonsumpcyjny += loans.KredytKonsumpcyjny;
                        item.PozyczkaOsobista += loans.PozyczkaOsobista;
                        break;
                    }

                }
                foreach (var item in DateFromDataBase.Dzieciaki)
                {
                    if (item.IdDzieci==idToInsert)
                    {
                        item.ArtykulySzkolne += children.ArtykulySzkolne;
                        item.DodatkoweZajecia += children.DodatkoweZajecia;
                        item.Inne += children.Inne;
                        item.OpiekaNadDziecmi += children.OpiekaNadDziecmi;
                        item.WplatyNaSzkole += children.WplatyNaSzkole;
                        item.ZabawkiGry += children.ZabawkiGry;
                        break;
                    }
                }

                foreach (var item in DateFromDataBase.Higieny)
                {
                    if (item.IdHigiena==idToInsert)
                    {
                        item.Fryzjer += hygiene.Fryzjer;
                        item.Inne += hygiene.Inne;
                        item.Kosmetyczka += hygiene.Kosmetyczka;
                        item.Kosmetyki += hygiene.Kosmetyki;
                        item.SrodkiCzystosci += hygiene.SrodkiCzystosci;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.InneWydatków)
                {
                    if (item.IdInneWydatki==idToInsert)
                    {
                        item.Dobroczynnosc += Diffrent.Dobroczynnosc;
                        item.EdukacjaSzkolenia += Diffrent.EdukacjaSzkolenia;
                        item.Inne += Diffrent.Inne;
                        item.Oprogramowanie += Diffrent.Oprogramowanie;
                        item.Podatki += Diffrent.Podatki;
                        item.Prezenty += Diffrent.Prezenty;
                        item.RTVAGD += Diffrent.RTVAGD;
                        item.Uslugi += Diffrent.Uslugi;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Jedzenia)
                {
                    if (item.IdJedzenie==idToInsert)
                    {
                        item.Alkohol += food.Alkohol;
                        item.Inne += food.Inne;
                        item.JedzenieDom += food.JedzenieDom;
                        item.JedzenieMiasto += food.JedzenieMiasto;
                        item.JedzeniePraca += food.JedzeniePraca;
                        break;
                    }

                }
                foreach (var item in DateFromDataBase.Mieszkania)
                {
                    if (item.IdMieszkania==idToInsert)
                    {
                        item.Czynsz += flat.Czynsz;
                        item.Gaz += flat.Gaz;
                        item.Inne += flat.Inne;
                        item.KonserwacjeNaprawy += flat.KonserwacjeNaprawy;
                        item.Ogrzewanie += flat.Ogrzewanie;
                        item.Prad += flat.Prad;
                        item.Smieci += flat.Smieci;
                        item.UbezpieczenieNieruchomosci += flat.UbezpieczenieNieruchomosci;
                        item.WodaKanalizacja += flat.WodaKanalizacja;
                        item.Wyposazenie += flat.Wyposazenie;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Rozrywki)
                {
                    if (item.IdRozrywka == idToInsert)
                    {
                        item.Czasopisma += entertaiment.Czasopisma;
                        item.Hobby += entertaiment.Hobby;
                        item.Hotel += entertaiment.Hotel;
                        item.Inne += entertaiment.Inne;
                        item.KinoTeatr += entertaiment.KinoTeatr;
                        item.Koncerty += entertaiment.Koncerty;
                        item.Ksiazki += entertaiment.Ksiazki;
                        item.SilowniaBasen += entertaiment.SilowniaBasen;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Telekomunikacje)
                {
                    if (item.IdTelekomunikacja==idToInsert)
                    {
                        item.Inne += telecomunication.Inne;
                        item.Internet += telecomunication.Internet;
                        item.Telefon1 += telecomunication.Telefon1;
                        item.Telefon2 += telecomunication.Telefon2;
                        item.Tv += telecomunication.Tv;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Transporty)
                {
                    if (item.IdTransport==idToInsert)
                    {
                        item.BiletyKomunikacjiMiejskiej += transport.BiletyKomunikacjiMiejskiej;
                        item.BiletyPKPPKS += transport.BiletyPKPPKS;
                        item.DodatkoweUbezp += transport.DodatkoweUbezp;
                        item.Inne += transport.Inne;
                        item.PaliwoSamochod += transport.PaliwoSamochod;
                        item.PrzegladNaprawa += transport.PrzegladNaprawa;
                        item.Taxi += transport.Taxi;
                        item.Wyposazenie += transport.Wyposazenie;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Ubranki)
                {
                    if (idToInsert==item.IdUbrania)
                    {
                        item.Buty += cloathes.Buty;
                        item.Dodatki += cloathes.Dodatki;
                        item.Inne += cloathes.Inne;
                        item.SportoweUbrania += cloathes.SportoweUbrania;
                        item.ZwykleUbrania += cloathes.ZwykleUbrania;
                        break;
                    }
                }
                foreach (var item in DateFromDataBase.Zdrowia)
                {
                    if (idToInsert==item.IdZdrowie)
                    {
                        item.Badania += helath.Badania;
                        item.Inne += helath.Inne;
                        item.Lekarstwa += helath.Lekarstwa;
                        item.Lekarz += helath.Lekarz;
                        break;
                    }
                }
                DateFromDataBase.SaveChanges();

            }
            TextBoxAdditionalEquipmentCar.Text = "";
            TextBoxAlcohol.Text = "";
            TextBoxAllegro.Text = "";
            TextBoxBankBonus.Text = "";
            TextBoxBeuatician.Text = "";
            TextBoxBonus.Text = "";
            TextBoxBooks.Text = "";
            TextBoxCharity.Text = "";
            TextBoxChildcare.Text = "";
            TextBoxChristmas.Text = "";
            TextBoxCinema.Text = "";
            TextBoxCleaningSupplies.Text = "";
            TextBoxConcerts.Text = "";
            TextBoxConsumerLoan.Text = "";
            TextBoxCosmetics.Text = "";
            TextBoxDiffrentChildren.Text = "";
            TextBoxDiffrentClothes.Text = "";
            TextBoxDiffrentEntertainment.Text = "";
            TextBoxDiffrentFlat.Text = "";
            TextBoxDiffrentFood.Text = "";
            TextBoxDiffrentHealth.Text = "";
            TextBoxDiffrentHygiene.Text = "";
            TextBoxDiffrentLoans.Text = "";
            TextBoxDiffrentReward.Text = "";
            TextBoxDiffrentSavings.Text = "";
            TextBoxDiffrentTaxes.Text = "";
            TextBoxDiffrentTransport.Text = "";
            TextBoxDoc.Text = "";
            TextBoxEducation.Text = "";
            TextBoxEmergencyFund.Text = "";
            TextBoxEquipment.Text = "";
            TextBoxExtensions.Text = "";
            TextBoxExtraLessons.Text = "";
            TextBoxFinancialCushion.Text = "";
            TextBoxFoodCity.Text = "";
            TextBoxFoodHouse.Text = "";
            TextBoxFoodWork.Text = "";
            TextBoxFuelCar.Text = "";
            TextBoxGas.Text = "";
            TextBoxGym.Text = "";
            TextBoxHairdresser.Text = "";
            TextBoxHeating.Text = "";
            TextBoxHobbies.Text = "";
            TextBoxHotels.Text = "";
            TextBoxIndividualLoan.Text = "";
            TextBoxInsurance.Text = "";
            TextBoxInsuranceCar.Text = "";
            TextBoxInterestBank.Text = "";
            TextBoxInternet.Text = "";
            TextBoxIrregularExpenditure.Text = "";
            TextBoxJoys.Text = "";
            TextBoxMedicine.Text = "";
            TextBoxMortage.Text = "";
            TextBoxNewspapers.Text = "";
            TextBoxNormalClothes.Text = "";
            TextBoxOverpaymentDebts.Text = "";
            TextBoxPhone1.Text = "";
            TextBoxPhone2.Text = "";
            TextBoxPKSPKP.Text = "";
            TextBoxPower.Text = "";
            TextBoxPresent.Text = "";
            TextBoxRent.Text = "";
            TextBoxReparing.Text = "";
            TextBoxReparingCar.Text = "";
            TextBoxRetirmentAccount.Text = "";
            TextBoxReward.Text = "";
            TextBoxRewardPartner.Text = "";
            TextBoxRTV.Text = "";
            TextBoxRubish.Text = "";
            TextBoxSchoolArtical.Text = "";
            TextBoxSchoolTaxes.Text = "";
            TextBoxServices.Text = "";
            TextBoxShoes.Text = "";
            TextBoxSoftware.Text = "";
            TextBoxSportClothes.Text = "";
            TextBoxSummerHoliday.Text = "";
            TextBoxSurvey.Text = "";
            TextBoxTaxes.Text = "";
            TextBoxTaxi.Text = "";
            TextBoxTelecomunication.Text = "";
            TextBoxTicketPublicTransport.Text = "";
            TextBoxTV.Text = "";
            TextBoxWater.Text = "";

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
