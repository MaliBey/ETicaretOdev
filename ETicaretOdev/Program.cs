using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.UrunAdi = "Samsung 49NU7100 49 122 Ekran 4K Uydu Alıcılı Smart LED TV";
        product1.Kategori = "Televizyon";
        product1.Fiyati = 4199 ;
        product1.StoktakiUrun = 569;

        Product product2 = new Product();
        product2.UrunAdi = "Gliss Ultimate Oil Elixir Şampuan 360 ml";
        product2.Kategori = "Kişisel Bakım ";
        product2.Fiyati =  14.93 ;
        product2.StoktakiUrun = 3850;

        Product product3 = new Product();
        product3.UrunAdi = "Xiaomi Mi Note 10 Lite 128 GB (Xiaomi Türkiye Garantili)";
        product3.Kategori = "Telefon";
        product3.Fiyati = 3899;
        product3.StoktakiUrun = 200;

        Product product4 = new Product();
        product4.UrunAdi = "Elveda Gülsarı - Cengiz Aytmatov";
        product4.Kategori = "Kitap";
        product4.Fiyati =  9.30 ;
        product4.StoktakiUrun = 3000;



       Product[] products = new Product[] { product1, product2, product3, product4 };

        foreach (var product in products)
        {
            Console.WriteLine(product.UrunAdi + " : " + product.Fiyati + "\n----------------------------");
        }

        for (int i = 0; i < products.Length ; i++)
        {
            Console.WriteLine(products[i].UrunAdi + " : " + products[i].Fiyati + "\n----------------------------");
        }

        int x = 0; 
        while (x < products.Length)
        {
            Console.WriteLine(products[x].UrunAdi + " : " + products[x].Fiyati + "\n----------------------------");
            x++;
        }




    }
}

class Product
{
  public string UrunAdi { get; set; }
  public string Kategori { get; set; }
  public double Fiyati { get; set; }
  public int StoktakiUrun { get; set; }

}
