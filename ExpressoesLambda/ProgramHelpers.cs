using ExpressoesLambda;

internal static class ProgramHelpers
{

    internal static void DisplayLivros(List<Livro> livros, string title)
    {
        Console.WriteLine(title);
        foreach (var livro in livros)
        {
            Console.WriteLine(livro.ToString());
        }
        Console.WriteLine();
    }
}