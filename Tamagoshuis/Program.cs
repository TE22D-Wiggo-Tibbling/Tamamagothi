Tamamagoshi tamamagoshi = new();

Console.WriteLine("naeme tamamagoishi");

tamamagoshi.Name = Console.ReadLine();
while(tamamagoshi.GetAlive()){

System.Console.WriteLine("What you wana do?");
System.Console.WriteLine("1) lär nytt ord   2) säga hejhej   3) mata   4) skit i");

if (Console.ReadLine() == "1")
{
    System.Console.WriteLine("WHAT YOU LERN IT?");
    string wordToLearn = Console.ReadLine();
    tamamagoshi.Teach(wordToLearn);
}
else if(Console.ReadLine() == "2") tamamagoshi.Hi();
}

Console.ReadLine();