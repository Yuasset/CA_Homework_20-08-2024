﻿using CA_Homework_20_08_2024;
using System.Collections;

int select;

//ArrayList karmaşık veri tiplerini birer nesne olarak tutmamızı sağlar. Verileri eklerken tip dönüşümü yapmamıza gerek kalmaz boxing denir. Fakat verileri çekerken tip dönüşümü (unboxing) yapmamız gerekmektedir.
ArrayList product = new ArrayList();

Book book1 = new Book();
book1.Name = "Beser Hatun";
book1.Type = "Edebiyat";
book1.PublishingHouse = "Alfa Yayıncılık";
book1.Author = "Ali Kılıç";
book1.PrintingYear = 2021;
book1.PageNumber = 336;
book1.Price = 111.75m;

Book book2 = new Book();
book2.Name = "Gece Yarısı Kütüphanesi";
book2.Type = "Edebiyat";
book2.PublishingHouse = "Domingo Yayınevi";
book2.Author = "Matt Haig";
book2.PrintingYear = 2021;
book2.PageNumber = 296;
book2.Price = 129m;

Book book3 = new Book();
book3.Name = "Savaş Sanatı";
book3.Type = "Araştırma";
book3.PublishingHouse = "İş Bankası Kültür Yayınları";
book3.Author = "Sun Tzu";
book3.PrintingYear = 2014;
book3.PageNumber = 96;
book3.Price = 16.55m;

Book book4 = new Book();
book4.Name = "Kurtlarla Koşan Kadınlar";
book4.Type = "Araştırma";
book4.PublishingHouse = "Ayrıntı Yayınları";
book4.Author = "Clarissa Pinkola Estés";
book4.PrintingYear = 2003;
book4.PageNumber = 608;
book4.Price = 215.40m;

Book book5 = new Book();
book5.Name = "Kendime Düşünceler";
book5.Type = "Felsefe";
book5.PublishingHouse = "İş Bankası Kültür Yayınları";
book5.Author = "Marcus Aurelius";
book5.PrintingYear = 2018;
book5.PageNumber = 256;
book5.Price = 29.45m;

Book book6 = new Book();
book6.Name = "İrade Terbiyesi";
book6.Type = "Felsefe";
book6.PublishingHouse = "İndigo Kitap";
book6.Author = "Jules Payot";
book6.PrintingYear = 2021;
book6.PageNumber = 346;
book6.Price = 38.60m;

Electronic electronic1 = new Electronic();
electronic1.Name = "Samsung Galaxy Tab A9 Plus SM-X210 Gri 64 GB 11 Tablet";
electronic1.Type = "Tablet";
electronic1.Brand = "Samsung";
electronic1.Price = 4269m;

Electronic electronic2 = new Electronic();
electronic2.Name = "Lenovo IdeaCentre AIO 3 24IAP7 F0GH010RTR i3-1215U 8 GB 256 GB SSD UHD Graphics 23.8 All in One PC";
electronic2.Type = "Bilgisayar";
electronic2.Brand = "Lenovo";
electronic2.Price = 17299m;

Toy toy1 = new Toy();
toy1.Name = "Educa 18465 Paisaje De Tulipanes Fsc 1500 Parça Puzzle";
toy1.Type = "Puzzle";
toy1.Brand = "Educa";
toy1.Price = 173.45m;

Toy toy2 = new Toy();
toy2.Name = "Star Wars F1119 Animatronic Baby Yoda Figür";
toy2.Type = "Figür";
toy2.Brand = "Star Wars";
toy2.Price = 2549m;

product.Add(book1);
product.Add(book2);
product.Add(book3);
product.Add(book4);
product.Add(book5);
product.Add(book6);

product.Add(electronic1);
product.Add(electronic2);

product.Add(toy1);
product.Add(toy2);

while (true)
{
    try
    {
        Console.WriteLine("Bilge Markete Hoşgeldiniz Aşağıdan İşlem Seçin");
        Console.WriteLine("1-Kitap");
        Console.WriteLine("2-Elektronik");
        Console.WriteLine("3-Oyuncak");

        Console.Write("Seçim: ");
        select = Convert.ToInt32(Console.ReadLine());

        switch (select)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Kitap menüsü bir seçim gerçekleştirin");
                Console.WriteLine("1-Edebiyat");
                Console.WriteLine("2-Araştırma");
                Console.WriteLine("3-Felsefe");
                Console.Write("Seçim: ");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Aşağıda edebiyat kitapları listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Book) //is operatörü ile tip kontrolü yapılır item nesnesi veri tipi Book tipinde ise if bloğu çalışır
                            {
                                Book book = (Book)item; //Unboxing
                                if (book.Type == "Edebiyat")
                                {
                                    Console.WriteLine($"Adı: {book.Name} \nTürü: {book.Type} \nYayın Evi: {book.PublishingHouse} \nYazar: {book.Author} \nBasım Tarihi: {book.PrintingYear} \nSayfa Sayısı: {book.PageNumber} \nFiyat: {book.Price} TL (KDV Hariç) \nKDV: {book.PriceKDV}");
                                }
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Aşağıda araştırma kitapları listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Book) //is operatörü ile tip kontrolü yapılır item nesnesi veri tipi Book tipinde ise if bloğu çalışır
                            {
                                Book book = (Book)item; //Unboxing
                                if (book.Type == "Araştırma")
                                {
                                    Console.WriteLine($"Adı: {book.Name} \nTürü: {book.Type} \nYayın Evi: {book.PublishingHouse} \nYazar: {book.Author} \nBasım Tarihi: {book.PrintingYear} \nSayfa Sayısı: {book.PageNumber} \nFiyat: {book.Price} TL (KDV Hariç) \nKDV: {book.PriceKDV}");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aşağıda felsefe kitapları listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Book) //is operatörü ile tip kontrolü yapılır item nesnesi veri tipi Book tipinde ise if bloğu çalışır
                            {
                                Book book = (Book)item; //Unboxing
                                if (book.Type == "Felsefe")
                                {
                                    Console.WriteLine($"Adı: {book.Name} \nTürü: {book.Type} \nYayın Evi: {book.PublishingHouse} \nYazar: {book.Author} \nBasım Tarihi: {book.PrintingYear} \nSayfa Sayısı: {book.PageNumber} \nFiyat: {book.Price} TL (KDV Hariç) \nKDV: {book.PriceKDV}");
                                }
                            }
                        }
                        break;
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Elektronik menüsü bir seçim gerçekleştirin");
                Console.WriteLine("1-Tablet");
                Console.WriteLine("2-Bilgisayar");
                Console.Write("Seçim: ");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Aşağıda tabletler listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Electronic)
                            {
                                Electronic electronic = (Electronic)item;
                                if (electronic.Type == "Tablet")
                                {
                                    Console.WriteLine($"Adı: {electronic.Name} \nTipi: {electronic.Type} \nMarkası: {electronic.Brand} \nFiyat: {electronic.Price} TL (KDV Hariç) \nKDV: {electronic.PriceKDV}");
                                }
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Aşağıda bilgisayarlar listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Electronic)
                            {
                                Electronic electronic = (Electronic)item;
                                if (electronic.Type == "Bilgisayar")
                                {
                                    Console.WriteLine($"Adı: {electronic.Name} \nTipi: {electronic.Type} \nMarkası: {electronic.Brand} \nFiyat: {electronic.Price} TL (KDV Hariç) \nKDV: {electronic.PriceKDV}");
                                }
                            }
                        }
                        break;
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Oyuncak menüsü bir seçim gerçekleştirin");
                Console.WriteLine("1-Puzzle");
                Console.WriteLine("2-Figür");
                Console.Write("Seçim: ");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Aşağıda puzzlelar listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Toy)
                            {
                                Toy toy = (Toy)item;
                                if (toy.Type == "Puzzle")
                                {
                                    Console.WriteLine($"Adı: {toy.Name} \nTipi: {toy.Type} \nMarkası: {toy.Brand} \nFiyat: {toy.Price} TL (KDV Hariç) \nKDV: {toy.PriceKDV}");
                                }
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Aşağıda figürler listeleniyor");
                        foreach (object item in product)
                        {
                            if (item is Toy)
                            {
                                Toy toy = (Toy)item;
                                if (toy.Type == "Figür")
                                {
                                    Console.WriteLine($"Adı: {toy.Name} \nTipi: {toy.Type} \nMarkası: {toy.Brand} \nFiyat: {toy.Price} TL (KDV Hariç) \nKDV: {toy.PriceKDV}");
                                }
                            }
                        }
                        break;
                }
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Hatalı Giriş Yaptınız");
    }
}