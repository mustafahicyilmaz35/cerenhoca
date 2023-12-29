
#region İlk Bolum
//int[] sayilar = new int[5];

//sayilar[0] = 1;
//sayilar[1] = 2;
//sayilar[2] = 3;
//sayilar[3] = 4;
//sayilar[4] = 5;

//Console.WriteLine(sayilar[3]);


//char[] isim = new char[10];

//isim[0] = 'c';
//isim[1] = 'e';
//isim[2] = 'r';
//isim[3] = 'e';
//isim[4] = 'n';

//for (int i = 0; i  < isim.Length; i++)
//{
//    Console.Write(isim[i]);
//}

//Console.WriteLine("\n");
//string isim1 = "ceren";
//Console.WriteLine(isim1[1]);



// Karar Yapıları
// Koşullar
// Döngüler

//using HelloProject;

//int sayi = 3;

//if (sayi < 10)
//{
//    Console.WriteLine("Evet sayı 10 dan küçüktür.");
//}
//else if(sayi < 20)
//{
//    Console.WriteLine("Evet sayı 20 den küçüktür.");
//}
//else if(sayi < 30)
//{
//    Console.WriteLine("Evet sayı 30 dan büyüktür.");
//}
//else
//{
//    Console.WriteLine("Koşul Yanlış");
//}

//bool esit_mi = sayi == 11;
//Console.WriteLine(esit_mi);

//if(sayi < 10)
//{
//    Console.WriteLine("Evet Sayı 10 dan küçüktür.");
//}
//if(sayi < 5)
//{
//    Console.WriteLine("Evet Sayı 5 den küçüktür.");
//}


//Gunler gun = Gunler.Çarşamba;




//switch (gun)
//{
//    case Gunler.Pazartesi:
//        Console.WriteLine("Bugün pazartesi");
//        break;
//    case Gunler.Salı:
//        Console.WriteLine("Bugün Salı");
//        break;
//    case Gunler.Çarşamba: //magic string
//        Console.WriteLine("Bugün Çarşamba");
//        break;
//    case Gunler.Perşembe:
//        Console.WriteLine("Bugün Perşembe");
//        break;
//    case Gunler.Cuma:
//        Console.WriteLine("Bugün Cuma");
//        break;
//    case Gunler.Cumartesi:
//        Console.WriteLine("Bugün Cumartesi");
//        break;
//    case Gunler.Pazar:
//        Console.WriteLine("Bugün Pazar");
//        break;
//    default: Console.WriteLine("Lütfen bir gün değeri girin");
//        break;

//}



//DRY Dont Repeat Yourself
//Console.WriteLine("Hello World");
//Console.WriteLine("Hello World");
//Console.WriteLine("Hello World");
//Console.WriteLine("Hello World");
//Console.WriteLine("Hello World");

// while, for, do-while, foreach

//int i = 0;
//while(i < 5)
//{
//    Console.WriteLine("Hello World");
//    i++;
//}

//for(int i = 0; i < 5; i++)
//{

//    if(i == 1)
//    {
//        Console.WriteLine("Merhaba Dünya");
//    }
//    else
//    {
//        Console.WriteLine(i + " Hello World");
//    }
//}

//int[] sayilar = new int[5];

//for(int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = i;
//}

//Console.WriteLine("-----For Döngüsü ile Okuma-----");
//for (int i = 0;i < sayilar.Length; i++)
//{
//    Console.WriteLine(sayilar[i]);
//}

//Console.WriteLine("---------While Döngüsü İle Okuma--------");
//int j = 0;
//while(j < sayilar.Length)
//{
//    Console.WriteLine(sayilar[j]);
//    j++;
//}

//Console.WriteLine("---- Foreach İle Okuma ----");
//foreach (int item in sayilar)
//{
//    Console.WriteLine(item);
//}

//int i = 6;
//do
//{
//    Console.WriteLine(i + " Hello World");
//    i++;
//} while (i < 5);

//bool dogru_mu = true;

//do
//{
//    Console.Write("İsminizi Yazin: ");
//    string isim = Console.ReadLine();
//    Console.WriteLine("Merhaba " + isim);



//    var tus = Console.ReadKey();
//    if(tus.Key == ConsoleKey.Escape)
//    {
//        dogru_mu = false;   
//    }

//} while (dogru_mu);

// For ve foreach
#endregion


#region ikinci_bolum
// DRY

//int sayi = 2;
//int sayi1 = 5;

//int toplam = 0;

//toplam = sayi + sayi1;
//Console.WriteLine(toplam);


//sayi = 9;
//sayi1 = 6;
//toplam = sayi + sayi1;
//Console.WriteLine(toplam);

//// İş yapan fonksiyonlar -> void -> procedure
//void MerhabaDe(string isim) // Fonksiyonun tanımlanması
//{
//    int sayi = 10;
//    //Console.WriteLine("Hello " + isim + " " + sayi);
//    Console.WriteLine("Hello {0} {1}",isim,sayi);
//}



//string isim = "Ali";

//MerhabaDe("Ceren"); // Fonksiyonun çağrılması
//MerhabaDe("Merve");
//MerhabaDe("Mustafa");

//// Değer Döndüren Fonksiyonlar -> Fonksiyon

////SOLID
////Single Reponsibility
//int Topla(int sayi, int sayi1)
//{
//    //Console.WriteLine("sayı1: {0} sayı2: {1} ",sayi,sayi1);
//    //Console.WriteLine(sayi + sayi1);
//    return sayi + sayi1;
//}



//int sonuc;
//sonuc = Topla(2, 3);
//Console.WriteLine(sonuc);

#endregion


#region ucuncu_bolum
//int sayi3 = 7;


//void AsalSayiKontrolEt(int sayi)
//{
//    int sayac = 0;
//    for (int i = 1; i <= sayi; i++)
//    {
//        if (sayi % i == 0)
//        {

//            sayac++;
//        }

//    }

//    if (sayac == 2)
//    {
//        Console.WriteLine("Sayı Asaldır");
//    }
//    else
//    {
//        Console.WriteLine("Sayı Asal Değildir");
//    }
//}


////AsalSayiKontrolEt(13);
////AsalSayiKontrolEt(21);
////AsalSayiKontrolEt(16);
////AsalSayiKontrolEt(7);


//Console.Write("Bir Sayı Girin: ");
//int alinanSayi = Convert.ToInt32(Console.ReadLine());

//AsalSayiKontrolEt(alinanSayi);
#endregion

#region nesnelere giris
//using HelloProject;

//Ev ev = new Ev();
//ev.adres = "İstabul";
//ev.kapiNo = 1;
//ev.odaSayisi = 3;


//Console.WriteLine("Adres: " + ev.adres + " " + "Kapı Numarası: " + ev.kapiNo + " " + "Oda sayısı: " + ev.odaSayisi);


//ev.AdresYaz();

//Ev cereninEvi = new Ev();
//cereninEvi.kapiNo = 5;
//cereninEvi.adres = "Ankara";
//cereninEvi.odaSayisi = 4;

//Ev merveninEvi = new Ev();
//merveninEvi.kapiNo= 6;
//merveninEvi.adres = "İzmir";
//merveninEvi.odaSayisi= 7;

//Console.WriteLine("Cerenin oda sayısı " + cereninEvi.odaSayisi);
//Console.WriteLine("Mervenin adresi "  + merveninEvi.adres);
#endregion


// Encapsulation, Inheritance, Polimorphizm, Abstraction
// Erişim belirteçleri -> public, private,protected,internal



using HelloProject;

Ev ev = new Ev();
ev.Adres = "Ankara";
Console.WriteLine("Adres: " + ev.Adres);

