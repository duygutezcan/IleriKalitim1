using IleriKalitim1;

Egitmen e = new Egitmen();
e.Ad = "Duygu";
e.SoyAd = "Tezcan Kantar";
e.Maas = 3000;
var date = new DateTime(1991,11,09);
e.DogumTarihi=date;
Console.WriteLine( e.YasHesapla());
Console.WriteLine(e.MaasHesapla());
