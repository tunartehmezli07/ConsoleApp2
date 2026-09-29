//1)
//using System;
//using System.Text;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, string> telebeler = new Dictionary<int, string>();

//        telebeler.Add(1, "Nihad");
//        telebeler.Add(2, "Murad");
//        telebeler.Add(3, "Ramal");
//        telebeler.Add(4, "Aysel");
//        telebeler.Add(5, "Ayan");

//        int secim = 0;

//        while (secim != 4)
//        {
//            Console.WriteLine("\n--- TƏLƏBƏ QEYDİYYAT SİSTEMİ ---");
//            Console.WriteLine("1. Tələbə əlavə et");
//            Console.WriteLine("2. Tələbəni ID ilə axtar");
//            Console.WriteLine("3. Bütün tələbələri göstər");
//            Console.WriteLine("4. Çıxış");
//            Console.Write("Seçiminiz: ");

//            secim = Convert.ToInt32(Console.ReadLine());

//            switch (secim)
//            {
//                case 1:
//                    Console.Write("Tələbənin ID-sini daxil edin: ");
//                    int id = Convert.ToInt32(Console.ReadLine());

//                    Console.Write("Tələbənin adını daxil edin: ");
//                    string ad = Console.ReadLine();

//                    if (telebeler.ContainsKey(id))
//                    {
//                        Console.WriteLine("Bu ID artıq mövcuddur.");
//                    }
//                    else
//                    {
//                        telebeler.Add(id, ad);
//                        Console.WriteLine("Tələbə əlavə edildi.");
//                    }

//                    break;

//                case 2:
//                    Console.Write("Axtarmaq istədiyiniz ID-ni daxil edin: ");
//                    int axtarilanId = Convert.ToInt32(Console.ReadLine());

//                    if (telebeler.ContainsKey(axtarilanId))
//                    {
//                        Console.WriteLine("Tələbə: " + telebeler[axtarilanId]);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Bu ID ilə tələbə tapılmadı.");
//                    }

//                    break;

//                case 3:
//                    Console.WriteLine("\nBütün tələbələr:");

//                    foreach (var telebe in telebeler)
//                    {
//                        Console.WriteLine("ID: " + telebe.Key + " | Ad: " + telebe.Value);
//                    }

//                    break;

//                case 4:
//                    Console.WriteLine("Proqramdan çıxıldı.");
//                    break;

//                default:
//                    Console.WriteLine("Yanlış seçim etdiniz.");
//                    break;
//            }
//        }
//    }
//}


//2
//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("1. Dairə");
//        Console.WriteLine("2. Düzbucaqlı");
//        Console.WriteLine("3. Üçbucaq");

//        Console.Write("Fiqur seçin: ");
//        int secim = Convert.ToInt32(Console.ReadLine());

//        switch (secim)
//        {
//            case 1:
//                Console.Write("Radiusu daxil edin: ");
//                double radius = Convert.ToDouble(Console.ReadLine());

//                double daireSahesi = Math.PI * Math.Pow(radius, 2);

//                Console.WriteLine("Dairənin sahəsi: " +
//                    Math.Round(daireSahesi, 2));

//                break;

//            case 2:
//                Console.Write("Uzunluğu daxil edin: ");
//                double uzunluq = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Eni daxil edin: ");
//                double en = Convert.ToDouble(Console.ReadLine());

//                double duzbucaqliSahesi = uzunluq * en;

//                Console.WriteLine("Düzbucaqlının sahəsi: " +
//                    Math.Round(duzbucaqliSahesi, 2));

//                break;

//            case 3:
//                Console.Write("Birinci tərəfi daxil edin: ");
//                double a = Convert.ToDouble(Console.ReadLine());

//                Console.Write("İkinci tərəfi daxil edin: ");
//                double b = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Üçüncü tərəfi daxil edin: ");
//                double c = Convert.ToDouble(Console.ReadLine());

//                double p = (a + b + c) / 2;

//                double ucbucaqSahesi = Math.Sqrt(
//                    p * (p - a) * (p - b) * (p - c)
//                );

//                Console.WriteLine("Üçbucağın sahəsi: " +
//                    Math.Round(ucbucaqSahesi, 2));

//                break;

//            default:
//                Console.WriteLine("Yanlış seçim.");
//                break;
//        }
//    }
//}


//}3)--


//4)
//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();

//        int gizliEded = random.Next(0, 101);

//        int texmin;

//        do
//        {
//            Console.Write("0-100 arası ədəd daxil edin: ");
//            texmin = Convert.ToInt32(Console.ReadLine());

//            if (texmin > gizliEded)
//            {
//                Console.WriteLine("Daha kiçik ədəd cəhd edin.");
//            }
//            else if (texmin < gizliEded)
//            {
//                Console.WriteLine("Daha böyük ədəd cəhd edin.");
//            }
//            else
//            {
//                Console.WriteLine("Təbriklər!");
//            }

//        } while (texmin != gizliEded);
//    }
//}

