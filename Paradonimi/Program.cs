namespace Paradonimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] duma = word.ToCharArray();
            int mid = duma.Length / 2;
            bool result = false;
                for (int i = 0; i < mid; i++)
                {
                    if (duma[i] == duma[duma.Length - 1 - i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            if (result)
            {
                Console.WriteLine(word);
            }
        }
    }
    }
}
