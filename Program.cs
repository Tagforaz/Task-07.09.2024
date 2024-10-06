
#region 3 ededden hansi boyukdur
//int x = 5;
//int y = 17;
//int z = 10;
//if (x > y && x > z)
//{
//    Console.WriteLine(x);
//}
//else if (y > x && y > z)
//{
//    Console.WriteLine(y);

//}
//else
//{
//    Console.WriteLine(z);
//}
#endregion

#region  Soz icinden herfin tapilmasi
//string word = "Ezamiyyet";
//char axtarilanherf = 'e';
//bool tapildi = false;


//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == axtarilanherf)
//    {
//        tapildi = true;
//        Console.WriteLine($"Herf tapildi.Tapilan herf {axtarilanherf}");
//        break;
//    }
//}

//if (tapildi)
//{
//    Console.WriteLine("Herf tapilmadi.");
//}
#endregion


#region sozun icinde  i herfin necedefe yazildiqini sayini tapmaq
//string soz = "Bismak";
//char axtarilanherf = 'i';
//int say = 0;


//for (int i = 0; i < soz.Length; i++)
//{
//    if (soz[i] == axtarilanherf)
//    {
//        say++;
//    }
//}
//if (say > 0)
//{
//    Console.WriteLine($"Herf {say} defe tapildi.");
//}
//else
//{
//    Console.WriteLine("Herf tapilmadi.");
//}
#endregion


#region kvadrata yukseltme
int eded;

while (true)
{

    Console.WriteLine("Zehmet olmasa musbet ve cut eded yazin: ");
    eded = int.Parse(Console.ReadLine());

    if (eded > 0 && eded % 2 == 0)
    {

        int kvadrat = eded * eded;
        Console.WriteLine($"Yazdiqiniz reqemin kvadrati: {kvadrat}");
        break;
    }
    else
    {

        Console.WriteLine("Xeta: Yazdiqiniz eded musbet ve cut olmalıdır.");
    }
}
#endregion

#region Siyahidaki ededlerin cemi
//int[] ededler = { 10, 20, 30, 40, 50 };
//int cemi = 0;


//for (int i = 0; i < ededler.Length; i++)
//{
//    cemi += ededler[i];
//}


//Console.WriteLine($"Siyahidaki ededlerin cemi: {cemi}");
#endregion


#region   tehsil novu
//string tehsilNovu;
//string tehsilNovu2 = "Programing";
//string tehsilNovu3 = "Desing";
//string tehsilNovu4 = "System";

//while (true)
//{
//    Console.Write("Zehmet tehsil novu qeyd edin: ");
//    tehsilNovu = (Console.ReadLine());
//    if (tehsilNovu == tehsilNovu2)
//    {
//        Console.WriteLine("400 saat");
//    }
//    else if (tehsilNovu == tehsilNovu3)
//    {
//        Console.WriteLine("250 saat");
//    }
//    else if (tehsilNovu == tehsilNovu4)
//    {
//        Console.WriteLine("200 saat");
//    }
//    else
//    {
//        Console.WriteLine("Duzgun tehsil novu qeyd etmediniz. Yeniden qeyd edin:");

//    }
//}

#endregion