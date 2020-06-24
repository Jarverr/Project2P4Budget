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
using System.Windows.Threading;

namespace Project2.Views
{
    /// <summary>
    /// Logika interakcji dla klasy CheckingDate.xaml
    /// </summary>
    public partial class CheckingDate : UserControl
    {
        public int YearInUse { get; set; }
        public int MonthInUse { get; set; }
        public CheckingDate()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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
                GroupDiffrent.Visibility = Visibility.Collapsed;
                GroupDiffrentValues.Visibility = Visibility.Collapsed;
                CBAll.IsChecked = false;
            }
            else
            {
                GroupDiffrent.Visibility = Visibility.Visible;
                GroupDiffrentValues.Visibility = Visibility.Visible;
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

    }
}
