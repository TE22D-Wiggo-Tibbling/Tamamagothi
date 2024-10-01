public class Tamamagoshi
{
    private int hunger;
    private int bredom;
    private List<string> words = [];
    public string Name;
    private bool isAlive = true;

    public void Feed()
    {
        hunger -= 10;
    }

    private void ReduceBoredom()
    {
        bredom -= 2;
    }
    public void Hi()
    {
        if(words.Count>0){
        Console.WriteLine(words[Random.Shared.Next(words.Count)]);
        ReduceBoredom();
        }
        else{
            Console.WriteLine("Lär den ett ord först");
        }
    }

    public void Tick()
    {
        hunger++;
        bredom++;
        if (hunger > 10 || bredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"hunger: {hunger} boredome: {bredom}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }


    public void Teach(string word)
    {
        words.Add(word);
    }
}
