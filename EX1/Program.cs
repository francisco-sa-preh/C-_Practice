namespace EX1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, -4, 5 };
        bool hasNegative = ContainsNegative(numbers);
        Console.WriteLine(hasNegative); // Output: True

        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        hasNegative = ContainsNegative(numbersList);
        Console.WriteLine(hasNegative); // Output: False
    }

    //Implement the ContainsNegative method that checks whether a sequence of integers contains at least one negative number.
    public static bool ContainsNegative(IEnumerable<int> numbers)
   {
        //your code goes here
        foreach(int number in numbers)
        {
            if(number<0)
            return true;    
        }
            
        return false;

        //LINQ implementation
        //return numbers.Any(n => n < 0);  ANY() é um método de extensão LINQ que verifica se algum elemento em uma sequência atende a uma condição especificada. Ele retorna true se pelo menos um elemento satisfizer a condição, caso contrário, retorna false.
        //"Para cada número n, verifica se n é menor que 0."
    } 
}
