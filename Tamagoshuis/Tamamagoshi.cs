public class Tamamagoshi
{
    private int hunger;
    private int bredom;
    private List<string> words = new();
    private Random generator;
    public string Name;
    private bool isAlive;

    public void Feed()
    {
        hunger -= 10;
    }

    public void Hi()
    {
        System.Console.WriteLine(words[generator.Next(words.Count)]);
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
        System.Console.WriteLine($"hunger: {hunger} boredome: {bredom}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        bredom -= 2;
    }

    public void Teach(string word)
    {
        words.Add(word);
    }
}
