using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrnekSite2.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name="Kamera",Description="Kamera Ürünleri"},
                new Category() { Name="Telefon",Description="Telefon Ürünleri"},
                new Category() { Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
            };
            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Canon",Description="Kamera",Price=2500,Stock=1000,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,Image="1.jpg"},
                new Product(){Name="Asus",Description="Bilgisayar",Price=4500,Stock=200,IsHome=true,IsApproved=false,IsFeatured=false,Slider=false,CategoryId=3,Image="2.jpg"},
                new Product(){Name="Lenovo",Description="Bilgisayar",Price=7500,Stock=1500,IsHome=false,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,Image="3.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}