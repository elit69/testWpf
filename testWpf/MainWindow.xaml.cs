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
using testWpf.Model;

namespace testWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductDao dao = new ProductDao();
                Product product = new Product();
                product.id = 7;
                product.name = "sdfsd";
            try
                {
                    dao.addProduct(product);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            
        }

    }
}
