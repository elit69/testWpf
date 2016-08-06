using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using testWpf.model.entity;

namespace testWpf.model.dao
{
    class ProductDao
    {
        public void addProduct(Product product) { 
            using(var db = new CoffeeContext()){
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public List<Product> listProduct(){
            using (var db = new CoffeeContext()) {
             
               List<Product> list = db.Products.SqlQuery("SELECT * FROM stock.Product").ToList(); 
                return list;
            }
        }

    }
}
