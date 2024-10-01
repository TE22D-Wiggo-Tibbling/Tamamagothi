Tamamagoshi tamamagoshi = new();
string choise;

Console.WriteLine("naeme tamamagoishi");

tamamagoshi.Name = Console.ReadLine();
while(tamamagoshi.GetAlive()){

System.Console.WriteLine("What you wana do?");
System.Console.WriteLine("1) lär nytt ord   2) säga hejhej   3) mata   4) skit i");
choise = Console.ReadLine();
if (choise == "1")
{
    System.Console.WriteLine("WHAT YOU LERN IT?");
    string wordToLearn = Console.ReadLine();
    tamamagoshi.Teach(wordToLearn);
}
else if(choise == "2") tamamagoshi.Hi();
else if(choise=="3")tamamagoshi.Feed();
else if(choise=="3")tamamagoshi.PrintStats();
else System.Console.WriteLine("Du måste säga ETT nummer");

tamamagoshi.Tick();
}

Console.ReadLine();