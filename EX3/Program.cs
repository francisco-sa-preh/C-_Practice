namespace EX3;

class Program
{
    static void Main(string[] args)
    {
        string input = "Hello, World!";
        var frequencies = CountCharacterFrequencies(input);

        foreach (var item in frequencies)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    public static Dictionary<char, int> CountCharacterFrequencies(
            string input)
        {
            //your code goes here
            Dictionary<char,int> frequencies = new();
            
            foreach(char c in input)
            {
                if(frequencies.ContainsKey(c))
                frequencies[c]++;
                
                else
                frequencies[c]=1;
            }
            
            return frequencies;
            
        }
}
