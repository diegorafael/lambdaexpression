namespace ExpressoesLambda
{
    internal class LivroFilter
    {
        public static bool FiltroPorAno(Livro livro, int ano)
        {
            return livro.AnoPublicacao >= ano;
        }

        public static bool FiltroPorPrecoMaximo(Livro livro, decimal preco)
        {
            return livro.Preco <= preco;
        }

        public static bool FiltroPorTitulo(Livro livro, string palavra)
        {
            return livro.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase);
        }
    }
}
