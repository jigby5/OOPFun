namespace OOPFun;

internal class WordTools
{
    public int WordCounter(string words)
    {
        // split the string into separate words to be able to count
        string[] individualWords = words.Split(" ");

        int wordcount = individualWords.Length;
        
        return(wordcount);
    }

    public int CharacterCounter(string words)
    {
        int characterCount = words.Length;
        
        return(characterCount);
    }

    public void AlphabetCounter(string words)
    {
        // loop through the entire string
        int[] letters = new int[26];
        
        for (int i = 0; i < words.Length; i++)
        {
            char c = words[i];
            
            c = char.ToLower(c);

            if (c >= 97 && c <= 122)
            {
                letters[(c - 97)]++;
            }
        }

        for (int i = 0; i < letters.Length; i++)
        {
            char letter = (char)(i + 97);
            
            Console.WriteLine($"{letter}: {letters[i]}");

        }
    }
}