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

using testWpf.model.entity;
using testWpf.model.dao;
using testWpf.model;
using testWpf.Helper;

namespace testWpf
{
    public partial class MainWindow : Window
    {
        private ProductDao productDao = new ProductDao();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                productDao.addProduct(new Product { name = "Ice Ldatte", subCategoryId = 1, priceKHR = 12000, priceUSD = 3, isPackage = false, isDeleted = false, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" });
                
            } catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            Debug.debugJson(productDao.listProduct());
            //Debug.debugJson(new Product { name = "Ice Latte", subCategoryId = 1, priceKHR = 12000, priceUSD = 3, isPackage = false, isDeleted = false, createdBy = "1", createdAt = DateTime.Now, updatedAt = DateTime.Now, updatedBy = "1" });
            //using (var db = new CoffeeContext()){Debug.debugJson(db.Products.First());}
        }

    }
}
