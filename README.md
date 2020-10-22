
# TheCashier V 0.1
Fungsi aplikasi ini seperti halnya aplikasi kasir biasa dimana didalamnya kita dapat menginputkan item,jenis, jumlah maupun harga agar dijumlahkan sehingga muncul hasil akhir /total

## Scope & Functionalities 
- User dapat menginputkan nama item
- User dapat memilih jenis item barang ataupun jasa  
- User dapat menambahkan banyaknya barang yang ingin diinput 
- User akan mendapatkan informasi mengenai total harga dari segala inputan barang / jasa 

## How Does it Works
Bagaimana aplikasi ini dapat bekerja dengan cara diawali dengan menambahkan dari method `MainWindow` pada `class MainWindwo.xaml.cs` kita mendeklarasikan sebagai berikut

```
  public partial class MainWindow : Window
    {
        private Calculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource= calculator.getListItem();
        }
```

Untuk logika perhitungan dan penambahan barang disertai total harga pada kasir terdapat di `Calculator.cs` yaitu sebagai berikut

```
 class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }

        public void additem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubTotal();
        }

        public double getTotal()
        {
            return total;

        }

        public List<Item> getListItem()
        {
            return listItem;
        }
    }
```
#Terimakasih 😁
