
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Calisan> calisanlar = new List<Calisan>()
{
    new Calisan(){Ad = "Calışan1", Pozisyon = "Developer" , CalismaSaati = 50},
    new Calisan(){Ad = "Calışan2", Pozisyon = "Developer" , CalismaSaati = 60},
    new Calisan(){Ad = "Calışan3", Pozisyon = "Analist" , CalismaSaati = 55},
    new Calisan(){Ad = "Calışan4", Pozisyon = "Tester" , CalismaSaati = 60},
    new Calisan(){Ad = "Calışan5", Pozisyon = "Tester" , CalismaSaati = 45},
};

double totalUcret = 0;

foreach (var calisan in calisanlar)
{
var calisanUcreti = MaasHesapla(calisan);
totalUcret += calisanUcreti;

Console.WriteLine($"{calisan.Ad} Toplam Maaş : {calisanUcreti} TL");
}

Console.WriteLine($"Toplam Maaş : {totalUcret} TL");

double MaasHesapla(Calisan calisan)
{
double saatlikUcret = 0;
double toplamUcret = 0;

switch (calisan.Pozisyon)
{
case "Developer":
saatlikUcret = 200;
break;
case "Analist":
saatlikUcret = 150;
break;
case "Tester":
saatlikUcret = 300;
break;
default:
Console.WriteLine("Geçersiz pozisyon");
return 0;
}

if (calisan.CalismaSaati <= 40)
{
toplamUcret = calisan.CalismaSaati * saatlikUcret;
}
else
{
double normalMesai = 40 * saatlikUcret;
double fazlaMesai = (calisan.CalismaSaati - 40) * (saatlikUcret * 1.5);
toplamUcret = normalMesai + fazlaMesai;
}

return toplamUcret;
}

public class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public int CalismaSaati { get; set; }
}