internal class Program
{
    const string _inputPrompt = "Please input a string that contains only letters a-f.";
    const string _invalidPrompt = "Invalid Input.";

    static bool IsAToF(char c)
    {
        return c >= 'a' && c <= 'f';
    }

    static void Main()
    {
        Console.WriteLine(_inputPrompt);
        string input = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(input) || !input.All(IsAToF))
        {
            Console.WriteLine(_invalidPrompt);
        }
        else
        {
            int[] letterFrequency = new int[6];
            foreach (char c in input)
            {
                ++letterFrequency[c - 'a'];
            }

            int maxFrequency = letterFrequency.Max();
            List<int> maxFrequencyLetters = [];

            for (int i = 0; i < 6; ++i)
            {
                if (letterFrequency[i] == maxFrequency)
                {
                    maxFrequencyLetters.Add(i);
                }
            }

            foreach (int i in maxFrequencyLetters)
            {
                input = input.Replace((char)('a' + i), (char)('A' + i));
            }

            Console.WriteLine(input);
        }

    }
}