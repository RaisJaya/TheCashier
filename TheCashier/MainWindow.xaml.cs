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

namespace TheCashier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new calculator();
            lisBox.ItemsSource = calculator.getListItem();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string tittle = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), tittle, quantity, price, price, type);
            calculator.addItem(item);
            double total = calculator.getTotal();

            totalLabel.Content = string.Format("Rp.{0}", total);

            lisBox.Items.Refresh();
        }
    }
}
