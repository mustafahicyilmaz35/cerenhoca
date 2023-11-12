

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

using HelloProject;

int sayi = 3;

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


Gunler gun = Gunler.Çarşamba;




switch (gun)
{
    case Gunler.Pazartesi:
        Console.WriteLine("Bugün pazartesi");
        break;
    case Gunler.Salı:
        Console.WriteLine("Bugün Salı");
        break;
    case Gunler.Çarşamba: //magic string
        Console.WriteLine("Bugün Çarşamba");
        break;
    case Gunler.Perşembe:
        Console.WriteLine("Bugün Perşembe");
        break;
    case Gunler.Cuma:
        Console.WriteLine("Bugün Cuma");
        break;
    case Gunler.Cumartesi:
        Console.WriteLine("Bugün Cumartesi");
        break;
    case Gunler.Pazar:
        Console.WriteLine("Bugün Pazar");
        break;
    default: Console.WriteLine("Lütfen bir gün değeri girin");
        break;

}
