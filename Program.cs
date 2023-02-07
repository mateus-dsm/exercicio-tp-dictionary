internal class Program
{
    static void Main(string[] args)
    {
        int countA = 0;
        int countE = 0;
        int countI = 0;
        int countO = 0;
        int countU = 0;

        Console.WriteLine("Digite uma frase: ");
        char[] frase = Console.ReadLine().ToArray();

        foreach(char elemento in frase)
        {
            switch(elemento)
            {
                case 'a':
                case 'A':
                    countA++;
                    break;
                case 'e':
                case 'E':
                    countE++;
                    break;
                case 'i':
                case 'I':
                    countI++;
                    break;
                case 'o':
                case 'O':
                    countO++;
                    break;
                case 'u':
                case 'U':
                    countU++;
                    break;
            }
        }

        Dictionary<char, int> dicionario = new Dictionary<char, int>();
        dicionario.Add('a', countA);
        dicionario.Add('e', countE);
        dicionario.Add('i', countI);
        dicionario.Add('o', countO);
        dicionario.Add('u', countU);

        foreach (KeyValuePair<char, int> kvp in dicionario) Console.WriteLine($"Numero de ocorrencias da vogal {kvp.Key}: {kvp.Value}");
    }
}