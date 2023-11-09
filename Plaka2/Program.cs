class Program
{
    static void Main(string[] args)
    {
        int girilenSayi;
        bool dogruGiris = false ;

        do
        {
            Console.Write("Lütfen 1-81 arasında bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out girilenSayi))
            {
                if (girilenSayi >= 1 && girilenSayi <= 81)
                {
                    dogruGiris = true ;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı 1-81 arasında değil. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
        } while (!dogruGiris);

        string[] iller = {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir",
    "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
    "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari",
    "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir",
    "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir",
    "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
    "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman",
    "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
        };

        Console.WriteLine($"{girilenSayi} plaka kodu ile {iller[girilenSayi - 1]} ilini temsil eder."); 
    }
}