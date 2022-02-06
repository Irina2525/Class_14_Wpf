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

namespace Class_14_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new List<Product>();

            products.Add(new Product()
            {
                ProductName = "Mango",
                Price = 250,
                ImageName = "Data/mango.jpg",
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                ProductName = "Orange",
                Price = 180,
                ImageName = "Data/orange.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Laptop",
                Price = 160000,
                ImageName = "Data/laptop.jpg",
                ProductType = ProductTypes.Technic
            });
            products.Add(new Product()
            {
                ProductName = "TV",
                Price = 200,
                ImageName = "Data/tv.jpeg",
                ProductType = ProductTypes.Technic
            });
            lstBox.ItemsSource = products;
        }
    }
}