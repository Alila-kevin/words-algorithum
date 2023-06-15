internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("please enter the number of word to be counted");
        string input = Console.ReadLine();

        int letterCount = CountLetters(input);
        Console.WriteLine("Number of letters: " + letterCount);

        // Additional code can be added here
        //string input = "Hello, World! This is a sample sentence.";

        int wordCount = CountWords(input);
        Console.WriteLine("Number of words: " + wordCount);

        // Additional code can be added here
    }
    public static int CountLetters(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
                count++;
        }
        return count;
    }

    public static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}